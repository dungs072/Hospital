
namespace Hospital
{
    partial class frmLeaderNurse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLeaderNurse));
            this.qLBVDataSet = new Hospital.QLBVDataSet();
            this.gET_CURE_AREABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gET_CURE_AREATableAdapter = new Hospital.QLBVDataSetTableAdapters.GET_CURE_AREATableAdapter();
            this.tableAdapterManager = new Hospital.QLBVDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gET_NURSE_NOT_LEADERGridControl = new DevExpress.XtraGrid.GridControl();
            this.gET_NURSE_NOT_LEADERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIENTHOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGHIEPVU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gET_CURE_AREAGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDANHDINHKHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENYT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAreaId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNurse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAreaName = new System.Windows.Forms.TextBox();
            this.gET_NURSE_NOT_LEADERTableAdapter = new Hospital.QLBVDataSetTableAdapters.GET_NURSE_NOT_LEADERTableAdapter();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnRegister = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancelRegister = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.qLBVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_CURE_AREABindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gET_NURSE_NOT_LEADERGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_NURSE_NOT_LEADERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gET_CURE_AREAGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // qLBVDataSet
            // 
            this.qLBVDataSet.DataSetName = "QLBVDataSet";
            this.qLBVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gET_CURE_AREABindingSource
            // 
            this.gET_CURE_AREABindingSource.DataMember = "GET_CURE_AREA";
            this.gET_CURE_AREABindingSource.DataSource = this.qLBVDataSet;
            // 
            // gET_CURE_AREATableAdapter
            // 
            this.gET_CURE_AREATableAdapter.ClearBeforeFill = true;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1944, 336);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.gET_NURSE_NOT_LEADERGridControl);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1169, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(775, 336);
            this.panel3.TabIndex = 1;
            // 
            // gET_NURSE_NOT_LEADERGridControl
            // 
            this.gET_NURSE_NOT_LEADERGridControl.DataSource = this.gET_NURSE_NOT_LEADERBindingSource;
            this.gET_NURSE_NOT_LEADERGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gET_NURSE_NOT_LEADERGridControl.Location = new System.Drawing.Point(0, 48);
            this.gET_NURSE_NOT_LEADERGridControl.MainView = this.gridView2;
            this.gET_NURSE_NOT_LEADERGridControl.Name = "gET_NURSE_NOT_LEADERGridControl";
            this.gET_NURSE_NOT_LEADERGridControl.Size = new System.Drawing.Size(773, 286);
            this.gET_NURSE_NOT_LEADERGridControl.TabIndex = 1;
            this.gET_NURSE_NOT_LEADERGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gET_NURSE_NOT_LEADERBindingSource
            // 
            this.gET_NURSE_NOT_LEADERBindingSource.DataMember = "GET_NURSE_NOT_LEADER";
            this.gET_NURSE_NOT_LEADERBindingSource.DataSource = this.qLBVDataSet;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHOTEN,
            this.colPHAI,
            this.colDIENTHOAI,
            this.colNGHIEPVU});
            this.gridView2.GridControl = this.gET_NURSE_NOT_LEADERGridControl;
            this.gridView2.Name = "gridView2";
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
            this.colMANV.Width = 220;
            // 
            // colHOTEN
            // 
            this.colHOTEN.Caption = "Họ và tên";
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.MinWidth = 30;
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.OptionsColumn.AllowEdit = false;
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 1;
            this.colHOTEN.Width = 304;
            // 
            // colPHAI
            // 
            this.colPHAI.Caption = "Phái";
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 30;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.OptionsColumn.AllowEdit = false;
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 2;
            this.colPHAI.Width = 192;
            // 
            // colDIENTHOAI
            // 
            this.colDIENTHOAI.Caption = "Điện thoại";
            this.colDIENTHOAI.FieldName = "DIENTHOAI";
            this.colDIENTHOAI.MinWidth = 30;
            this.colDIENTHOAI.Name = "colDIENTHOAI";
            this.colDIENTHOAI.OptionsColumn.AllowEdit = false;
            this.colDIENTHOAI.Visible = true;
            this.colDIENTHOAI.VisibleIndex = 3;
            this.colDIENTHOAI.Width = 192;
            // 
            // colNGHIEPVU
            // 
            this.colNGHIEPVU.Caption = "Nghiệp vụ";
            this.colNGHIEPVU.FieldName = "NGHIEPVU";
            this.colNGHIEPVU.MinWidth = 30;
            this.colNGHIEPVU.Name = "colNGHIEPVU";
            this.colNGHIEPVU.OptionsColumn.AllowEdit = false;
            this.colNGHIEPVU.Visible = true;
            this.colNGHIEPVU.VisibleIndex = 4;
            this.colNGHIEPVU.Width = 194;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(773, 48);
            this.panel5.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(218, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "DANH SÁCH Y TÁ KHÔNG LÀ Y TÁ TRƯỞNG";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.gET_CURE_AREAGridControl);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1137, 336);
            this.panel2.TabIndex = 0;
            // 
            // gET_CURE_AREAGridControl
            // 
            this.gET_CURE_AREAGridControl.DataSource = this.gET_CURE_AREABindingSource;
            this.gET_CURE_AREAGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gET_CURE_AREAGridControl.Location = new System.Drawing.Point(0, 48);
            this.gET_CURE_AREAGridControl.MainView = this.gridView1;
            this.gET_CURE_AREAGridControl.Name = "gET_CURE_AREAGridControl";
            this.gET_CURE_AREAGridControl.Size = new System.Drawing.Size(1135, 286);
            this.gET_CURE_AREAGridControl.TabIndex = 1;
            this.gET_CURE_AREAGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gET_CURE_AREAGridControl.Click += new System.EventHandler(this.gET_CURE_AREAGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDANHDINHKHU,
            this.colTEN,
            this.colTENYT});
            this.gridView1.GridControl = this.gET_CURE_AREAGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colDANHDINHKHU
            // 
            this.colDANHDINHKHU.Caption = "Danh định khu";
            this.colDANHDINHKHU.FieldName = "DANHDINHKHU";
            this.colDANHDINHKHU.MinWidth = 30;
            this.colDANHDINHKHU.Name = "colDANHDINHKHU";
            this.colDANHDINHKHU.OptionsColumn.AllowEdit = false;
            this.colDANHDINHKHU.Visible = true;
            this.colDANHDINHKHU.VisibleIndex = 0;
            this.colDANHDINHKHU.Width = 112;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 30;
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.AllowEdit = false;
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 1;
            this.colTEN.Width = 112;
            // 
            // colTENYT
            // 
            this.colTENYT.Caption = "Y tá trưởng";
            this.colTENYT.FieldName = "TENYT";
            this.colTENYT.MinWidth = 30;
            this.colTENYT.Name = "colTENYT";
            this.colTENYT.OptionsColumn.AllowEdit = false;
            this.colTENYT.Visible = true;
            this.colTENYT.VisibleIndex = 2;
            this.colTENYT.Width = 112;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1135, 48);
            this.panel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(485, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHU ĐỊNH DANH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAreaId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNurse);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAreaName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 370);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 278);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập liệu";
            // 
            // txtAreaId
            // 
            this.txtAreaId.Location = new System.Drawing.Point(340, 52);
            this.txtAreaId.Name = "txtAreaId";
            this.txtAreaId.Size = new System.Drawing.Size(100, 27);
            this.txtAreaId.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Y tá trưởng:";
            // 
            // txtNurse
            // 
            this.txtNurse.Location = new System.Drawing.Point(126, 133);
            this.txtNurse.Name = "txtNurse";
            this.txtNurse.Size = new System.Drawing.Size(314, 27);
            this.txtNurse.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Khu:";
            // 
            // txtAreaName
            // 
            this.txtAreaName.Location = new System.Drawing.Point(88, 52);
            this.txtAreaName.Name = "txtAreaName";
            this.txtAreaName.Size = new System.Drawing.Size(233, 27);
            this.txtAreaName.TabIndex = 0;
            // 
            // gET_NURSE_NOT_LEADERTableAdapter
            // 
            this.gET_NURSE_NOT_LEADERTableAdapter.ClearBeforeFill = true;
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
            this.btnRegister,
            this.btnCancelRegister,
            this.btnReload});
            this.barManager1.MaxItemId = 4;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRegister, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCancelRegister, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnRegister
            // 
            this.btnRegister.Caption = "Đăng kí";
            this.btnRegister.Id = 0;
            this.btnRegister.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRegister.ImageOptions.Image")));
            this.btnRegister.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRegister.ImageOptions.LargeImage")));
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRegister_ItemClick);
            // 
            // btnCancelRegister
            // 
            this.btnCancelRegister.Caption = "Hủy đăng kí";
            this.btnCancelRegister.Id = 1;
            this.btnCancelRegister.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelRegister.ImageOptions.Image")));
            this.btnCancelRegister.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCancelRegister.ImageOptions.LargeImage")));
            this.btnCancelRegister.Name = "btnCancelRegister";
            this.btnCancelRegister.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancelRegister_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 3;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1944, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 648);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1944, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 614);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1944, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 614);
            // 
            // frmLeaderNurse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1944, 648);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmLeaderNurse";
            this.Text = "Y tá trưởng";
            this.Load += new System.EventHandler(this.frmLeaderNurse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLBVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_CURE_AREABindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gET_NURSE_NOT_LEADERGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_NURSE_NOT_LEADERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gET_CURE_AREAGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLBVDataSet qLBVDataSet;
        private System.Windows.Forms.BindingSource gET_CURE_AREABindingSource;
        private QLBVDataSetTableAdapters.GET_CURE_AREATableAdapter gET_CURE_AREATableAdapter;
        private QLBVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gET_CURE_AREAGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource gET_NURSE_NOT_LEADERBindingSource;
        private QLBVDataSetTableAdapters.GET_NURSE_NOT_LEADERTableAdapter gET_NURSE_NOT_LEADERTableAdapter;
        private DevExpress.XtraGrid.GridControl gET_NURSE_NOT_LEADERGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colDIENTHOAI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGHIEPVU;
        private DevExpress.XtraGrid.Columns.GridColumn colDANHDINHKHU;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colTENYT;
        private System.Windows.Forms.TextBox txtAreaId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNurse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAreaName;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnRegister;
        private DevExpress.XtraBars.BarButtonItem btnCancelRegister;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}