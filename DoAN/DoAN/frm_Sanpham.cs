using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAN
{
    public partial class frm_Sanpham : UserControl
    {
        public frm_Sanpham()
        {
            InitializeComponent();
        }
        QL_FPT_SHOPDataContext ql = new QL_FPT_SHOPDataContext();
        private void txt_tk_TextChanged(object sender, EventArgs e)
        {
            sanpham_1DataGridView.DataSource = ql.XEMTT_TTsanPham(txt_tk.Text);
        }

        private void frm_Sanpham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fPT_SHOPDataSet.LOAISANPHAM' table. You can move, or remove it, as needed.
            this.lOAISANPHAMTableAdapter.Fill(this.fPT_SHOPDataSet.LOAISANPHAM);
            // TODO: This line of code loads data into the 'fPT_SHOPDataSet.NHACUNGCAP' table. You can move, or remove it, as needed.
            this.nHACUNGCAPTableAdapter.Fill(this.fPT_SHOPDataSet.NHACUNGCAP);
            // TODO: This line of code loads data into the 'fPT_SHOPDataSet.DANHMUCBAOHANH' table. You can move, or remove it, as needed.
            this.dANHMUCBAOHANHTableAdapter.Fill(this.fPT_SHOPDataSet.DANHMUCBAOHANH);
           this.sanpham_1TableAdapter.Fill_sp(this.fPT_SHOPDataSet.sanpham_1);
           txt_masp.Text = ql.SINHMA_SANPHAM();
        }

        private void btn_chonanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All Text File (*.jpg)|*.jpg";

            open.FilterIndex = 1;
            open.RestoreDirectory = true;
            if (open.ShowDialog() == DialogResult.OK)
            {

               
                pic_anhsp.ImageLocation = open.FileName;

            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_masp.Text == "" || txt_tensp.Text == "" || txt_mau.Text == "" || txt_soluong.Text == "" || cbo_tinhtrang.Text == "")
            {
                MessageBox.Show("Không được để trống");
                return;

            }
            var kt = (from s in ql.SANPHAMs
                      where s.TENSP == txt_tensp.Text && s.MAU == txt_mau.Text
                      select s).Count();
            if (kt > 0)
            {
                MessageBox.Show("Tên và màu sản phẩm không được phép trùng");
                return;
            }
            SANPHAM sp = new SANPHAM();
            var ktt = from s in ql.LOAISANPHAMs where s.MALOAI == txt_masp.Text select s;
            if (ktt.Count() > 0)
            {
                MessageBox.Show("Trùng khóa chính");
                return;
            }
            byte[] b = convertImage(pic_anhsp.Image);
            sp.MASP = txt_masp.Text;
            sp.TENSP = txt_tensp.Text;
            sp.MAU = txt_mau.Text;
            sp.SOLUONG = Convert.ToInt32(txt_soluong.Text.ToString());
            sp.TINHTRANG = cbo_tinhtrang.Text;
            sp.GHICHU = txt_ghichu.Text;
            sp.MALOAI = cbo_loaisp.SelectedValue.ToString();
            sp.MA_DMBH = cbo_dmbh.SelectedValue.ToString();
            sp.MANCC = cbo_nhacc.SelectedValue.ToString();
            sp.ANHSP = b;
            ql.SANPHAMs.InsertOnSubmit(sp);
            
            ql.SubmitChanges();
            this.sanpham_1TableAdapter.Fill_sp(this.fPT_SHOPDataSet.sanpham_1);
            MessageBox.Show("Thành công");
        

        }

     


        private void button1_Click(object sender, EventArgs e)
        {
            frm_Sanpham_Load(sender, e);

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                var ktx = (from s in ql.SANPHAMs
                           from ctkm in ql.CT_KHUYENMAIs
                           from cthd in ql.CT_HOADONs
                           from cttkbh in ql.CT_DONDATHANGs
                           from lsg in ql.LICHSUGIAs
                           where s.MASP == cthd.MASP && s.MASP == sanpham_1DataGridView.CurrentRow.Cells[0].Value.ToString()
                                || s.MASP == ctkm.MASP && s.MASP == sanpham_1DataGridView.CurrentRow.Cells[0].Value.ToString()
                                || s.MASP == cttkbh.MASP && s.MASP == sanpham_1DataGridView.CurrentRow.Cells[0].Value.ToString()
                                || s.MASP == lsg.MASP && s.MASP == sanpham_1DataGridView.CurrentRow.Cells[0].Value.ToString()
                           select s).Count();
                if (ktx > 0)
                {
                    MessageBox.Show("Không thể xóa");
                    return;
                }

                var thanhvien = ql.SANPHAMs.SingleOrDefault(t => t.MASP == sanpham_1DataGridView.CurrentRow.Cells[0].Value.ToString());
                ql.SANPHAMs.DeleteOnSubmit(thanhvien);
                ql.SubmitChanges();
                this.sanpham_1TableAdapter.Fill_sp(this.fPT_SHOPDataSet.sanpham_1);
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void sanpham_1DataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
            txt_masp.Text = sanpham_1DataGridView.CurrentRow.Cells[0].Value.ToString();
            txt_tensp.Text = sanpham_1DataGridView.CurrentRow.Cells[1].Value.ToString();
            txt_mau.Text = sanpham_1DataGridView.CurrentRow.Cells[2].Value.ToString();
            txt_soluong.Text = sanpham_1DataGridView.CurrentRow.Cells[3].Value.ToString();
            cbo_tinhtrang.Text = sanpham_1DataGridView.CurrentRow.Cells[4].Value.ToString();
            txt_ghichu.Text = sanpham_1DataGridView.CurrentRow.Cells[5].Value.ToString();
            cbo_dmbh.Text = sanpham_1DataGridView.CurrentRow.Cells[6].Value.ToString();
   //         pic_anhnv.Image = bytetoimage((sanpham_1DataGridView.CurrentRow.Cells[7].Value.ToString()));
            cbo_loaisp.Text = sanpham_1DataGridView.CurrentRow.Cells[11].Value.ToString();
            cbo_nhacc.Text = sanpham_1DataGridView.CurrentRow.Cells[9].Value.ToString();
           

                byte[] b = (byte[])sanpham_1DataGridView.CurrentRow.Cells[7].Value;
                pic_anhsp.Image = bytetoimage(b);
            }
            catch
            {
                MessageBox.Show("Không có ảnh");
            }

        }
  
        private byte[] convertImage(Image img)//chuyen image sang byte
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        private Image bytetoimage(byte[] b)//chuyen byte sang image
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] b = convertImage(pic_anhsp.Image);
                var thanhvien = ql.SANPHAMs.SingleOrDefault(t => t.MASP == sanpham_1DataGridView.CurrentRow.Cells[0].Value.ToString());
                thanhvien.TENSP = txt_tensp.Text;
                thanhvien.MAU = txt_mau.Text;
                thanhvien.SOLUONG = Convert.ToInt32(txt_soluong.Text.ToString());
                thanhvien.TINHTRANG = cbo_tinhtrang.Text;
                thanhvien.GHICHU = txt_ghichu.Text;
                thanhvien.ANHSP = b;
                ql.SubmitChanges();
                this.sanpham_1TableAdapter.Fill_sp(this.fPT_SHOPDataSet.sanpham_1);
                MessageBox.Show("Thành công");

            }
            catch
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void sanpham_1DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sanpham_1DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
}
