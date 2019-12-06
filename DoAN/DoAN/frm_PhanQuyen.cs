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
    public partial class frm_PhanQuyen : UserControl
    {
        public frm_PhanQuyen()
        {
            InitializeComponent();
        }

       

        
        private void frm_PhanQuyen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fPT_SHOPDataSet.QL_NHOMND' table. You can move, or remove it, as needed.
            this.qL_NHOMNDTableAdapter.Fill(this.fPT_SHOPDataSet.QL_NHOMND);
            // TODO: This line of code loads data into the 'fPT_SHOPDataSet.QL_NHOMND' table. You can move, or remove it, as needed.
            this.qL_NHOMNDTableAdapter.Fill(this.fPT_SHOPDataSet.QL_NHOMND);
          
            // TODO: This line of code loads data into the 'fPT_SHOPDataSet.DM_MANHINH' table. You can move, or remove it, as needed.
            this.dM_MANHINHTableAdapter.Fill(this.fPT_SHOPDataSet.DM_MANHINH);
            // TODO: This line of code loads data into the 'fPT_SHOPDataSet.QL_NGUOIDUNG' table. You can move, or remove it, as needed.
           
        }

        private void loaddl()
        {
            if (qL_NHOMNDComboBox.SelectedValue != null)
            {
                try
                {
                    this.phanQuyenNguoiDungTableAdapter.Fill(this.fPT_SHOPDataSet.PhanQuyenNguoiDung, qL_NHOMNDComboBox.SelectedValue.ToString());
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }

        private void qL_NGUOIDUNGComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           loaddl();
        }
        QL_FPT_SHOPDataContext ql = new QL_FPT_SHOPDataContext();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String s=dM_MANHINHDataGridView.CurrentRow.Cells[0].Value.ToString();
                String v=qL_NHOMNDComboBox.SelectedValue.ToString();
                var kt=from pqu in ql.QL_PHANQUYENs where pqu.MANHOM==v && pqu.MAMANHINH==s select pqu;
                if(kt.Count()>0)
                {
                    MessageBox.Show("trùng ");
                    return;
                }
               QL_PHANQUYEN pq = new QL_PHANQUYEN();
               pq.MAMANHINH =s ;
               pq.MANHOM = v;
               ql.QL_PHANQUYENs.InsertOnSubmit(pq);
               ql.SubmitChanges();
                loaddl();
                MessageBox.Show("Thành công");
                
            }
            catch
            {
                MessageBox.Show("thất bại");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String s = phanQuyenNguoiDungDataGridView.CurrentRow.Cells[0].Value.ToString();
            String mnhom = qL_NHOMNDComboBox.SelectedValue.ToString();
            var thanhvien = ql.QL_PHANQUYENs.SingleOrDefault(tv => tv.MAMANHINH == s && tv.MANHOM==mnhom);
            ql.QL_PHANQUYENs.DeleteOnSubmit(thanhvien);
            ql.SubmitChanges();
            
            loaddl();
            MessageBox.Show("Thành công");
        }

     

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void qL_NHOMNDComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //loaddl();
        }

        private void qL_NHOMNDComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            loaddl();
        }
    }
}
