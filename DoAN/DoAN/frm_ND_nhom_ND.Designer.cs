namespace DoAN
{
    partial class frm_ND_nhom_ND
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.qL_NGUOIDUNGDataGridView = new System.Windows.Forms.DataGridView();
            this.qL_NGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fPT_SHOPDataSet = new DoAN.FPT_SHOPDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.themNDVaoNhomDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.themNDVaoNhomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbo_tennhom = new System.Windows.Forms.ComboBox();
            this.qL_NHOMNDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NGUOIDUNGTableAdapter = new DoAN.FPT_SHOPDataSetTableAdapters.QL_NGUOIDUNGTableAdapter();
            this.tableAdapterManager = new DoAN.FPT_SHOPDataSetTableAdapters.TableAdapterManager();
            this.qL_NHOMNDTableAdapter = new DoAN.FPT_SHOPDataSetTableAdapters.QL_NHOMNDTableAdapter();
            this.themNDVaoNhomTableAdapter = new DoAN.FPT_SHOPDataSetTableAdapters.ThemNDVaoNhomTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNGDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fPT_SHOPDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.themNDVaoNhomDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.themNDVaoNhomBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOMNDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.qL_NGUOIDUNGDataGridView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 516);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Người dùng";
            // 
            // qL_NGUOIDUNGDataGridView
            // 
            this.qL_NGUOIDUNGDataGridView.AllowUserToAddRows = false;
            this.qL_NGUOIDUNGDataGridView.AutoGenerateColumns = false;
            this.qL_NGUOIDUNGDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.qL_NGUOIDUNGDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.qL_NGUOIDUNGDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qL_NGUOIDUNGDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1});
            this.qL_NGUOIDUNGDataGridView.DataSource = this.qL_NGUOIDUNGBindingSource;
            this.qL_NGUOIDUNGDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qL_NGUOIDUNGDataGridView.Location = new System.Drawing.Point(3, 16);
            this.qL_NGUOIDUNGDataGridView.Name = "qL_NGUOIDUNGDataGridView";
            this.qL_NGUOIDUNGDataGridView.Size = new System.Drawing.Size(386, 497);
            this.qL_NGUOIDUNGDataGridView.TabIndex = 0;
            this.qL_NGUOIDUNGDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.qL_NGUOIDUNGDataGridView_CellContentClick);
            // 
            // qL_NGUOIDUNGBindingSource
            // 
            this.qL_NGUOIDUNGBindingSource.DataMember = "QL_NGUOIDUNG";
            this.qL_NGUOIDUNGBindingSource.DataSource = this.fPT_SHOPDataSet;
            // 
            // fPT_SHOPDataSet
            // 
            this.fPT_SHOPDataSet.DataSetName = "FPT_SHOPDataSet";
            this.fPT_SHOPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(392, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(101, 516);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(11, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(10, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.themNDVaoNhomDataGridView);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(493, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(549, 516);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Người dùng nhóm người dùng";
            // 
            // themNDVaoNhomDataGridView
            // 
            this.themNDVaoNhomDataGridView.AllowUserToAddRows = false;
            this.themNDVaoNhomDataGridView.AutoGenerateColumns = false;
            this.themNDVaoNhomDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.themNDVaoNhomDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.themNDVaoNhomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.themNDVaoNhomDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.themNDVaoNhomDataGridView.DataSource = this.themNDVaoNhomBindingSource;
            this.themNDVaoNhomDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.themNDVaoNhomDataGridView.Location = new System.Drawing.Point(3, 69);
            this.themNDVaoNhomDataGridView.Name = "themNDVaoNhomDataGridView";
            this.themNDVaoNhomDataGridView.Size = new System.Drawing.Size(543, 444);
            this.themNDVaoNhomDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TENDN";
            this.dataGridViewTextBoxColumn3.HeaderText = "TENDN";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MANHOM";
            this.dataGridViewTextBoxColumn4.HeaderText = "MANHOM";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // themNDVaoNhomBindingSource
            // 
            this.themNDVaoNhomBindingSource.DataMember = "ThemNDVaoNhom";
            this.themNDVaoNhomBindingSource.DataSource = this.fPT_SHOPDataSet;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbo_tennhom);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(3, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(543, 53);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // cbo_tennhom
            // 
            this.cbo_tennhom.DataSource = this.qL_NHOMNDBindingSource;
            this.cbo_tennhom.DisplayMember = "TENNHOMND";
            this.cbo_tennhom.FormattingEnabled = true;
            this.cbo_tennhom.Location = new System.Drawing.Point(55, 19);
            this.cbo_tennhom.Name = "cbo_tennhom";
            this.cbo_tennhom.Size = new System.Drawing.Size(300, 21);
            this.cbo_tennhom.TabIndex = 0;
            this.cbo_tennhom.ValueMember = "MANHOM";
            this.cbo_tennhom.SelectedIndexChanged += new System.EventHandler(this.cbo_tennhom_SelectedIndexChanged);
            // 
            // qL_NHOMNDBindingSource
            // 
            this.qL_NHOMNDBindingSource.DataMember = "QL_NHOMND";
            this.qL_NHOMNDBindingSource.DataSource = this.fPT_SHOPDataSet;
            // 
            // qL_NGUOIDUNGTableAdapter
            // 
            this.qL_NGUOIDUNGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHUCVUTableAdapter = null;
            this.tableAdapterManager.CT_DONDATHANGTableAdapter = null;
            this.tableAdapterManager.CT_HOADONTableAdapter = null;
            this.tableAdapterManager.CT_KHUYENMAI1TableAdapter = null;
            this.tableAdapterManager.CT_KHUYENMAITableAdapter = null;
            this.tableAdapterManager.CT_PHIEUNHAPHANGTableAdapter = null;
            this.tableAdapterManager.CT_THONGKEBHTableAdapter = null;
            this.tableAdapterManager.CT_THONGKENHTableAdapter = null;
            this.tableAdapterManager.DANHMUCBAOHANHTableAdapter = null;
            this.tableAdapterManager.DANHMUCSANPHAMTableAdapter = null;
            this.tableAdapterManager.DM_MANHINHTableAdapter = null;
            this.tableAdapterManager.DONDATHANGNCCTableAdapter = null;
          
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.KHUYENMAITableAdapter = null;
            this.tableAdapterManager.LICHSUGIATableAdapter = null;
            this.tableAdapterManager.LOAISANPHAMTableAdapter = null;
            this.tableAdapterManager.NHACUNGCAPTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PhanQuyenNguoiDungTableAdapter = null;
            this.tableAdapterManager.PHIEUBAOHANHTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPHANGTableAdapter = null;
            this.tableAdapterManager.QL_NGUOIDUNGTableAdapter = this.qL_NGUOIDUNGTableAdapter;
            this.tableAdapterManager.QL_NHOMNDTableAdapter = this.qL_NHOMNDTableAdapter;
            this.tableAdapterManager.QL_PHANQUYENTableAdapter = null;
            this.tableAdapterManager.QLND_NHOMNDTableAdapter = null;
            this.tableAdapterManager.SANPHAMTableAdapter = null;
            this.tableAdapterManager.ThemNDVaoNhomTableAdapter = null;
            this.tableAdapterManager.THONGKE_BHTableAdapter = null;
            this.tableAdapterManager.THONGKE_NHTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DoAN.FPT_SHOPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // qL_NHOMNDTableAdapter
            // 
            this.qL_NHOMNDTableAdapter.ClearBeforeFill = true;
            // 
            // themNDVaoNhomTableAdapter
            // 
            this.themNDVaoNhomTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TENDN";
            this.dataGridViewTextBoxColumn1.HeaderText = "TENDN";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MATKHAU";
            this.dataGridViewTextBoxColumn2.HeaderText = "MATKHAU";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "HOATDONG";
            this.dataGridViewCheckBoxColumn1.HeaderText = "HOATDONG";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // frm_ND_nhom_ND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_ND_nhom_ND";
            this.Size = new System.Drawing.Size(1042, 516);
            this.Load += new System.EventHandler(this.frm_ND_nhom_ND_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNGDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fPT_SHOPDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.themNDVaoNhomDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.themNDVaoNhomBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOMNDBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private FPT_SHOPDataSet fPT_SHOPDataSet;
        private System.Windows.Forms.BindingSource qL_NGUOIDUNGBindingSource;
        private FPT_SHOPDataSetTableAdapters.QL_NGUOIDUNGTableAdapter qL_NGUOIDUNGTableAdapter;
        private FPT_SHOPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView qL_NGUOIDUNGDataGridView;
        private System.Windows.Forms.GroupBox groupBox4;
        private FPT_SHOPDataSetTableAdapters.QL_NHOMNDTableAdapter qL_NHOMNDTableAdapter;
        private System.Windows.Forms.BindingSource qL_NHOMNDBindingSource;
        private System.Windows.Forms.ComboBox cbo_tennhom;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource themNDVaoNhomBindingSource;
        private FPT_SHOPDataSetTableAdapters.ThemNDVaoNhomTableAdapter themNDVaoNhomTableAdapter;
        private System.Windows.Forms.DataGridView themNDVaoNhomDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}