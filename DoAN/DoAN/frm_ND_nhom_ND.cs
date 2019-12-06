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
    public partial class frm_ND_nhom_ND : UserControl
    {
        public frm_ND_nhom_ND()
        {
            InitializeComponent();
        }

        private void qL_NGUOIDUNGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qL_NGUOIDUNGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fPT_SHOPDataSet);

        }

        private void frm_ND_nhom_ND_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fPT_SHOPDataSet.QL_NHOMND' table. You can move, or remove it, as needed.
            this.qL_NHOMNDTableAdapter.Fill(this.fPT_SHOPDataSet.QL_NHOMND);
            // TODO: This line of code loads data into the 'fPT_SHOPDataSet.QL_NGUOIDUNG' table. You can move, or remove it, as needed.
            this.qL_NGUOIDUNGTableAdapter.Fill(this.fPT_SHOPDataSet.QL_NGUOIDUNG);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
          
        }

        private void cbo_tennhom_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.themNDVaoNhomTableAdapter.Fill(this.fPT_SHOPDataSet.ThemNDVaoNhom, cbo_tennhom.SelectedValue.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        QL_FPT_SHOPDataContext ql = new QL_FPT_SHOPDataContext();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String s = qL_NGUOIDUNGDataGridView.CurrentRow.Cells[0].Value.ToString();
                String v = cbo_tennhom.SelectedValue.ToString();
                var kt = from pqu in ql.QLND_NHOMNDs
                         where pqu.TENDN == v && pqu.MANHOM == s select pqu;
                if (kt.Count() > 0)
                {
                    MessageBox.Show("trùng ");
                    return;
                }
                QLND_NHOMND pq = new QLND_NHOMND();
                pq.TENDN = s;
                pq.MANHOM = v;
                ql.QLND_NHOMNDs.InsertOnSubmit(pq);
                ql.SubmitChanges();
                this.themNDVaoNhomTableAdapter.Fill(this.fPT_SHOPDataSet.ThemNDVaoNhom, cbo_tennhom.SelectedValue.ToString());
                MessageBox.Show("Thành công");

            }
            catch
            {
                MessageBox.Show("thất bại");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String s = themNDVaoNhomDataGridView.CurrentRow.Cells[0].Value.ToString();
            String mnhom = cbo_tennhom.SelectedValue.ToString();
            var thanhvien = ql.QLND_NHOMNDs.SingleOrDefault(tv => tv.TENDN == s && tv.MANHOM == mnhom);
            ql.QLND_NHOMNDs.DeleteOnSubmit(thanhvien);
            ql.SubmitChanges();
            this.themNDVaoNhomTableAdapter.Fill(this.fPT_SHOPDataSet.ThemNDVaoNhom, cbo_tennhom.SelectedValue.ToString());
            MessageBox.Show("Thành công");
        }

        private void qL_NGUOIDUNGDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
