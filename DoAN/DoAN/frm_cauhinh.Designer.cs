namespace DoAN
{
    partial class frm_cauhinh
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
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_ketnoi = new System.Windows.Forms.Button();
            this.cbb_database = new System.Windows.Forms.ComboBox();
            this.cbb_server = new System.Windows.Forms.ComboBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(181, 214);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(75, 45);
            this.btn_huy.TabIndex = 39;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_ketnoi
            // 
            this.btn_ketnoi.Location = new System.Drawing.Point(39, 214);
            this.btn_ketnoi.Name = "btn_ketnoi";
            this.btn_ketnoi.Size = new System.Drawing.Size(75, 45);
            this.btn_ketnoi.TabIndex = 38;
            this.btn_ketnoi.Text = "Kết nối";
            this.btn_ketnoi.UseVisualStyleBackColor = true;
            this.btn_ketnoi.Click += new System.EventHandler(this.btn_ketnoi_Click);
            // 
            // cbb_database
            // 
            this.cbb_database.FormattingEnabled = true;
            this.cbb_database.Location = new System.Drawing.Point(110, 164);
            this.cbb_database.Name = "cbb_database";
            this.cbb_database.Size = new System.Drawing.Size(146, 21);
            this.cbb_database.TabIndex = 37;
            this.cbb_database.SelectedIndexChanged += new System.EventHandler(this.cbb_database_SelectedIndexChanged);
            // 
            // cbb_server
            // 
            this.cbb_server.FormattingEnabled = true;
            this.cbb_server.Location = new System.Drawing.Point(110, 24);
            this.cbb_server.Name = "cbb_server";
            this.cbb_server.Size = new System.Drawing.Size(146, 21);
            this.cbb_server.TabIndex = 36;
            this.cbb_server.DropDown += new System.EventHandler(this.cbb_server_DropDown);
            this.cbb_server.TextChanged += new System.EventHandler(this.cbb_server_TextChanged);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(110, 119);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(146, 20);
            this.txt_password.TabIndex = 35;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(110, 72);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(146, 20);
            this.txt_username.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(23, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Database";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(23, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(23, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "User name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Server name";
            // 
            // frm_cauhinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 292);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_ketnoi);
            this.Controls.Add(this.cbb_database);
            this.Controls.Add(this.cbb_server);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.IsMdiContainer = true;
            this.Name = "frm_cauhinh";
            this.Text = "frm_cauhinh";
            this.Load += new System.EventHandler(this.frm_cauhinh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_ketnoi;
        private System.Windows.Forms.ComboBox cbb_database;
        private System.Windows.Forms.ComboBox cbb_server;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}