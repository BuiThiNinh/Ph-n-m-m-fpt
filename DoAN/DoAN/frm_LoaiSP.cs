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
    public partial class frm_LoaiSP : UserControl
    {
        public frm_LoaiSP()
        {
            InitializeComponent();
        }

        private void dANHMUCSANPHAMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dANHMUCSANPHAMBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fPT_SHOPDataSet);

        }

        private void frm_LoaiSP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fPT_SHOPDataSet.LOAISANPHAM' table. You can move, or remove it, as needed.
            this.loaispTableAdapter.Fill(this.fPT_SHOPDataSet.Loaisp);
            // TODO: This line of code loads data into the 'fPT_SHOPDataSet.DANHMUCSANPHAM' table. You can move, or remove it, as needed.
            this.dANHMUCSANPHAMTableAdapter.Fill(this.fPT_SHOPDataSet.DANHMUCSANPHAM);
            txt_maloai.Text = ql.SINHMA_LOAISP();
        }
        QL_FPT_SHOPDataContext ql = new QL_FPT_SHOPDataContext();
        private void txt_tk_TextChanged(object sender, EventArgs e)
        {
            loaispDataGridView.DataSource = ql.XEMTT_LOAISP(txt_tk.Text);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_maloai.Text == "" || txt_tenloai.Text == "" || cmb_tendm.Text == "")
            {
                MessageBox.Show("Không được để trống");
                return;
            }
            //kiểm tra trùng
            LOAISANPHAM lsp = new LOAISANPHAM();
            var kt = from s in ql.LOAISANPHAMs where s.MALOAI == txt_maloai.Text select s;
            if (kt.Count() > 0)
            {
                MessageBox.Show("Trùng khóa chính");
                return;
            }
            lsp.MALOAI = txt_maloai.Text;
            lsp.TENLOAI = txt_tenloai.Text;
            lsp.MADM = cmb_tendm.SelectedValue.ToString();
            ql.LOAISANPHAMs.InsertOnSubmit(lsp);
            ql.SubmitChanges();
            frm_LoaiSP_Load(sender, e);
            MessageBox.Show("Thành công");
            txt_tenloai.Text = "";
            cmb_tendm.Text = string.Empty;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                var ktkn = from l in ql.LOAISANPHAMs
                           from dm in ql.SANPHAMs
                           where l.MALOAI == dm.MALOAI && dm.MALOAI == loaispDataGridView.CurrentRow.Cells[0].Value.ToString()
                           select dm;
                if(ktkn.Count()>0)
                {
                    MessageBox.Show("không thể xóa");
                    return;
                }
                var thanhvien = ql.LOAISANPHAMs.SingleOrDefault(t => t.MALOAI == loaispDataGridView.CurrentRow.Cells[0].Value.ToString());
                ql.LOAISANPHAMs.DeleteOnSubmit(thanhvien);
                ql.SubmitChanges();
                frm_LoaiSP_Load(sender, e);
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                var thanhvien = ql.LOAISANPHAMs.SingleOrDefault(t => t.MALOAI == loaispDataGridView.CurrentRow.Cells[0].Value.ToString());
                if (txt_tenloai.Text != "")
                {
                    thanhvien.TENLOAI = txt_tenloai.Text;
                    thanhvien.MADM = cmb_tendm.SelectedValue.ToString();
                }
                else
                {
                    thanhvien.MADM = cmb_tendm.SelectedValue.ToString();
                }
                ql.SubmitChanges();
                this.loaispTableAdapter.Fill(this.fPT_SHOPDataSet.Loaisp);
                MessageBox.Show("Thành công");
                txt_tenloai.Text = "";
            }
            catch
            {
                MessageBox.Show("Thất bại");
            }
        }
    }
}
