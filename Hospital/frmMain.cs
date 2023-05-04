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
                if (tForm == typeof(frmRegisterLivingRoom))
                {
                    f = new frmRegisterLivingRoom();
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
            ShowForm(typeof(frmLogin));
        }

        private void btnBarRegisterLivingRoom_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(typeof(frmRegisterLivingRoom));
        }
    }
}
