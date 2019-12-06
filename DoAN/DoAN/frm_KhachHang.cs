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
    public partial class frm_KhachHang : UserControl
    {
        public frm_KhachHang()
        {
            InitializeComponent();
        }

        private void kHACHHANGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHACHHANGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fPT_SHOPDataSet);

        }

        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fPT_SHOPDataSet.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.fPT_SHOPDataSet.KHACHHANG);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_ThemTTKH t = new frm_ThemTTKH(this);
            //t.Message = txtMahd.Text.ToString();
            //t.Show();
            t.UpdateEventHandler += F2_UpdateEventHandler;
            t.ShowDialog();
        }

        private void F2_UpdateEventHandler(object sender, frm_ThemTTKH.UpdateEventArgs args)
        {
            this.kHACHHANGTableAdapter.Fill(this.fPT_SHOPDataSet.KHACHHANG);
        }
        QL_FPT_SHOPDataContext ql = new QL_FPT_SHOPDataContext();
        private void button2_Click(object sender, EventArgs e)
        {

            var thanhvien =ql.KHACHHANGs.SingleOrDefault(tv => tv.MAKH == kHACHHANGDataGridView.CurrentRow.Cells[0].Value.ToString());
            thanhvien.TENKH = kHACHHANGDataGridView.CurrentRow.Cells[1].Value.ToString();
            thanhvien.SDT_KH = kHACHHANGDataGridView.CurrentRow.Cells[2].Value.ToString();
            thanhvien.DIACHI_KH = kHACHHANGDataGridView.CurrentRow.Cells[3].Value.ToString();
            ql.SubmitChanges();
            frm_KhachHang_Load(sender, e);
            MessageBox.Show("Thành công");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            kHACHHANGDataGridView.DataSource = ql.XEMTT_KHACHHANG(textBox1.Text);
        }
    }
}
