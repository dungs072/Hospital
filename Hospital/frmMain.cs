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
                else if (tForm == typeof(frmHourWorkingDetail))
                {
                    f = new frmHourWorkingDetail();
                }
                else if(tForm == typeof(frmHoursWorkingWeek))
                {
                    f = new frmHoursWorkingWeek();
                }
                else if (tForm == typeof(frmUsingEquipment))
                {
                    f = new frmUsingEquipment();
                }
                else if(tForm == typeof(frmWeek))
                {
                    f = new frmWeek();
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
        private void btnBarWorkingHour_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(typeof(frmHourWorkingDetail));
        }
        private void btnBarHoursWorkingWeek_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(typeof(frmHoursWorkingWeek));
        }
        private void btnBarUsingEquip_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(typeof(frmUsingEquipment));
        }
        private void btnBarWeek_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(typeof(frmWeek));
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

        private void frmMain_Load(object sender, EventArgs e)
        {
            ShowForm(typeof(frmLogin));
            ribbonPage2.Visible = false;
            ribbonPage3.Visible = false;
            ribbonPage4.Visible = false;
            btnBarLogOut.Enabled = false;
            btnBarChangePassword.Enabled = false;
        }


        public void LoginByHospitalRole()
        {
            ribbonPage2.Visible = true;
            ribbonPage3.Visible = true;
            ribbonPage4.Visible = true;

            ribbonControl1.SelectedPage = ribbonPage2;
            CloseAllFormCurrentlyOpen();
        }
        public void LoginByDoctorRole()
        {
            ribbonPage3.Visible = true;
            ribbonControl1.SelectedPage = ribbonPage3;
            CloseAllFormCurrentlyOpen();
        }
        public void LoginByNurseRole()
        {
            
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
            btnBarLogin.Enabled = true;
            btnBarLogOut.Enabled = false;
            btnBarChangePassword.Enabled = false;

            CloseAllFormCurrentlyOpen();
            ShowForm(typeof(frmLogin));
        }
    }
}
