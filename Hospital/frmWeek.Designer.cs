
namespace Hospital
{
    partial class frmWeek
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
            System.Windows.Forms.Label iD_TUANLabel;
            System.Windows.Forms.Label tUAN_SOLabel;
            System.Windows.Forms.Label nGAYBATDAULabel;
            System.Windows.Forms.Label nGAYKETTHUCLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWeek));
            this.qLBVDataSet = new Hospital.QLBVDataSet();
            this.tUANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tUANTableAdapter = new Hospital.QLBVDataSetTableAdapters.TUANTableAdapter();
            this.tableAdapterManager = new Hospital.QLBVDataSetTableAdapters.TableAdapterManager();
            this.tUANGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_TUAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUAN_SO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYBATDAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYKETTHUC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iD_TUANSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.txtNumberWeek = new DevExpress.XtraEditors.SpinEdit();
            this.txtStartDate = new DevExpress.XtraEditors.DateEdit();
            this.txtEndDate = new DevExpress.XtraEditors.DateEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.btnWrite = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancel = new DevExpress.XtraBars.BarButtonItem();
            this.cHITIETGIOLAMVIECBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHITIETGIOLAMVIECTableAdapter = new Hospital.QLBVDataSetTableAdapters.CHITIETGIOLAMVIECTableAdapter();
            iD_TUANLabel = new System.Windows.Forms.Label();
            tUAN_SOLabel = new System.Windows.Forms.Label();
            nGAYBATDAULabel = new System.Windows.Forms.Label();
            nGAYKETTHUCLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLBVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUANGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iD_TUANSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberWeek.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETGIOLAMVIECBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // qLBVDataSet
            // 
            this.qLBVDataSet.DataSetName = "QLBVDataSet";
            this.qLBVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tUANBindingSource
            // 
            this.tUANBindingSource.DataMember = "TUAN";
            this.tUANBindingSource.DataSource = this.qLBVDataSet;
            // 
            // tUANTableAdapter
            // 
            this.tUANTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BENHNHANTableAdapter = null;
            this.tableAdapterManager.CHITIETCHUATRITableAdapter = null;
            this.tableAdapterManager.CHITIETGIOLAMVIECTableAdapter = this.cHITIETGIOLAMVIECTableAdapter;
            this.tableAdapterManager.CHITIETLAMVIECKHUCHUATRITableAdapter = null;
            this.tableAdapterManager.CHITIETOTableAdapter = null;
            this.tableAdapterManager.CHITIETSUDUNGVTTableAdapter = null;
            this.tableAdapterManager.CHUCVUTableAdapter = null;
            this.tableAdapterManager.GIUONGTableAdapter = null;
            this.tableAdapterManager.KHUCHUATRITableAdapter = null;
            this.tableAdapterManager.LOAICHUATRITableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHONGTableAdapter = null;
            this.tableAdapterManager.TUANTableAdapter = this.tUANTableAdapter;
            this.tableAdapterManager.UpdateOrder = Hospital.QLBVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VATTUTableAdapter = null;
            // 
            // tUANGridControl
            // 
            this.tUANGridControl.DataSource = this.tUANBindingSource;
            this.tUANGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tUANGridControl.Location = new System.Drawing.Point(0, 34);
            this.tUANGridControl.MainView = this.gridView1;
            this.tUANGridControl.Name = "tUANGridControl";
            this.tUANGridControl.Size = new System.Drawing.Size(1110, 339);
            this.tUANGridControl.TabIndex = 1;
            this.tUANGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_TUAN,
            this.colTUAN_SO,
            this.colNGAYBATDAU,
            this.colNGAYKETTHUC});
            this.gridView1.GridControl = this.tUANGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colID_TUAN
            // 
            this.colID_TUAN.Caption = "Mã tuần";
            this.colID_TUAN.FieldName = "ID_TUAN";
            this.colID_TUAN.MinWidth = 30;
            this.colID_TUAN.Name = "colID_TUAN";
            this.colID_TUAN.OptionsColumn.AllowEdit = false;
            this.colID_TUAN.Visible = true;
            this.colID_TUAN.VisibleIndex = 0;
            this.colID_TUAN.Width = 112;
            // 
            // colTUAN_SO
            // 
            this.colTUAN_SO.Caption = "Tuần số";
            this.colTUAN_SO.FieldName = "TUAN_SO";
            this.colTUAN_SO.MinWidth = 30;
            this.colTUAN_SO.Name = "colTUAN_SO";
            this.colTUAN_SO.OptionsColumn.AllowEdit = false;
            this.colTUAN_SO.Visible = true;
            this.colTUAN_SO.VisibleIndex = 1;
            this.colTUAN_SO.Width = 112;
            // 
            // colNGAYBATDAU
            // 
            this.colNGAYBATDAU.Caption = "Ngày bắt đầu";
            this.colNGAYBATDAU.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNGAYBATDAU.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYBATDAU.FieldName = "NGAYBATDAU";
            this.colNGAYBATDAU.MinWidth = 30;
            this.colNGAYBATDAU.Name = "colNGAYBATDAU";
            this.colNGAYBATDAU.OptionsColumn.AllowEdit = false;
            this.colNGAYBATDAU.Visible = true;
            this.colNGAYBATDAU.VisibleIndex = 2;
            this.colNGAYBATDAU.Width = 112;
            // 
            // colNGAYKETTHUC
            // 
            this.colNGAYKETTHUC.Caption = "Ngày kết thúc";
            this.colNGAYKETTHUC.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNGAYKETTHUC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYKETTHUC.FieldName = "NGAYKETTHUC";
            this.colNGAYKETTHUC.MinWidth = 30;
            this.colNGAYKETTHUC.Name = "colNGAYKETTHUC";
            this.colNGAYKETTHUC.OptionsColumn.AllowEdit = false;
            this.colNGAYKETTHUC.Visible = true;
            this.colNGAYKETTHUC.VisibleIndex = 3;
            this.colNGAYKETTHUC.Width = 112;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(nGAYKETTHUCLabel);
            this.groupBox1.Controls.Add(this.txtEndDate);
            this.groupBox1.Controls.Add(nGAYBATDAULabel);
            this.groupBox1.Controls.Add(this.txtStartDate);
            this.groupBox1.Controls.Add(tUAN_SOLabel);
            this.groupBox1.Controls.Add(this.txtNumberWeek);
            this.groupBox1.Controls.Add(iD_TUANLabel);
            this.groupBox1.Controls.Add(this.iD_TUANSpinEdit);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 373);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 447);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập liệu";
            // 
            // iD_TUANLabel
            // 
            iD_TUANLabel.AutoSize = true;
            iD_TUANLabel.Location = new System.Drawing.Point(22, 75);
            iD_TUANLabel.Name = "iD_TUANLabel";
            iD_TUANLabel.Size = new System.Drawing.Size(66, 19);
            iD_TUANLabel.TabIndex = 0;
            iD_TUANLabel.Text = "Id tuần:";
            // 
            // iD_TUANSpinEdit
            // 
            this.iD_TUANSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tUANBindingSource, "ID_TUAN", true));
            this.iD_TUANSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.iD_TUANSpinEdit.Enabled = false;
            this.iD_TUANSpinEdit.Location = new System.Drawing.Point(156, 71);
            this.iD_TUANSpinEdit.Name = "iD_TUANSpinEdit";
            this.iD_TUANSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.iD_TUANSpinEdit.Size = new System.Drawing.Size(150, 28);
            this.iD_TUANSpinEdit.TabIndex = 1;
            // 
            // tUAN_SOLabel
            // 
            tUAN_SOLabel.AutoSize = true;
            tUAN_SOLabel.Location = new System.Drawing.Point(22, 136);
            tUAN_SOLabel.Name = "tUAN_SOLabel";
            tUAN_SOLabel.Size = new System.Drawing.Size(72, 19);
            tUAN_SOLabel.TabIndex = 2;
            tUAN_SOLabel.Text = "Tuần số:";
            // 
            // txtNumberWeek
            // 
            this.txtNumberWeek.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tUANBindingSource, "TUAN_SO", true));
            this.txtNumberWeek.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNumberWeek.Location = new System.Drawing.Point(156, 132);
            this.txtNumberWeek.Name = "txtNumberWeek";
            this.txtNumberWeek.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNumberWeek.Properties.MaxValue = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.txtNumberWeek.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNumberWeek.Size = new System.Drawing.Size(150, 28);
            this.txtNumberWeek.TabIndex = 3;
            // 
            // nGAYBATDAULabel
            // 
            nGAYBATDAULabel.AutoSize = true;
            nGAYBATDAULabel.Location = new System.Drawing.Point(22, 200);
            nGAYBATDAULabel.Name = "nGAYBATDAULabel";
            nGAYBATDAULabel.Size = new System.Drawing.Size(109, 19);
            nGAYBATDAULabel.TabIndex = 4;
            nGAYBATDAULabel.Text = "Ngày bắt đầu:";
            // 
            // txtStartDate
            // 
            this.txtStartDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tUANBindingSource, "NGAYBATDAU", true));
            this.txtStartDate.EditValue = null;
            this.txtStartDate.Location = new System.Drawing.Point(156, 196);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtStartDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.txtStartDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtStartDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.txtStartDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtStartDate.Size = new System.Drawing.Size(203, 28);
            this.txtStartDate.TabIndex = 5;
            // 
            // nGAYKETTHUCLabel
            // 
            nGAYKETTHUCLabel.AutoSize = true;
            nGAYKETTHUCLabel.Location = new System.Drawing.Point(22, 268);
            nGAYKETTHUCLabel.Name = "nGAYKETTHUCLabel";
            nGAYKETTHUCLabel.Size = new System.Drawing.Size(112, 19);
            nGAYKETTHUCLabel.TabIndex = 6;
            nGAYKETTHUCLabel.Text = "Ngày kết thúc:";
            // 
            // txtEndDate
            // 
            this.txtEndDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tUANBindingSource, "NGAYKETTHUC", true));
            this.txtEndDate.EditValue = null;
            this.txtEndDate.Location = new System.Drawing.Point(156, 265);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtEndDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.txtEndDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtEndDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.txtEndDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtEndDate.Size = new System.Drawing.Size(203, 28);
            this.txtEndDate.TabIndex = 7;
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
            this.btnReload,
            this.btnCancel});
            this.barManager1.MaxItemId = 6;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1110, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 820);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1110, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 786);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1110, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 786);
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUpdate, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnWrite, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCancel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Thêm";
            this.btnAdd.Id = 0;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.btnAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Xóa";
            this.btnDelete.Id = 1;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.btnDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Caption = "Sửa";
            this.btnUpdate.Id = 2;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.btnUpdate.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUpdate_ItemClick);
            // 
            // btnWrite
            // 
            this.btnWrite.Caption = "Ghi";
            this.btnWrite.Id = 3;
            this.btnWrite.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.btnWrite.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnWrite_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 4;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Caption = "Cancel";
            this.btnCancel.Id = 5;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.btnCancel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.LargeImage")));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancel_ItemClick);
            // 
            // cHITIETGIOLAMVIECBindingSource
            // 
            this.cHITIETGIOLAMVIECBindingSource.DataMember = "FK_CHITIETGIOLAMVIEC_TUAN";
            this.cHITIETGIOLAMVIECBindingSource.DataSource = this.tUANBindingSource;
            // 
            // cHITIETGIOLAMVIECTableAdapter
            // 
            this.cHITIETGIOLAMVIECTableAdapter.ClearBeforeFill = true;
            // 
            // frmWeek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 820);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tUANGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmWeek";
            this.Text = "Tuần làm việc";
            this.Load += new System.EventHandler(this.frmWeek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLBVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUANGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iD_TUANSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberWeek.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETGIOLAMVIECBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLBVDataSet qLBVDataSet;
        private System.Windows.Forms.BindingSource tUANBindingSource;
        private QLBVDataSetTableAdapters.TUANTableAdapter tUANTableAdapter;
        private QLBVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl tUANGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID_TUAN;
        private DevExpress.XtraGrid.Columns.GridColumn colTUAN_SO;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYBATDAU;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYKETTHUC;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.DateEdit txtEndDate;
        private DevExpress.XtraEditors.DateEdit txtStartDate;
        private DevExpress.XtraEditors.SpinEdit txtNumberWeek;
        private DevExpress.XtraEditors.SpinEdit iD_TUANSpinEdit;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnUpdate;
        private DevExpress.XtraBars.BarButtonItem btnWrite;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnCancel;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private QLBVDataSetTableAdapters.CHITIETGIOLAMVIECTableAdapter cHITIETGIOLAMVIECTableAdapter;
        private System.Windows.Forms.BindingSource cHITIETGIOLAMVIECBindingSource;
    }
}