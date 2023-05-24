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
            btnBarLogin.Enabled = false;
            btnBarLogOut.Enabled = true;
            btnBarChangePassword.Enabled = true;
           
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
                else if (tForm == typeof(frmCure))
                {
                    f = new frmCure();
                }
                else if (tForm == typeof(frmEquipmentDetail))
                {
                    f = new frmEquipmentDetail();
                }
                else if (tForm == typeof(frmAreaWorkingDetail))
                {
                    f = new frmAreaWorkingDetail();
                }
                else if (tForm == typeof(frmUsingEquipment))
                {
                    f = new frmUsingEquipment();
                }
                else if (tForm == typeof(frmPatient))
                {
                    f = new frmPatient();
                }
                else if (tForm == typeof(frmEquipment))
                {
                    f = new frmEquipment();
                }
                else if(tForm == typeof(frmTreatment))
                {
                    f = new frmTreatment();
                }
                else if (tForm == typeof(frmLeaderNurse))
                {
                    f = new frmLeaderNurse();
                }
                else if (tForm == typeof(frmDoctor))
                {
                    f = new frmDoctor();
                }
                else if (tForm == typeof(frmNurse))
                {
                    f = new frmNurse();
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
        private void btnBarCure_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(typeof(frmCure));
        }
        private void btnBarUsingEquipment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(typeof(frmEquipmentDetail));
        }
        private void btnBarRegisterArea_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(typeof(frmAreaWorkingDetail));
        }
        private void btnBarUsingEquip_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(typeof(frmUsingEquipment));
        }
        private void btnBarPatient_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(typeof(frmPatient));
        }
        private void btnBarEquipment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(typeof(frmEquipment));
        }
        private void btnBarTreatment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(typeof(frmTreatment));
        }
        private void btnBarUsingEquipNurse_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(typeof(frmEquipmentDetail));
        }

        private void btnBarRegisterLivingRoomNurse_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(typeof(frmRegisterLivingRoom));
        }
        private void btnBarRegisterLeaderNurse_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(typeof(frmLeaderNurse));
        }
        private void btnBarDoctor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(typeof(frmDoctor));
        }
        private void btnBarNurse_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(typeof(frmNurse));
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ShowForm(typeof(frmLogin));
            ribbonPage2.Visible = false;
            ribbonPage3.Visible = false;
            ribbonPage4.Visible = false;
            ribbonPage5.Visible = false;
            btnBarLogOut.Enabled = false;
            btnBarChangePassword.Enabled = false;
        }


        public void LoginByHospitalRole()
        {
            ribbonPage2.Visible = true;
            ribbonPage3.Visible = true;
            ribbonPage4.Visible = true;
            ribbonPage5.Visible = false;

            ribbonControl1.SelectedPage = ribbonPage2;
            CloseAllFormCurrentlyOpen();
        }
        public void LoginByDoctorRole()
        {
            ribbonPage3.Visible = true;
            ribbonPage5.Visible = false;
            ribbonControl1.SelectedPage = ribbonPage3;
            CloseAllFormCurrentlyOpen();
        }
        public void LoginByNurseRole()
        {
            ribbonPage5.Visible = true;
            ribbonControl1.SelectedPage = ribbonPage5;
            CloseAllFormCurrentlyOpen();
        }
        private void CloseAllFormCurrentlyOpen()
        {
            foreach (var form in MdiChildren)
            {
                form.Close();
            }
        }
        private void btnBarLogOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ribbonPage2.Visible = false;
            ribbonPage3.Visible = false;
            ribbonPage4.Visible = false;
            ribbonPage5.Visible = false;
            btnBarLogin.Enabled = true;
            btnBarLogOut.Enabled = false;
            btnBarChangePassword.Enabled = false;

            btnBarUsingEquip.Enabled = true;
            btnBarRegisterArea.Enabled = true;
            CloseAllFormCurrentlyOpen();
            ShowForm(typeof(frmLogin));
        }

    
    }
}
