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
    public partial class frm_NhapHang : UserControl
    {
        public frm_NhapHang()
        {
            InitializeComponent();
        }

        String TenDN;
        public string Tendn
        {
            get { return TenDN; }
            set { TenDN = value; }
        }
        String TENNV;
        public string Tennv
        {
            get { return TENNV; }
            set { TENNV = value; }
        }
        QL_FPT_SHOPDataContext ql = new QL_FPT_SHOPDataContext();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            phieuNhapDataGridView.DataSource = ql.XEMTT_TTPNH(textBox1.Text);
        }

        private void frm_NhapHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fPT_SHOPDataSet.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Fill(this.fPT_SHOPDataSet.PhieuNhap);
            this.dONDATHANGNCCTableAdapter.Fill(this.fPT_SHOPDataSet.DONDATHANGNCC);
            txt_manhaphang.Text = ql.SINHMA_Pnh();
            txt_manv.Text = Tendn;
            txt_tennv .Text= Tennv;
            ed_ngaynhap.Text = DateTime.Now.ToShortDateString();
        }

        private void phieuNhapDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.cT_PHIEUNHAPHANG1TableAdapter.Fill(this.fPT_SHOPDataSet.CT_PHIEUNHAPHANG1, phieuNhapDataGridView.CurrentRow.Cells[0].Value.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dONDATHANGNCCComboBox_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.Enter)
            {
                var kt = (from p in ql.DONDATHANGNCCs
                          from nc in ql.NHACUNGCAPs
                          where p.MANCC == nc.MANCC && p.MADH == cbo_madh.Text
                          select nc.TENNCC).FirstOrDefault();
                 var ktt = (from p in ql.DONDATHANGNCCs
                            where p.MADH == cbo_madh.Text
                            select p.MANCC).FirstOrDefault();
                 txt_tenncc .Text= kt.ToString();
                 txt_mancc.Text = ktt.ToString();
           }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            //kiểm tra rỗng
            if (txt_manhaphang.Text == "" || txt_manv.Text == ""  || ed_ngaynhap.Text == "")
            {
                MessageBox.Show("Không được để trống");
                return;
            }
            //kiểm tra trùng
            PHIEUNHAPHANG nh = new PHIEUNHAPHANG();
            var kt = from s in ql.PHIEUNHAPHANGs where s.MANH == txt_manhaphang.Text select s;
            if (kt.Count() > 0)
            {
                MessageBox.Show("Trùng khóa chính");
                return;
            }
            nh.MANH = txt_manhaphang.Text;
            nh.MANV = txt_manv.Text;
            nh.MADH = cbo_madh.Text;
            nh.NGAYNHAPHANG =Convert.ToDateTime( ed_ngaynhap.Text);
            nh.TONGSOLUONGNHAP = 0;
            nh.TONGTIENNHAP = 0;
            ql.PHIEUNHAPHANGs.InsertOnSubmit(nh);
            ql.SubmitChanges();
            //frm_phieunhaphang_Load(sender, e);
            //this.cT_PHIEUNHAPHANG1TableAdapter.Fill(this.fPT_SHOPDataSet.CT_PHIEUNHAPHANG1, phieuNhapDataGridView.CurrentRow.Cells[0].Value.ToString());
            frm_NhapHang_Load(sender, e);
            MessageBox.Show("Thành công");
            //txt_manhaphang.Text = "" || txt_manv.Text = "" || txt_madathang.Text = "" || txt_mancc.Text = "" || ed_ngaynhap.Text = "" || txt_soluong.Text = "" || txt_tongtien.Text = "";
            
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var kt = (from bb in ql.PHIEUNHAPHANGs
                      from ct in ql.CT_PHIEUNHAPHANGs
                  
                      where bb.MANH == ct.MANH && bb.MANH == phieuNhapDataGridView.CurrentRow.Cells[0].Value.ToString()
                      select bb).Count();
            if (kt == 0)
            {

                var thanhvien = ql.PHIEUNHAPHANGs.SingleOrDefault(tv => tv.MANH == phieuNhapDataGridView.CurrentRow.Cells[0].Value.ToString());
                ql.PHIEUNHAPHANGs.DeleteOnSubmit(thanhvien);
                ql.SubmitChanges();
                frm_NhapHang_Load(sender, e);
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("không thể xóa");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var thanhvien = ql.PHIEUNHAPHANGs.SingleOrDefault(tv => tv.MANH == phieuNhapDataGridView.CurrentRow.Cells[0].Value.ToString());
            thanhvien.MADH = cbo_madh.Text;
            ql.SubmitChanges();
            frm_NhapHang_Load(sender, e);
            MessageBox.Show("Thành công");
        }

        private void cT_PHIEUNHAPHANG1DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)// stt cột trong datagirdview
            {
                var thanhvien = ql.CT_PHIEUNHAPHANGs.SingleOrDefault(tv => tv.MA_CTPNH == cT_PHIEUNHAPHANG1DataGridView.CurrentRow.Cells[0].Value.ToString());
                ql.CT_PHIEUNHAPHANGs.DeleteOnSubmit(thanhvien);
                ql.SubmitChanges();
                this.cT_PHIEUNHAPHANG1TableAdapter.Fill(this.fPT_SHOPDataSet.CT_PHIEUNHAPHANG1, phieuNhapDataGridView.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Thành công");
                frm_NhapHang_Load(sender, e);
            }
            if (e.ColumnIndex == 7)// stt cột trong datagirdview
            {
                var thanhvien = ql.CT_PHIEUNHAPHANGs.SingleOrDefault(tv => tv.MA_CTPNH == cT_PHIEUNHAPHANG1DataGridView.CurrentRow.Cells[0].Value.ToString());
                thanhvien.MASP = cT_PHIEUNHAPHANG1DataGridView.CurrentRow.Cells[1].Value.ToString();
                thanhvien.SOLUONGNHAP = Convert.ToInt32(cT_PHIEUNHAPHANG1DataGridView.CurrentRow.Cells[3].Value.ToString());
                thanhvien.DONGIANHAP = Convert.ToDecimal(cT_PHIEUNHAPHANG1DataGridView.CurrentRow.Cells[4].Value.ToString());
                ql.SubmitChanges();
                this.cT_PHIEUNHAPHANG1TableAdapter.Fill(this.fPT_SHOPDataSet.CT_PHIEUNHAPHANG1, phieuNhapDataGridView.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Thành công");
                frm_NhapHang_Load(sender, e);

            }
        }

      
    }
}
