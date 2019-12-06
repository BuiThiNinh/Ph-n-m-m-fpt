namespace DoAN
{
    partial class frm_ThemCTDDH
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
            System.Windows.Forms.Label mA_CTDDHLabel;
            System.Windows.Forms.Label sOLUONGMUALabel;
            System.Windows.Forms.Label mADHLabel;
            System.Windows.Forms.Label mASPLabel;
            System.Windows.Forms.Label label2;
            this.txt_mactddh = new System.Windows.Forms.TextBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_madonhang = new System.Windows.Forms.TextBox();
            this.fPT_SHOPDataSet = new DoAN.FPT_SHOPDataSet();
            this.nHACUNGCAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHACUNGCAPTableAdapter = new DoAN.FPT_SHOPDataSetTableAdapters.NHACUNGCAPTableAdapter();
            this.tableAdapterManager = new DoAN.FPT_SHOPDataSetTableAdapters.TableAdapterManager();
            this.sANPHAMTableAdapter = new DoAN.FPT_SHOPDataSetTableAdapters.SANPHAMTableAdapter();
            this.cbo_nhacc = new System.Windows.Forms.ComboBox();
            this.sANPHAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sANPHAMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cbo_tensp = new System.Windows.Forms.ComboBox();
            mA_CTDDHLabel = new System.Windows.Forms.Label();
            sOLUONGMUALabel = new System.Windows.Forms.Label();
            mADHLabel = new System.Windows.Forms.Label();
            mASPLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fPT_SHOPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHACUNGCAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // mA_CTDDHLabel
            // 
            mA_CTDDHLabel.AutoSize = true;
            mA_CTDDHLabel.BackColor = System.Drawing.Color.Transparent;
            mA_CTDDHLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mA_CTDDHLabel.ForeColor = System.Drawing.Color.Navy;
            mA_CTDDHLabel.Location = new System.Drawing.Point(45, 19);
            mA_CTDDHLabel.Name = "mA_CTDDHLabel";
            mA_CTDDHLabel.Size = new System.Drawing.Size(142, 15);
            mA_CTDDHLabel.TabIndex = 14;
            mA_CTDDHLabel.Text = "Mã chi tiết đơn hàng:";
            // 
            // sOLUONGMUALabel
            // 
            sOLUONGMUALabel.AutoSize = true;
            sOLUONGMUALabel.BackColor = System.Drawing.Color.Transparent;
            sOLUONGMUALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOLUONGMUALabel.ForeColor = System.Drawing.Color.Navy;
            sOLUONGMUALabel.Location = new System.Drawing.Point(45, 139);
            sOLUONGMUALabel.Name = "sOLUONGMUALabel";
            sOLUONGMUALabel.Size = new System.Drawing.Size(68, 15);
            sOLUONGMUALabel.TabIndex = 8;
            sOLUONGMUALabel.Text = "Số lượng:";
            // 
            // mADHLabel
            // 
            mADHLabel.AutoSize = true;
            mADHLabel.BackColor = System.Drawing.Color.Transparent;
            mADHLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mADHLabel.ForeColor = System.Drawing.Color.Navy;
            mADHLabel.Location = new System.Drawing.Point(45, 49);
            mADHLabel.Name = "mADHLabel";
            mADHLabel.Size = new System.Drawing.Size(91, 15);
            mADHLabel.TabIndex = 28;
            mADHLabel.Text = "Mã đặt hàng:";
            // 
            // mASPLabel
            // 
            mASPLabel.AutoSize = true;
            mASPLabel.BackColor = System.Drawing.Color.Transparent;
            mASPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mASPLabel.ForeColor = System.Drawing.Color.Navy;
            mASPLabel.Location = new System.Drawing.Point(45, 109);
            mASPLabel.Name = "mASPLabel";
            mASPLabel.Size = new System.Drawing.Size(98, 15);
            mASPLabel.TabIndex = 30;
            mASPLabel.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.Navy;
            label2.Location = new System.Drawing.Point(45, 79);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(121, 15);
            label2.TabIndex = 37;
            label2.Text = "Tên nhà cung cấp";
            // 
            // txt_mactddh
            // 
            this.txt_mactddh.Location = new System.Drawing.Point(207, 18);
            this.txt_mactddh.Name = "txt_mactddh";
            this.txt_mactddh.ReadOnly = true;
            this.txt_mactddh.Size = new System.Drawing.Size(300, 20);
            this.txt_mactddh.TabIndex = 15;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(207, 136);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(300, 20);
            this.txt_soluong.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Controls.Add(this.btn_Them);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 72);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xử lý";
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_thoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_thoat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_thoat.FlatAppearance.BorderSize = 3;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.Navy;
            this.btn_thoat.Image = global::DoAN.Properties.Resources.dong;
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(401, 13);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(106, 51);
            this.btn_thoat.TabIndex = 31;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
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
            this.btn_Them.Location = new System.Drawing.Point(207, 14);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(106, 51);
            this.btn_Them.TabIndex = 29;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_madonhang
            // 
            this.txt_madonhang.Location = new System.Drawing.Point(207, 47);
            this.txt_madonhang.Name = "txt_madonhang";
            this.txt_madonhang.Size = new System.Drawing.Size(300, 20);
            this.txt_madonhang.TabIndex = 32;
            // 
            // fPT_SHOPDataSet
            // 
            this.fPT_SHOPDataSet.DataSetName = "FPT_SHOPDataSet";
            this.fPT_SHOPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHACUNGCAPBindingSource
            // 
            this.nHACUNGCAPBindingSource.DataMember = "NHACUNGCAP";
            this.nHACUNGCAPBindingSource.DataSource = this.fPT_SHOPDataSet;
            // 
            // nHACUNGCAPTableAdapter
            // 
            this.nHACUNGCAPTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.NHACUNGCAPTableAdapter = this.nHACUNGCAPTableAdapter;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PhanQuyenNguoiDungTableAdapter = null;
            this.tableAdapterManager.PHIEUBAOHANHTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPHANGTableAdapter = null;
            this.tableAdapterManager.QL_NGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.QL_NHOMNDTableAdapter = null;
            this.tableAdapterManager.QL_PHANQUYENTableAdapter = null;
            this.tableAdapterManager.QLND_NHOMNDTableAdapter = null;
            this.tableAdapterManager.SANPHAMTableAdapter = this.sANPHAMTableAdapter;
            this.tableAdapterManager.ThemNDVaoNhomTableAdapter = null;
            this.tableAdapterManager.THONGKE_BHTableAdapter = null;
            this.tableAdapterManager.THONGKE_NHTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DoAN.FPT_SHOPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sANPHAMTableAdapter
            // 
            this.sANPHAMTableAdapter.ClearBeforeFill = true;
            // 
            // cbo_nhacc
            // 
            this.cbo_nhacc.DataSource = this.nHACUNGCAPBindingSource;
            this.cbo_nhacc.DisplayMember = "TENNCC";
            this.cbo_nhacc.FormattingEnabled = true;
            this.cbo_nhacc.Location = new System.Drawing.Point(206, 76);
            this.cbo_nhacc.Name = "cbo_nhacc";
            this.cbo_nhacc.Size = new System.Drawing.Size(300, 21);
            this.cbo_nhacc.TabIndex = 38;
            this.cbo_nhacc.ValueMember = "MANCC";
            this.cbo_nhacc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cbo_nhacc_MouseDown);
            // 
            // sANPHAMBindingSource
            // 
            this.sANPHAMBindingSource.DataMember = "SANPHAM";
            this.sANPHAMBindingSource.DataSource = this.fPT_SHOPDataSet;
            // 
            // sANPHAMBindingSource1
            // 
            this.sANPHAMBindingSource1.DataMember = "SANPHAM";
            this.sANPHAMBindingSource1.DataSource = this.fPT_SHOPDataSet;
            // 
            // cbo_tensp
            // 
            this.cbo_tensp.DataSource = this.sANPHAMBindingSource1;
            this.cbo_tensp.DisplayMember = "TENSP";
            this.cbo_tensp.FormattingEnabled = true;
            this.cbo_tensp.Location = new System.Drawing.Point(207, 109);
            this.cbo_tensp.Name = "cbo_tensp";
            this.cbo_tensp.Size = new System.Drawing.Size(300, 21);
            this.cbo_tensp.TabIndex = 39;
            this.cbo_tensp.ValueMember = "MASP";
            // 
            // frm_ThemCTDDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(539, 257);
            this.Controls.Add(this.cbo_tensp);
            this.Controls.Add(this.cbo_nhacc);
            this.Controls.Add(label2);
            this.Controls.Add(this.txt_madonhang);
            this.Controls.Add(mADHLabel);
            this.Controls.Add(mASPLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(mA_CTDDHLabel);
            this.Controls.Add(this.txt_mactddh);
            this.Controls.Add(sOLUONGMUALabel);
            this.Controls.Add(this.txt_soluong);
            this.IsMdiContainer = true;
            this.Name = "frm_ThemCTDDH";
            this.Text = "frm_ThemCTDDH";
            this.Load += new System.EventHandler(this.frm_ThemCTDDH_Load_1);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fPT_SHOPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHACUNGCAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_mactddh;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.TextBox txt_madonhang;
        private FPT_SHOPDataSet fPT_SHOPDataSet;
        private System.Windows.Forms.BindingSource nHACUNGCAPBindingSource;
        private FPT_SHOPDataSetTableAdapters.NHACUNGCAPTableAdapter nHACUNGCAPTableAdapter;
        private FPT_SHOPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbo_nhacc;
        private FPT_SHOPDataSetTableAdapters.SANPHAMTableAdapter sANPHAMTableAdapter;
        private System.Windows.Forms.BindingSource sANPHAMBindingSource;
        private System.Windows.Forms.BindingSource sANPHAMBindingSource1;
        private System.Windows.Forms.ComboBox cbo_tensp;
    }
}