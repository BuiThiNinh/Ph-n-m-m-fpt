namespace DoAN
{
    partial class frm_tknv
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
            System.Windows.Forms.Label tENDNLabel;
            System.Windows.Forms.Label mATKHAULabel;
            this.fPT_SHOPDataSet = new DoAN.FPT_SHOPDataSet();
            this.qL_NGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NGUOIDUNGTableAdapter = new DoAN.FPT_SHOPDataSetTableAdapters.QL_NGUOIDUNGTableAdapter();
            this.tableAdapterManager = new DoAN.FPT_SHOPDataSetTableAdapters.TableAdapterManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tENDNTextBox = new System.Windows.Forms.TextBox();
            this.mATKHAUTextBox = new System.Windows.Forms.TextBox();
            this.hOATDONGCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.qL_NGUOIDUNGDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            tENDNLabel = new System.Windows.Forms.Label();
            mATKHAULabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fPT_SHOPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNGBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hOATDONGCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNGDataGridView)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // fPT_SHOPDataSet
            // 
            this.fPT_SHOPDataSet.DataSetName = "FPT_SHOPDataSet";
            this.fPT_SHOPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qL_NGUOIDUNGBindingSource
            // 
            this.qL_NGUOIDUNGBindingSource.DataMember = "QL_NGUOIDUNG";
            this.qL_NGUOIDUNGBindingSource.DataSource = this.fPT_SHOPDataSet;
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
            this.tableAdapterManager.PHIEUBAOHANHTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPHANGTableAdapter = null;
            this.tableAdapterManager.QL_NGUOIDUNGTableAdapter = this.qL_NGUOIDUNGTableAdapter;
            this.tableAdapterManager.QL_NHOMNDTableAdapter = null;
            this.tableAdapterManager.QL_PHANQUYENTableAdapter = null;
            this.tableAdapterManager.QLND_NHOMNDTableAdapter = null;
            this.tableAdapterManager.SANPHAMTableAdapter = null;
            this.tableAdapterManager.ThemNDVaoNhomTableAdapter = null;
            this.tableAdapterManager.THONGKE_BHTableAdapter = null;
            this.tableAdapterManager.THONGKE_NHTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DoAN.FPT_SHOPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(tENDNLabel);
            this.groupBox1.Controls.Add(this.tENDNTextBox);
            this.groupBox1.Controls.Add(mATKHAULabel);
            this.groupBox1.Controls.Add(this.mATKHAUTextBox);
            this.groupBox1.Controls.Add(this.hOATDONGCheckEdit);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1026, 200);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // tENDNLabel
            // 
            tENDNLabel.AutoSize = true;
            tENDNLabel.Location = new System.Drawing.Point(173, 45);
            tENDNLabel.Name = "tENDNLabel";
            tENDNLabel.Size = new System.Drawing.Size(81, 13);
            tENDNLabel.TabIndex = 7;
            tENDNLabel.Text = "Tên đăng nhập";
            // 
            // tENDNTextBox
            // 
            this.tENDNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qL_NGUOIDUNGBindingSource, "TENDN", true));
            this.tENDNTextBox.Location = new System.Drawing.Point(257, 42);
            this.tENDNTextBox.Name = "tENDNTextBox";
            this.tENDNTextBox.ReadOnly = true;
            this.tENDNTextBox.Size = new System.Drawing.Size(213, 20);
            this.tENDNTextBox.TabIndex = 8;
            // 
            // mATKHAULabel
            // 
            mATKHAULabel.AutoSize = true;
            mATKHAULabel.Location = new System.Drawing.Point(173, 80);
            mATKHAULabel.Name = "mATKHAULabel";
            mATKHAULabel.Size = new System.Drawing.Size(52, 13);
            mATKHAULabel.TabIndex = 9;
            mATKHAULabel.Text = "Mật khẩu";
            // 
            // mATKHAUTextBox
            // 
            this.mATKHAUTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qL_NGUOIDUNGBindingSource, "MATKHAU", true));
            this.mATKHAUTextBox.Location = new System.Drawing.Point(257, 77);
            this.mATKHAUTextBox.Name = "mATKHAUTextBox";
            this.mATKHAUTextBox.ReadOnly = true;
            this.mATKHAUTextBox.Size = new System.Drawing.Size(213, 20);
            this.mATKHAUTextBox.TabIndex = 10;
            // 
            // hOATDONGCheckEdit
            // 
            this.hOATDONGCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qL_NGUOIDUNGBindingSource, "HOATDONG", true));
            this.hOATDONGCheckEdit.Location = new System.Drawing.Point(258, 105);
            this.hOATDONGCheckEdit.Name = "hOATDONGCheckEdit";
            this.hOATDONGCheckEdit.Properties.Caption = "Hoạt động";
            this.hOATDONGCheckEdit.Size = new System.Drawing.Size(213, 19);
            this.hOATDONGCheckEdit.TabIndex = 11;
            // 
            // qL_NGUOIDUNGDataGridView
            // 
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
            this.qL_NGUOIDUNGDataGridView.Location = new System.Drawing.Point(0, 200);
            this.qL_NGUOIDUNGDataGridView.Name = "qL_NGUOIDUNGDataGridView";
            this.qL_NGUOIDUNGDataGridView.Size = new System.Drawing.Size(1026, 333);
            this.qL_NGUOIDUNGDataGridView.TabIndex = 3;
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
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btn_sua);
            this.groupBox6.Controls.Add(this.btn_xoa);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox6.Location = new System.Drawing.Point(3, 133);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1020, 64);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Xử lý";
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
            this.btn_sua.Location = new System.Drawing.Point(450, 10);
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
            this.btn_xoa.Location = new System.Drawing.Point(152, 10);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(106, 51);
            this.btn_xoa.TabIndex = 26;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // frm_tknv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 533);
            this.Controls.Add(this.qL_NGUOIDUNGDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_tknv";
            this.Text = "frm_tknv";
            this.Load += new System.EventHandler(this.frm_tknv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fPT_SHOPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNGBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hOATDONGCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNGDataGridView)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FPT_SHOPDataSet fPT_SHOPDataSet;
        private System.Windows.Forms.BindingSource qL_NGUOIDUNGBindingSource;
        private FPT_SHOPDataSetTableAdapters.QL_NGUOIDUNGTableAdapter qL_NGUOIDUNGTableAdapter;
        private FPT_SHOPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tENDNTextBox;
        private System.Windows.Forms.TextBox mATKHAUTextBox;
        private DevExpress.XtraEditors.CheckEdit hOATDONGCheckEdit;
        private System.Windows.Forms.DataGridView qL_NGUOIDUNGDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
    }
}