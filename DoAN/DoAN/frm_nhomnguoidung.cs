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
    public partial class frm_nhomnguoidung : UserControl
    {
        public frm_nhomnguoidung()
        {
            InitializeComponent();
        }

        private void qL_NHOMNDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qL_NHOMNDBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fPT_SHOPDataSet);

        }

        private void frm_nd_nhom_nd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fPT_SHOPDataSet.QL_NHOMND' table. You can move, or remove it, as needed.
            this.qL_NHOMNDTableAdapter.Fill(this.fPT_SHOPDataSet.QL_NHOMND);
           

        }
        QL_FPT_SHOPDataContext ql = new QL_FPT_SHOPDataContext();
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_manhom.Text == "" || txt_tennhomnd.Text == "")
            {
                MessageBox.Show("Không được để trống");
                return;
            }
            //kiểm tra trùng
            QL_NHOMND nnd = new QL_NHOMND();
            var kt = from s in ql.QL_NHOMNDs where s.MANHOM == txt_manhom.Text select s;
            if (kt.Count() > 0)
            {
                MessageBox.Show("Trùng khóa chính");
                return;
            }
            nnd.MANHOM = txt_manhom.Text;
            nnd.TENNHOMND = txt_tennhomnd.Text;
            nnd.GHICHU = txt_ghichu.Text;
            ql.QL_NHOMNDs.InsertOnSubmit(nnd);
            ql.SubmitChanges();
            frm_nd_nhom_nd_Load(sender, e);
            MessageBox.Show("Thành công");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                var ktkn = from l in ql.QL_NHOMNDs
                           from dm in ql.QLND_NHOMNDs
                           from pq in ql.QL_PHANQUYENs
                           where l.MANHOM == dm.MANHOM && dm.MANHOM == qL_NHOMNDDataGridView.CurrentRow.Cells[0].Value.ToString()
                           || l.MANHOM == pq.MANHOM && dm.MANHOM == qL_NHOMNDDataGridView.CurrentRow.Cells[0].Value.ToString()
                           select dm;
                if (ktkn.Count() > 0)
                {
                    MessageBox.Show("không thể xóa");
                    return;
                }
                var thanhvien = ql.QL_NHOMNDs.SingleOrDefault(t => t.MANHOM == qL_NHOMNDDataGridView.CurrentRow.Cells[0].Value.ToString());
                ql.QL_NHOMNDs.DeleteOnSubmit(thanhvien);
                ql.SubmitChanges();
                frm_nd_nhom_nd_Load(sender, e);
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
                var thanhvien = ql.QL_NHOMNDs.SingleOrDefault(t => t.MANHOM == qL_NHOMNDDataGridView.CurrentRow.Cells[0].Value.ToString());
                if (txt_tennhomnd.Text != "" && txt_ghichu.Text != "")
                {

                    thanhvien.TENNHOMND = txt_tennhomnd.Text;
                    thanhvien.GHICHU = txt_ghichu.Text;
                }
                else
                {
                    if (txt_tennhomnd.Text != "" && txt_ghichu.Text == "")
                    {
                        thanhvien.TENNHOMND = txt_tennhomnd.Text;

                    }
                    else
                    {
                        thanhvien.GHICHU = txt_ghichu.Text;
                    }
                }
                ql.SubmitChanges();
                frm_nd_nhom_nd_Load(sender, e);
                MessageBox.Show("Thành công");

            }
            catch
            {
                MessageBox.Show("Thất bại");
            }
        }
    }
}
