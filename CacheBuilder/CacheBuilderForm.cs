using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperMap.Data;
using SuperMap.Data.Processing;
using SuperMap.Realspace;
using System.IO;

namespace CacheBuilder
{
    public partial class CacheBuilderForm : Form
    {
        private Datasource m_datasource;
        private DatasetVector m_datasetVectorB;//新模型数据集
        private DatasetVector m_datasetVectorAB;//合并后的模型数据集
        private OSGBCacheBuilder m_OSGBCacheBuilder;

        private Point3D m_point3D;

        string udbpath;//udb路径
        string scppath1; //带扩展名的SCP文件完整路径
        string scppath2; //不带扩展名的SCP所在文件夹路径
        string cachepath;//获取的缓存文件夹路径
        string cachename;//缓存名称
        double tilewidth;//瓦片边长

        bool a = true;


        public CacheBuilderForm()
        {
            InitializeComponent();
        }


        private void Btn_SelectScp_Click(object sender, EventArgs e)
        {
            SelectSCP();
        }


        private void Btn_SelectUDB_Click(object sender, EventArgs e)
        {
            OpenDatabase();
        }


        private void Btn_UpdateCache_Click(object sender, EventArgs e)
        {
            Judgement();
            UpdateCache();
        }






        //选择SCP文件
        private void SelectSCP()
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog
                {
                    Multiselect = false,//该值确定是否可以选择多个文件
                    Title = "Please choose scp file",
                    Filter = "*.scp|*.scp"
                };
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    scppath1 = fileDialog.FileName;//获取带扩展名的SCP文件完整路径
                    scppath2 = Path.GetDirectoryName(scppath1);//获取SCP所在文件夹路径
                    cachename = Path.GetFileNameWithoutExtension(scppath1);//获取缓存名称
                    cachepath = Directory.GetParent(scppath2).FullName;//获取缓存文件夹路径
                    TextBox_scppath.Text = scppath1;//在文本中显示scp路径
                }
                fileDialog.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Select *.scp failed");
                return;
            }
        }

        //打开UDB或UDBX
        private void OpenDatabase()
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog
                {
                    Multiselect = false,//该值确定是否可以选择多个文件
                    Title = "Please choose udb or udbx",
                    Filter = "*.udb,*.udbx|*.udb;*.udbx"
                };
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    udbpath = fileDialog.FileName;//获取udb完整路径
                    TextBox_udbpath.Text = udbpath;//在文本中显示udb路径
                    if (udbpath != null)
                    {
                        LoadDatasource();//加载数据源中的数据
                        if (m_datasource.Datasets.Count != 0)
                        {
                            BindCombox_AddData();//为ComboBox绑定数据
                        }
                        else
                        {
                            MessageBox.Show("No dataset in this datasource");
                        }
                    }
                }
                fileDialog.Dispose();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Open fileDialog failed");
                return;
            }
        }

        //Load Datasource
        private void LoadDatasource()
        {
            try
            {
                Workspace m_workspace = new Workspace();
                DatasourceConnectionInfo conInfo = new DatasourceConnectionInfo(udbpath, "model", "");
                if (Path.GetExtension(udbpath) == ".udb")
                {
                    conInfo.EngineType = EngineType.UDB;
                }
                else
                {
                    conInfo.EngineType = EngineType.UDBX;
                }
                m_datasource = m_workspace.Datasources.Open(conInfo);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }


        //绑定数据源中的数据
        private void BindCombox_AddData()
        {
            try
            {
                ComboBox_OriginalDataset.Items.Clear();
                ComboBox_NewDataset.Items.Clear();
                ComboBox_MergedDataset.Items.Clear();
                for (int i = 0; i < m_datasource.Datasets.Count; i++)
                {
                    ComboBox_OriginalDataset.Items.Add(m_datasource.Datasets[i].Name);
                    ComboBox_NewDataset.Items.Add(m_datasource.Datasets[i].Name);
                    ComboBox_MergedDataset.Items.Add(m_datasource.Datasets[i].Name);
                 }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Add data to list failed");
                return;
            }
        }


        //Update Cache.
        private void UpdateCache()
        {
            if (a == true)
            {
                try
                {
                    m_point3D.X = Convert.ToDouble(TextBox_positionX.Text);
                    m_point3D.Y = Convert.ToDouble(TextBox_positionY.Text);
                    m_point3D.Z = Convert.ToDouble(TextBox_positionZ.Text);
                    tilewidth = Convert.ToDouble(TextBox_tilewidth.Text);

                    //只更新缓存
                    m_datasetVectorAB = m_datasource.Datasets[ComboBox_MergedDataset.Text] as DatasetVector; //get ModelAB from UDB
                    m_datasetVectorB = m_datasource.Datasets[ComboBox_NewDataset.Text] as DatasetVector; //get ModelB from UDB
                    m_OSGBCacheBuilder = new OSGBCacheBuilder
                    {
                        Dataset = m_datasetVectorAB,
                        OutputFolder = cachepath,
                        CacheName = cachename,
                        Position = m_point3D,
                        TileWidth = tilewidth,
                        Bounds = m_datasetVectorB.Bounds,
                        FileType = CacheFileType.S3MB,
                        TilePyramidSplitType = PyramidSplitType.QuadTree,
                        UserIDField = "SmID",
                        CompressedTextureType = CompressedTextureType.DDS,

                    };
                    m_OSGBCacheBuilder.BuildCacheWithoutConfigFile(); //只创建缓存不生成配置文件和索引文件

                    //只更新scp及索引文件
                    m_OSGBCacheBuilder.Bounds = m_datasetVectorAB.Bounds;
                    File.Delete(scppath2 + "\\" + "attribute.json");//更新前删除属性文件，以免更新失败 S3M
                                                                    //File.Delete(scppath2 + "\\" + "indexData.dat");//更新前删除属性文件，以免更新失败 S3MB
                    m_OSGBCacheBuilder.ToConfigAndIndexFile(scppath2 + "\\" + cachename + ".scp"); //生成新的scp及属性文件
                    m_datasetVectorB.Close();
                    m_datasetVectorAB.Close();
                    m_OSGBCacheBuilder.Dispose();
                    m_datasource.Close();
                    MessageBox.Show("Cache updated successfully.\nCache path: " + scppath2);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Cache updated failed");
                    return;
                }
            }
            else 
            {
                MessageBox.Show("Incomplete parameters required for cache updating");
            }

        }



        //生成缓存前所需参数检验
        private void Judgement()
        {
            if (scppath1 == null)
            {
                a = false;
            }
            if (ComboBox_OriginalDataset.SelectedIndex == -1)
            {
                a = false;
            }
            if (ComboBox_NewDataset.SelectedIndex == -1)
            {
                a = false;
            }
            if (ComboBox_MergedDataset.SelectedIndex == -1)
            {
                a = false;
            }
            if (TextBox_positionX.Text.Length == 0)
            {
                a = false;
            }
            if (TextBox_positionY.Text.Length == 0)
            {
                a = false;
            }
            if (TextBox_positionZ.Text.Length == 0)
            {
                a = false;
            }
            if (TextBox_tilewidth.Text.Length == 0)
            {
                a = false;
            }

        }


    }
}
