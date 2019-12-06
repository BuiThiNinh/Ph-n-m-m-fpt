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
    public partial class frm_ThemTTKH : Form
    {
        public frm_ThemTTKH(frm_KhachHang us)
        {
            InitializeComponent();
        }

        public frm_ThemTTKH(frm_banHang frm_banHang)
        {
            // TODO: Complete member initialization
            this.frm_banHang = frm_banHang;
        }
        /// <summary>
        /// //////////
        /// </summary>
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

        /// <summary>
        /// ////////////////
        /// </summary>
        QL_FPT_SHOPDataContext ql = new QL_FPT_SHOPDataContext();
        private frm_banHang frm_banHang;
        private void frm_ThemTTKH_Load(object sender, EventArgs e)
        {
            txt_makh.Text = ql.SINHMA_KH();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_makh.Text == "" || txt_tenkh.Text == "" || txtsdt.Text == ""|| txtdiachi.Text=="")
            {
                MessageBox.Show("Không được để trống");
                return;
            }
            //kiểm tra trùng
            KHACHHANG bb = new KHACHHANG();
            var kt = from s in ql.KHACHHANGs where s.MAKH == txt_makh.Text select s;
            if (kt.Count() > 0)
            {
                MessageBox.Show("Trùng khóa chính");
                return;
            }
            bb.MAKH = txt_makh.Text;
            bb.TENKH = txt_tenkh.Text;
            bb.SDT_KH = txtsdt.Text;
            bb.DIACHI_KH = txtdiachi.Text;
            ql.KHACHHANGs.InsertOnSubmit(bb);
            ql.SubmitChanges();
            insert();
            MessageBox.Show("Thành công");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
