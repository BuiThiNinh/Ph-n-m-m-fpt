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
    public partial class frm_khuyenmai : UserControl
    {
        public frm_khuyenmai()
        {
            InitializeComponent();
        }

        private void kHUYENMAIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHUYENMAIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fPT_SHOPDataSet);

        }
        QL_FPT_SHOPDataContext ql = new QL_FPT_SHOPDataContext();
        private void frm_khuyenmai_Load(object sender, EventArgs e)
        {
            this.lOAISANPHAMTableAdapter.Fill(this.fPT_SHOPDataSet.LOAISANPHAM);
            // TODO: This line of code loads data into the 'fPT_SHOPDataSet.KHUYENMAI' table. You can move, or remove it, as needed.
            this.kHUYENMAITableAdapter.Fill(this.fPT_SHOPDataSet.KHUYENMAI);
            txtMaKM.Text = ql.SINHMA_KHUYENMAI();
            //cbo_tensp.DataSource = loaddlLoai();
            //cbo_tensp.DisplayMember="TENLOAI";
            //cbo_tensp.ValueMember = "MALOAI";
            cbo_tensp.DataSource = loaddlsp();
            cbo_tensp.DisplayMember = "TENSP";
            cbo_tensp.ValueMember = "MASP";


        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.cT_KHUYENMAI1TableAdapter.Fill(this.fPT_SHOPDataSet.CT_KHUYENMAI1, mAKHUYENMAIToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }
        private void load()
        {
            if (kHUYENMAIDataGridView.CurrentRow.Cells[0].Value.ToString() != null)
            {
                try
                {
                    this.cT_KHUYENMAI1TableAdapter.Fill(this.fPT_SHOPDataSet.CT_KHUYENMAI1, kHUYENMAIDataGridView.CurrentRow.Cells[0].Value.ToString());
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }

        private void kHUYENMAIDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //var kt = from k in ql.KHUYENMAIs
            //         from ct in ql.CT_KHUYENMAIs
            //         where k.MAKHUYENMAI == ct.MAKHUYENMAI && k.MAKHUYENMAI == cT_KHUYENMAIDataGridView.CurrentRow.Cells[0].Value.ToString()
            //         select ct;

            load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMaKM.Text == "" || txt_TenKm.Text == "" || edtngaybd.Text == "" || editnkt.Text == "" ||
                cbo_tensp.Text == "" || txtnoidung.Text == "" || txtphamtram.Text == "")
            {
                 MessageBox.Show("Không được để trống");
                    return;
            }
                var ktkc = from km in ql.KHUYENMAIs where km.MAKHUYENMAI == txtMaKM.Text select km;
                if (ktkc.Count() > 0)
                {
                    MessageBox.Show(" trùng khóa chính");
                    return;
                }
                var ktk = from ct in ql.CT_KHUYENMAIs
                          where ct.MAKHUYENMAI == txtMaKM.Text
                               && ct.MASP == cbo_tensp.SelectedValue.ToString()
                           select ct;
                if (ktk.Count() > 0)
                {
                    MessageBox.Show("trùng khóa chính bảng CT_ Khuyến mãi");
                    return;
                }
               
                KHUYENMAI k = new KHUYENMAI();
                CT_KHUYENMAI ctkm = new CT_KHUYENMAI();
                k.MAKHUYENMAI = txtMaKM.Text;
                k.TENKHUYENMAI = txt_TenKm.Text;
                k.NGAYBD = Convert.ToDateTime(edtngaybd.Text);
                k.NGAYKT = Convert.ToDateTime(editnkt.Text);
                ctkm.MAKHUYENMAI = txtMaKM.Text;
                ctkm.MASP = cbo_tensp.SelectedValue.ToString();
                ctkm.PHANTRAM = Convert.ToDouble(txtphamtram.Text);
                ctkm.NOIDUNGKM = txtnoidung.Text;
                ql.CT_KHUYENMAIs.InsertOnSubmit(ctkm);
                ql.KHUYENMAIs.InsertOnSubmit(k);
                ql.SubmitChanges();
                this.kHUYENMAITableAdapter.Fill(this.fPT_SHOPDataSet.KHUYENMAI);
                MessageBox.Show("Thành công");
                btn_Them.Enabled = true;
            
        }

        private void kHUYENMAIDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)// stt cột trong datagirdview
            {
                //kiểm tra có khóa ngoại
                var kt = (from bb in ql.KHUYENMAIs
                          from ct in ql.CT_KHUYENMAIs
                          where bb.MAKHUYENMAI == ct.MAKHUYENMAI && bb.MAKHUYENMAI == kHUYENMAIDataGridView.CurrentRow.Cells[0].Value.ToString()
                          select bb).Count();
                if (kt == 0)
                {
                    var thanhvien = ql.KHUYENMAIs.SingleOrDefault(tv => tv.MAKHUYENMAI == kHUYENMAIDataGridView.CurrentRow.Cells[0].Value.ToString());
                    ql.KHUYENMAIs.DeleteOnSubmit(thanhvien);

                    ql.SubmitChanges();
                    frm_khuyenmai_Load(sender, e);
                    MessageBox.Show("thành công");

                }
                else
                {
                    MessageBox.Show("không thể xóa");
                }

            }
            //sửa
            if (e.ColumnIndex == 5)
            {
                var thanhvien = ql.KHUYENMAIs.SingleOrDefault(tv => tv.MAKHUYENMAI == kHUYENMAIDataGridView.CurrentRow.Cells[0].Value.ToString());
                thanhvien.TENKHUYENMAI = kHUYENMAIDataGridView.CurrentRow.Cells[1].Value.ToString();
                thanhvien.NGAYBD =Convert.ToDateTime( kHUYENMAIDataGridView.CurrentRow.Cells[2].Value.ToString());
                thanhvien.NGAYKT = Convert.ToDateTime(kHUYENMAIDataGridView.CurrentRow.Cells[3].Value.ToString());
                ql.SubmitChanges();
                this.kHUYENMAITableAdapter.Fill(this.fPT_SHOPDataSet.KHUYENMAI);
                MessageBox.Show("thành công");
            }
        }

       
        private void txt_TenKm_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TenKm.Text))
            {
                e.Cancel = true;
                txt_TenKm.Focus();
                errorProvider1.SetError(txt_TenKm, "không được để trống!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_TenKm, null);
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbo_tensp.Text))
            {
                e.Cancel = true;
                cbo_tensp.Focus();
                errorProvider2.SetError(cbo_tensp, "không được để trống!");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(cbo_tensp, null);
            }
        }

        private void txtnoidung_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtnoidung.Text))
            {
                e.Cancel = true;
                txtnoidung.Focus();
                errorProvider3.SetError(txtnoidung, "không được để trống!");
            }
            else
            {
                e.Cancel = false;
                errorProvider3.SetError(txtnoidung, null);
            }
        }

        private void txt_phantram_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtphamtram.Text))
            {
                e.Cancel = true;
                txtphamtram.Focus();
                errorProvider1.SetError(txtphamtram, "không được để trống!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtphamtram, null);
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (cbo_tensp.Text == "" || txtnoidung.Text == "" || txtphamtram.Text == "")
            {
                MessageBox.Show("Không được để trống");
                return;
            }
                var ktkc = from ct in ql.CT_KHUYENMAIs where ct.MAKHUYENMAI == kHUYENMAIDataGridView.CurrentRow.Cells[0].Value.ToString()
                          && ct.MASP == cbo_tensp.SelectedValue.ToString()
                           select ct;
                if (ktkc.Count() > 0)
                {
                    MessageBox.Show("trùng khóa chính");
                    return;
                }
                CT_KHUYENMAI k = new CT_KHUYENMAI();
                k.MAKHUYENMAI = kHUYENMAIDataGridView.CurrentRow.Cells[0].Value.ToString();
                k.MASP = cbo_tensp.SelectedValue.ToString();
                k.PHANTRAM = Convert.ToDouble(txtphamtram.Text);
                k.NOIDUNGKM = txtnoidung.Text;
                ql.CT_KHUYENMAIs.InsertOnSubmit(k);
                ql.SubmitChanges();
                frm_khuyenmai_Load(sender, e);
                MessageBox.Show("Thành công");
                btn_Them.Enabled = true;
            }

        private void cbo_tenloai_SelectedValueChanged(object sender, EventArgs e)
        {
            var kt = (from l in ql.LOAISANPHAMs
                      from sp in ql.SANPHAMs
                      where l.MALOAI == sp.MALOAI && l.MALOAI == cbo_tenloai.SelectedValue.ToString()
                      select sp.TENSP).ToList();
            cbo_tensp.DataSource = kt.ToList();

        }
        private List<LOAISANPHAM> loaddlLoai()
        {
            return ql.LOAISANPHAMs.Select(t => t).ToList<LOAISANPHAM>();
        }
        private List<SANPHAM> loaddlsp()
        {
            return ql.SANPHAMs.Select(t => t).ToList<SANPHAM>();
        }

        private void cbo_tenloai_MouseDown(object sender, MouseEventArgs e)
        {
            var kt = (from l in ql.LOAISANPHAMs
                      from sp in ql.SANPHAMs
                      where l.MALOAI == sp.MALOAI && l.MALOAI == cbo_tenloai.SelectedValue.ToString()
                      select sp.TENSP).ToList();
            cbo_tensp.DataSource = kt.ToList();
        }
        
        
     
    }
    

     
}
