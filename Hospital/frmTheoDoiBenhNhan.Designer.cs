namespace Hospital
{
    partial class frmTheoDoiBenhNhan
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
            System.Windows.Forms.Label mABNLabel;
            System.Windows.Forms.Label hOLabel1;
            System.Windows.Forms.Label tENLabel1;
            System.Windows.Forms.Label mABSTDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTheoDoiBenhNhan));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnTHEM = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnLAMMOI = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnGHI = new DevExpress.XtraBars.BarButtonItem();
            this.btnSUA = new DevExpress.XtraBars.BarButtonItem();
            this.btnCANCEL = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.QLBVDataSet = new Hospital.QLBVDataSet();
            this.tableAdapterManager = new Hospital.QLBVDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.gET_FULL_DOCTORSGridControl = new DevExpress.XtraGrid.GridControl();
            this.gET_FULL_DOCTORSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIENTHOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sP_BENHNHAN_KHONG_THEO_DOIGridControl = new DevExpress.XtraGrid.GridControl();
            this.sP_BENHNHAN_KHONG_THEO_DOIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMABN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsBenhNhanCoBS = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelNhapLieu = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gET_PATIENT_HAVE_STALK_DOCTORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaBacSiTheoDoi = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtMaBenhNhan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nHANVIENTableAdapter = new Hospital.QLBVDataSetTableAdapters.NHANVIENTableAdapter();
            this.bENHNHANTableAdapter = new Hospital.QLBVDataSetTableAdapters.BENHNHANTableAdapter();
            this.sP_BENHNHAN_KHONG_THEO_DOITableAdapter = new Hospital.QLBVDataSetTableAdapters.SP_BENHNHAN_KHONG_THEO_DOITableAdapter();
            this.btnXOA = new DevExpress.XtraBars.BarButtonItem();
            this.gET_FULL_DOCTORSTableAdapter = new Hospital.QLBVDataSetTableAdapters.GET_FULL_DOCTORSTableAdapter();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gET_PATIENT_HAVE_STALK_DOCTORTableAdapter = new Hospital.QLBVDataSetTableAdapters.GET_PATIENT_HAVE_STALK_DOCTORTableAdapter();
            this.gET_PATIENT_HAVE_STALK_DOCTORGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMABN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOAI1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBACSITHEODOI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBACSITIEPNHAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMABSTD1 = new DevExpress.XtraGrid.Columns.GridColumn();
            mABNLabel = new System.Windows.Forms.Label();
            hOLabel1 = new System.Windows.Forms.Label();
            tENLabel1 = new System.Windows.Forms.Label();
            mABSTDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLBVDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gET_FULL_DOCTORSGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_FULL_DOCTORSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_BENHNHAN_KHONG_THEO_DOIGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_BENHNHAN_KHONG_THEO_DOIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBenhNhanCoBS)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gET_PATIENT_HAVE_STALK_DOCTORBindingSource)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gET_PATIENT_HAVE_STALK_DOCTORGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // mABNLabel
            // 
            mABNLabel.AutoSize = true;
            mABNLabel.Location = new System.Drawing.Point(32, 105);
            mABNLabel.Name = "mABNLabel";
            mABNLabel.Size = new System.Drawing.Size(115, 19);
            mABNLabel.TabIndex = 10;
            mABNLabel.Text = "Mã bệnh nhân:";
            // 
            // hOLabel1
            // 
            hOLabel1.AutoSize = true;
            hOLabel1.Location = new System.Drawing.Point(35, 176);
            hOLabel1.Name = "hOLabel1";
            hOLabel1.Size = new System.Drawing.Size(35, 19);
            hOLabel1.TabIndex = 12;
            hOLabel1.Text = "Họ:";
            // 
            // tENLabel1
            // 
            tENLabel1.AutoSize = true;
            tENLabel1.Location = new System.Drawing.Point(324, 179);
            tENLabel1.Name = "tENLabel1";
            tENLabel1.Size = new System.Drawing.Size(42, 19);
            tENLabel1.TabIndex = 14;
            tENLabel1.Text = "Tên:";
            // 
            // mABSTDLabel
            // 
            mABSTDLabel.AutoSize = true;
            mABSTDLabel.Location = new System.Drawing.Point(29, 245);
            mABSTDLabel.Name = "mABSTDLabel";
            mABSTDLabel.Size = new System.Drawing.Size(118, 19);
            mABSTDLabel.TabIndex = 16;
            mABSTDLabel.Text = "Bác sĩ theo dõi:";
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
            this.btnTHEM,
            this.btnGHI,
            this.btnSUA,
            this.btnCANCEL,
            this.barButtonItem5,
            this.btnLAMMOI,
            this.btnDelete});
            this.barManager1.MaxItemId = 11;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTHEM, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLAMMOI, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnTHEM
            // 
            this.btnTHEM.Caption = "Đăng kí theo dõi";
            this.btnTHEM.Id = 0;
            this.btnTHEM.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTHEM.ImageOptions.Image")));
            this.btnTHEM.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTHEM.ImageOptions.LargeImage")));
            this.btnTHEM.Name = "btnTHEM";
            this.btnTHEM.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTHEM_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Hủy đăng kí theo dõi";
            this.btnDelete.Id = 8;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.LargeImage")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // btnLAMMOI
            // 
            this.btnLAMMOI.Caption = "Reload";
            this.btnLAMMOI.Id = 7;
            this.btnLAMMOI.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLAMMOI.ImageOptions.Image")));
            this.btnLAMMOI.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLAMMOI.ImageOptions.LargeImage")));
            this.btnLAMMOI.Name = "btnLAMMOI";
            this.btnLAMMOI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLAMMOI_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1312, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 866);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1312, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 832);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1312, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 832);
            // 
            // btnGHI
            // 
            this.btnGHI.Id = 9;
            this.btnGHI.Name = "btnGHI";
            // 
            // btnSUA
            // 
            this.btnSUA.Id = 10;
            this.btnSUA.Name = "btnSUA";
            // 
            // btnCANCEL
            // 
            this.btnCANCEL.Caption = "CANCEL";
            this.btnCANCEL.Id = 4;
            this.btnCANCEL.Name = "btnCANCEL";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "THOÁT";
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // QLBVDataSet
            // 
            this.QLBVDataSet.DataSetName = "QLBVDataSet";
            this.QLBVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.sP_BENHNHAN_KHONG_THEO_DOIGridControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1312, 315);
            this.panel1.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.gET_FULL_DOCTORSGridControl);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(777, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(535, 315);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(509, 51);
            this.panel3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(180, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "DANH SÁCH BÁC SĨ";
            // 
            // gET_FULL_DOCTORSGridControl
            // 
            this.gET_FULL_DOCTORSGridControl.DataSource = this.gET_FULL_DOCTORSBindingSource;
            this.gET_FULL_DOCTORSGridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gET_FULL_DOCTORSGridControl.Location = new System.Drawing.Point(0, 51);
            this.gET_FULL_DOCTORSGridControl.MainView = this.gridView1;
            this.gET_FULL_DOCTORSGridControl.MenuManager = this.barManager1;
            this.gET_FULL_DOCTORSGridControl.Name = "gET_FULL_DOCTORSGridControl";
            this.gET_FULL_DOCTORSGridControl.Size = new System.Drawing.Size(509, 268);
            this.gET_FULL_DOCTORSGridControl.TabIndex = 0;
            this.gET_FULL_DOCTORSGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gET_FULL_DOCTORSBindingSource
            // 
            this.gET_FULL_DOCTORSBindingSource.DataMember = "GET_FULL_DOCTORS";
            this.gET_FULL_DOCTORSBindingSource.DataSource = this.QLBVDataSet;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO1,
            this.colTEN1,
            this.colDIENTHOAI,
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
            // colHO1
            // 
            this.colHO1.Caption = "Họ";
            this.colHO1.FieldName = "HO";
            this.colHO1.MinWidth = 30;
            this.colHO1.Name = "colHO1";
            this.colHO1.OptionsColumn.AllowEdit = false;
            this.colHO1.Visible = true;
            this.colHO1.VisibleIndex = 1;
            this.colHO1.Width = 112;
            // 
            // colTEN1
            // 
            this.colTEN1.Caption = "Tên";
            this.colTEN1.FieldName = "TEN";
            this.colTEN1.MinWidth = 30;
            this.colTEN1.Name = "colTEN1";
            this.colTEN1.OptionsColumn.AllowEdit = false;
            this.colTEN1.Visible = true;
            this.colTEN1.VisibleIndex = 2;
            this.colTEN1.Width = 112;
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
            this.colDIENTHOAI.Width = 112;
            // 
            // colTRINHDO
            // 
            this.colTRINHDO.Caption = "Trình độ";
            this.colTRINHDO.FieldName = "TRINHDO";
            this.colTRINHDO.MinWidth = 30;
            this.colTRINHDO.Name = "colTRINHDO";
            this.colTRINHDO.OptionsColumn.AllowEdit = false;
            this.colTRINHDO.Visible = true;
            this.colTRINHDO.VisibleIndex = 4;
            this.colTRINHDO.Width = 112;
            // 
            // sP_BENHNHAN_KHONG_THEO_DOIGridControl
            // 
            this.sP_BENHNHAN_KHONG_THEO_DOIGridControl.DataSource = this.sP_BENHNHAN_KHONG_THEO_DOIBindingSource;
            this.sP_BENHNHAN_KHONG_THEO_DOIGridControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.sP_BENHNHAN_KHONG_THEO_DOIGridControl.Location = new System.Drawing.Point(0, 0);
            this.sP_BENHNHAN_KHONG_THEO_DOIGridControl.MainView = this.gridView3;
            this.sP_BENHNHAN_KHONG_THEO_DOIGridControl.MenuManager = this.barManager1;
            this.sP_BENHNHAN_KHONG_THEO_DOIGridControl.Name = "sP_BENHNHAN_KHONG_THEO_DOIGridControl";
            this.sP_BENHNHAN_KHONG_THEO_DOIGridControl.Size = new System.Drawing.Size(777, 315);
            this.sP_BENHNHAN_KHONG_THEO_DOIGridControl.TabIndex = 1;
            this.sP_BENHNHAN_KHONG_THEO_DOIGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            this.sP_BENHNHAN_KHONG_THEO_DOIGridControl.Click += new System.EventHandler(this.sP_BENHNHAN_KHONG_THEO_DOIGridControl_Click);
            // 
            // sP_BENHNHAN_KHONG_THEO_DOIBindingSource
            // 
            this.sP_BENHNHAN_KHONG_THEO_DOIBindingSource.DataMember = "SP_BENHNHAN_KHONG_THEO_DOI";
            this.sP_BENHNHAN_KHONG_THEO_DOIBindingSource.DataSource = this.QLBVDataSet;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMABN,
            this.colHO,
            this.colTEN,
            this.colNGAYSINH,
            this.colLOAI});
            this.gridView3.GridControl = this.sP_BENHNHAN_KHONG_THEO_DOIGridControl;
            this.gridView3.Name = "gridView3";
            this.gridView3.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colLOAI, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colMABN
            // 
            this.colMABN.Caption = "Mã bệnh nhân";
            this.colMABN.FieldName = "MABN";
            this.colMABN.MinWidth = 30;
            this.colMABN.Name = "colMABN";
            this.colMABN.OptionsColumn.AllowEdit = false;
            this.colMABN.Visible = true;
            this.colMABN.VisibleIndex = 0;
            this.colMABN.Width = 183;
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
            this.colHO.Width = 183;
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
            this.colTEN.Width = 183;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.Caption = "Ngày sinh";
            this.colNGAYSINH.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNGAYSINH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.MinWidth = 30;
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.OptionsColumn.AllowEdit = false;
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 3;
            this.colNGAYSINH.Width = 183;
            // 
            // colLOAI
            // 
            this.colLOAI.Caption = "Loại";
            this.colLOAI.FieldName = "LOAI";
            this.colLOAI.MinWidth = 30;
            this.colLOAI.Name = "colLOAI";
            this.colLOAI.OptionsColumn.AllowEdit = false;
            this.colLOAI.Visible = true;
            this.colLOAI.VisibleIndex = 4;
            this.colLOAI.Width = 116;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelNhapLieu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 349);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(515, 517);
            this.panel2.TabIndex = 16;
            // 
            // panelNhapLieu
            // 
            this.panelNhapLieu.Controls.Add(this.textBox1);
            this.panelNhapLieu.Controls.Add(mABSTDLabel);
            this.panelNhapLieu.Controls.Add(this.txtMaBacSiTheoDoi);
            this.panelNhapLieu.Controls.Add(tENLabel1);
            this.panelNhapLieu.Controls.Add(this.txtLastname);
            this.panelNhapLieu.Controls.Add(hOLabel1);
            this.panelNhapLieu.Controls.Add(this.txtFirstname);
            this.panelNhapLieu.Controls.Add(mABNLabel);
            this.panelNhapLieu.Controls.Add(this.txtMaBenhNhan);
            this.panelNhapLieu.Controls.Add(this.label2);
            this.panelNhapLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNhapLieu.Enabled = false;
            this.panelNhapLieu.Location = new System.Drawing.Point(0, 0);
            this.panelNhapLieu.Name = "panelNhapLieu";
            this.panelNhapLieu.Size = new System.Drawing.Size(515, 517);
            this.panelNhapLieu.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gET_PATIENT_HAVE_STALK_DOCTORBindingSource, "MABSTD", true));
            this.textBox1.Location = new System.Drawing.Point(354, 245);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 27);
            this.textBox1.TabIndex = 18;
            // 
            // gET_PATIENT_HAVE_STALK_DOCTORBindingSource
            // 
            this.gET_PATIENT_HAVE_STALK_DOCTORBindingSource.DataMember = "GET_PATIENT_HAVE_STALK_DOCTOR";
            this.gET_PATIENT_HAVE_STALK_DOCTORBindingSource.DataSource = this.QLBVDataSet;
            // 
            // txtMaBacSiTheoDoi
            // 
            this.txtMaBacSiTheoDoi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gET_PATIENT_HAVE_STALK_DOCTORBindingSource, "BACSITHEODOI", true));
            this.txtMaBacSiTheoDoi.Location = new System.Drawing.Point(153, 242);
            this.txtMaBacSiTheoDoi.Name = "txtMaBacSiTheoDoi";
            this.txtMaBacSiTheoDoi.Size = new System.Drawing.Size(179, 27);
            this.txtMaBacSiTheoDoi.TabIndex = 17;
            // 
            // txtLastname
            // 
            this.txtLastname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gET_PATIENT_HAVE_STALK_DOCTORBindingSource, "TEN", true));
            this.txtLastname.Location = new System.Drawing.Point(372, 176);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(121, 27);
            this.txtLastname.TabIndex = 15;
            // 
            // txtFirstname
            // 
            this.txtFirstname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gET_PATIENT_HAVE_STALK_DOCTORBindingSource, "HO", true));
            this.txtFirstname.Location = new System.Drawing.Point(153, 173);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(152, 27);
            this.txtFirstname.TabIndex = 13;
            // 
            // txtMaBenhNhan
            // 
            this.txtMaBenhNhan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gET_PATIENT_HAVE_STALK_DOCTORBindingSource, "MABN", true));
            this.txtMaBenhNhan.Location = new System.Drawing.Point(153, 102);
            this.txtMaBenhNhan.Name = "txtMaBenhNhan";
            this.txtMaBenhNhan.Size = new System.Drawing.Size(110, 27);
            this.txtMaBenhNhan.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "THÔNG TIN VỀ BỆNH NHÂN";
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // bENHNHANTableAdapter
            // 
            this.bENHNHANTableAdapter.ClearBeforeFill = true;
            // 
            // sP_BENHNHAN_KHONG_THEO_DOITableAdapter
            // 
            this.sP_BENHNHAN_KHONG_THEO_DOITableAdapter.ClearBeforeFill = true;
            // 
            // btnXOA
            // 
            this.btnXOA.Name = "btnXOA";
            // 
            // gET_FULL_DOCTORSTableAdapter
            // 
            this.gET_FULL_DOCTORSTableAdapter.ClearBeforeFill = true;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(515, 349);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(797, 57);
            this.panel5.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(271, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH BỆNH NHÂN ĐƯỢC THEO DÕI";
            // 
            // gET_PATIENT_HAVE_STALK_DOCTORTableAdapter
            // 
            this.gET_PATIENT_HAVE_STALK_DOCTORTableAdapter.ClearBeforeFill = true;
            // 
            // gET_PATIENT_HAVE_STALK_DOCTORGridControl
            // 
            this.gET_PATIENT_HAVE_STALK_DOCTORGridControl.DataSource = this.gET_PATIENT_HAVE_STALK_DOCTORBindingSource;
            this.gET_PATIENT_HAVE_STALK_DOCTORGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gET_PATIENT_HAVE_STALK_DOCTORGridControl.Location = new System.Drawing.Point(515, 406);
            this.gET_PATIENT_HAVE_STALK_DOCTORGridControl.MainView = this.gridView2;
            this.gET_PATIENT_HAVE_STALK_DOCTORGridControl.MenuManager = this.barManager1;
            this.gET_PATIENT_HAVE_STALK_DOCTORGridControl.Name = "gET_PATIENT_HAVE_STALK_DOCTORGridControl";
            this.gET_PATIENT_HAVE_STALK_DOCTORGridControl.Size = new System.Drawing.Size(797, 460);
            this.gET_PATIENT_HAVE_STALK_DOCTORGridControl.TabIndex = 29;
            this.gET_PATIENT_HAVE_STALK_DOCTORGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gET_PATIENT_HAVE_STALK_DOCTORGridControl.Click += new System.EventHandler(this.gET_PATIENT_HAVE_STALK_DOCTORGridControl_Click);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMABN1,
            this.colHO2,
            this.colTEN2,
            this.colNGAYSINH1,
            this.colLOAI1,
            this.colBACSITHEODOI,
            this.colBACSITIEPNHAN,
            this.colMABSTD1});
            this.gridView2.GridControl = this.gET_PATIENT_HAVE_STALK_DOCTORGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // colMABN1
            // 
            this.colMABN1.Caption = "Mã bệnh nhân";
            this.colMABN1.FieldName = "MABN";
            this.colMABN1.MinWidth = 30;
            this.colMABN1.Name = "colMABN1";
            this.colMABN1.OptionsColumn.AllowEdit = false;
            this.colMABN1.Visible = true;
            this.colMABN1.VisibleIndex = 0;
            this.colMABN1.Width = 112;
            // 
            // colHO2
            // 
            this.colHO2.Caption = "Họ";
            this.colHO2.FieldName = "HO";
            this.colHO2.MinWidth = 30;
            this.colHO2.Name = "colHO2";
            this.colHO2.OptionsColumn.AllowEdit = false;
            this.colHO2.Visible = true;
            this.colHO2.VisibleIndex = 1;
            this.colHO2.Width = 112;
            // 
            // colTEN2
            // 
            this.colTEN2.Caption = "Tên";
            this.colTEN2.FieldName = "TEN";
            this.colTEN2.MinWidth = 30;
            this.colTEN2.Name = "colTEN2";
            this.colTEN2.OptionsColumn.AllowEdit = false;
            this.colTEN2.Visible = true;
            this.colTEN2.VisibleIndex = 2;
            this.colTEN2.Width = 112;
            // 
            // colNGAYSINH1
            // 
            this.colNGAYSINH1.Caption = "Ngày sinh";
            this.colNGAYSINH1.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNGAYSINH1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYSINH1.FieldName = "NGAYSINH";
            this.colNGAYSINH1.MinWidth = 30;
            this.colNGAYSINH1.Name = "colNGAYSINH1";
            this.colNGAYSINH1.OptionsColumn.AllowEdit = false;
            this.colNGAYSINH1.Visible = true;
            this.colNGAYSINH1.VisibleIndex = 3;
            this.colNGAYSINH1.Width = 112;
            // 
            // colLOAI1
            // 
            this.colLOAI1.Caption = "Loại";
            this.colLOAI1.FieldName = "LOAI";
            this.colLOAI1.MinWidth = 30;
            this.colLOAI1.Name = "colLOAI1";
            this.colLOAI1.OptionsColumn.AllowEdit = false;
            this.colLOAI1.Visible = true;
            this.colLOAI1.VisibleIndex = 4;
            this.colLOAI1.Width = 112;
            // 
            // colBACSITHEODOI
            // 
            this.colBACSITHEODOI.Caption = "Bác sĩ theo dõi";
            this.colBACSITHEODOI.FieldName = "BACSITHEODOI";
            this.colBACSITHEODOI.MinWidth = 30;
            this.colBACSITHEODOI.Name = "colBACSITHEODOI";
            this.colBACSITHEODOI.OptionsColumn.AllowEdit = false;
            this.colBACSITHEODOI.Visible = true;
            this.colBACSITHEODOI.VisibleIndex = 5;
            this.colBACSITHEODOI.Width = 112;
            // 
            // colBACSITIEPNHAN
            // 
            this.colBACSITIEPNHAN.Caption = "Bác sĩ tiếp nhận";
            this.colBACSITIEPNHAN.FieldName = "BACSITIEPNHAN";
            this.colBACSITIEPNHAN.MinWidth = 30;
            this.colBACSITIEPNHAN.Name = "colBACSITIEPNHAN";
            this.colBACSITIEPNHAN.OptionsColumn.AllowEdit = false;
            this.colBACSITIEPNHAN.Visible = true;
            this.colBACSITIEPNHAN.VisibleIndex = 6;
            this.colBACSITIEPNHAN.Width = 112;
            // 
            // colMABSTD1
            // 
            this.colMABSTD1.Caption = "Mã bác sĩ theo dõi";
            this.colMABSTD1.FieldName = "MABSTD";
            this.colMABSTD1.MinWidth = 30;
            this.colMABSTD1.Name = "colMABSTD1";
            this.colMABSTD1.OptionsColumn.AllowEdit = false;
            this.colMABSTD1.Width = 112;
            // 
            // frmTheoDoiBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 866);
            this.Controls.Add(this.gET_PATIENT_HAVE_STALK_DOCTORGridControl);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmTheoDoiBenhNhan";
            this.Text = "Đăng kí theo dõi bệnh nhân";
            this.Load += new System.EventHandler(this.frmTheoDoiBenhNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLBVDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gET_FULL_DOCTORSGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_FULL_DOCTORSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_BENHNHAN_KHONG_THEO_DOIGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_BENHNHAN_KHONG_THEO_DOIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBenhNhanCoBS)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelNhapLieu.ResumeLayout(false);
            this.panelNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gET_PATIENT_HAVE_STALK_DOCTORBindingSource)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gET_PATIENT_HAVE_STALK_DOCTORGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnTHEM;
        private DevExpress.XtraBars.BarButtonItem btnGHI;
        private DevExpress.XtraBars.BarButtonItem btnSUA;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private QLBVDataSet QLBVDataSet;
        private QLBVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
       // private QLBVDataSetTableAdapters.SP_BACSITableAdapter sP_BACSITableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelNhapLieu;
        private QLBVDataSetTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private System.Windows.Forms.BindingSource bdsBenhNhanCoBS;
        private QLBVDataSetTableAdapters.BENHNHANTableAdapter bENHNHANTableAdapter;
        private System.Windows.Forms.BindingSource sP_BENHNHAN_KHONG_THEO_DOIBindingSource;
        private QLBVDataSetTableAdapters.SP_BENHNHAN_KHONG_THEO_DOITableAdapter sP_BENHNHAN_KHONG_THEO_DOITableAdapter;
        private DevExpress.XtraGrid.GridControl sP_BENHNHAN_KHONG_THEO_DOIGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaBacSiTheoDoi;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtMaBenhNhan;
        private DevExpress.XtraBars.BarButtonItem btnCANCEL;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem btnLAMMOI;
        private DevExpress.XtraGrid.Columns.GridColumn colMABN;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colLOAI;
        private DevExpress.XtraBars.BarButtonItem btnXOA;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.BindingSource gET_FULL_DOCTORSBindingSource;
        private QLBVDataSetTableAdapters.GET_FULL_DOCTORSTableAdapter gET_FULL_DOCTORSTableAdapter;
        private DevExpress.XtraGrid.GridControl gET_FULL_DOCTORSGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO1;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN1;
        private DevExpress.XtraGrid.Columns.GridColumn colDIENTHOAI;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource gET_PATIENT_HAVE_STALK_DOCTORBindingSource;
        private QLBVDataSetTableAdapters.GET_PATIENT_HAVE_STALK_DOCTORTableAdapter gET_PATIENT_HAVE_STALK_DOCTORTableAdapter;
        private DevExpress.XtraGrid.GridControl gET_PATIENT_HAVE_STALK_DOCTORGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMABN1;
        private DevExpress.XtraGrid.Columns.GridColumn colHO2;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN2;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH1;
        private DevExpress.XtraGrid.Columns.GridColumn colLOAI1;
        private DevExpress.XtraGrid.Columns.GridColumn colBACSITHEODOI;
        private DevExpress.XtraGrid.Columns.GridColumn colBACSITIEPNHAN;
        private DevExpress.XtraGrid.Columns.GridColumn colMABSTD1;
        private System.Windows.Forms.TextBox textBox1;
    }
}