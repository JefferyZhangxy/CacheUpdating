
namespace CacheBuilder
{
    partial class CacheBuilderForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.workspace1 = new SuperMap.Data.Workspace(this.components);
            this.Btn_UpdateCache = new System.Windows.Forms.Button();
            this.Btn_SelectUDB = new System.Windows.Forms.Button();
            this.TextBox_udbpath = new System.Windows.Forms.TextBox();
            this.ComboBox_OriginalDataset = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_SelectScp = new System.Windows.Forms.Button();
            this.TextBox_scppath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBox_NewDataset = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboBox_MergedDataset = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBox_positionX = new System.Windows.Forms.TextBox();
            this.TextBox_positionY = new System.Windows.Forms.TextBox();
            this.TextBox_positionZ = new System.Windows.Forms.TextBox();
            this.TextBox_tilewidth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.datasetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datasetsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // workspace1
            // 
            this.workspace1.Caption = "UntitledWorkspace";
            this.workspace1.Description = "";
            this.workspace1.DesktopInfo = "";
            // 
            // Btn_UpdateCache
            // 
            this.Btn_UpdateCache.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_UpdateCache.Location = new System.Drawing.Point(265, 552);
            this.Btn_UpdateCache.Name = "Btn_UpdateCache";
            this.Btn_UpdateCache.Size = new System.Drawing.Size(130, 38);
            this.Btn_UpdateCache.TabIndex = 1;
            this.Btn_UpdateCache.Text = "Update Cache";
            this.Btn_UpdateCache.UseVisualStyleBackColor = true;
            this.Btn_UpdateCache.Click += new System.EventHandler(this.Btn_UpdateCache_Click);
            // 
            // Btn_SelectUDB
            // 
            this.Btn_SelectUDB.Location = new System.Drawing.Point(486, 31);
            this.Btn_SelectUDB.Name = "Btn_SelectUDB";
            this.Btn_SelectUDB.Size = new System.Drawing.Size(102, 31);
            this.Btn_SelectUDB.TabIndex = 3;
            this.Btn_SelectUDB.Text = "Select";
            this.Btn_SelectUDB.UseVisualStyleBackColor = true;
            this.Btn_SelectUDB.Click += new System.EventHandler(this.Btn_SelectUDB_Click);
            // 
            // TextBox_udbpath
            // 
            this.TextBox_udbpath.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextBox_udbpath.Location = new System.Drawing.Point(216, 37);
            this.TextBox_udbpath.Name = "TextBox_udbpath";
            this.TextBox_udbpath.ReadOnly = true;
            this.TextBox_udbpath.Size = new System.Drawing.Size(232, 25);
            this.TextBox_udbpath.TabIndex = 4;
            // 
            // ComboBox_OriginalDataset
            // 
            this.ComboBox_OriginalDataset.BackColor = System.Drawing.SystemColors.Window;
            this.ComboBox_OriginalDataset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_OriginalDataset.FormattingEnabled = true;
            this.ComboBox_OriginalDataset.Location = new System.Drawing.Point(216, 89);
            this.ComboBox_OriginalDataset.Name = "ComboBox_OriginalDataset";
            this.ComboBox_OriginalDataset.Size = new System.Drawing.Size(232, 23);
            this.ComboBox_OriginalDataset.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "*.scp Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "*.udb or *.udbx";
            // 
            // Btn_SelectScp
            // 
            this.Btn_SelectScp.Location = new System.Drawing.Point(486, 31);
            this.Btn_SelectScp.Name = "Btn_SelectScp";
            this.Btn_SelectScp.Size = new System.Drawing.Size(102, 29);
            this.Btn_SelectScp.TabIndex = 8;
            this.Btn_SelectScp.Text = "Select";
            this.Btn_SelectScp.UseVisualStyleBackColor = true;
            this.Btn_SelectScp.Click += new System.EventHandler(this.Btn_SelectScp_Click);
            // 
            // TextBox_scppath
            // 
            this.TextBox_scppath.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextBox_scppath.Location = new System.Drawing.Point(120, 35);
            this.TextBox_scppath.Name = "TextBox_scppath";
            this.TextBox_scppath.ReadOnly = true;
            this.TextBox_scppath.Size = new System.Drawing.Size(348, 25);
            this.TextBox_scppath.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Original Dataset";
            // 
            // ComboBox_NewDataset
            // 
            this.ComboBox_NewDataset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_NewDataset.FormattingEnabled = true;
            this.ComboBox_NewDataset.Location = new System.Drawing.Point(216, 133);
            this.ComboBox_NewDataset.Name = "ComboBox_NewDataset";
            this.ComboBox_NewDataset.Size = new System.Drawing.Size(232, 23);
            this.ComboBox_NewDataset.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "New Dataset";
            // 
            // ComboBox_MergedDataset
            // 
            this.ComboBox_MergedDataset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_MergedDataset.FormattingEnabled = true;
            this.ComboBox_MergedDataset.Location = new System.Drawing.Point(216, 179);
            this.ComboBox_MergedDataset.Name = "ComboBox_MergedDataset";
            this.ComboBox_MergedDataset.Size = new System.Drawing.Size(232, 23);
            this.ComboBox_MergedDataset.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Merged Dataset";
            // 
            // TextBox_positionX
            // 
            this.TextBox_positionX.Location = new System.Drawing.Point(171, 41);
            this.TextBox_positionX.Name = "TextBox_positionX";
            this.TextBox_positionX.Size = new System.Drawing.Size(139, 25);
            this.TextBox_positionX.TabIndex = 15;
            // 
            // TextBox_positionY
            // 
            this.TextBox_positionY.Location = new System.Drawing.Point(171, 79);
            this.TextBox_positionY.Name = "TextBox_positionY";
            this.TextBox_positionY.Size = new System.Drawing.Size(139, 25);
            this.TextBox_positionY.TabIndex = 16;
            // 
            // TextBox_positionZ
            // 
            this.TextBox_positionZ.Location = new System.Drawing.Point(171, 123);
            this.TextBox_positionZ.Name = "TextBox_positionZ";
            this.TextBox_positionZ.Size = new System.Drawing.Size(139, 25);
            this.TextBox_positionZ.TabIndex = 17;
            // 
            // TextBox_tilewidth
            // 
            this.TextBox_tilewidth.Location = new System.Drawing.Point(446, 41);
            this.TextBox_tilewidth.Name = "TextBox_tilewidth";
            this.TextBox_tilewidth.Size = new System.Drawing.Size(113, 25);
            this.TextBox_tilewidth.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Position.X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Position.Y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Position.Z";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(344, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Tile Width";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ComboBox_MergedDataset);
            this.groupBox1.Controls.Add(this.ComboBox_OriginalDataset);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ComboBox_NewDataset);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Btn_SelectUDB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TextBox_udbpath);
            this.groupBox1.Location = new System.Drawing.Point(29, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 226);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datasource and Dataset Settings";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TextBox_positionX);
            this.groupBox2.Controls.Add(this.TextBox_positionY);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.TextBox_positionZ);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.TextBox_tilewidth);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(29, 364);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(606, 167);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tile Parameter Setting";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Btn_SelectScp);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.TextBox_scppath);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(29, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(606, 77);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cache Path Setting";
            // 
            // datasetsBindingSource
            // 
            this.datasetsBindingSource.DataSource = typeof(SuperMap.Data.Datasets);
            // 
            // CacheBuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 609);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_UpdateCache);
            this.Name = "CacheBuilderForm";
            this.Text = "Cache Updating Tool";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datasetsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SuperMap.Data.Workspace workspace1;
        private System.Windows.Forms.Button Btn_UpdateCache;
        private System.Windows.Forms.Button Btn_SelectUDB;
        private System.Windows.Forms.TextBox TextBox_udbpath;
        private System.Windows.Forms.ComboBox ComboBox_OriginalDataset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_SelectScp;
        private System.Windows.Forms.TextBox TextBox_scppath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboBox_NewDataset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboBox_MergedDataset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBox_positionX;
        private System.Windows.Forms.TextBox TextBox_positionY;
        private System.Windows.Forms.TextBox TextBox_positionZ;
        private System.Windows.Forms.TextBox TextBox_tilewidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingSource datasetsBindingSource;
    }
}

