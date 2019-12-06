namespace DoAN
{
    partial class frm_Sanpham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Sanpham));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbo_loaisp = new System.Windows.Forms.ComboBox();
            this.lOAISANPHAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fPT_SHOPDataSet = new DoAN.FPT_SHOPDataSet();
            this.label11 = new System.Windows.Forms.Label();
            this.cbo_nhacc = new System.Windows.Forms.ComboBox();
            this.nHACUNGCAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.cbo_dmbh = new System.Windows.Forms.ComboBox();
            this.dANHMUCBAOHANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pic_anhsp = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_ghichu = new System.Windows.Forms.TextBox();
            this.cbo_tinhtrang = new System.Windows.Forms.ComboBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.txt_mau = new System.Windows.Forms.TextBox();
            this.txt_tensp = new System.Windows.Forms.TextBox();
            this.txt_masp = new System.Windows.Forms.TextBox();
            this.btn_chonanh = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sanpham_1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanpham_1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new DoAN.FPT_SHOPDataSetTableAdapters.TableAdapterManager();
            this.sanpham_1TableAdapter = new DoAN.FPT_SHOPDataSetTableAdapters.sanpham_1TableAdapter();
            this.dANHMUCBAOHANHTableAdapter = new DoAN.FPT_SHOPDataSetTableAdapters.DANHMUCBAOHANHTableAdapter();
            this.nHACUNGCAPTableAdapter = new DoAN.FPT_SHOPDataSetTableAdapters.NHACUNGCAPTableAdapter();
            this.lOAISANPHAMTableAdapter = new DoAN.FPT_SHOPDataSetTableAdapters.LOAISANPHAMTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAISANPHAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fPT_SHOPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHACUNGCAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANHMUCBAOHANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_anhsp)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sanpham_1DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanpham_1BindingSource)).BeginInit();
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
            this.groupBox1.Size = new System.Drawing.Size(1287, 62);
            this.groupBox1.TabIndex = 22;
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.cbo_loaisp);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cbo_nhacc);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cbo_dmbh);
            this.groupBox2.Controls.Add(this.pic_anhsp);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.txt_ghichu);
            this.groupBox2.Controls.Add(this.cbo_tinhtrang);
            this.groupBox2.Controls.Add(this.txt_soluong);
            this.groupBox2.Controls.Add(this.txt_mau);
            this.groupBox2.Controls.Add(this.txt_tensp);
            this.groupBox2.Controls.Add(this.txt_masp);
            this.groupBox2.Controls.Add(this.btn_chonanh);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1287, 296);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sản phẩm";
            // 
            // cbo_loaisp
            // 
            this.cbo_loaisp.DataSource = this.lOAISANPHAMBindingSource;
            this.cbo_loaisp.DisplayMember = "TENLOAI";
            this.cbo_loaisp.FormattingEnabled = true;
            this.cbo_loaisp.Location = new System.Drawing.Point(657, 96);
            this.cbo_loaisp.Name = "cbo_loaisp";
            this.cbo_loaisp.Size = new System.Drawing.Size(193, 25);
            this.cbo_loaisp.TabIndex = 82;
            this.cbo_loaisp.ValueMember = "MALOAI";
            // 
            // lOAISANPHAMBindingSource
            // 
            this.lOAISANPHAMBindingSource.DataMember = "LOAISANPHAM";
            this.lOAISANPHAMBindingSource.DataSource = this.fPT_SHOPDataSet;
            // 
            // fPT_SHOPDataSet
            // 
            this.fPT_SHOPDataSet.DataSetName = "FPT_SHOPDataSet";
            this.fPT_SHOPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(535, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 17);
            this.label11.TabIndex = 82;
            this.label11.Text = "Loại sản phẩm:";
            // 
            // cbo_nhacc
            // 
            this.cbo_nhacc.DataSource = this.nHACUNGCAPBindingSource;
            this.cbo_nhacc.DisplayMember = "TENNCC";
            this.cbo_nhacc.FormattingEnabled = true;
            this.cbo_nhacc.Location = new System.Drawing.Point(1020, 51);
            this.cbo_nhacc.Name = "cbo_nhacc";
            this.cbo_nhacc.Size = new System.Drawing.Size(256, 25);
            this.cbo_nhacc.TabIndex = 81;
            this.cbo_nhacc.ValueMember = "MANCC";
            // 
            // nHACUNGCAPBindingSource
            // 
            this.nHACUNGCAPBindingSource.DataMember = "NHACUNGCAP";
            this.nHACUNGCAPBindingSource.DataSource = this.fPT_SHOPDataSet;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(856, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 17);
            this.label10.TabIndex = 81;
            this.label10.Text = "Tên nhà cung cấp:";
            // 
            // cbo_dmbh
            // 
            this.cbo_dmbh.DataSource = this.dANHMUCBAOHANHBindingSource;
            this.cbo_dmbh.DisplayMember = "TEN_DMBH";
            this.cbo_dmbh.FormattingEnabled = true;
            this.cbo_dmbh.Location = new System.Drawing.Point(1020, 18);
            this.cbo_dmbh.Name = "cbo_dmbh";
            this.cbo_dmbh.Size = new System.Drawing.Size(256, 25);
            this.cbo_dmbh.TabIndex = 80;
            this.cbo_dmbh.ValueMember = "MA_DMBH";
            // 
            // dANHMUCBAOHANHBindingSource
            // 
            this.dANHMUCBAOHANHBindingSource.DataMember = "DANHMUCBAOHANH";
            this.dANHMUCBAOHANHBindingSource.DataSource = this.fPT_SHOPDataSet;
            // 
            // pic_anhsp
            // 
            this.pic_anhsp.Image = ((System.Drawing.Image)(resources.GetObject("pic_anhsp.Image")));
            this.pic_anhsp.Location = new System.Drawing.Point(12, 25);
            this.pic_anhsp.Name = "pic_anhsp";
            this.pic_anhsp.Size = new System.Drawing.Size(174, 156);
            this.pic_anhsp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_anhsp.TabIndex = 80;
            this.pic_anhsp.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(856, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Danh mục bảo hành:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.btn_sua);
            this.groupBox4.Controls.Add(this.btn_xoa);
            this.groupBox4.Controls.Add(this.btn_Them);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox4.Location = new System.Drawing.Point(3, 232);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1281, 61);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Xử lý";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1065, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 48);
            this.button1.TabIndex = 28;
            this.button1.Text = "Làm mới";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.btn_sua.Location = new System.Drawing.Point(778, 13);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(106, 48);
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
            this.btn_xoa.Location = new System.Drawing.Point(465, 10);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(106, 48);
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
            this.btn_Them.Location = new System.Drawing.Point(175, 10);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(106, 48);
            this.btn_Them.TabIndex = 23;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Location = new System.Drawing.Point(1020, 96);
            this.txt_ghichu.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ghichu.Multiline = true;
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(256, 108);
            this.txt_ghichu.TabIndex = 23;
            // 
            // cbo_tinhtrang
            // 
            this.cbo_tinhtrang.FormattingEnabled = true;
            this.cbo_tinhtrang.Items.AddRange(new object[] {
            "Còn hàng",
            "Hết hàng",
            "Chưa nhập"});
            this.cbo_tinhtrang.Location = new System.Drawing.Point(657, 60);
            this.cbo_tinhtrang.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_tinhtrang.Name = "cbo_tinhtrang";
            this.cbo_tinhtrang.Size = new System.Drawing.Size(194, 25);
            this.cbo_tinhtrang.TabIndex = 22;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(657, 24);
            this.txt_soluong.Margin = new System.Windows.Forms.Padding(2);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.ReadOnly = true;
            this.txt_soluong.Size = new System.Drawing.Size(194, 23);
            this.txt_soluong.TabIndex = 21;
            this.txt_soluong.Text = "0";
            // 
            // txt_mau
            // 
            this.txt_mau.Location = new System.Drawing.Point(333, 96);
            this.txt_mau.Margin = new System.Windows.Forms.Padding(2);
            this.txt_mau.Name = "txt_mau";
            this.txt_mau.Size = new System.Drawing.Size(193, 23);
            this.txt_mau.TabIndex = 20;
            // 
            // txt_tensp
            // 
            this.txt_tensp.Location = new System.Drawing.Point(333, 60);
            this.txt_tensp.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tensp.Name = "txt_tensp";
            this.txt_tensp.Size = new System.Drawing.Size(193, 23);
            this.txt_tensp.TabIndex = 19;
            // 
            // txt_masp
            // 
            this.txt_masp.Location = new System.Drawing.Point(333, 24);
            this.txt_masp.Margin = new System.Windows.Forms.Padding(2);
            this.txt_masp.Name = "txt_masp";
            this.txt_masp.ReadOnly = true;
            this.txt_masp.Size = new System.Drawing.Size(194, 23);
            this.txt_masp.TabIndex = 18;
            // 
            // btn_chonanh
            // 
            this.btn_chonanh.Location = new System.Drawing.Point(21, 186);
            this.btn_chonanh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_chonanh.Name = "btn_chonanh";
            this.btn_chonanh.Size = new System.Drawing.Size(136, 43);
            this.btn_chonanh.TabIndex = 12;
            this.btn_chonanh.Text = "Chọn ảnh";
            this.btn_chonanh.UseVisualStyleBackColor = true;
            this.btn_chonanh.Click += new System.EventHandler(this.btn_chonanh_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(866, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ghi chú:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(535, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tình trạng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(535, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(211, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Màu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(211, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên sản phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(211, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sản phẩm:";
            // 
            // sanpham_1DataGridView
            // 
            this.sanpham_1DataGridView.AllowUserToAddRows = false;
            this.sanpham_1DataGridView.AutoGenerateColumns = false;
            this.sanpham_1DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sanpham_1DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.sanpham_1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sanpham_1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn11});
            this.sanpham_1DataGridView.DataSource = this.sanpham_1BindingSource;
            this.sanpham_1DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sanpham_1DataGridView.Location = new System.Drawing.Point(0, 358);
            this.sanpham_1DataGridView.Name = "sanpham_1DataGridView";
            this.sanpham_1DataGridView.ReadOnly = true;
            this.sanpham_1DataGridView.Size = new System.Drawing.Size(1287, 333);
            this.sanpham_1DataGridView.TabIndex = 24;
            this.sanpham_1DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sanpham_1DataGridView_CellContentClick);
            this.sanpham_1DataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.sanpham_1DataGridView_CellMouseClick);
            this.sanpham_1DataGridView.SelectionChanged += new System.EventHandler(this.sanpham_1DataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MASP";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã sản phẩm";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TENSP";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên sản phẩm";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MAU";
            this.dataGridViewTextBoxColumn4.HeaderText = "Màu";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SOLUONG";
            this.dataGridViewTextBoxColumn5.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TINHTRANG";
            this.dataGridViewTextBoxColumn6.HeaderText = "Tình trạng";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "GHICHU";
            this.dataGridViewTextBoxColumn7.HeaderText = "Ghi chú";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "MA_DMBH";
            this.dataGridViewTextBoxColumn8.HeaderText = "Mã danh mục bảo hành";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "ANHSP";
            this.dataGridViewImageColumn1.HeaderText = "Ảnh sản phẩm";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "MANCC";
            this.dataGridViewTextBoxColumn9.HeaderText = "Mã nhà cung cấp";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "TENNCC";
            this.dataGridViewTextBoxColumn10.HeaderText = "Tên nhà cung cấp";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MALOAI";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã loại";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "TENLOAI";
            this.dataGridViewTextBoxColumn11.HeaderText = "Tên loại";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // sanpham_1BindingSource
            // 
            this.sanpham_1BindingSource.DataMember = "sanpham_1";
            this.sanpham_1BindingSource.DataSource = this.fPT_SHOPDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHUCVUTableAdapter = null;
            this.tableAdapterManager.Connection = null;
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
            // sanpham_1TableAdapter
            // 
            this.sanpham_1TableAdapter.ClearBeforeFill = true;
            // 
            // dANHMUCBAOHANHTableAdapter
            // 
            this.dANHMUCBAOHANHTableAdapter.ClearBeforeFill = true;
            // 
            // nHACUNGCAPTableAdapter
            // 
            this.nHACUNGCAPTableAdapter.ClearBeforeFill = true;
            // 
            // lOAISANPHAMTableAdapter
            // 
            this.lOAISANPHAMTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Sanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 691);
            this.Controls.Add(this.sanpham_1DataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Sanpham";
            this.Text = "frm_Sanpham";
            this.Load += new System.EventHandler(this.frm_Sanpham_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAISANPHAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fPT_SHOPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHACUNGCAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANHMUCBAOHANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_anhsp)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sanpham_1DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanpham_1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_ghichu;
        private System.Windows.Forms.ComboBox cbo_tinhtrang;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.TextBox txt_mau;
        private System.Windows.Forms.TextBox txt_tensp;
        private System.Windows.Forms.TextBox txt_masp;
        private System.Windows.Forms.Button btn_chonanh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_Them;
        private FPT_SHOPDataSet fPT_SHOPDataSet;
        private FPT_SHOPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource sanpham_1BindingSource;
        private FPT_SHOPDataSetTableAdapters.sanpham_1TableAdapter sanpham_1TableAdapter;
        private System.Windows.Forms.DataGridView sanpham_1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pic_anhsp;
        private System.Windows.Forms.BindingSource dANHMUCBAOHANHBindingSource;
        private FPT_SHOPDataSetTableAdapters.DANHMUCBAOHANHTableAdapter dANHMUCBAOHANHTableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbo_dmbh;
        private System.Windows.Forms.BindingSource nHACUNGCAPBindingSource;
        private FPT_SHOPDataSetTableAdapters.NHACUNGCAPTableAdapter nHACUNGCAPTableAdapter;
        private System.Windows.Forms.ComboBox cbo_nhacc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource lOAISANPHAMBindingSource;
        private FPT_SHOPDataSetTableAdapters.LOAISANPHAMTableAdapter lOAISANPHAMTableAdapter;
        private System.Windows.Forms.ComboBox cbo_loaisp;
        private System.Windows.Forms.Button button1;
    }
}