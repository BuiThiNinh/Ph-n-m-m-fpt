namespace DoAN
{
    partial class frm_ThemTTKH
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
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label tENKHLabel;
            System.Windows.Forms.Label sDTKHACHHANGLabel;
            System.Windows.Forms.Label dIACHIKHLabel;
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtsdt = new DevExpress.XtraEditors.TextEdit();
            mAKHLabel = new System.Windows.Forms.Label();
            tENKHLabel = new System.Windows.Forms.Label();
            sDTKHACHHANGLabel = new System.Windows.Forms.Label();
            dIACHIKHLabel = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsdt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.ForeColor = System.Drawing.Color.Navy;
            mAKHLabel.Location = new System.Drawing.Point(19, 25);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(104, 14);
            mAKHLabel.TabIndex = 8;
            mAKHLabel.Text = "Mã khách hàng:";
            // 
            // tENKHLabel
            // 
            tENKHLabel.AutoSize = true;
            tENKHLabel.ForeColor = System.Drawing.Color.Navy;
            tENKHLabel.Location = new System.Drawing.Point(19, 67);
            tENKHLabel.Name = "tENKHLabel";
            tENKHLabel.Size = new System.Drawing.Size(108, 14);
            tENKHLabel.TabIndex = 10;
            tENKHLabel.Text = "Tên khách hàng:";
            // 
            // sDTKHACHHANGLabel
            // 
            sDTKHACHHANGLabel.AutoSize = true;
            sDTKHACHHANGLabel.ForeColor = System.Drawing.Color.Navy;
            sDTKHACHHANGLabel.Location = new System.Drawing.Point(19, 106);
            sDTKHACHHANGLabel.Name = "sDTKHACHHANGLabel";
            sDTKHACHHANGLabel.Size = new System.Drawing.Size(93, 14);
            sDTKHACHHANGLabel.TabIndex = 12;
            sDTKHACHHANGLabel.Text = "Số điện thoại:";
            // 
            // dIACHIKHLabel
            // 
            dIACHIKHLabel.AutoSize = true;
            dIACHIKHLabel.ForeColor = System.Drawing.Color.Navy;
            dIACHIKHLabel.Location = new System.Drawing.Point(19, 146);
            dIACHIKHLabel.Name = "dIACHIKHLabel";
            dIACHIKHLabel.Size = new System.Drawing.Size(51, 14);
            dIACHIKHLabel.TabIndex = 14;
            dIACHIKHLabel.Text = "Địa chỉ:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Silver;
            this.groupBox4.Controls.Add(this.txtsdt);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(mAKHLabel);
            this.groupBox4.Controls.Add(this.txt_makh);
            this.groupBox4.Controls.Add(tENKHLabel);
            this.groupBox4.Controls.Add(this.txt_tenkh);
            this.groupBox4.Controls.Add(sDTKHACHHANGLabel);
            this.groupBox4.Controls.Add(dIACHIKHLabel);
            this.groupBox4.Controls.Add(this.txtdiachi);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(424, 274);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_sua);
            this.groupBox3.Controls.Add(this.btn_Them);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 188);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(418, 83);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xử lý";
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_sua.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_sua.FlatAppearance.BorderSize = 3;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.Navy;
            this.btn_sua.Image = global::DoAN.Properties.Resources.dong;
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(290, 22);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(106, 51);
            this.btn_sua.TabIndex = 30;
            this.btn_sua.Text = "Thoát";
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
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
            this.btn_Them.Location = new System.Drawing.Point(77, 22);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(106, 51);
            this.btn_Them.TabIndex = 28;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_makh
            // 
            this.txt_makh.Location = new System.Drawing.Point(145, 22);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(258, 22);
            this.txt_makh.TabIndex = 9;
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Location = new System.Drawing.Point(145, 64);
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(258, 22);
            this.txt_tenkh.TabIndex = 11;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(145, 143);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(258, 22);
            this.txtdiachi.TabIndex = 15;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(145, 104);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Properties.Mask.EditMask = "0\\d?\\d?\\d?\\d?\\d?\\d?\\d?\\d?\\d?";
            this.txtsdt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtsdt.Size = new System.Drawing.Size(258, 20);
            this.txtsdt.TabIndex = 17;
            // 
            // frm_ThemTTKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 277);
            this.Controls.Add(this.groupBox4);
            this.IsMdiContainer = true;
            this.Name = "frm_ThemTTKH";
            this.Text = "frm_ThemTTKH";
            this.Load += new System.EventHandler(this.frm_ThemTTKH_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtsdt.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_makh;
        private System.Windows.Forms.TextBox txt_tenkh;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_Them;
        private DevExpress.XtraEditors.TextEdit txtsdt;
    }
}