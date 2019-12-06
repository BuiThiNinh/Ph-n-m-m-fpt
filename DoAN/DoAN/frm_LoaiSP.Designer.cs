namespace DoAN
{
    partial class frm_LoaiSP
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_tendm = new System.Windows.Forms.ComboBox();
            this.dANHMUCSANPHAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fPT_SHOPDataSet = new DoAN.FPT_SHOPDataSet();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_maloai = new System.Windows.Forms.TextBox();
            this.txt_tenloai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.dANHMUCSANPHAMTableAdapter = new DoAN.FPT_SHOPDataSetTableAdapters.DANHMUCSANPHAMTableAdapter();
            this.tableAdapterManager = new DoAN.FPT_SHOPDataSetTableAdapters.TableAdapterManager();
            this.loaispBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loaispTableAdapter = new DoAN.FPT_SHOPDataSetTableAdapters.LoaispTableAdapter();
            this.loaispDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dANHMUCSANPHAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fPT_SHOPDataSet)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaispBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaispDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.cmb_tendm);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_maloai);
            this.groupBox2.Controls.Add(this.txt_tenloai);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1241, 186);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loại sản phẩm";
            // 
            // cmb_tendm
            // 
            this.cmb_tendm.DataSource = this.dANHMUCSANPHAMBindingSource;
            this.cmb_tendm.DisplayMember = "TENDM";
            this.cmb_tendm.FormattingEnabled = true;
            this.cmb_tendm.Location = new System.Drawing.Point(669, 36);
            this.cmb_tendm.Name = "cmb_tendm";
            this.cmb_tendm.Size = new System.Drawing.Size(216, 24);
            this.cmb_tendm.TabIndex = 33;
            this.cmb_tendm.ValueMember = "MADM";
            // 
            // dANHMUCSANPHAMBindingSource
            // 
            this.dANHMUCSANPHAMBindingSource.DataMember = "DANHMUCSANPHAM";
            this.dANHMUCSANPHAMBindingSource.DataSource = this.fPT_SHOPDataSet;
            // 
            // fPT_SHOPDataSet
            // 
            this.fPT_SHOPDataSet.DataSetName = "FPT_SHOPDataSet";
            this.fPT_SHOPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_sua);
            this.groupBox4.Controls.Add(this.btn_xoa);
            this.groupBox4.Controls.Add(this.btn_Them);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox4.Location = new System.Drawing.Point(3, 119);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1235, 64);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Xử lý";
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_sua.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_sua.FlatAppearance.BorderSize = 3;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.Navy;
            this.btn_sua.Image = global::DoAN.Properties.Resources.marker;
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(784, 11);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(106, 51);
            this.btn_sua.TabIndex = 27;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_xoa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_xoa.FlatAppearance.BorderSize = 3;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.Navy;
            this.btn_xoa.Image = global::DoAN.Properties.Resources.xoa;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(495, 11);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(106, 51);
            this.btn_xoa.TabIndex = 26;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Them.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Them.FlatAppearance.BorderSize = 3;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.Navy;
            this.btn_Them.Image = global::DoAN.Properties.Resources.them;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(206, 11);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(106, 51);
            this.btn_Them.TabIndex = 23;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(554, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Tên danh mục:";
            // 
            // txt_maloai
            // 
            this.txt_maloai.Location = new System.Drawing.Point(250, 35);
            this.txt_maloai.Multiline = true;
            this.txt_maloai.Name = "txt_maloai";
            this.txt_maloai.Size = new System.Drawing.Size(246, 23);
            this.txt_maloai.TabIndex = 30;
            // 
            // txt_tenloai
            // 
            this.txt_tenloai.Location = new System.Drawing.Point(250, 74);
            this.txt_tenloai.Multiline = true;
            this.txt_tenloai.Name = "txt_tenloai";
            this.txt_tenloai.Size = new System.Drawing.Size(246, 23);
            this.txt_tenloai.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(129, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Mã loại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(129, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Tên loại:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_tk);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1241, 62);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = global::DoAN.Properties.Resources.search_50px;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(559, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(17, 19);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tìm kiếm";
            // 
            // txt_tk
            // 
            this.txt_tk.Location = new System.Drawing.Point(328, 24);
            this.txt_tk.Multiline = true;
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(251, 22);
            this.txt_tk.TabIndex = 2;
            this.txt_tk.TextChanged += new System.EventHandler(this.txt_tk_TextChanged);
            // 
            // dANHMUCSANPHAMTableAdapter
            // 
            this.dANHMUCSANPHAMTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.DANHMUCSANPHAMTableAdapter = this.dANHMUCSANPHAMTableAdapter;
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
            this.tableAdapterManager.QL_NGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.QL_NHOMNDTableAdapter = null;
            this.tableAdapterManager.QL_PHANQUYENTableAdapter = null;
            this.tableAdapterManager.QLND_NHOMNDTableAdapter = null;
            this.tableAdapterManager.SANPHAMTableAdapter = null;
            this.tableAdapterManager.THONGKE_BHTableAdapter = null;
            this.tableAdapterManager.THONGKE_NHTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DoAN.FPT_SHOPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // loaispBindingSource
            // 
            this.loaispBindingSource.DataMember = "Loaisp";
            this.loaispBindingSource.DataSource = this.fPT_SHOPDataSet;
            // 
            // loaispTableAdapter
            // 
            this.loaispTableAdapter.ClearBeforeFill = true;
            // 
            // loaispDataGridView
            // 
            this.loaispDataGridView.AllowUserToAddRows = false;
            this.loaispDataGridView.AutoGenerateColumns = false;
            this.loaispDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loaispDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.loaispDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loaispDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.loaispDataGridView.DataSource = this.loaispBindingSource;
            this.loaispDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loaispDataGridView.Location = new System.Drawing.Point(0, 248);
            this.loaispDataGridView.Name = "loaispDataGridView";
            this.loaispDataGridView.ReadOnly = true;
            this.loaispDataGridView.Size = new System.Drawing.Size(1241, 305);
            this.loaispDataGridView.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MALOAI";
            this.dataGridViewTextBoxColumn1.HeaderText = "MALOAI";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENLOAI";
            this.dataGridViewTextBoxColumn2.HeaderText = "TENLOAI";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MADM";
            this.dataGridViewTextBoxColumn3.HeaderText = "MADM";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TENDM";
            this.dataGridViewTextBoxColumn4.HeaderText = "TENDM";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // frm_LoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.loaispDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_LoaiSP";
            this.Size = new System.Drawing.Size(1241, 553);
            this.Load += new System.EventHandler(this.frm_LoaiSP_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dANHMUCSANPHAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fPT_SHOPDataSet)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaispBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaispDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_maloai;
        private System.Windows.Forms.TextBox txt_tenloai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tk;
        private FPT_SHOPDataSet fPT_SHOPDataSet;
        private System.Windows.Forms.BindingSource dANHMUCSANPHAMBindingSource;
        private FPT_SHOPDataSetTableAdapters.DANHMUCSANPHAMTableAdapter dANHMUCSANPHAMTableAdapter;
        private FPT_SHOPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmb_tendm;
        private System.Windows.Forms.BindingSource loaispBindingSource;
        private FPT_SHOPDataSetTableAdapters.LoaispTableAdapter loaispTableAdapter;
        private System.Windows.Forms.DataGridView loaispDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}