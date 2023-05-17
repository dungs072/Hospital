﻿
namespace Hospital
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            DevExpress.Utils.Animation.PushTransition pushTransition1 = new DevExpress.Utils.Animation.PushTransition();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnBarLogin = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarRegisterLivingRoom = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarCure = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarUsingEquipment = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarRegisterArea = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarWorkingHour = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarHoursWorkingWeek = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarUsingEquip = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarWeek = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarPatient = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarEquipment = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarTreatment = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarLogOut = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarChangePassword = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.workspaceManager1 = new DevExpress.Utils.WorkspaceManager(this.components);
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.id = new System.Windows.Forms.ToolStripStatusLabel();
            this.fullname = new System.Windows.Forms.ToolStripStatusLabel();
            this.group = new System.Windows.Forms.ToolStripStatusLabel();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnBarUsingEquipNurse = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarRegisterLivingRoomNurse = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnBarLogin,
            this.btnBarRegisterLivingRoom,
            this.btnBarCure,
            this.btnBarUsingEquipment,
            this.btnBarRegisterArea,
            this.btnBarWorkingHour,
            this.btnBarHoursWorkingWeek,
            this.btnBarUsingEquip,
            this.btnBarWeek,
            this.btnBarPatient,
            this.btnBarEquipment,
            this.btnBarTreatment,
            this.btnBarLogOut,
            this.btnBarChangePassword,
            this.btnBarUsingEquipNurse,
            this.btnBarRegisterLivingRoomNurse});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 19;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4,
            this.ribbonPage5});
            this.ribbonControl1.Size = new System.Drawing.Size(1137, 244);
            // 
            // btnBarLogin
            // 
            this.btnBarLogin.Caption = "Đăng nhập";
            this.btnBarLogin.Id = 1;
            this.btnBarLogin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBarLogin.ImageOptions.Image")));
            this.btnBarLogin.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBarLogin.ImageOptions.LargeImage")));
            this.btnBarLogin.Name = "btnBarLogin";
            this.btnBarLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarLogin_ItemClick);
            // 
            // btnBarRegisterLivingRoom
            // 
            this.btnBarRegisterLivingRoom.Caption = "ĐĂNG KÍ PHÒNG Ở";
            this.btnBarRegisterLivingRoom.Id = 2;
            this.btnBarRegisterLivingRoom.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBarRegisterLivingRoom.ImageOptions.Image")));
            this.btnBarRegisterLivingRoom.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBarRegisterLivingRoom.ImageOptions.LargeImage")));
            this.btnBarRegisterLivingRoom.Name = "btnBarRegisterLivingRoom";
            this.btnBarRegisterLivingRoom.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarRegisterLivingRoom_ItemClick);
            // 
            // btnBarCure
            // 
            this.btnBarCure.Caption = "Chữa trị";
            this.btnBarCure.Id = 5;
            this.btnBarCure.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBarCure.ImageOptions.Image")));
            this.btnBarCure.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBarCure.ImageOptions.LargeImage")));
            this.btnBarCure.Name = "btnBarCure";
            this.btnBarCure.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarCure_ItemClick_1);
            // 
            // btnBarUsingEquipment
            // 
            this.btnBarUsingEquipment.Caption = "Sử dụng vật tư";
            this.btnBarUsingEquipment.Id = 6;
            this.btnBarUsingEquipment.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBarUsingEquipment.ImageOptions.Image")));
            this.btnBarUsingEquipment.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBarUsingEquipment.ImageOptions.LargeImage")));
            this.btnBarUsingEquipment.Name = "btnBarUsingEquipment";
            this.btnBarUsingEquipment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarUsingEquipment_ItemClick);
            // 
            // btnBarRegisterArea
            // 
            this.btnBarRegisterArea.Caption = "Đăng kí khu làm việc";
            this.btnBarRegisterArea.Id = 7;
            this.btnBarRegisterArea.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBarRegisterArea.ImageOptions.Image")));
            this.btnBarRegisterArea.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBarRegisterArea.ImageOptions.LargeImage")));
            this.btnBarRegisterArea.Name = "btnBarRegisterArea";
            this.btnBarRegisterArea.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarRegisterArea_ItemClick);
            // 
            // btnBarWorkingHour
            // 
            this.btnBarWorkingHour.Caption = "Thời gian làm việc";
            this.btnBarWorkingHour.Id = 8;
            this.btnBarWorkingHour.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBarWorkingHour.ImageOptions.Image")));
            this.btnBarWorkingHour.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBarWorkingHour.ImageOptions.LargeImage")));
            this.btnBarWorkingHour.Name = "btnBarWorkingHour";
            this.btnBarWorkingHour.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarWorkingHour_ItemClick);
            // 
            // btnBarHoursWorkingWeek
            // 
            this.btnBarHoursWorkingWeek.Caption = "Tổng thời gian làm việc theo tuần";
            this.btnBarHoursWorkingWeek.Id = 9;
            this.btnBarHoursWorkingWeek.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBarHoursWorkingWeek.ImageOptions.Image")));
            this.btnBarHoursWorkingWeek.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBarHoursWorkingWeek.ImageOptions.LargeImage")));
            this.btnBarHoursWorkingWeek.Name = "btnBarHoursWorkingWeek";
            this.btnBarHoursWorkingWeek.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarHoursWorkingWeek_ItemClick);
            // 
            // btnBarUsingEquip
            // 
            this.btnBarUsingEquip.Caption = "Hóa đơn sử dụng vật tư";
            this.btnBarUsingEquip.Id = 10;
            this.btnBarUsingEquip.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBarUsingEquip.ImageOptions.Image")));
            this.btnBarUsingEquip.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBarUsingEquip.ImageOptions.LargeImage")));
            this.btnBarUsingEquip.Name = "btnBarUsingEquip";
            this.btnBarUsingEquip.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarUsingEquip_ItemClick);
            // 
            // btnBarWeek
            // 
            this.btnBarWeek.Caption = "Tuần làm việc";
            this.btnBarWeek.Id = 11;
            this.btnBarWeek.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBarWeek.ImageOptions.Image")));
            this.btnBarWeek.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBarWeek.ImageOptions.LargeImage")));
            this.btnBarWeek.Name = "btnBarWeek";
            this.btnBarWeek.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarWeek_ItemClick);
            // 
            // btnBarPatient
            // 
            this.btnBarPatient.Caption = "Bệnh nhân";
            this.btnBarPatient.Id = 12;
            this.btnBarPatient.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBarPatient.ImageOptions.Image")));
            this.btnBarPatient.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBarPatient.ImageOptions.LargeImage")));
            this.btnBarPatient.Name = "btnBarPatient";
            this.btnBarPatient.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarPatient_ItemClick);
            // 
            // btnBarEquipment
            // 
            this.btnBarEquipment.Caption = "Vật tư-Thuốc men";
            this.btnBarEquipment.Id = 13;
            this.btnBarEquipment.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBarEquipment.ImageOptions.Image")));
            this.btnBarEquipment.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBarEquipment.ImageOptions.LargeImage")));
            this.btnBarEquipment.Name = "btnBarEquipment";
            this.btnBarEquipment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarEquipment_ItemClick);
            // 
            // btnBarTreatment
            // 
            this.btnBarTreatment.Caption = "Loại chữa trị";
            this.btnBarTreatment.Id = 14;
            this.btnBarTreatment.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBarTreatment.ImageOptions.Image")));
            this.btnBarTreatment.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBarTreatment.ImageOptions.LargeImage")));
            this.btnBarTreatment.Name = "btnBarTreatment";
            this.btnBarTreatment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarTreatment_ItemClick);
            // 
            // btnBarLogOut
            // 
            this.btnBarLogOut.Caption = "Đăng xuất";
            this.btnBarLogOut.Id = 15;
            this.btnBarLogOut.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBarLogOut.ImageOptions.Image")));
            this.btnBarLogOut.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBarLogOut.ImageOptions.LargeImage")));
            this.btnBarLogOut.Name = "btnBarLogOut";
            this.btnBarLogOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarLogOut_ItemClick);
            // 
            // btnBarChangePassword
            // 
            this.btnBarChangePassword.Caption = "Đổi mật khẩu";
            this.btnBarChangePassword.Id = 16;
            this.btnBarChangePassword.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBarChangePassword.ImageOptions.Image")));
            this.btnBarChangePassword.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBarChangePassword.ImageOptions.LargeImage")));
            this.btnBarChangePassword.Name = "btnBarChangePassword";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.ImageOptions.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBarLogin);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBarChangePassword);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBarLogOut);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup2});
            this.ribbonPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage2.ImageOptions.Image")));
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Quản trị";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnBarWeek);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnBarPatient);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnBarEquipment);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnBarTreatment);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnBarRegisterLivingRoom);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnBarRegisterArea);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnBarWorkingHour);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage3.ImageOptions.Image")));
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Điều trị bệnh nhân";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnBarCure);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnBarUsingEquipment);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage4.ImageOptions.Image")));
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Báo cáo";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnBarHoursWorkingWeek);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnBarUsingEquip);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // workspaceManager1
            // 
            this.workspaceManager1.TargetControl = this;
            this.workspaceManager1.TransitionType = pushTransition1;
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbonControl1;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.id,
            this.fullname,
            this.group});
            this.statusStrip1.Location = new System.Drawing.Point(0, 494);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1137, 32);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // id
            // 
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(127, 25);
            this.id.Text = "Mã nhân viên: ";
            // 
            // fullname
            // 
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(93, 25);
            this.fullname.Text = "Họ và tên:";
            // 
            // group
            // 
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(66, 25);
            this.group.Text = "Nhóm:";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
            this.ribbonPage5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage5.ImageOptions.Image")));
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "Y tá";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnBarUsingEquipNurse);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnBarRegisterLivingRoomNurse);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // btnBarUsingEquipNurse
            // 
            this.btnBarUsingEquipNurse.Caption = "Sử dụng vật tư";
            this.btnBarUsingEquipNurse.Id = 17;
            this.btnBarUsingEquipNurse.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBarUsingEquipNurse.ImageOptions.Image")));
            this.btnBarUsingEquipNurse.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBarUsingEquipNurse.ImageOptions.LargeImage")));
            this.btnBarUsingEquipNurse.Name = "btnBarUsingEquipNurse";
            this.btnBarUsingEquipNurse.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarUsingEquipNurse_ItemClick);
            // 
            // btnBarRegisterLivingRoomNurse
            // 
            this.btnBarRegisterLivingRoomNurse.Caption = "Đăng kí phòng ở";
            this.btnBarRegisterLivingRoomNurse.Id = 18;
            this.btnBarRegisterLivingRoomNurse.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.btnBarRegisterLivingRoomNurse.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.btnBarRegisterLivingRoomNurse.Name = "btnBarRegisterLivingRoomNurse";
            this.btnBarRegisterLivingRoomNurse.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarRegisterLivingRoomNurse_ItemClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 526);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "  Quản lý bệnh viện";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnBarLogin;
        private DevExpress.Utils.WorkspaceManager workspaceManager1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private System.Windows.Forms.ToolStripStatusLabel id;
        private System.Windows.Forms.ToolStripStatusLabel fullname;
        private System.Windows.Forms.ToolStripStatusLabel group;
        private DevExpress.XtraBars.BarButtonItem btnBarRegisterLivingRoom;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.BarButtonItem btnBarCure;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnBarUsingEquipment;
        private DevExpress.XtraBars.BarButtonItem btnBarRegisterArea;
        private DevExpress.XtraBars.BarButtonItem btnBarWorkingHour;
        private DevExpress.XtraBars.BarButtonItem btnBarHoursWorkingWeek;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnBarUsingEquip;
        private DevExpress.XtraBars.BarButtonItem btnBarWeek;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnBarPatient;
        private DevExpress.XtraBars.BarButtonItem btnBarEquipment;
        private DevExpress.XtraBars.BarButtonItem btnBarTreatment;
        private DevExpress.XtraBars.BarButtonItem btnBarLogOut;
        private DevExpress.XtraBars.BarButtonItem btnBarChangePassword;
        private DevExpress.XtraBars.BarButtonItem btnBarUsingEquipNurse;
        private DevExpress.XtraBars.BarButtonItem btnBarRegisterLivingRoomNurse;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
    }
}

