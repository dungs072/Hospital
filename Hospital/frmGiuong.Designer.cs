namespace Hospital
{
    partial class frmGiuong
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
            System.Windows.Forms.Label mAGIUONGLabel;
            System.Windows.Forms.Label sOGIUONGLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiuong));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnTHEM = new DevExpress.XtraBars.BarButtonItem();
            this.btnGHI = new DevExpress.XtraBars.BarButtonItem();
            this.btnXOA = new DevExpress.XtraBars.BarButtonItem();
            this.btnSUA = new DevExpress.XtraBars.BarButtonItem();
            this.btnRELOAD = new DevExpress.XtraBars.BarButtonItem();
            this.btnCANCEL = new DevExpress.XtraBars.BarButtonItem();
            this.btnTHOAT = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.qLBVDataSet = new Hospital.QLBVDataSet();
            this.bdsPhong = new System.Windows.Forms.BindingSource(this.components);
            this.pHONGTableAdapter = new Hospital.QLBVDataSetTableAdapters.PHONGTableAdapter();
            this.tableAdapterManager = new Hospital.QLBVDataSetTableAdapters.TableAdapterManager();
            this.gIUONGTableAdapter = new Hospital.QLBVDataSetTableAdapters.GIUONGTableAdapter();
            this.pHONGGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDANHDINHKHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcGiuong = new DevExpress.XtraEditors.PanelControl();
            this.txtSoGiuong = new System.Windows.Forms.TextBox();
            this.bdsGiuong = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaGiuong = new System.Windows.Forms.TextBox();
            this.gIUONGGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGIUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOGIUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAPHONG1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsChiTietO = new System.Windows.Forms.BindingSource(this.components);
            this.cHITIETOTableAdapter = new Hospital.QLBVDataSetTableAdapters.CHITIETOTableAdapter();
            mAGIUONGLabel = new System.Windows.Forms.Label();
            sOGIUONGLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcGiuong)).BeginInit();
            this.pcGiuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIUONGGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChiTietO)).BeginInit();
            this.SuspendLayout();
            // 
            // mAGIUONGLabel
            // 
            mAGIUONGLabel.AutoSize = true;
            mAGIUONGLabel.Location = new System.Drawing.Point(89, 102);
            mAGIUONGLabel.Name = "mAGIUONGLabel";
            mAGIUONGLabel.Size = new System.Drawing.Size(116, 19);
            mAGIUONGLabel.TabIndex = 0;
            mAGIUONGLabel.Text = "MÃ GIƯỜNG : ";
            // 
            // sOGIUONGLabel
            // 
            sOGIUONGLabel.AutoSize = true;
            sOGIUONGLabel.Location = new System.Drawing.Point(89, 159);
            sOGIUONGLabel.Name = "sOGIUONGLabel";
            sOGIUONGLabel.Size = new System.Drawing.Size(114, 19);
            sOGIUONGLabel.TabIndex = 4;
            sOGIUONGLabel.Text = "SỐ GIƯỜNG : ";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.btnTHEM,
            this.btnGHI,
            this.btnXOA,
            this.btnSUA,
            this.btnRELOAD,
            this.btnCANCEL,
            this.btnTHOAT});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 9;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTHEM, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGHI, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXOA, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSUA, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRELOAD, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCANCEL, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTHOAT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnTHEM
            // 
            this.btnTHEM.Caption = "THÊM GIƯỜNG";
            this.btnTHEM.Id = 2;
            this.btnTHEM.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTHEM.ImageOptions.Image")));
            this.btnTHEM.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTHEM.ImageOptions.LargeImage")));
            this.btnTHEM.Name = "btnTHEM";
            this.btnTHEM.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTHEM_ItemClick);
            // 
            // btnGHI
            // 
            this.btnGHI.Caption = "GHI";
            this.btnGHI.Enabled = false;
            this.btnGHI.Id = 3;
            this.btnGHI.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGHI.ImageOptions.Image")));
            this.btnGHI.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGHI.ImageOptions.LargeImage")));
            this.btnGHI.Name = "btnGHI";
            this.btnGHI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGHI_ItemClick);
            // 
            // btnXOA
            // 
            this.btnXOA.Caption = "XÓA";
            this.btnXOA.Id = 4;
            this.btnXOA.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXOA.ImageOptions.Image")));
            this.btnXOA.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXOA.ImageOptions.LargeImage")));
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXOA_ItemClick);
            // 
            // btnSUA
            // 
            this.btnSUA.Caption = "SỬA";
            this.btnSUA.Id = 5;
            this.btnSUA.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSUA.ImageOptions.Image")));
            this.btnSUA.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSUA.ImageOptions.LargeImage")));
            this.btnSUA.Name = "btnSUA";
            this.btnSUA.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSUA_ItemClick);
            // 
            // btnRELOAD
            // 
            this.btnRELOAD.Caption = "RELOAD";
            this.btnRELOAD.Id = 6;
            this.btnRELOAD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRELOAD.ImageOptions.Image")));
            this.btnRELOAD.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRELOAD.ImageOptions.LargeImage")));
            this.btnRELOAD.Name = "btnRELOAD";
            this.btnRELOAD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRELOAD_ItemClick);
            // 
            // btnCANCEL
            // 
            this.btnCANCEL.Caption = "CANCEL";
            this.btnCANCEL.Enabled = false;
            this.btnCANCEL.Id = 7;
            this.btnCANCEL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCANCEL.ImageOptions.Image")));
            this.btnCANCEL.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCANCEL.ImageOptions.LargeImage")));
            this.btnCANCEL.Name = "btnCANCEL";
            this.btnCANCEL.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCANCEL_ItemClick);
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.Caption = "THOÁT";
            this.btnTHOAT.Id = 8;
            this.btnTHOAT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTHOAT.ImageOptions.SvgImage")));
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTHOAT_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1277, 55);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 600);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1277, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 55);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 545);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1277, 55);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 545);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // qLBVDataSet
            // 
            this.qLBVDataSet.DataSetName = "QLBVDataSet";
            this.qLBVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsPhong
            // 
            this.bdsPhong.DataMember = "PHONG";
            this.bdsPhong.DataSource = this.qLBVDataSet;
            // 
            // pHONGTableAdapter
            // 
            this.pHONGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BENHNHANTableAdapter = null;
            this.tableAdapterManager.CHITIETCHUATRITableAdapter = null;
            this.tableAdapterManager.CHITIETGIOLAMVIECTableAdapter = null;
            this.tableAdapterManager.CHITIETLAMVIECKHUCHUATRITableAdapter = null;
            this.tableAdapterManager.CHITIETOTableAdapter = null;
            this.tableAdapterManager.CHITIETSUDUNGVTTableAdapter = null;
            this.tableAdapterManager.CHUCVUTableAdapter = null;
            this.tableAdapterManager.GIUONGTableAdapter = this.gIUONGTableAdapter;
            this.tableAdapterManager.KHUCHUATRITableAdapter = null;
            this.tableAdapterManager.LOAICHUATRITableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHONGTableAdapter = this.pHONGTableAdapter;
            this.tableAdapterManager.TUANTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Hospital.QLBVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VATTUTableAdapter = null;
            // 
            // gIUONGTableAdapter
            // 
            this.gIUONGTableAdapter.ClearBeforeFill = true;
            // 
            // pHONGGridControl
            // 
            this.pHONGGridControl.DataSource = this.bdsPhong;
            this.pHONGGridControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.pHONGGridControl.Location = new System.Drawing.Point(0, 0);
            this.pHONGGridControl.MainView = this.gridView1;
            this.pHONGGridControl.MenuManager = this.barManager1;
            this.pHONGGridControl.Name = "pHONGGridControl";
            this.pHONGGridControl.Size = new System.Drawing.Size(544, 315);
            this.pHONGGridControl.TabIndex = 6;
            this.pHONGGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPHONG,
            this.colSOPHONG,
            this.colDANHDINHKHU});
            this.gridView1.GridControl = this.pHONGGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMAPHONG
            // 
            this.colMAPHONG.Caption = "MÃ PHÒNG";
            this.colMAPHONG.FieldName = "MAPHONG";
            this.colMAPHONG.MinWidth = 30;
            this.colMAPHONG.Name = "colMAPHONG";
            this.colMAPHONG.OptionsColumn.AllowEdit = false;
            this.colMAPHONG.Visible = true;
            this.colMAPHONG.VisibleIndex = 0;
            this.colMAPHONG.Width = 112;
            // 
            // colSOPHONG
            // 
            this.colSOPHONG.Caption = "SỐ PHÒNG";
            this.colSOPHONG.FieldName = "SOPHONG";
            this.colSOPHONG.MinWidth = 30;
            this.colSOPHONG.Name = "colSOPHONG";
            this.colSOPHONG.OptionsColumn.AllowEdit = false;
            this.colSOPHONG.Visible = true;
            this.colSOPHONG.VisibleIndex = 1;
            this.colSOPHONG.Width = 112;
            // 
            // colDANHDINHKHU
            // 
            this.colDANHDINHKHU.Caption = "DANH ĐỊNH KHU";
            this.colDANHDINHKHU.FieldName = "DANHDINHKHU";
            this.colDANHDINHKHU.MinWidth = 30;
            this.colDANHDINHKHU.Name = "colDANHDINHKHU";
            this.colDANHDINHKHU.OptionsColumn.AllowEdit = false;
            this.colDANHDINHKHU.Visible = true;
            this.colDANHDINHKHU.VisibleIndex = 2;
            this.colDANHDINHKHU.Width = 112;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pcGiuong);
            this.panel1.Controls.Add(this.pHONGGridControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1277, 315);
            this.panel1.TabIndex = 7;
            // 
            // pcGiuong
            // 
            this.pcGiuong.Controls.Add(sOGIUONGLabel);
            this.pcGiuong.Controls.Add(this.txtSoGiuong);
            this.pcGiuong.Controls.Add(this.label2);
            this.pcGiuong.Controls.Add(this.label1);
            this.pcGiuong.Controls.Add(mAGIUONGLabel);
            this.pcGiuong.Controls.Add(this.txtMaGiuong);
            this.pcGiuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcGiuong.Location = new System.Drawing.Point(544, 0);
            this.pcGiuong.Name = "pcGiuong";
            this.pcGiuong.Size = new System.Drawing.Size(733, 315);
            this.pcGiuong.TabIndex = 7;
            // 
            // txtSoGiuong
            // 
            this.txtSoGiuong.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGiuong, "SOGIUONG", true));
            this.txtSoGiuong.Location = new System.Drawing.Point(215, 156);
            this.txtSoGiuong.Name = "txtSoGiuong";
            this.txtSoGiuong.Size = new System.Drawing.Size(135, 27);
            this.txtSoGiuong.TabIndex = 5;
            // 
            // bdsGiuong
            // 
            this.bdsGiuong.DataMember = "FK_GIUONG_PHONG";
            this.bdsGiuong.DataSource = this.bdsPhong;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "THÔNG TIN VỀ GIƯỜNG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 2;
            // 
            // txtMaGiuong
            // 
            this.txtMaGiuong.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGiuong, "MAGIUONG", true));
            this.txtMaGiuong.Location = new System.Drawing.Point(212, 99);
            this.txtMaGiuong.Name = "txtMaGiuong";
            this.txtMaGiuong.Size = new System.Drawing.Size(195, 27);
            this.txtMaGiuong.TabIndex = 1;
            // 
            // gIUONGGridControl
            // 
            this.gIUONGGridControl.DataSource = this.bdsGiuong;
            this.gIUONGGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gIUONGGridControl.Location = new System.Drawing.Point(0, 370);
            this.gIUONGGridControl.MainView = this.gridView2;
            this.gIUONGGridControl.MenuManager = this.barManager1;
            this.gIUONGGridControl.Name = "gIUONGGridControl";
            this.gIUONGGridControl.Size = new System.Drawing.Size(1277, 230);
            this.gIUONGGridControl.TabIndex = 6;
            this.gIUONGGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGIUONG,
            this.colSOGIUONG,
            this.colMAPHONG1});
            this.gridView2.GridControl = this.gIUONGGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // colMAGIUONG
            // 
            this.colMAGIUONG.Caption = "MÃ GIƯỜNG";
            this.colMAGIUONG.FieldName = "MAGIUONG";
            this.colMAGIUONG.MinWidth = 30;
            this.colMAGIUONG.Name = "colMAGIUONG";
            this.colMAGIUONG.OptionsColumn.AllowEdit = false;
            this.colMAGIUONG.Visible = true;
            this.colMAGIUONG.VisibleIndex = 0;
            this.colMAGIUONG.Width = 112;
            // 
            // colSOGIUONG
            // 
            this.colSOGIUONG.Caption = "SỐ GIƯỜNG";
            this.colSOGIUONG.FieldName = "SOGIUONG";
            this.colSOGIUONG.MinWidth = 30;
            this.colSOGIUONG.Name = "colSOGIUONG";
            this.colSOGIUONG.OptionsColumn.AllowEdit = false;
            this.colSOGIUONG.Visible = true;
            this.colSOGIUONG.VisibleIndex = 1;
            this.colSOGIUONG.Width = 112;
            // 
            // colMAPHONG1
            // 
            this.colMAPHONG1.Caption = "MÃ PHÒNG";
            this.colMAPHONG1.FieldName = "MAPHONG";
            this.colMAPHONG1.MinWidth = 30;
            this.colMAPHONG1.Name = "colMAPHONG1";
            this.colMAPHONG1.OptionsColumn.AllowEdit = false;
            this.colMAPHONG1.Visible = true;
            this.colMAPHONG1.VisibleIndex = 2;
            this.colMAPHONG1.Width = 112;
            // 
            // bdsChiTietO
            // 
            this.bdsChiTietO.DataMember = "FK_CHITIETO_GIUONG";
            this.bdsChiTietO.DataSource = this.bdsGiuong;
            // 
            // cHITIETOTableAdapter
            // 
            this.cHITIETOTableAdapter.ClearBeforeFill = true;
            // 
            // frmGiuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 620);
            this.Controls.Add(this.gIUONGGridControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmGiuong";
            this.Text = "frmGiuong";
            this.Load += new System.EventHandler(this.frmGiuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcGiuong)).EndInit();
            this.pcGiuong.ResumeLayout(false);
            this.pcGiuong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIUONGGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChiTietO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnTHEM;
        private DevExpress.XtraBars.BarButtonItem btnGHI;
        private DevExpress.XtraBars.BarButtonItem btnXOA;
        private DevExpress.XtraBars.BarButtonItem btnSUA;
        private DevExpress.XtraBars.BarButtonItem btnRELOAD;
        private DevExpress.XtraBars.BarButtonItem btnCANCEL;
        private DevExpress.XtraBars.BarButtonItem btnTHOAT;
        private System.Windows.Forms.BindingSource bdsPhong;
        private QLBVDataSet qLBVDataSet;
        private QLBVDataSetTableAdapters.PHONGTableAdapter pHONGTableAdapter;
        private QLBVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl pHONGGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private QLBVDataSetTableAdapters.GIUONGTableAdapter gIUONGTableAdapter;
        private System.Windows.Forms.BindingSource bdsGiuong;
        private DevExpress.XtraGrid.GridControl gIUONGGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.PanelControl pcGiuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaGiuong;
        private System.Windows.Forms.TextBox txtSoGiuong;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGIUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colSOGIUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPHONG1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn colSOPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDANHDINHKHU;
        private System.Windows.Forms.BindingSource bdsChiTietO;
        private QLBVDataSetTableAdapters.CHITIETOTableAdapter cHITIETOTableAdapter;
    }
}