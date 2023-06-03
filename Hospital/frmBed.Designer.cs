
namespace Hospital
{
    partial class frmBed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBed));
            this.qLBVDataSet = new Hospital.QLBVDataSet();
            this.gET_ROOMSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gET_ROOMSTableAdapter = new Hospital.QLBVDataSetTableAdapters.GET_ROOMSTableAdapter();
            this.tableAdapterManager = new Hospital.QLBVDataSetTableAdapters.TableAdapterManager();
            this.gET_ROOMSGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDANHDINHKHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBedNumber = new DevExpress.XtraEditors.SpinEdit();
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtBedId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRoomId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gET_BEDS_BASE_ON_ROOMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gET_BEDS_BASE_ON_ROOMTableAdapter = new Hospital.QLBVDataSetTableAdapters.GET_BEDS_BASE_ON_ROOMTableAdapter();
            this.gET_BEDS_BASE_ON_ROOMGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGIUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOGIUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAPHONG1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.qLBVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_ROOMSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_ROOMSGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBedNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_BEDS_BASE_ON_ROOMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_BEDS_BASE_ON_ROOMGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // qLBVDataSet
            // 
            this.qLBVDataSet.DataSetName = "QLBVDataSet";
            this.qLBVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gET_ROOMSBindingSource
            // 
            this.gET_ROOMSBindingSource.DataMember = "GET_ROOMS";
            this.gET_ROOMSBindingSource.DataSource = this.qLBVDataSet;
            // 
            // gET_ROOMSTableAdapter
            // 
            this.gET_ROOMSTableAdapter.ClearBeforeFill = true;
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
            // gET_ROOMSGridControl
            // 
            this.gET_ROOMSGridControl.DataSource = this.gET_ROOMSBindingSource;
            this.gET_ROOMSGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.gET_ROOMSGridControl.Location = new System.Drawing.Point(0, 34);
            this.gET_ROOMSGridControl.MainView = this.gridView1;
            this.gET_ROOMSGridControl.Name = "gET_ROOMSGridControl";
            this.gET_ROOMSGridControl.Size = new System.Drawing.Size(1074, 298);
            this.gET_ROOMSGridControl.TabIndex = 1;
            this.gET_ROOMSGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gET_ROOMSGridControl.Click += new System.EventHandler(this.gET_ROOMSGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPHONG,
            this.colSOPHONG,
            this.colTENKHU,
            this.colDANHDINHKHU});
            this.gridView1.GridControl = this.gET_ROOMSGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMAPHONG
            // 
            this.colMAPHONG.Caption = "Mã phòng";
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
            this.colSOPHONG.Caption = "Số phòng";
            this.colSOPHONG.FieldName = "SOPHONG";
            this.colSOPHONG.MinWidth = 30;
            this.colSOPHONG.Name = "colSOPHONG";
            this.colSOPHONG.OptionsColumn.AllowEdit = false;
            this.colSOPHONG.Visible = true;
            this.colSOPHONG.VisibleIndex = 1;
            this.colSOPHONG.Width = 112;
            // 
            // colTENKHU
            // 
            this.colTENKHU.Caption = "Tên khu";
            this.colTENKHU.FieldName = "TENKHU";
            this.colTENKHU.MinWidth = 30;
            this.colTENKHU.Name = "colTENKHU";
            this.colTENKHU.OptionsColumn.AllowEdit = false;
            this.colTENKHU.Visible = true;
            this.colTENKHU.VisibleIndex = 2;
            this.colTENKHU.Width = 112;
            // 
            // colDANHDINHKHU
            // 
            this.colDANHDINHKHU.Caption = "Danh định khu";
            this.colDANHDINHKHU.FieldName = "DANHDINHKHU";
            this.colDANHDINHKHU.MinWidth = 30;
            this.colDANHDINHKHU.Name = "colDANHDINHKHU";
            this.colDANHDINHKHU.OptionsColumn.AllowEdit = false;
            this.colDANHDINHKHU.Visible = true;
            this.colDANHDINHKHU.VisibleIndex = 3;
            this.colDANHDINHKHU.Width = 112;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBedNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBedId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtRoomId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 332);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 332);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập liệu";
            // 
            // txtBedNumber
            // 
            this.txtBedNumber.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtBedNumber.Location = new System.Drawing.Point(146, 208);
            this.txtBedNumber.MenuManager = this.barManager1;
            this.txtBedNumber.Name = "txtBedNumber";
            this.txtBedNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtBedNumber.Size = new System.Drawing.Size(202, 28);
            this.txtBedNumber.TabIndex = 5;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1074, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 664);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1074, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 630);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1074, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 630);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số giường:";
            // 
            // txtBedId
            // 
            this.txtBedId.Location = new System.Drawing.Point(146, 130);
            this.txtBedId.MaxLength = 5;
            this.txtBedId.Name = "txtBedId";
            this.txtBedId.Size = new System.Drawing.Size(202, 27);
            this.txtBedId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã giường:";
            // 
            // txtRoomId
            // 
            this.txtRoomId.Location = new System.Drawing.Point(146, 54);
            this.txtRoomId.Name = "txtRoomId";
            this.txtRoomId.ReadOnly = true;
            this.txtRoomId.Size = new System.Drawing.Size(202, 27);
            this.txtRoomId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phòng:";
            // 
            // gET_BEDS_BASE_ON_ROOMBindingSource
            // 
            this.gET_BEDS_BASE_ON_ROOMBindingSource.DataMember = "GET_BEDS_BASE_ON_ROOM";
            this.gET_BEDS_BASE_ON_ROOMBindingSource.DataSource = this.qLBVDataSet;
            // 
            // gET_BEDS_BASE_ON_ROOMTableAdapter
            // 
            this.gET_BEDS_BASE_ON_ROOMTableAdapter.ClearBeforeFill = true;
            // 
            // gET_BEDS_BASE_ON_ROOMGridControl
            // 
            this.gET_BEDS_BASE_ON_ROOMGridControl.DataSource = this.gET_BEDS_BASE_ON_ROOMBindingSource;
            this.gET_BEDS_BASE_ON_ROOMGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gET_BEDS_BASE_ON_ROOMGridControl.Location = new System.Drawing.Point(407, 332);
            this.gET_BEDS_BASE_ON_ROOMGridControl.MainView = this.gridView2;
            this.gET_BEDS_BASE_ON_ROOMGridControl.Name = "gET_BEDS_BASE_ON_ROOMGridControl";
            this.gET_BEDS_BASE_ON_ROOMGridControl.Size = new System.Drawing.Size(667, 332);
            this.gET_BEDS_BASE_ON_ROOMGridControl.TabIndex = 3;
            this.gET_BEDS_BASE_ON_ROOMGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gET_BEDS_BASE_ON_ROOMGridControl.Click += new System.EventHandler(this.gET_BEDS_BASE_ON_ROOMGridControl_Click);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGIUONG,
            this.colSOGIUONG,
            this.colMAPHONG1});
            this.gridView2.GridControl = this.gET_BEDS_BASE_ON_ROOMGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // colMAGIUONG
            // 
            this.colMAGIUONG.Caption = "Mã giường";
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
            this.colSOGIUONG.Caption = "Số giường";
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
            this.colMAPHONG1.Caption = "Mã phòng";
            this.colMAPHONG1.FieldName = "MAPHONG";
            this.colMAPHONG1.MinWidth = 30;
            this.colMAPHONG1.Name = "colMAPHONG1";
            this.colMAPHONG1.OptionsColumn.AllowEdit = false;
            this.colMAPHONG1.Visible = true;
            this.colMAPHONG1.VisibleIndex = 2;
            this.colMAPHONG1.Width = 112;
            // 
            // frmBed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 664);
            this.Controls.Add(this.gET_BEDS_BASE_ON_ROOMGridControl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gET_ROOMSGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmBed";
            this.Text = "Giường bệnh";
            this.Load += new System.EventHandler(this.frmBed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLBVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_ROOMSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_ROOMSGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBedNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_BEDS_BASE_ON_ROOMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_BEDS_BASE_ON_ROOMGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLBVDataSet qLBVDataSet;
        private System.Windows.Forms.BindingSource gET_ROOMSBindingSource;
        private QLBVDataSetTableAdapters.GET_ROOMSTableAdapter gET_ROOMSTableAdapter;
        private QLBVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gET_ROOMSGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn colSOPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKHU;
        private DevExpress.XtraGrid.Columns.GridColumn colDANHDINHKHU;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource gET_BEDS_BASE_ON_ROOMBindingSource;
        private QLBVDataSetTableAdapters.GET_BEDS_BASE_ON_ROOMTableAdapter gET_BEDS_BASE_ON_ROOMTableAdapter;
        private DevExpress.XtraGrid.GridControl gET_BEDS_BASE_ON_ROOMGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGIUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colSOGIUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPHONG1;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBedId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRoomId;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SpinEdit txtBedNumber;
    }
}