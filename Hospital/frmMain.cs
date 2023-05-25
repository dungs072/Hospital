using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hospital
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public void ShowMenu()
        {
            id.Text = "Mã nhân viên = " + Program.userName;
            fullname.Text = "Họ và tên = " + Program.mFullName;
            group.Text = "Nhóm = " + Program.mGroup;
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }

        private void ShowForm(Type tForm)
        {
            Form frm = CheckExists(tForm);
            if (frm != null) frm.Activate();
            else
            {
                Form f;
                /*if (tForm == typeof(frmRegisterLivingRoom))
                {
                    f = new frmRegisterLivingRoom();
                }*/
                
                if(tForm == typeof(frmGiuong))
                {
                    f = new frmGiuong();
                }    
                else
                {
                    f = new frmLogin();
                }
                f.MdiParent = this;
                f.Show();

            }
        }
        
        private void btnBarLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLogin login = new frmLogin();
            login.MdiParent = this;
            login.Show();
        }

        private void btnBarRegisterLivingRoom_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //ShowForm(typeof(frmRegisterLivingRoom));
        }

        private void btnChucVu_NhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formCHUCVUvaNHANVIEN cvnv = new formCHUCVUvaNHANVIEN();
            cvnv.MdiParent = this;
            cvnv.Show();
        }

        private void btnPhong_Khu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPhongvaKhuChuaTri p_khu = new frmPhongvaKhuChuaTri();
            p_khu.MdiParent = this;
            p_khu.Show();
        }

        private void btnGiuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //frmGiuong giuong = new frmGiuong();
            //giuong.MdiParent = this;
            //giuong.Show();
            ShowForm(typeof(frmGiuong));
        }

        private void btnTheoDoiBenhNhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTheoDoiBenhNhan theodoi = new frmTheoDoiBenhNhan();
            theodoi.MdiParent = this;
            theodoi.Show();
        }

        private void btnTaoTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTaoTK taoTK = new frmTaoTK();
            taoTK.MdiParent = this;
            taoTK.Show();
        }

        private void btnXoaTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmXoaTaiKhoan deleteTK = new frmXoaTaiKhoan();
            deleteTK.MdiParent = this;

            deleteTK.Show();
        }
    }
}
