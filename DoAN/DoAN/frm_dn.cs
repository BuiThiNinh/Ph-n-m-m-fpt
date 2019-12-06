using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAN
{
    public partial class frm_dn : Form
    {
        PhanQuyen pq = new PhanQuyen();
        public frm_dn()
        {
            InitializeComponent();
        }
        cauhinh kt = new cauhinh();
      
         private void Processlogin()
        {
            LoginResult result;
            result = kt.Check_User(txt_tendangnhap.Text, txt_matkhau.Text);
            if (result == LoginResult.Invalid)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                return;
            }
            else if (result == LoginResult.Disable)
            {
                MessageBox.Show("Tài khoản đã bị khóa");
                return;
            }
            else
            {
                // đúng tài khoản và mật khẩu
                frm_main main = new frm_main();
                main.Tendn = txt_tendangnhap.Text.ToString();
                /////////

                /////////
                main.ShowDialog();
            }
         }
        private void frm_dn_Load(object sender, EventArgs e)
        {

        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tendangnhap.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống");
                txt_tendangnhap.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_matkhau.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống");
                txt_matkhau.Focus();
                return;
            }
            int kq = kt.check_config();
            if (kq == 0)
            {
                Processlogin();
            }
            if (kq == 1)
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại");
                ProcessConfig();
            }
            if (kq == 2)
            {
                MessageBox.Show("Chuỗi cấu hình không phù hợp");
                ProcessConfig();
            }
        }
        private void ProcessConfig()
        {
            frm_cauhinh frm_cauhinh = new frm_cauhinh();
           
            frm_cauhinh.Show();
        }


    }
}
