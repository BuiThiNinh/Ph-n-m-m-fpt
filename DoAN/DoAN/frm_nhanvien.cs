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
    public partial class frm_nhanvien : UserControl
    {
        public frm_nhanvien()
        {
            InitializeComponent();
        }

        private void nHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHANVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fPT_SHOPDataSet);

        }
        
        private void frm_nhanvien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fPT_SHOPDataSet.CHUCVU' table. You can move, or remove it, as needed.
            this.cHUCVUTableAdapter.Fill(this.fPT_SHOPDataSet.CHUCVU);
            // TODO: This line of code loads data into the 'fPT_SHOPDataSet.DANHMUCBAOHANH' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'fPT_SHOPDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.fPT_SHOPDataSet.NHANVIEN);
            //FPT_SHOPDataSet ds=new FPT_SHOPDataSet();
            //databingking(ds.Tables["NHANVIEN"]);
            //pic_anhnv.SizeMode = PictureBoxSizeMode.StretchImage;
            
            txt_manv.Text = ql.SINHMA_NHANVIEN();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All Text File (*.jpg)|*.jpg";

            open.FilterIndex = 1;
            open.RestoreDirectory = true;
            if (open.ShowDialog() == DialogResult.OK)
            {

                
                pic_anhnv.ImageLocation = open.FileName;

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
        QL_FPT_SHOPDataContext ql = new QL_FPT_SHOPDataContext();

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if ( txt_diachi.Text == "" || txt_luong.Text == "" || txt_manv.Text == "" || txt_tennv.Text == "" ||
                txtphat.Text == "" || txtsdtnv.Text == "" || txtThuong.Text == "" || txttongluong.Text == "" )
            {
                MessageBox.Show("Không được để trống");
                return;
            }
            NHANVIEN nv = new NHANVIEN();
            var kt = from s in ql.NHANVIENs where s.MANV == txt_manv.Text select s;
            if (kt.Count() > 0)
            {
                MessageBox.Show("Trùng khóa chính");
                return;
            }
            byte[] b = convertImage(pic_anhnv.Image);
            nv.MANV = txt_manv.Text;
            nv.HOTENNV = txt_tennv.Text;
            nv.SDT_NV = txtsdtnv.Text;
            nv.MACHUCVU = cbo_cv.SelectedValue.ToString();
            if(ckb_nam.Checked==true)
            {
                nv.GIOITINH = ckb_nam.Text;
            }

            if (ckb_nu.Checked == true)
            {
                nv.GIOITINH = ckb_nu.Text;
            }
            nv.LUONG = Convert.ToDecimal(txt_luong.Text);
            nv.HINHANH = b;
            nv.TONGLUONGTHANG = 0;
            nv.THUONGDS = Convert.ToDecimal(txtThuong.Text);
            nv.PHAT = Convert.ToDecimal(txtphat.Text);
            nv.NGAYSINH = Convert.ToDateTime(edngaysinh.Text);
            nv.DIACHI_NV = txt_diachi.Text;
          
            ql.NHANVIENs.InsertOnSubmit(nv);
            ql.SubmitChanges();
            frm_nhanvien_Load(sender, e);
            MessageBox.Show("Thành công");
            txt_diachi.Text = txt_luong.Text = txt_tennv.Text =
                txtphat.Text = txtsdtnv.Text = txtThuong.Text = txttongluong.Text = "";

        }

        private void txtsdtnv_Validating(object sender, CancelEventArgs e)
        {
            if ((txtsdtnv.Text.Length) != 10)
            {
                //e.Cancel = true;
                //txtsdt.Focus();
                errorProvider1.SetError(txtsdtnv, "Phai nhap 10 so");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtsdtnv, null);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var kt = (from nv in ql.NHANVIENs
                      from ddh in ql.DONDATHANGNCCs
                      from pnh in ql.DONDATHANGNCCs
                      from hd in ql.HOADONs
                      from nd in ql.QL_NGUOIDUNGs
                      where nv.MANV==nd.TENDN || nv.MANV==hd.MAHD || nv.MANV == ddh.MANV  ||
                      nv.MANV == ddh.MANCC && nv.MANV == nHANVIENDataGridView.CurrentRow.Cells[0].Value.ToString()
                      select nv).Count();
            if (kt == 0)
            {
                var thanhvien = ql.NHANVIENs.SingleOrDefault(tv => tv.MANV == nHANVIENDataGridView.CurrentRow.Cells[0].Value.ToString());
                ql.NHANVIENs.DeleteOnSubmit(thanhvien);
                ql.SubmitChanges();
                frm_nhanvien_Load(sender, e);
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("không thể xóa");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var thanhvien = ql.NHANVIENs.SingleOrDefault(tv => tv.MANV == nHANVIENDataGridView.CurrentRow.Cells[0].Value.ToString());
            byte[] b = convertImage(pic_anhnv.Image);
                thanhvien.HOTENNV = txt_tennv.Text;
          
                thanhvien.SDT_NV = txtsdtnv.Text;
            thanhvien.MACHUCVU = cbo_cv.SelectedValue.ToString();
            if (ckb_nam.Checked == true)
            {
                thanhvien.GIOITINH = ckb_nam.Text;
            }

            if (ckb_nu.Checked == true)
            {
                thanhvien.GIOITINH = ckb_nu.Text;
            }
            thanhvien.LUONG = Convert.ToDecimal(txt_luong.Text);
            thanhvien.HINHANH = b;
            thanhvien.TONGLUONGTHANG = 0;
            thanhvien.THUONGDS = Convert.ToDecimal(txtThuong.Text);
            thanhvien.PHAT = Convert.ToDecimal(txtphat.Text);
            thanhvien.NGAYSINH = Convert.ToDateTime(edngaysinh.Text);
 
            thanhvien.DIACHI_NV = txt_diachi.Text;
            ql.SubmitChanges();
            frm_nhanvien_Load(sender, e);
            MessageBox.Show("Thành công");
            txt_diachi.Text = txt_luong.Text = txt_tennv.Text =
                txtphat.Text = txtsdtnv.Text = txtThuong.Text = txttongluong.Text = "";
        }

        private void nHANVIENDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
            txt_manv.Text = nHANVIENDataGridView.CurrentRow.Cells[0].Value.ToString();
            cbo_cv.Text = nHANVIENDataGridView.CurrentRow.Cells[1].Value.ToString();
            txt_tennv.Text=nHANVIENDataGridView.CurrentRow.Cells[2].Value.ToString();
            if (nHANVIENDataGridView.CurrentRow.Cells[3].Value.ToString() == "Nam")
            {
                ckb_nam.Text = nHANVIENDataGridView.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                ckb_nu.Text = nHANVIENDataGridView.CurrentRow.Cells[3].Value.ToString();
            }
            edngaysinh.Text = nHANVIENDataGridView.CurrentRow.Cells[4].Value.ToString();
            txtsdtnv.Text = nHANVIENDataGridView.CurrentRow.Cells[5].Value.ToString();
            txt_luong.Text = nHANVIENDataGridView.CurrentRow.Cells[7].Value.ToString();
            txtThuong.Text = nHANVIENDataGridView.CurrentRow.Cells[8].Value.ToString();
            txtphat.Text = nHANVIENDataGridView.CurrentRow.Cells[9].Value.ToString();
            txttongluong.Text = nHANVIENDataGridView.CurrentRow.Cells[10].Value.ToString();
            txt_diachi.Text = nHANVIENDataGridView.CurrentRow.Cells[11].Value.ToString();

            byte[] b = (byte[])nHANVIENDataGridView.CurrentRow.Cells[6].Value;
                pic_anhnv.Image = bytetoimage(b);
            }
            catch
            {
                MessageBox.Show("Không có ảnh");
            }
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nHANVIENDataGridView.DataSource = ql.XEMTT_NHANVIEN(textBox1.Text);
        }

        private void nHANVIENDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtsdtnv_Validating_1(object sender, CancelEventArgs e)
        {
            if ((txtsdtnv.Text.Length) != 10)
            {
                //e.Cancel = true;
                //txtsdt.Focus();
                errorProvider1.SetError(txtsdtnv, "Phai nhap 10 so");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtsdtnv, null);
            }
        }

        private void txt_luong_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txt_luong_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        //void databingking(DataTable pDT)
        //{
         
        //    txt_anhnv.DataBindings.Clear();



        //    txt_anhnv.DataBindings.Add("Text", pDT, "HINHANH");
        

        //}
        //private void button4_Click(object sender, EventArgs e)
        //{
        //            }
    }
}
