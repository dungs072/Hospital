
namespace Hospital
{
    partial class frmRoomAndArea
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
            System.Windows.Forms.Label dANHDINHKHULabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label mAPHONGLabel;
            System.Windows.Forms.Label sOPHONGLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoomAndArea));
            this.qLBVDataSet = new Hospital.QLBVDataSet();
            this.kHUCHUATRIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHUCHUATRITableAdapter = new Hospital.QLBVDataSetTableAdapters.KHUCHUATRITableAdapter();
            this.tableAdapterManager = new Hospital.QLBVDataSetTableAdapters.TableAdapterManager();
            this.pHONGTableAdapter = new Hospital.QLBVDataSetTableAdapters.PHONGTableAdapter();
            this.kHUCHUATRIGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDANHDINHKHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRoomNumber = new DevExpress.XtraEditors.SpinEdit();
            this.pHONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtRoomId = new System.Windows.Forms.TextBox();
            this.txtAreaName = new System.Windows.Forms.TextBox();
            this.txtAreaId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pHONGGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDANHDINHKHU1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAddRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdateRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.btnWriteRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancelRoom = new System.Windows.Forms.ToolStripMenuItem();
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
            this.cHITIETLAMVIECKHUCHUATRIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHITIETLAMVIECKHUCHUATRITableAdapter = new Hospital.QLBVDataSetTableAdapters.CHITIETLAMVIECKHUCHUATRITableAdapter();
            this.gIUONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIUONGTableAdapter = new Hospital.QLBVDataSetTableAdapters.GIUONGTableAdapter();
            dANHDINHKHULabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            mAPHONGLabel = new System.Windows.Forms.Label();
            sOPHONGLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLBVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHUCHUATRIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHUCHUATRIGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETLAMVIECKHUCHUATRIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIUONGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dANHDINHKHULabel
            // 
            dANHDINHKHULabel.AutoSize = true;
            dANHDINHKHULabel.Location = new System.Drawing.Point(6, 104);
            dANHDINHKHULabel.Name = "dANHDINHKHULabel";
            dANHDINHKHULabel.Size = new System.Drawing.Size(119, 19);
            dANHDINHKHULabel.TabIndex = 2;
            dANHDINHKHULabel.Text = "Danh định khu:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(252, 104);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(73, 19);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "Tên khu:";
            // 
            // mAPHONGLabel
            // 
            mAPHONGLabel.AutoSize = true;
            mAPHONGLabel.Location = new System.Drawing.Point(12, 263);
            mAPHONGLabel.Name = "mAPHONGLabel";
            mAPHONGLabel.Size = new System.Drawing.Size(85, 19);
            mAPHONGLabel.TabIndex = 6;
            mAPHONGLabel.Text = "Mã phòng:";
            // 
            // sOPHONGLabel
            // 
            sOPHONGLabel.AutoSize = true;
            sOPHONGLabel.Location = new System.Drawing.Point(252, 266);
            sOPHONGLabel.Name = "sOPHONGLabel";
            sOPHONGLabel.Size = new System.Drawing.Size(83, 19);
            sOPHONGLabel.TabIndex = 8;
            sOPHONGLabel.Text = "Số phòng:";
            // 
            // qLBVDataSet
            // 
            this.qLBVDataSet.DataSetName = "QLBVDataSet";
            this.qLBVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHUCHUATRIBindingSource
            // 
            this.kHUCHUATRIBindingSource.DataMember = "KHUCHUATRI";
            this.kHUCHUATRIBindingSource.DataSource = this.qLBVDataSet;
            // 
            // kHUCHUATRITableAdapter
            // 
            this.kHUCHUATRITableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.GIUONGTableAdapter = null;
            this.tableAdapterManager.KHUCHUATRITableAdapter = this.kHUCHUATRITableAdapter;
            this.tableAdapterManager.LOAICHUATRITableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHONGTableAdapter = this.pHONGTableAdapter;
            this.tableAdapterManager.UpdateOrder = Hospital.QLBVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VATTUTableAdapter = null;
            this.tableAdapterManager.YTATableAdapter = null;
            // 
            // pHONGTableAdapter
            // 
            this.pHONGTableAdapter.ClearBeforeFill = true;
            // 
            // kHUCHUATRIGridControl
            // 
            this.kHUCHUATRIGridControl.DataSource = this.kHUCHUATRIBindingSource;
            this.kHUCHUATRIGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.kHUCHUATRIGridControl.Location = new System.Drawing.Point(0, 34);
            this.kHUCHUATRIGridControl.MainView = this.gridView1;
            this.kHUCHUATRIGridControl.Name = "kHUCHUATRIGridControl";
            this.kHUCHUATRIGridControl.Size = new System.Drawing.Size(1106, 275);
            this.kHUCHUATRIGridControl.TabIndex = 1;
            this.kHUCHUATRIGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDANHDINHKHU,
            this.colTEN});
            this.gridView1.GridControl = this.kHUCHUATRIGridControl;
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
            this.colTEN.Caption = "Tên khu";
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 30;
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.AllowEdit = false;
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 1;
            this.colTEN.Width = 112;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRoomNumber);
            this.groupBox1.Controls.Add(sOPHONGLabel);
            this.groupBox1.Controls.Add(mAPHONGLabel);
            this.groupBox1.Controls.Add(this.txtRoomId);
            this.groupBox1.Controls.Add(tENLabel);
            this.groupBox1.Controls.Add(this.txtAreaName);
            this.groupBox1.Controls.Add(dANHDINHKHULabel);
            this.groupBox1.Controls.Add(this.txtAreaId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 309);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 432);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập liệu";
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pHONGBindingSource, "SOPHONG", true));
            this.txtRoomNumber.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtRoomNumber.Location = new System.Drawing.Point(349, 259);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtRoomNumber.Properties.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtRoomNumber.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtRoomNumber.Size = new System.Drawing.Size(231, 28);
            this.txtRoomNumber.TabIndex = 9;
            // 
            // pHONGBindingSource
            // 
            this.pHONGBindingSource.DataMember = "FK_PHONG_KHUCHUATRI";
            this.pHONGBindingSource.DataSource = this.kHUCHUATRIBindingSource;
            // 
            // txtRoomId
            // 
            this.txtRoomId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pHONGBindingSource, "MAPHONG", true));
            this.txtRoomId.Location = new System.Drawing.Point(131, 260);
            this.txtRoomId.Name = "txtRoomId";
            this.txtRoomId.Size = new System.Drawing.Size(100, 27);
            this.txtRoomId.TabIndex = 7;
            // 
            // txtAreaName
            // 
            this.txtAreaName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHUCHUATRIBindingSource, "TEN", true));
            this.txtAreaName.Location = new System.Drawing.Point(349, 101);
            this.txtAreaName.MaxLength = 50;
            this.txtAreaName.Name = "txtAreaName";
            this.txtAreaName.Size = new System.Drawing.Size(231, 27);
            this.txtAreaName.TabIndex = 5;
            // 
            // txtAreaId
            // 
            this.txtAreaId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHUCHUATRIBindingSource, "DANHDINHKHU", true));
            this.txtAreaId.Location = new System.Drawing.Point(131, 101);
            this.txtAreaId.Name = "txtAreaId";
            this.txtAreaId.ReadOnly = true;
            this.txtAreaId.Size = new System.Drawing.Size(100, 27);
            this.txtAreaId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(257, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "PHÒNG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(252, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHU VỰC";
            // 
            // pHONGGridControl
            // 
            this.pHONGGridControl.DataSource = this.pHONGBindingSource;
            this.pHONGGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pHONGGridControl.Location = new System.Drawing.Point(608, 309);
            this.pHONGGridControl.MainView = this.gridView2;
            this.pHONGGridControl.Name = "pHONGGridControl";
            this.pHONGGridControl.Size = new System.Drawing.Size(498, 432);
            this.pHONGGridControl.TabIndex = 3;
            this.pHONGGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPHONG,
            this.colSOPHONG,
            this.colDANHDINHKHU1});
            this.gridView2.GridControl = this.pHONGGridControl;
            this.gridView2.Name = "gridView2";
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
            // colDANHDINHKHU1
            // 
            this.colDANHDINHKHU1.Caption = "Danh định khu";
            this.colDANHDINHKHU1.FieldName = "DANHDINHKHU";
            this.colDANHDINHKHU1.MinWidth = 30;
            this.colDANHDINHKHU1.Name = "colDANHDINHKHU1";
            this.colDANHDINHKHU1.OptionsColumn.AllowEdit = false;
            this.colDANHDINHKHU1.Visible = true;
            this.colDANHDINHKHU1.VisibleIndex = 2;
            this.colDANHDINHKHU1.Width = 112;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddRoom,
            this.btnDeleteRoom,
            this.btnUpdateRoom,
            this.btnWriteRoom,
            this.btnCancelRoom});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(187, 164);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(186, 32);
            this.btnAddRoom.Text = "Thêm phòng";
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(186, 32);
            this.btnDeleteRoom.Text = "Xóa phòng";
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
            // 
            // btnUpdateRoom
            // 
            this.btnUpdateRoom.Name = "btnUpdateRoom";
            this.btnUpdateRoom.Size = new System.Drawing.Size(186, 32);
            this.btnUpdateRoom.Text = "Sửa phòng";
            this.btnUpdateRoom.Click += new System.EventHandler(this.btnUpdateRoom_Click);
            // 
            // btnWriteRoom
            // 
            this.btnWriteRoom.Name = "btnWriteRoom";
            this.btnWriteRoom.Size = new System.Drawing.Size(186, 32);
            this.btnWriteRoom.Text = "Ghi phòng";
            this.btnWriteRoom.Click += new System.EventHandler(this.btnWriteRoom_Click);
            // 
            // btnCancelRoom
            // 
            this.btnCancelRoom.Name = "btnCancelRoom";
            this.btnCancelRoom.Size = new System.Drawing.Size(186, 32);
            this.btnCancelRoom.Text = "Cancel";
            this.btnCancelRoom.Click += new System.EventHandler(this.btnCancelRoom_Click);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1106, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 741);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1106, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 707);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1106, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 707);
            // 
            // cHITIETLAMVIECKHUCHUATRIBindingSource
            // 
            this.cHITIETLAMVIECKHUCHUATRIBindingSource.DataMember = "FK_CHITIETLAMVIECKHUCHUATRI_KHUCHUATRI";
            this.cHITIETLAMVIECKHUCHUATRIBindingSource.DataSource = this.kHUCHUATRIBindingSource;
            // 
            // cHITIETLAMVIECKHUCHUATRITableAdapter
            // 
            this.cHITIETLAMVIECKHUCHUATRITableAdapter.ClearBeforeFill = true;
            // 
            // gIUONGBindingSource
            // 
            this.gIUONGBindingSource.DataMember = "FK_GIUONG_PHONG";
            this.gIUONGBindingSource.DataSource = this.pHONGBindingSource;
            // 
            // gIUONGTableAdapter
            // 
            this.gIUONGTableAdapter.ClearBeforeFill = true;
            // 
            // frmRoomAndArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 741);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.pHONGGridControl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kHUCHUATRIGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmRoomAndArea";
            this.Text = "Khu và phòng";
            this.Load += new System.EventHandler(this.frmRoomAndArea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLBVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHUCHUATRIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHUCHUATRIGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETLAMVIECKHUCHUATRIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIUONGBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLBVDataSet qLBVDataSet;
        private System.Windows.Forms.BindingSource kHUCHUATRIBindingSource;
        private QLBVDataSetTableAdapters.KHUCHUATRITableAdapter kHUCHUATRITableAdapter;
        private QLBVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private QLBVDataSetTableAdapters.PHONGTableAdapter pHONGTableAdapter;
        private DevExpress.XtraGrid.GridControl kHUCHUATRIGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource pHONGBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colDANHDINHKHU;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraEditors.SpinEdit txtRoomNumber;
        private System.Windows.Forms.TextBox txtRoomId;
        private System.Windows.Forms.TextBox txtAreaName;
        private System.Windows.Forms.TextBox txtAreaId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl pHONGGridControl;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnAddRoom;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteRoom;
        private System.Windows.Forms.ToolStripMenuItem btnUpdateRoom;
        private System.Windows.Forms.ToolStripMenuItem btnWriteRoom;
        private System.Windows.Forms.ToolStripMenuItem btnCancelRoom;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn colSOPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDANHDINHKHU1;
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
        private System.Windows.Forms.BindingSource cHITIETLAMVIECKHUCHUATRIBindingSource;
        private QLBVDataSetTableAdapters.CHITIETLAMVIECKHUCHUATRITableAdapter cHITIETLAMVIECKHUCHUATRITableAdapter;
        private System.Windows.Forms.BindingSource gIUONGBindingSource;
        private QLBVDataSetTableAdapters.GIUONGTableAdapter gIUONGTableAdapter;
    }
}