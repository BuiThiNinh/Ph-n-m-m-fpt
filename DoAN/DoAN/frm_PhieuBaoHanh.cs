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
    public partial class frm_PhieuBaoHanh : UserControl
    {
        public frm_PhieuBaoHanh()
        {
            InitializeComponent();
        }

        private void pHIEUBAOHANHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pHIEUBAOHANHBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fPT_SHOPDataSet);

        }
        QL_FPT_SHOPDataContext ql = new QL_FPT_SHOPDataContext();
        private void frm_PhieuBaoHanh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fPT_SHOPDataSet.BaoHanh' table. You can move, or remove it, as needed.
            this.baoHanhTableAdapter.Fill(this.fPT_SHOPDataSet.BaoHanh);
            // TODO: This line of code loads data into the 'fPT_SHOPDataSet.BaoHanh' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'fPT_SHOPDataSet.PHIEUBAOHANH' table. You can move, or remove it, as needed.
            this.pHIEUBAOHANHTableAdapter.Fill(this.fPT_SHOPDataSet.PHIEUBAOHANH);
           // txt_mapbh.Text = ql.SINHMA_PBH();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            ////kiểm tra rỗng
            //if (txt_mapbh.Text == "" || txt_cthd.Text == "" || txt_tgbh.Text == ""||txt_solanbh.Text=="")
            //{
            //    MessageBox.Show("Không được để trống");
            //    return;
            //}
            ////kiểm tra trùng
            //PHIEUBAOHANH bb = new PHIEUBAOHANH();
            //var kt = from s in ql.PHIEUBAOHANHs where s.MA_PBH == txt_mapbh.Text select s;
            //if (kt.Count() > 0)
            //{
            //    MessageBox.Show("Trùng khóa chính");
            //    return;
            //}
            //bb.MA_PBH = txt_mapbh.Text;
            //bb.MA_CTHD = txt_cthd.Text;
            //bb.NGAYTAO_PBH=Convert.ToDateTime(edngaylap.Text);
            //bb.THOIGIAN_BH = txt_tgbh.Text;
            //bb.SOLAN_BH = Convert.ToInt32(txt_solanbh.Text);
            //bb.GHICHU = txt_ghichu.Text;
            //ql.PHIEUBAOHANHs.InsertOnSubmit(bb);
            //ql.SubmitChanges();
            //frm_PhieuBaoHanh_Load(sender, e);
            //MessageBox.Show("Thành công");
            //txt_ghichu.Text = txt_solanbh.Text = txt_tgbh.Text= txt_cthd.Text= "";
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txt_tk_TextChanged(object sender, EventArgs e)
        {
            baoHanhDataGridView.DataSource = ql.XEMTT_TTPBH(txt_tk.Text);
        }

        private void baoHanhDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_cthd.Text = baoHanhDataGridView.CurrentRow.Cells[0].Value.ToString();
            edngaylap.Text = baoHanhDataGridView.CurrentRow.Cells[1].Value.ToString();
            txt_tgbh.Text = baoHanhDataGridView.CurrentRow.Cells[2].Value.ToString();
            //txt_solanbh.Text = baoHanhDataGridView.CurrentRow.Cells[3].Value.ToString();
            //txt_ghichu.Text = baoHanhDataGridView.CurrentRow.Cells[4].Value.ToString();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                var thanhvien = ql.PHIEUBAOHANHs.SingleOrDefault(tv => tv.MA_PBH == baoHanhDataGridView.CurrentRow.Cells[0].Value.ToString());

                thanhvien.SOLAN_BH =Convert.ToInt32( txt_solanbh.Text);
                thanhvien.GHICHU = txt_ghichu.Text;
               
                ql.SubmitChanges();
                frm_PhieuBaoHanh_Load(sender, e);
                MessageBox.Show("Thành công");
               
            }
            catch
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var thanhvien = ql.PHIEUBAOHANHs.SingleOrDefault(tv => tv.MA_PBH == baoHanhDataGridView.CurrentRow.Cells[0].Value.ToString());
            ql.PHIEUBAOHANHs.DeleteOnSubmit(thanhvien);
            ql.SubmitChanges();
            frm_PhieuBaoHanh_Load(sender, e);
            MessageBox.Show("Thành công");
        }
    }
}
