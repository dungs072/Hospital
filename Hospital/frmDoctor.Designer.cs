
namespace Hospital
{
    partial class frmDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoctor));
            this.qLBVDataSet = new Hospital.QLBVDataSet();
            this.gET_FULL_DOCTORSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gET_FULL_DOCTORSTableAdapter = new Hospital.QLBVDataSetTableAdapters.GET_FULL_DOCTORSTableAdapter();
            this.tableAdapterManager = new Hospital.QLBVDataSetTableAdapters.TableAdapterManager();
            this.gET_FULL_DOCTORSGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIENTHOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCCCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.cmbEducation = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPersonalId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDoctorId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.btnWrite = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancel = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.qLBVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_FULL_DOCTORSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_FULL_DOCTORSGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // qLBVDataSet
            // 
            this.qLBVDataSet.DataSetName = "QLBVDataSet";
            this.qLBVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gET_FULL_DOCTORSBindingSource
            // 
            this.gET_FULL_DOCTORSBindingSource.DataMember = "GET_FULL_DOCTORS";
            this.gET_FULL_DOCTORSBindingSource.DataSource = this.qLBVDataSet;
            // 
            // gET_FULL_DOCTORSTableAdapter
            // 
            this.gET_FULL_DOCTORSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BACSITableAdapter = null;
            this.tableAdapterManager.BENHNHANTableAdapter = null;
            this.tableAdapterManager.CHITIETCHUATRITableAdapter = null;
            this.tableAdapterManager.CHITIETLAMVIECKHUCHUATRITableAdapter = null;
            this.tableAdapterManager.CHITIETOTableAdapter = null;
            this.tableAdapterManager.CHITIETSUDUNGVTTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.GIUONGTableAdapter = null;
            this.tableAdapterManager.KHUCHUATRITableAdapter = null;
            this.tableAdapterManager.LOAICHUATRITableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHONGTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Hospital.QLBVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VATTUTableAdapter = null;
            this.tableAdapterManager.YTATableAdapter = null;
            // 
            // gET_FULL_DOCTORSGridControl
            // 
            this.gET_FULL_DOCTORSGridControl.DataSource = this.gET_FULL_DOCTORSBindingSource;
            this.gET_FULL_DOCTORSGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.gET_FULL_DOCTORSGridControl.Location = new System.Drawing.Point(0, 34);
            this.gET_FULL_DOCTORSGridControl.MainView = this.gridView1;
            this.gET_FULL_DOCTORSGridControl.Name = "gET_FULL_DOCTORSGridControl";
            this.gET_FULL_DOCTORSGridControl.Size = new System.Drawing.Size(1126, 272);
            this.gET_FULL_DOCTORSGridControl.TabIndex = 1;
            this.gET_FULL_DOCTORSGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gET_FULL_DOCTORSGridControl.Click += new System.EventHandler(this.gET_FULL_DOCTORSGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colPHAI,
            this.colDIACHI,
            this.colDIENTHOAI,
            this.colCCCD,
            this.colTRINHDO});
            this.gridView1.GridControl = this.gET_FULL_DOCTORSGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã nhân viên";
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 30;
            this.colMANV.Name = "colMANV";
            this.colMANV.OptionsColumn.AllowEdit = false;
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            this.colMANV.Width = 112;
            // 
            // colHO
            // 
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 30;
            this.colHO.Name = "colHO";
            this.colHO.OptionsColumn.AllowEdit = false;
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 112;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 30;
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.AllowEdit = false;
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 112;
            // 
            // colPHAI
            // 
            this.colPHAI.Caption = "Giới tính";
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 30;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.OptionsColumn.AllowEdit = false;
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 3;
            this.colPHAI.Width = 112;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 30;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.AllowEdit = false;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            this.colDIACHI.Width = 112;
            // 
            // colDIENTHOAI
            // 
            this.colDIENTHOAI.Caption = "Điện thoại";
            this.colDIENTHOAI.FieldName = "DIENTHOAI";
            this.colDIENTHOAI.MinWidth = 30;
            this.colDIENTHOAI.Name = "colDIENTHOAI";
            this.colDIENTHOAI.OptionsColumn.AllowEdit = false;
            this.colDIENTHOAI.Visible = true;
            this.colDIENTHOAI.VisibleIndex = 5;
            this.colDIENTHOAI.Width = 112;
            // 
            // colCCCD
            // 
            this.colCCCD.Caption = "Căn cước công dân";
            this.colCCCD.FieldName = "CCCD";
            this.colCCCD.MinWidth = 30;
            this.colCCCD.Name = "colCCCD";
            this.colCCCD.OptionsColumn.AllowEdit = false;
            this.colCCCD.Visible = true;
            this.colCCCD.VisibleIndex = 6;
            this.colCCCD.Width = 112;
            // 
            // colTRINHDO
            // 
            this.colTRINHDO.Caption = "Trình độ";
            this.colTRINHDO.FieldName = "TRINHDO";
            this.colTRINHDO.MinWidth = 30;
            this.colTRINHDO.Name = "colTRINHDO";
            this.colTRINHDO.OptionsColumn.AllowEdit = false;
            this.colTRINHDO.Visible = true;
            this.colTRINHDO.VisibleIndex = 7;
            this.colTRINHDO.Width = 112;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbSex);
            this.groupBox1.Controls.Add(this.cmbEducation);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtPersonalId);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDoctorId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 434);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập liệu";
            // 
            // cmbSex
            // 
            this.cmbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Location = new System.Drawing.Point(148, 188);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(158, 27);
            this.cmbSex.TabIndex = 16;
            // 
            // cmbEducation
            // 
            this.cmbEducation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEducation.FormattingEnabled = true;
            this.cmbEducation.Location = new System.Drawing.Point(457, 191);
            this.cmbEducation.Name = "cmbEducation";
            this.cmbEducation.Size = new System.Drawing.Size(219, 27);
            this.cmbEducation.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(340, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Trình độ:";
            // 
            // txtPersonalId
            // 
            this.txtPersonalId.Location = new System.Drawing.Point(481, 334);
            this.txtPersonalId.MaxLength = 12;
            this.txtPersonalId.Name = "txtPersonalId";
            this.txtPersonalId.Size = new System.Drawing.Size(213, 27);
            this.txtPersonalId.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(398, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "CCCD:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(148, 331);
            this.txtPhoneNumber.MaxLength = 10;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(219, 27);
            this.txtPhoneNumber.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Số điện thoại:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(148, 264);
            this.txtAddress.MaxLength = 75;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(418, 27);
            this.txtAddress.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giới tính:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(457, 113);
            this.txtLastName.MaxLength = 30;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(158, 27);
            this.txtLastName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(148, 113);
            this.txtFirstName.MaxLength = 50;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(158, 27);
            this.txtFirstName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ:";
            // 
            // txtDoctorId
            // 
            this.txtDoctorId.Location = new System.Drawing.Point(148, 46);
            this.txtDoctorId.MaxLength = 10;
            this.txtDoctorId.Name = "txtDoctorId";
            this.txtDoctorId.Size = new System.Drawing.Size(158, 27);
            this.txtDoctorId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã bác sĩ:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAdd,
            this.btnDelete,
            this.btnUpdate,
            this.btnWrite,
            this.btnCancel,
            this.btnReload});
            this.barManager1.MaxItemId = 6;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUpdate, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnWrite, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCancel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Thêm";
            this.btnAdd.Id = 0;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.LargeImage")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Xóa";
            this.btnDelete.Id = 1;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.LargeImage")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Caption = "Sửa";
            this.btnUpdate.Id = 2;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.LargeImage")));
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUpdate_ItemClick);
            // 
            // btnWrite
            // 
            this.btnWrite.Caption = "Ghi";
            this.btnWrite.Id = 3;
            this.btnWrite.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnWrite.ImageOptions.Image")));
            this.btnWrite.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnWrite.ImageOptions.LargeImage")));
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnWrite_ItemClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Caption = "Cancel";
            this.btnCancel.Id = 4;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.LargeImage")));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancel_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 5;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1126, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 740);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1126, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 706);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1126, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 706);
            // 
            // frmDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 740);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gET_FULL_DOCTORSGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDoctor";
            this.Text = "Bác sĩ";
            this.Load += new System.EventHandler(this.frmDoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLBVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_FULL_DOCTORSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_FULL_DOCTORSGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLBVDataSet qLBVDataSet;
        private System.Windows.Forms.BindingSource gET_FULL_DOCTORSBindingSource;
        private QLBVDataSetTableAdapters.GET_FULL_DOCTORSTableAdapter gET_FULL_DOCTORSTableAdapter;
        private QLBVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gET_FULL_DOCTORSGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colDIENTHOAI;
        private DevExpress.XtraGrid.Columns.GridColumn colCCCD;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.ComboBox cmbEducation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPersonalId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDoctorId;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnUpdate;
        private DevExpress.XtraBars.BarButtonItem btnWrite;
        private DevExpress.XtraBars.BarButtonItem btnCancel;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}