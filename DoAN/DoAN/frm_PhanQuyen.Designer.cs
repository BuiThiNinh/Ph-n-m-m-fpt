namespace DoAN
{
    partial class frm_PhanQuyen
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
            this.dM_MANHINHDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dM_MANHINHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fPT_SHOPDataSet = new DoAN.FPT_SHOPDataSet();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.phanQuyenNguoiDungDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phanQuyenNguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.qL_NHOMNDComboBox = new System.Windows.Forms.ComboBox();
            this.qL_NHOMNDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new DoAN.FPT_SHOPDataSetTableAdapters.TableAdapterManager();
            this.dM_MANHINHTableAdapter = new DoAN.FPT_SHOPDataSetTableAdapters.DM_MANHINHTableAdapter();
            this.phanQuyenNguoiDungTableAdapter = new DoAN.FPT_SHOPDataSetTableAdapters.PhanQuyenNguoiDungTableAdapter();
            this.qL_NHOMNDTableAdapter = new DoAN.FPT_SHOPDataSetTableAdapters.QL_NHOMNDTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dM_MANHINHDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dM_MANHINHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fPT_SHOPDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyenNguoiDungDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyenNguoiDungBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOMNDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dM_MANHINHDataGridView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 582);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh mục màn hình";
            // 
            // dM_MANHINHDataGridView
            // 
            this.dM_MANHINHDataGridView.AutoGenerateColumns = false;
            this.dM_MANHINHDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dM_MANHINHDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dM_MANHINHDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dM_MANHINHDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dM_MANHINHDataGridView.DataSource = this.dM_MANHINHBindingSource;
            this.dM_MANHINHDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dM_MANHINHDataGridView.Location = new System.Drawing.Point(3, 16);
            this.dM_MANHINHDataGridView.Name = "dM_MANHINHDataGridView";
            this.dM_MANHINHDataGridView.Size = new System.Drawing.Size(386, 563);
            this.dM_MANHINHDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MAMANHINH";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mã màn hình";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TENMANHINHCHUCNANG";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tên màn hình chức năng";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dM_MANHINHBindingSource
            // 
            this.dM_MANHINHBindingSource.DataMember = "DM_MANHINH";
            this.dM_MANHINHBindingSource.DataSource = this.fPT_SHOPDataSet;
            // 
            // fPT_SHOPDataSet
            // 
            this.fPT_SHOPDataSet.DataSetName = "FPT_SHOPDataSet";
            this.fPT_SHOPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(392, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(83, 582);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(4, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.phanQuyenNguoiDungDataGridView);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(475, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 582);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phân quyền";
            // 
            // phanQuyenNguoiDungDataGridView
            // 
            this.phanQuyenNguoiDungDataGridView.AutoGenerateColumns = false;
            this.phanQuyenNguoiDungDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.phanQuyenNguoiDungDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.phanQuyenNguoiDungDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phanQuyenNguoiDungDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.phanQuyenNguoiDungDataGridView.DataSource = this.phanQuyenNguoiDungBindingSource;
            this.phanQuyenNguoiDungDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phanQuyenNguoiDungDataGridView.Location = new System.Drawing.Point(3, 90);
            this.phanQuyenNguoiDungDataGridView.Name = "phanQuyenNguoiDungDataGridView";
            this.phanQuyenNguoiDungDataGridView.Size = new System.Drawing.Size(396, 489);
            this.phanQuyenNguoiDungDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAMANHINH";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã màn hình";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MANHOM";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã nhóm";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // phanQuyenNguoiDungBindingSource
            // 
            this.phanQuyenNguoiDungBindingSource.DataMember = "PhanQuyenNguoiDung";
            this.phanQuyenNguoiDungBindingSource.DataSource = this.fPT_SHOPDataSet;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.qL_NHOMNDComboBox);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(3, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(396, 74);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // qL_NHOMNDComboBox
            // 
            this.qL_NHOMNDComboBox.DataSource = this.qL_NHOMNDBindingSource;
            this.qL_NHOMNDComboBox.DisplayMember = "TENNHOMND";
            this.qL_NHOMNDComboBox.FormattingEnabled = true;
            this.qL_NHOMNDComboBox.Location = new System.Drawing.Point(39, 37);
            this.qL_NHOMNDComboBox.Name = "qL_NHOMNDComboBox";
            this.qL_NHOMNDComboBox.Size = new System.Drawing.Size(300, 21);
            this.qL_NHOMNDComboBox.TabIndex = 0;
            this.qL_NHOMNDComboBox.ValueMember = "MANHOM";
            this.qL_NHOMNDComboBox.SelectedIndexChanged += new System.EventHandler(this.qL_NHOMNDComboBox_SelectedIndexChanged_1);
            this.qL_NHOMNDComboBox.SelectedValueChanged += new System.EventHandler(this.qL_NHOMNDComboBox_SelectedValueChanged);
            // 
            // qL_NHOMNDBindingSource
            // 
            this.qL_NHOMNDBindingSource.DataMember = "QL_NHOMND";
            this.qL_NHOMNDBindingSource.DataSource = this.fPT_SHOPDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHUCVUTableAdapter = null;
            this.tableAdapterManager.CT_DONDATHANGTableAdapter = null;
            this.tableAdapterManager.CT_HOADONTableAdapter = null;
            this.tableAdapterManager.CT_KHUYENMAI1TableAdapter = null;
            this.tableAdapterManager.CT_KHUYENMAITableAdapter = null;
            this.tableAdapterManager.CT_THONGKEBHTableAdapter = null;
            this.tableAdapterManager.CT_THONGKENHTableAdapter = null;
            this.tableAdapterManager.DANHMUCBAOHANHTableAdapter = null;
            this.tableAdapterManager.DANHMUCSANPHAMTableAdapter = null;
            this.tableAdapterManager.DM_MANHINHTableAdapter = this.dM_MANHINHTableAdapter;
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
            this.tableAdapterManager.QL_NGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.QL_NHOMNDTableAdapter = null;
            this.tableAdapterManager.QL_PHANQUYENTableAdapter = null;
            this.tableAdapterManager.QLND_NHOMNDTableAdapter = null;
            this.tableAdapterManager.SANPHAMTableAdapter = null;
            this.tableAdapterManager.THONGKE_BHTableAdapter = null;
            this.tableAdapterManager.THONGKE_NHTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DoAN.FPT_SHOPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dM_MANHINHTableAdapter
            // 
            this.dM_MANHINHTableAdapter.ClearBeforeFill = true;
            // 
            // phanQuyenNguoiDungTableAdapter
            // 
            this.phanQuyenNguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // qL_NHOMNDTableAdapter
            // 
            this.qL_NHOMNDTableAdapter.ClearBeforeFill = true;
            // 
            // frm_PhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 582);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
  //          this.IsMdiContainer = true;
            this.Name = "frm_PhanQuyen";
            this.Text = "frm_PhanQuyen";
            this.Load += new System.EventHandler(this.frm_PhanQuyen_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dM_MANHINHDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dM_MANHINHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fPT_SHOPDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyenNguoiDungDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyenNguoiDungBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOMNDBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private FPT_SHOPDataSet fPT_SHOPDataSet;
        private FPT_SHOPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private FPT_SHOPDataSetTableAdapters.DM_MANHINHTableAdapter dM_MANHINHTableAdapter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.BindingSource dM_MANHINHBindingSource;
        private System.Windows.Forms.DataGridView dM_MANHINHDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource phanQuyenNguoiDungBindingSource;
        private FPT_SHOPDataSetTableAdapters.PhanQuyenNguoiDungTableAdapter phanQuyenNguoiDungTableAdapter;
        private System.Windows.Forms.DataGridView phanQuyenNguoiDungDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource qL_NHOMNDBindingSource;
        private FPT_SHOPDataSetTableAdapters.QL_NHOMNDTableAdapter qL_NHOMNDTableAdapter;
        private System.Windows.Forms.ComboBox qL_NHOMNDComboBox;
    }
}