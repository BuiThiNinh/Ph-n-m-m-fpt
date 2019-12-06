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
    public partial class frm_tknv : UserControl
    {
        public frm_tknv()
        {
            InitializeComponent();
        }

        private void qL_NGUOIDUNGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qL_NGUOIDUNGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fPT_SHOPDataSet);

        }

        private void frm_tknv_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fPT_SHOPDataSet.QL_NGUOIDUNG' table. You can move, or remove it, as needed.
            this.qL_NGUOIDUNGTableAdapter.Fill(this.fPT_SHOPDataSet.QL_NGUOIDUNG);

        }
        QL_FPT_SHOPDataContext ql = new QL_FPT_SHOPDataContext();
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var thanhvien = ql.QL_NGUOIDUNGs.SingleOrDefault(tv => tv.TENDN == qL_NGUOIDUNGDataGridView.CurrentRow.Cells[0].Value.ToString());
            ql.QL_NGUOIDUNGs.DeleteOnSubmit(thanhvien);
            ql.SubmitChanges();
            frm_tknv_Load(sender, e);
            MessageBox.Show("Thành công");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                var thanhvien = ql.QL_NGUOIDUNGs.SingleOrDefault(tv => tv.TENDN == qL_NGUOIDUNGDataGridView.CurrentRow.Cells[0].Value.ToString());
                thanhvien.MATKHAU = qL_NGUOIDUNGDataGridView.CurrentRow.Cells[1].Value.ToString();
                //if (hOATDONGCheckEdit.Checked = true)
                //{
                //    thanhvien.HOATDONG = Convert.ToBoolean(hOATDONGCheckEdit.Text);
                //}

                ql.SubmitChanges();
                frm_tknv_Load(sender, e);
                MessageBox.Show("Thành công");
            }
            catch
            {
                MessageBox.Show("lỗi+");
            }
        }
    }
}
