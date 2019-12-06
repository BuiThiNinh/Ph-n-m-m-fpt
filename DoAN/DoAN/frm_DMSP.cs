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
    public partial class frm_DMSP : UserControl
    {
        public frm_DMSP()
        {
            InitializeComponent();
        }

        private void dANHMUCSANPHAMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dANHMUCSANPHAMBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fPT_SHOPDataSet);

        }

        private void frm_DMSP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fPT_SHOPDataSet.DANHMUCSANPHAM' table. You can move, or remove it, as needed.
            this.dANHMUCSANPHAMTableAdapter.Fill(this.fPT_SHOPDataSet.DANHMUCSANPHAM);
            txt_madm.Text = ql.SINHMA_DANHMUCSP();

        }
        QL_FPT_SHOPDataContext ql = new QL_FPT_SHOPDataContext();
        private void btn_Them_Click(object sender, EventArgs e)
        {
            //kiểm tra rỗng
            if (txt_madm.Text == "" || txt_tendm.Text == "")
            {
                MessageBox.Show("Không được để trống");
                return;
            }
            //kiểm tra trùng
            DANHMUCSANPHAM dm = new DANHMUCSANPHAM();
            var kt = from s in ql.DANHMUCSANPHAMs where s.MADM == txt_madm.Text select s;
            if (kt.Count() > 0)
            {
                MessageBox.Show("Trùng khóa chính");
                return;
            }
            dm.MADM = txt_madm.Text;
            dm.TENDM = txt_tendm.Text;
            ql.DANHMUCSANPHAMs.InsertOnSubmit(dm);
            ql.SubmitChanges();
            frm_DMSP_Load(sender, e);
            MessageBox.Show("Thành công");
            txt_tendm.Text = "";
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                var ktkn = from l in ql.LOAISANPHAMs
                           from dm in ql.DANHMUCSANPHAMs
                           where l.MADM == dm.MADM && dm.MADM == dANHMUCSANPHAMDataGridView.CurrentRow.Cells[0].Value.ToString()
                           select dm;
                if (ktkn.Count() > 0)
                {
                    MessageBox.Show("Không thể xóa");
                    return;
                }
                var thanhvien = ql.DANHMUCSANPHAMs.SingleOrDefault(t => t.MADM == dANHMUCSANPHAMDataGridView.CurrentRow.Cells[0].Value.ToString());
                ql.DANHMUCSANPHAMs.DeleteOnSubmit(thanhvien);
                ql.SubmitChanges();
                frm_DMSP_Load(sender, e);
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
                var thanhvien = ql.DANHMUCSANPHAMs.SingleOrDefault(t => t.MADM == dANHMUCSANPHAMDataGridView.CurrentRow.Cells[0].Value.ToString());
                thanhvien.TENDM = txt_tendm.Text;
                ql.SubmitChanges();
                frm_DMSP_Load(sender, e);
                MessageBox.Show("Thành công");
                txt_tendm.Text = "";
            }
            catch
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void txt_tendm_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tendm.Text))
            {
                e.Cancel = true;
                txt_tendm.Focus();
                errorProvider1.SetError(txt_tendm, "không được để trống!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_tendm, null);
            }
        }
    }
}
