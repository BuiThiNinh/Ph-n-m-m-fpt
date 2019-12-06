namespace DoAN
{
    partial class frm_PhieuBaoHanh
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_solanbh = new Tk_Contronl.txt_ChiNhapSo();
            this.edngaylap = new DevExpress.XtraEditors.DateEdit();
            this.txt_ghichu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_cthd = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.txt_tgbh = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.baoHanhDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baoHanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fPT_SHOPDataSet = new DoAN.FPT_SHOPDataSet();
            this.pHIEUBAOHANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEUBAOHANHTableAdapter = new DoAN.FPT_SHOPDataSetTableAdapters.PHIEUBAOHANHTableAdapter();
            this.tableAdapterManager = new DoAN.FPT_SHOPDataSetTableAdapters.TableAdapterManager();
            this.baoHanhTableAdapter = new DoAN.FPT_SHOPDataSetTableAdapters.BaoHanhTableAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edngaylap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edngaylap.Properties)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baoHanhDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baoHanhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fPT_SHOPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUBAOHANHBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(1289, 62);
            this.groupBox1.TabIndex = 21;
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
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Controls.Add(this.txt_solanbh);
            this.groupBox3.Controls.Add(this.edngaylap);
            this.groupBox3.Controls.Add(this.txt_ghichu);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txt_cthd);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.txt_tgbh);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 62);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1289, 245);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txt_solanbh
            // 
            this.txt_solanbh.Location = new System.Drawing.Point(622, 58);
            this.txt_solanbh.Name = "txt_solanbh";
            this.txt_solanbh.Size = new System.Drawing.Size(374, 22);
            this.txt_solanbh.TabIndex = 29;
            // 
            // edngaylap
            // 
            this.edngaylap.EditValue = null;
            this.edngaylap.Enabled = false;
            this.edngaylap.Location = new System.Drawing.Point(173, 60);
            this.edngaylap.Name = "edngaylap";
            this.edngaylap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edngaylap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edngaylap.Size = new System.Drawing.Size(259, 20);
            this.edngaylap.TabIndex = 27;
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Location = new System.Drawing.Point(622, 87);
            this.txt_ghichu.Multiline = true;
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(374, 93);
            this.txt_ghichu.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(479, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Ghi chú:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(479, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Số lần bảo hành:";
            // 
            // txt_cthd
            // 
            this.txt_cthd.Enabled = false;
            this.txt_cthd.Location = new System.Drawing.Point(173, 21);
            this.txt_cthd.Name = "txt_cthd";
            this.txt_cthd.ReadOnly = true;
            this.txt_cthd.Size = new System.Drawing.Size(259, 22);
            this.txt_cthd.TabIndex = 19;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.btn_sua);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(3, 178);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1283, 64);
            this.groupBox4.TabIndex = 18;
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
            this.btn_sua.Location = new System.Drawing.Point(863, 10);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(130, 51);
            this.btn_sua.TabIndex = 27;
            this.btn_sua.Text = "Cập nhật";
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // txt_tgbh
            // 
            this.txt_tgbh.Enabled = false;
            this.txt_tgbh.Location = new System.Drawing.Point(622, 23);
            this.txt_tgbh.Name = "txt_tgbh";
            this.txt_tgbh.ReadOnly = true;
            this.txt_tgbh.Size = new System.Drawing.Size(374, 22);
            this.txt_tgbh.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(475, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Thời gian bảo hành:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(20, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Ngày lập:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(20, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Mã phiếu bảo hành";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.baoHanhDataGridView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1289, 366);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // baoHanhDataGridView
            // 
            this.baoHanhDataGridView.AutoGenerateColumns = false;
            this.baoHanhDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.baoHanhDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.baoHanhDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.baoHanhDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.baoHanhDataGridView.DataSource = this.baoHanhBindingSource;
            this.baoHanhDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baoHanhDataGridView.Location = new System.Drawing.Point(3, 16);
            this.baoHanhDataGridView.Name = "baoHanhDataGridView";
            this.baoHanhDataGridView.Size = new System.Drawing.Size(1283, 347);
            this.baoHanhDataGridView.TabIndex = 0;
            this.baoHanhDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.baoHanhDataGridView_CellMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MA_PBH";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã phiếu bảo hành";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NGAYTAO_PBH";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ngày tạo phiếu bảo hành";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "THOIGIAN_BH";
            this.dataGridViewTextBoxColumn3.HeaderText = "Thời gian bảo hành";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SOLAN_BH";
            this.dataGridViewTextBoxColumn4.HeaderText = "Số lần bảo hành";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "GHICHU";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ghi chú";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "HOTENNV";
            this.dataGridViewTextBoxColumn6.HeaderText = "Họ tên nhân viên";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TENKH";
            this.dataGridViewTextBoxColumn7.HeaderText = "Tên khách hàng";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "SDT_KH";
            this.dataGridViewTextBoxColumn8.HeaderText = "Số điện thoại";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // baoHanhBindingSource
            // 
            this.baoHanhBindingSource.DataMember = "BaoHanh";
            this.baoHanhBindingSource.DataSource = this.fPT_SHOPDataSet;
            // 
            // fPT_SHOPDataSet
            // 
            this.fPT_SHOPDataSet.DataSetName = "FPT_SHOPDataSet";
            this.fPT_SHOPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHIEUBAOHANHBindingSource
            // 
            this.pHIEUBAOHANHBindingSource.DataMember = "PHIEUBAOHANH";
            this.pHIEUBAOHANHBindingSource.DataSource = this.fPT_SHOPDataSet;
            // 
            // pHIEUBAOHANHTableAdapter
            // 
            this.pHIEUBAOHANHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHUCVUTableAdapter = null;
            this.tableAdapterManager.CT_DONDATHANGTableAdapter = null;
            this.tableAdapterManager.CT_HOADONTableAdapter = null;
            this.tableAdapterManager.CT_KHUYENMAI1TableAdapter = null;
            this.tableAdapterManager.CT_KHUYENMAITableAdapter = null;
            this.tableAdapterManager.CT_PHIEUNHAPHANG1TableAdapter = null;
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
            this.tableAdapterManager.PHIEUBAOHANHTableAdapter = this.pHIEUBAOHANHTableAdapter;
            this.tableAdapterManager.PHIEUNHAPHANGTableAdapter = null;
            this.tableAdapterManager.QL_NGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.QL_NHOMNDTableAdapter = null;
            this.tableAdapterManager.QL_PHANQUYENTableAdapter = null;
            this.tableAdapterManager.QLND_NHOMNDTableAdapter = null;
            this.tableAdapterManager.SANPHAMTableAdapter = null;
            this.tableAdapterManager.ThemNDVaoNhomTableAdapter = null;
            this.tableAdapterManager.THONGKE_BHTableAdapter = null;
            this.tableAdapterManager.THONGKE_NHTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DoAN.FPT_SHOPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // baoHanhTableAdapter
            // 
            this.baoHanhTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Image = global::DoAN.Properties.Resources.xoa;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(671, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 51);
            this.button1.TabIndex = 28;
            this.button1.Text = "Xóa";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_PhieuBaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_PhieuBaoHanh";
            this.Size = new System.Drawing.Size(1289, 673);
            this.Load += new System.EventHandler(this.frm_PhieuBaoHanh_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edngaylap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edngaylap.Properties)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.baoHanhDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baoHanhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fPT_SHOPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUBAOHANHBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.DateEdit edngaylap;
        private System.Windows.Forms.TextBox txt_ghichu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_cthd;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.TextBox txt_tgbh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private FPT_SHOPDataSet fPT_SHOPDataSet;
        private System.Windows.Forms.BindingSource pHIEUBAOHANHBindingSource;
        private FPT_SHOPDataSetTableAdapters.PHIEUBAOHANHTableAdapter pHIEUBAOHANHTableAdapter;
        private FPT_SHOPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Tk_Contronl.txt_ChiNhapSo txt_solanbh;
        private System.Windows.Forms.BindingSource baoHanhBindingSource;
        private FPT_SHOPDataSetTableAdapters.BaoHanhTableAdapter baoHanhTableAdapter;
        private System.Windows.Forms.DataGridView baoHanhDataGridView;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button button1;
    }
}