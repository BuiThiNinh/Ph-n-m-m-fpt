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
    public partial class frm_NCC : UserControl
    {
        public frm_NCC()
        {
            InitializeComponent();
        }
        QL_FPT_SHOPDataContext ql = new QL_FPT_SHOPDataContext();
        private void frm_NCC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fPT_SHOPDataSet.NHACUNGCAP' table. You can move, or remove it, as needed.
            this.nHACUNGCAPTableAdapter.Fill(this.fPT_SHOPDataSet.NHACUNGCAP);
            // TODO: This line of code loads data into the 'fPT_SHOPDataSet.NCC' table. You can move, or remove it, as needed.
           
            txt_mancc.Text = ql.SINHMA_NHACC();
        }

        private void txt_ChiNhapSo1_Validating(object sender, CancelEventArgs e)
        {
            if ((txt_sdt.Text.Length) != 10)
            {
                //e.Cancel = true;
                //txtsdt.Focus();
                errorProvider1.SetError(txt_sdt, "Phai nhap 10 so");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_sdt, null);
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            //kiểm tra rỗng
            if (txt_mancc.Text == "" || txt_Tenncc.Text == "" || txt_sdt.Text == "" || txt_dc.Text == "")
            {
                MessageBox.Show("Không được để trống");
                return;
            }
            //kiểm tra trùng
            NHACUNGCAP bb = new NHACUNGCAP();
            var kt = from s in ql.CT_HOADONs where s.MA_CTHD == txt_mancc.Text select s;
            if (kt.Count() > 0)
            {
                MessageBox.Show("Trùng khóa chính");
                return;
            }
            bb.MANCC = txt_mancc.Text;
            bb.TENNCC = txt_Tenncc.Text;
            bb.SDT_NCC = txt_sdt.Text;
            bb.DIACHI_NCC = txt_dc.Text;
            ql.NHACUNGCAPs.InsertOnSubmit(bb);
            ql.SubmitChanges();
            frm_NCC_Load(sender, e);
            MessageBox.Show("Thành công");
            txt_Tenncc.Text = txt_sdt.Text = txt_dc.Text = "";
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var kt = (from bb in ql.NHACUNGCAPs
                      from ct in ql.SANPHAMs
                      from ddh in ql.DONDATHANGNCCs
                      where bb.MANCC == ct.MANCC && bb.MANCC == nHACUNGCAPDataGridView.CurrentRow.Cells[0].Value.ToString() || bb.MANCC == ddh.MANCC && bb.MANCC == nHACUNGCAPDataGridView.CurrentRow.Cells[0].Value.ToString()
                      select bb).Count();
            if (kt == 0)
            {
                var thanhvien = ql.NHACUNGCAPs.SingleOrDefault(tv => tv.MANCC == nHACUNGCAPDataGridView.CurrentRow.Cells[0].Value.ToString());
                ql.NHACUNGCAPs.DeleteOnSubmit(thanhvien);
                ql.SubmitChanges();
                frm_NCC_Load(sender, e);
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
                var thanhvien = ql.NHACUNGCAPs.SingleOrDefault(tv => tv.MANCC == nHACUNGCAPDataGridView.CurrentRow.Cells[0].Value.ToString());

                thanhvien.TENNCC = txt_Tenncc.Text;
                thanhvien.DIACHI_NCC = txt_dc.Text;
                thanhvien.SDT_NCC = txt_sdt.Text;
                ql.SubmitChanges();
                frm_NCC_Load(sender, e);
                MessageBox.Show("Thành công");
                txt_Tenncc.Text = txt_sdt.Text = txt_dc.Text = "";
            }
            catch
            {
                MessageBox.Show("Thất bại");
            }

        }

        private void nHACUNGCAPDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_mancc.Text = nHACUNGCAPDataGridView.CurrentRow.Cells[0].Value.ToString();
            txt_sdt.Text = nHACUNGCAPDataGridView.CurrentRow.Cells[3].Value.ToString();
            txt_Tenncc.Text = nHACUNGCAPDataGridView.CurrentRow.Cells[1].Value.ToString();
            txt_dc.Text = nHACUNGCAPDataGridView.CurrentRow.Cells[2].Value.ToString();
        }

        private void txt_tk_TextChanged(object sender, EventArgs e)
        {
            nHACUNGCAPDataGridView.DataSource = ql.XEMTT_TTNCC(txt_tk.Text);
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_mancc.Text = txt_sdt.Text = txt_dc.Text = txt_Tenncc.Text = string.Empty;
            frm_NCC_Load(sender, e);

        }
    }
}
