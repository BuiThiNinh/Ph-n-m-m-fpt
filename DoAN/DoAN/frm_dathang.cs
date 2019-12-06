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
    public partial class frm_dathang : UserControl
    {
        public frm_dathang()
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
        private void dONDATHANGNCCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dONDATHANGNCCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fPT_SHOPDataSet);

        }

        private void frm_nhaphang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fPT_SHOPDataSet.CT_PhieuDatHang' table. You can move, or remove it, as needed.
            //this.cT_PhieuDatHangTableAdapter.Fill_sd(this.fPT_SHOPDataSet.CT_PhieuDatHang, phieuDatHangDataGridView.CurrentRow.Cells[0].Value.ToString());
            // TODO: This line of code loads data into the 'fPT_SHOPDataSet.PhieuDatHang' table. You can move, or remove it, as needed.
            this.phieuDatHangTableAdapter.Fill(this.fPT_SHOPDataSet.PhieuDatHang);
            // TODO: This line of code loads data into the 'fPT_SHOPDataSet.CT_DONDATHANG' table. You can move, or remove it, as needed.
          //  this.cT_DONDATHANGTableAdapter.Fill(this.fPT_SHOPDataSet.CT_DONDATHANG);
            // TODO: This line of code loads data into the 'fPT_SHOPDataSet.DONDATHANGNCC' table. You can move, or remove it, as needed.
            this.dONDATHANGNCCTableAdapter.Fill(this.fPT_SHOPDataSet.DONDATHANGNCC);
            this.nHACUNGCAPTableAdapter.Fill(this.fPT_SHOPDataSet.NHACUNGCAP);

            txt_madathang.Text = ql.SINHMA_DDHNCC();
            txt_manv.Text = TenDN;
            txttennv.Text = Tennv;
            ed_ngaydathang.Text = DateTime.Now.ToShortDateString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_ThemCTDDH ctddh = new frm_ThemCTDDH(this);
            ctddh.Message = phieuDatHangDataGridView.CurrentRow.Cells[0].Value.ToString();
            ctddh.UpdateEventHandler += F2_UpdateEventHandler;
            ctddh.ShowDialog();
        }

        private void F2_UpdateEventHandler(object sender, frm_ThemCTDDH.UpdateEventArgs args)
        {
            this.cT_PhieuDatHangTableAdapter.Fill_sd(this.fPT_SHOPDataSet.CT_PhieuDatHang, phieuDatHangDataGridView.CurrentRow.Cells[0].Value.ToString());
        }

        QL_FPT_SHOPDataContext ql = new QL_FPT_SHOPDataContext();
        private void btn_Them_Click(object sender, EventArgs e)
        {
            //kiểm tra rỗng
            if (txt_madathang.Text == "" || txt_manv.Text == "" || cbo_mancc.Text == "" || ed_ngaydathang.Text == "" || txt_tongtien.Text == "")
            {
                MessageBox.Show("Không được để trống");
                return;
            }
            //kiểm tra trùng
            DONDATHANGNCC bb = new DONDATHANGNCC();
            var kt = from s in ql.CT_HOADONs where s.MA_CTHD == txt_madathang.Text select s;
            if (kt.Count() > 0)
            {
                MessageBox.Show("Trùng khóa chính");
                return;
            }
            bb.MADH = txt_madathang.Text;    
            bb.MANV = txt_manv.Text;
            bb.MANCC = cbo_mancc.SelectedValue.ToString();
            bb.NGAYDATHANG = Convert.ToDateTime(ed_ngaydathang.Text);
            if (radio_chuagiao.Checked == true)
            {
                bb.TINHTRANG = radio_chuagiao.Text;
            }
            else
            {
                bb.TINHTRANG = radio_chuagiao.Text;
            }
          
            bb.TIENTRATRUOC = Convert.ToDecimal(txt_tongtien.Text);
            ql.DONDATHANGNCCs.InsertOnSubmit(bb);
            ql.SubmitChanges();
            frm_nhaphang_Load(sender, e);

            MessageBox.Show("Thành công");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var kt = (from bb in ql.DONDATHANGNCCs
                      from ct in ql.CT_DONDATHANGs
                      from nh in ql.PHIEUNHAPHANGs
                      where bb.MADH == ct.MADH && bb.MADH == nh.MADH && bb.MADH == phieuDatHangDataGridView.CurrentRow.Cells[0].Value.ToString()
                      select bb).Count();
            if (kt == 0)
            {

                var thanhvien = ql.DONDATHANGNCCs.SingleOrDefault(tv => tv.MADH == phieuDatHangDataGridView.CurrentRow.Cells[0].Value.ToString());
                ql.DONDATHANGNCCs.DeleteOnSubmit(thanhvien);
                ql.SubmitChanges();
                frm_nhaphang_Load(sender, e);
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("không thể xóa");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var thanhvien = ql.DONDATHANGNCCs.SingleOrDefault(tv => tv.MADH == phieuDatHangDataGridView.CurrentRow.Cells[0].Value.ToString());

            if (txt_tongtien.Text != "")
            {
                if (radio_chuagiao.Checked == true)
                {
                    thanhvien.TINHTRANG = radio_chuagiao.Text;
                }
                else
                {
                    thanhvien.TINHTRANG = radio_dagiao.Text;
                }
                thanhvien.TIENTRATRUOC = Convert.ToDecimal(txt_tongtien.Text);
                thanhvien.MANCC = cbo_mancc.SelectedValue.ToString();

            }
            if (txt_tongtien.Text == null)
            {
                if (radio_chuagiao.Checked == true)
                {
                    thanhvien.TINHTRANG = radio_chuagiao.Text;
                }
                else
                {
                    thanhvien.TINHTRANG = radio_chuagiao.Text;
                }
                thanhvien.MANCC = cbo_mancc.SelectedValue.ToString();

            }

                ql.SubmitChanges();
                frm_nhaphang_Load(sender, e);
                MessageBox.Show("Thành công");
            
        }

        private void txt_manv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
            
                var kt = (from bb in ql.NHANVIENs

                          where bb.MANV == txt_manv.Text
                          select bb.HOTENNV).FirstOrDefault();
                txttennv.Text = kt.ToString();

              
            }
           
        }

        private void txt_mancc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var kt = (from bb in ql.NHACUNGCAPs

                          where bb.MANCC == cbo_mancc.Text
                          select bb.TENNCC).FirstOrDefault();
                txt_tongtien.Text = kt.ToString();
            }
        }

        

        private void cT_PhieuDatHangDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)// stt cột trong datagirdview
            {
                    var thanhvien = ql.CT_DONDATHANGs.SingleOrDefault(tv => tv.MA_CTDDH == cT_PhieuDatHangDataGridView.CurrentRow.Cells[0].Value.ToString());
                    ql.CT_DONDATHANGs.DeleteOnSubmit(thanhvien);
                    ql.SubmitChanges();
                    this.cT_PhieuDatHangTableAdapter.Fill_sd(this.fPT_SHOPDataSet.CT_PhieuDatHang, phieuDatHangDataGridView.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show("Thành công");
                
            }

                //sửa
                if (e.ColumnIndex == 6)
                {
                    var thanhvien = ql.CT_DONDATHANGs.SingleOrDefault(tv => tv.MA_CTDDH == cT_PhieuDatHangDataGridView.CurrentRow.Cells[0].Value.ToString());
                    thanhvien.MADH = cT_PhieuDatHangDataGridView.CurrentRow.Cells[3].Value.ToString();
                    thanhvien.MASP = cT_PhieuDatHangDataGridView.CurrentRow.Cells[1].Value.ToString();
                    thanhvien.SOLUONGDAT = Convert.ToInt32(cT_PhieuDatHangDataGridView.CurrentRow.Cells[4].Value.ToString());
                    ql.SubmitChanges();
                    this.cT_PhieuDatHangTableAdapter.Fill_sd(this.fPT_SHOPDataSet.CT_PhieuDatHang, phieuDatHangDataGridView.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show("Thành công");
                }


            
        }

        private void phieuDatHangDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (phieuDatHangDataGridView.CurrentRow.Cells[0].Value.ToString() != "")
            {
                try
                {
                    this.cT_PhieuDatHangTableAdapter.Fill_sd(this.fPT_SHOPDataSet.CT_PhieuDatHang, phieuDatHangDataGridView.CurrentRow.Cells[0].Value.ToString());
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           phieuDatHangDataGridView.DataSource = ql.XEMTT_DDH(textBox1.Text);
        }

        private void fill_sdToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cT_PhieuDatHangTableAdapter.Fill_sd(this.fPT_SHOPDataSet.CT_PhieuDatHang, phieuDatHangDataGridView.CurrentRow.Cells[0].Value.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

    }
}
