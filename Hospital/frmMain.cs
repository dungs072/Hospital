﻿using System;
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
                else if (tForm == typeof(frmCure))
                {
                    f = new frmCure();
                }
                else if (tForm == typeof(frmEquipmentDetail))
                {
                    f = new frmEquipmentDetail();
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

        private void frmMain_Load(object sender, EventArgs e)
        {
            ShowForm(typeof(frmLogin));
            ribbonPage2.Visible = false;
            ribbonPage3.Visible = false;
        }


        public void LoginByHospitalRole()
        {
            ribbonPage2.Visible = true;
            ribbonControl1.SelectedPage = ribbonPage2;
            CloseLoginForm();
        }
        public void LoginByDoctorRole()
        {
            ribbonPage3.Visible = true;
            ribbonControl1.SelectedPage = ribbonPage3;
            CloseLoginForm();
        }
        public void LoginByNurseRole()
        {

        }
        private void CloseLoginForm()
        {
            foreach (var form in MdiChildren)
            {
                form.Close();
            }
        }

       
    }
}
