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
    public partial class frm_main : Form
    {
        PhanQuyen pq = new PhanQuyen();
        public frm_main()
        {
            InitializeComponent();
        }
        String TenDN;
        public string Tendn
        {
            get { return TenDN; }
            set { TenDN = value; }
        }
        private void Group1_Enter(object sender, EventArgs e)
        {

        }
        QL_FPT_SHOPDataContext ql = new QL_FPT_SHOPDataContext();
        private void frm_main_Load(object sender, EventArgs e)
        {
            List<QL_PHANQUYEN> manhinh = new List<QL_PHANQUYEN>();
            QLND_NHOMND nhom= new QLND_NHOMND();
            nhom = pq.laymanhom(Tendn);
            manhinh = pq.laydsmanhinh(nhom.MANHOM);
            for (int i = 0; i < manhinh.Count(); i++)
            {
                if (manhinh[i].MAMANHINH == "MH00001")
                {
                    gr_nhaphang.Visible = false;
                    gr_phanquyen.Visible = gr_taikhoannv.Visible = gr_nhomnd.Visible = gr_ndnnd.Visible = false;
                    rb_danhmuc.Visible = false;
                }
                if (manhinh[i].MAMANHINH == "MH00002")
                {
                    gr_banhang.Visible = false;
                    gr_phanquyen.Visible = gr_taikhoannv.Visible = gr_nhomnd.Visible = gr_ndnnd.Visible = false;
                    rb_danhmuc.Visible = false;
                }
                if (manhinh[i].MAMANHINH == "MH00003")
                {
                    rb_nghiepvu.Visible = false;
                    rb_danhmuc.Visible = false;
                   // gr_phanquyen.Visible = gr_taikhoannv.Visible = gr_nhomnd.Visible = gr_ndnnd.Visible = false;

                }
                if (manhinh[i].MAMANHINH == "MH00004")
                {
                    rb_nghiepvu.Visible = false;
                    gr_phanquyen.Visible = gr_taikhoannv.Visible = gr_nhomnd.Visible = gr_ndnnd.Visible = false;
                }
            }

            //Tendn = lb_manvdn.Text;
            var ktt = (from nv in ql.NHANVIENs where nv.MANV == lb_manvdn.Text select nv.HOTENNV).FirstOrDefault();
           // lb_tennv_dn.Text = ktt.ToString();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_doimk mk = new frm_doimk();
            mk.Tendn = lb_manvdn.Text;
            mk.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_banHang bh = new frm_banHang();
            bh.Tendn = lb_manvdn.Text;
            panel1.Controls.Clear();
            panel1.Controls.Add(bh);
            bh.Show();
        }

        private void btn_ddh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_dathang nh = new frm_dathang();
            panel1.Controls.Clear();
            nh.Tendn = lb_manvdn.Text;
            nh.Tennv = lb_tennv_dn.Text;
            panel1.Controls.Add(nh);

        }

        private void btn_nccc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_NCC ncc = new frm_NCC();
            panel1.Controls.Clear();
            panel1.Controls.Add(ncc);
        }

        private void btn_nv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_nhanvien nv = new frm_nhanvien();
            panel1.Controls.Clear();
            panel1.Controls.Add(nv);
        }

        private void btn_kh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_KhachHang kh = new frm_KhachHang();
            panel1.Controls.Clear();
            panel1.Controls.Add(kh);
        }

        private void btn_bh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_thongke tk = new frm_thongke();
            tk.Show();
        }

        private void btn_nhaphang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_pn.Enabled = btn_ddh.Enabled = true;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_PhanQuyen pq = new frm_PhanQuyen();
            panel1.Controls.Clear();
            panel1.Controls.Add(pq);
        }

        private void btn_km_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_khuyenmai kh = new frm_khuyenmai();
            panel1.Controls.Clear();
            panel1.Controls.Add(kh);
        }

        private void btn_loaisp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_LoaiSP l = new frm_LoaiSP();
            panel1.Controls.Clear();
            panel1.Controls.Add(l);
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem4_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            frm_PhieuBaoHanh pbh = new frm_PhieuBaoHanh();
            panel1.Controls.Clear();

            panel1.Controls.Add(pbh);
        }

        private void btn_sp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_Sanpham pbh = new frm_Sanpham();
            panel1.Controls.Clear();
            panel1.Controls.Add(pbh);
        }

        private void btn_pn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_NhapHang nh = new frm_NhapHang();
            panel1.Controls.Clear();
            nh.Tendn = lb_manvdn.Text;
            nh.Tennv = lb_tennv_dn.Text;
            panel1.Controls.Add(nh);
        }

        private void btn_dmsp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_DMSP nh = new frm_DMSP();
            panel1.Controls.Clear();
        
            panel1.Controls.Add(nh);
        }

        private void btn_tknv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_tknv nh = new frm_tknv();
            panel1.Controls.Clear();

            panel1.Controls.Add(nh);
        }

        private void btn_nhomND_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_nhomnguoidung l = new frm_nhomnguoidung();
            panel1.Controls.Clear();
            panel1.Controls.Add(l);
        }

        private void btn_ndNhomnd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_ND_nhom_ND l = new frm_ND_nhom_ND();
            panel1.Controls.Clear();
            panel1.Controls.Add(l);
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
