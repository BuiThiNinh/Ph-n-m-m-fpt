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
    public partial class frm_ThemCTDDH : Form
    {
        public frm_ThemCTDDH( frm_dathang us )
        {
            InitializeComponent();
        }

        string strNhan;
        public string Message
        {
            get { return strNhan; }
            set { strNhan = value; }
        }
        public delegate void updatedelegate(object sender, UpdateEventArgs args);
        public event updatedelegate UpdateEventHandler;


        public class UpdateEventArgs : EventArgs
        {
            public string data
            {
                get;
                set;
            }
        }
        protected void insert()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }

        QL_FPT_SHOPDataContext ql = new QL_FPT_SHOPDataContext();

       
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_mactddh.Text == "" || txt_soluong.Text == ""  || txt_madonhang.Text == "" )
            {
                MessageBox.Show("Không được để trống");
                return;
            }
            //kiểm tra trùng
            CT_DONDATHANG bb = new CT_DONDATHANG();
            var kt = from s in ql.CT_DONDATHANGs where s.MA_CTDDH == txt_mactddh.Text select s;
            if (kt.Count() > 0)
            {
                MessageBox.Show("Trùng khóa chính");
                return;
            }
            bb.MA_CTDDH = txt_mactddh.Text;
            bb.SOLUONGDAT = Convert.ToInt32(txt_soluong.Text);
            bb.MADH=txt_madonhang.Text;
            bb.MASP = cbo_tensp.SelectedValue.ToString();
            ql.CT_DONDATHANGs.InsertOnSubmit(bb);
            ql.SubmitChanges();
            insert();
            MessageBox.Show("Thành công");
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_ThemCTDDH_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fPT_SHOPDataSet.SANPHAM' table. You can move, or remove it, as needed.
            this.sANPHAMTableAdapter.Fill(this.fPT_SHOPDataSet.SANPHAM);
            // TODO: This line of code loads data into the 'fPT_SHOPDataSet.NHACUNGCAP' table. You can move, or remove it, as needed.
            this.nHACUNGCAPTableAdapter.Fill(this.fPT_SHOPDataSet.NHACUNGCAP);
            txt_mactddh.Text = ql.SINHMA_CTDDH();
            txt_madonhang.Text = strNhan;
        }

        private void cmb_masp_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void nHACUNGCAPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHACUNGCAPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fPT_SHOPDataSet);

        }

        private void cbo_nhacc_MouseDown(object sender, MouseEventArgs e)
        {
            var kt = (from s in ql.SANPHAMs
                      where s.MANCC == cbo_nhacc.SelectedValue.ToString()
                      select s.TENSP).ToList();
            cbo_tensp.DataSource = kt.ToList();
            cbo_tensp.DisplayMember = "TENSP";
        }
    }
}
