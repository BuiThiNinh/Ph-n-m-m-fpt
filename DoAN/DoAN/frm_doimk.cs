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
    public partial class frm_doimk : Form
    {
        public frm_doimk()
        {
            InitializeComponent();
        }
        String TenDN;
        public string Tendn
        {
            get { return TenDN; }
            set { TenDN = value; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_mkcu.Text))
            {
                e.Cancel = true;
                txt_mkcu.Focus();
                errorProvider1.SetError(txt_mkcu, "Không được để trống");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_mkcu, null);
            }
        }

        private void frm_doimk_Load(object sender, EventArgs e)
        {
            txtten.Text = Tendn;
        }

        private void txt_mkm_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_mkm.Text))
            {
                e.Cancel = true;
                txt_mkm.Focus();
                errorProvider2.SetError(txt_mkm, "Không được để trống");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(txt_mkm, null);
            }
        }

        private void txt_nlmk_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nlmk.Text))
            {
                e.Cancel = true;
                txt_nlmk.Focus();
                errorProvider3.SetError(txt_nlmk, "Không được để trống");
            }
            else
            {
                e.Cancel = false;
                errorProvider3.SetError(txt_nlmk, null);
            }
            if (txt_mkm.Text != txt_nlmk.Text)
            {
                e.Cancel = true;
                errorProvider3.SetError(txt_nlmk, "mật khẩu không trùng với mật khẩu mới");
            }
            else
            {
                e.Cancel = false;
                errorProvider3.SetError(txt_nlmk, null);
            }
        }
        QL_FPT_SHOPDataContext ql = new QL_FPT_SHOPDataContext();
        private void btn_xn_Click(object sender, EventArgs e)
        {
            var kt = from tk in ql.QL_NGUOIDUNGs

                     where tk.TENDN==txtten.Text && tk.MATKHAU == txt_mkcu.Text
                     select tk;
            if (kt.Count() > 0)
            {
                var thanhvien = ql.QL_NGUOIDUNGs.SingleOrDefault(tv => tv.TENDN == txtten.Text);
                thanhvien.MATKHAU = txt_mkm.Text;
                ql.SubmitChanges();
                MessageBox.Show("Thành công");
           
            }
                else
                {
                    MessageBox.Show("sai mật khẩu");
                }

            
        }
    }
}
