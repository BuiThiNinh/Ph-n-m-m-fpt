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
    public partial class frm_banHang : UserControl
    {
        public frm_banHang()
        {
            InitializeComponent();
        }
        String TenDN;
        public string Tendn
        {
            get { return TenDN; }
            set { TenDN = value; }
        }
        private void fill_bhToolStripButton_Click(object sender, EventArgs e)
        {
           
        }

        private void txt_mahd_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.banHangTableAdapter.Fill_bh(this.fPT_SHOPDataSet.BanHang, txt_mahd.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        QL_FPT_SHOPDataContext ql = new QL_FPT_SHOPDataContext();
        private void frm_banHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fPT_SHOPDataSet.HoaDon1' table. You can move, or remove it, as needed.
            this.hoaDon1TableAdapter.Fill(this.fPT_SHOPDataSet.HoaDon1);
           this.lOAISANPHAMTableAdapter.Fill(this.fPT_SHOPDataSet.LOAISANPHAM);
            // TODO: This line of code loads data into the 'fPT_SHOPDataSet.BaoHanh' table. You can move, or remove it, as needed.
            this.baoHanhTableAdapter.Fill(this.fPT_SHOPDataSet.BaoHanh);
           // this.banHangTableAdapter.Fill_bh(this.fPT_SHOPDataSet.BanHang, txt_mahd.Text);
            txt_mahd.Text = ql.SINHMA_HOADON();
            txt_macthd.Text = ql.SINHMA_CTHD();
            ed_nglap.Text = DateTime.Now.ToShortDateString();
            txt_manv.Text = Tendn;
            
        }

      
        private void txt_tenkh_KeyDown(object sender, KeyEventArgs e)
        {
            //var ktsdt = from kh in ql.KHACHHANGs
            //            where kh.SDT_KH == txtsdt.Text
            //            select kh;
            //if (ktsdt.Count() < 0)
            //{
            //    MessageBox.Show("sai số điện thoại");
            //    return;
            //}
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    KHACHHANG bb = new KHACHHANG();
                    var ktpbh = (
                              from ct in ql.KHACHHANGs
                              where ct.SDT_KH == txtsdt.Text.ToString()
                              select ct.TENKH).FirstOrDefault();
                    var kt = (
                           from ct in ql.KHACHHANGs
                           where ct.SDT_KH == txtsdt.Text.ToString()
                           select ct.MAKH).FirstOrDefault();
                    txt_tenkh.Text = ktpbh.ToString();
                    txt_makh.Text = kt.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Sai số điện thoại");
            }
        }

        private void txt_masp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LICHSUGIA bb = new LICHSUGIA();
                var ktpbh = (
                          from ct in ql.LICHSUGIAs
                          where ct.MASP == txtmasp.Text
                          select ct.GIA).FirstOrDefault();
                var ktp = (
                         from ct in ql.SANPHAMs
                         where ct.MASP == txtmasp.Text
                         select ct.MAU).FirstOrDefault();
                var ktt = (
                        from ct in ql.SANPHAMs
                        where ct.MASP == txtmasp.Text
                        select ct.TENSP).FirstOrDefault();
                var kttt = (
                     from ct in ql.SANPHAMs
                     where ct.MASP == txtmasp.Text
                     select ct.TINHTRANG).FirstOrDefault();
               
                   txt_tensp.Text = ktt.ToString();
                    txtmau.Text = ktp.ToString();
                    txtdongia.Text = ktpbh.ToString();
                    txt_tinhtrang.Text = kttt.ToString();
            }
        }

        private void btn_themhd_Click(object sender, EventArgs e)
        {
            //kiểm tra rỗng
            if (txt_mahd.Text == "" || txt_manv.Text == "" || ed_nglap.Text == ""|| txt_makh.Text=="" )
            {
                MessageBox.Show("Không được để trống");
                return;
            }
            //kiểm tra trùng
            HOADON bb = new HOADON();
            var kt = from s in ql.HOADONs where s.MAHD == txt_mahd.Text select s;
            if (kt.Count() > 0)
            {
                MessageBox.Show("Trùng khóa chính");
                return;
            }
            bb.MAHD = txt_mahd.Text;
            bb.MAKH = txt_makh.Text;
            bb.MANV = txt_manv.Text;
            bb.NGAYLAPHD = Convert.ToDateTime(ed_nglap.Text.ToString());
            bb.TONGSOLUONG = 0;
            bb.TONGTIENHD = 0;
            this.hoaDon1TableAdapter.Fill(this.fPT_SHOPDataSet.HoaDon1);
            ql.HOADONs.InsertOnSubmit(bb);
            ql.SubmitChanges();

            MessageBox.Show("Thành công");
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            frm_banHang_Load(sender, e);
            this.banHangTableAdapter.Fill_bh(this.fPT_SHOPDataSet.BanHang, txt_mahd.Text);
            txt_manv.Text = ed_nglap.Text  = txtdongia.Text="";
        }
        private void btn_themct_Click(object sender, EventArgs e)
        {
            //kiểm tra rỗng
            if (txt_mahd.Text == "" || txt_macthd.Text == "" || txt_sl.Text == ""||txtdongia.Text==""||txt_tg.Text=="")
            {
                MessageBox.Show("Không được để trống");
                return;
            }
            //kiểm tra trùng
            PHIEUBAOHANH p = new PHIEUBAOHANH();
            CT_HOADON bb = new CT_HOADON();
            var kt = from s in ql.CT_HOADONs where s.MA_CTHD == txt_macthd.Text select s;
            if (kt.Count() > 0)
            {
                MessageBox.Show("Trùng khóa chính");
                return;
            }
            
            bb.MA_CTHD = txt_macthd.Text;
            bb.MAHD = hoaDon1DataGridView.CurrentRow.Cells[0].Value.ToString();
            bb.MASP = txtmasp.Text;
            bb.SOLUONGMUA = Convert.ToInt32(txt_sl.Text);
            bb.DONGIAHANG = Convert.ToDecimal(txtdongia.Text);
            bb.THANHTIENHD = 0;
            ql.CT_HOADONs.InsertOnSubmit(bb);
            var ktbh = from s in ql.PHIEUBAOHANHs where s.MA_PBH == txt_macthd.Text select s;
            if (kt.Count() > 0)
            {
                MessageBox.Show("Trùng khóa chính");
                return;
            }
            p.MA_PBH = txt_macthd.Text;
            p.NGAYTAO_PBH = Convert.ToDateTime(ed_nglap.Text);
            p.GHICHU = null;
            p.THOIGIAN_BH = txt_tg.Text;
            ql.PHIEUBAOHANHs.InsertOnSubmit(p);
            ql.SubmitChanges();
            //this.banHangTableAdapter.Fill_bh(this.fPT_SHOPDataSet.BanHang, txt_mahd.Text);
            frm_banHang_Load(sender, e);
            MessageBox.Show("Thành công");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

            var kt = (from bb in ql.CT_HOADONs
                      from ct in ql.PHIEUBAOHANHs
                      where bb.MA_CTHD == ct.MA_PBH && bb.MA_CTHD == banHangDataGridView.CurrentRow.Cells[0].Value.ToString()
                      select bb).Count();
            if (kt == 0)
            {

                var thanhvien = ql.CT_HOADONs.SingleOrDefault(tv => tv.MA_CTHD == banHangDataGridView.CurrentRow.Cells[0].Value.ToString());
                ql.CT_HOADONs.DeleteOnSubmit(thanhvien);
                ql.SubmitChanges();
                this.banHangTableAdapter.Fill_bh(this.fPT_SHOPDataSet.BanHang, txt_mahd.Text);
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("không thể xóa");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {

                var thanhvien = ql.CT_HOADONs.SingleOrDefault(tv => tv.MA_CTHD == banHangDataGridView.CurrentRow.Cells[0].Value.ToString());
                thanhvien.MASP = banHangDataGridView.CurrentRow.Cells[2].Value.ToString();
                thanhvien.DONGIAHANG = Convert.ToDecimal(banHangDataGridView.CurrentRow.Cells[4].Value.ToString());
                ql.SubmitChanges();
                this.banHangTableAdapter.Fill_bh(this.fPT_SHOPDataSet.BanHang, txt_mahd.Text);
                MessageBox.Show("Thành công");
            }
            catch
            {
                MessageBox.Show("thất bại");
            }
        }

        private void txtsdt_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtsdt_Validating(object sender, CancelEventArgs e)
        {
            if ((txtsdt.Text.Length)!=10)
            {
                //e.Cancel = true;
                //txtsdt.Focus();
                errorProvider1.SetError(txtsdt, "Phai nhap 10 so");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtsdt, null);
            }
        }

        private void btn_chuyen_Click(object sender, EventArgs e)
        {
            frm_KhachHang kh = new frm_KhachHang();
            kh.Show();
        }

      
       

        private void fill_bhToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.banHangTableAdapter.Fill_bh(this.fPT_SHOPDataSet.BanHang, hoaDon1DataGridView.CurrentRow.Cells[0].Value.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }


        }

        private void hoaDon1DataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(hoaDon1DataGridView.CurrentRow.Cells[0].Value.ToString()!=null)
            {
                try
                {
                    this.banHangTableAdapter.Fill_bh(this.fPT_SHOPDataSet.BanHang, hoaDon1DataGridView.CurrentRow.Cells[0].Value.ToString());
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }

        private void hoaDon1DataGridView_CellMouseClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void hoaDon1DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)// stt cột trong datagirdview
            {
                //kiểm tra có khóa ngoại
                var kt = (from hd in ql.HOADONs
                          from ct in ql.CT_HOADONs
                          where hd.MAHD == ct.MAHD && hd.MAHD == hoaDon1DataGridView.CurrentRow.Cells[0].Value.ToString()
                          select hd).Count();
                if (kt == 0)
                {
                    var thanhvien = ql.HOADONs.SingleOrDefault(tv => tv.MAHD == hoaDon1DataGridView.CurrentRow.Cells[0].Value.ToString());
                    ql.HOADONs.DeleteOnSubmit(thanhvien);

                    ql.SubmitChanges();
                    this.hoaDon1TableAdapter.Fill(this.fPT_SHOPDataSet.HoaDon1);
                    txt_mahd.Text = ql.SINHMA_HOADON();
                    MessageBox.Show("thành công");

                }
                else
                {
                    MessageBox.Show("không thể xóa");
                }

            }
            //sửa
            if (e.ColumnIndex == 9)
            {
                var thanhvien = ql.HOADONs.SingleOrDefault(tv => tv.MAHD == hoaDon1DataGridView.CurrentRow.Cells[0].Value.ToString());
                thanhvien.MANV = hoaDon1DataGridView.CurrentRow.Cells[1].Value.ToString();
                thanhvien.MAKH =hoaDon1DataGridView.CurrentRow.Cells[2].Value.ToString();
                ql.SubmitChanges();
                this.hoaDon1TableAdapter.Fill(this.fPT_SHOPDataSet.HoaDon1);
                MessageBox.Show("thành công");
            }
        }

        private void txt_tg_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tg.Text))
            {
                e.Cancel = true;
                txt_tg.Focus();
                errorProvider1.SetError(txt_tg, "Không được để trống !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_tg, null);
            }
        }

        private void btn_chuyen_Click_1(object sender, EventArgs e)
        {
            frm_ThemTTKH t = new frm_ThemTTKH (this);
            //t.Message = txtMahd.Text.ToString();
            //t.Show();
            t.UpdateEventHandler += F2_UpdateEventHandler;
            t.ShowDialog();
        }
        private void F2_UpdateEventHandler(object sender, frm_ThemTTKH.UpdateEventArgs args)
        {
            frm_banHang_Load(sender, e);
        }


        public EventArgs e { get; set; }
    }
}
