
namespace Hospital
{
    partial class frmEquipment
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
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label tENVTLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEquipment));
            this.qLBVDataSet = new Hospital.QLBVDataSet();
            this.vATTUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vATTUTableAdapter = new Hospital.QLBVDataSetTableAdapters.VATTUTableAdapter();
            this.tableAdapterManager = new Hospital.QLBVDataSetTableAdapters.TableAdapterManager();
            this.cHITIETSUDUNGVTTableAdapter = new Hospital.QLBVDataSetTableAdapters.CHITIETSUDUNGVTTableAdapter();
            this.vATTUGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrice = new DevExpress.XtraEditors.SpinEdit();
            this.txtEquipmentName = new DevExpress.XtraEditors.TextEdit();
            this.txtEquipmentId = new DevExpress.XtraEditors.TextEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.btnWrite = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancel = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.cHITIETSUDUNGVTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            mAVTLabel = new System.Windows.Forms.Label();
            tENVTLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLBVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEquipmentName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEquipmentId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETSUDUNGVTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(43, 100);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(81, 19);
            mAVTLabel.TabIndex = 0;
            mAVTLabel.Text = "Mã vật tư:";
            // 
            // tENVTLabel
            // 
            tENVTLabel.AutoSize = true;
            tENVTLabel.Location = new System.Drawing.Point(36, 165);
            tENVTLabel.Name = "tENVTLabel";
            tENVTLabel.Size = new System.Drawing.Size(88, 19);
            tENVTLabel.TabIndex = 2;
            tENVTLabel.Text = "Tên vật tư:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(43, 223);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(70, 19);
            dONGIALabel.TabIndex = 4;
            dONGIALabel.Text = "Đơn giá:";
            // 
            // qLBVDataSet
            // 
            this.qLBVDataSet.DataSetName = "QLBVDataSet";
            this.qLBVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vATTUBindingSource
            // 
            this.vATTUBindingSource.DataMember = "VATTU";
            this.vATTUBindingSource.DataSource = this.qLBVDataSet;
            // 
            // vATTUTableAdapter
            // 
            this.vATTUTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BACSITableAdapter = null;
            this.tableAdapterManager.BENHNHANTableAdapter = null;
            this.tableAdapterManager.CHITIETCHUATRITableAdapter = null;
            this.tableAdapterManager.CHITIETLAMVIECKHUCHUATRITableAdapter = null;
            this.tableAdapterManager.CHITIETOTableAdapter = null;
            this.tableAdapterManager.CHITIETSUDUNGVTTableAdapter = this.cHITIETSUDUNGVTTableAdapter;
            this.tableAdapterManager.GIUONGTableAdapter = null;
            this.tableAdapterManager.KHUCHUATRITableAdapter = null;
            this.tableAdapterManager.LOAICHUATRITableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHONGTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Hospital.QLBVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VATTUTableAdapter = this.vATTUTableAdapter;
            this.tableAdapterManager.YTATableAdapter = null;
            // 
            // cHITIETSUDUNGVTTableAdapter
            // 
            this.cHITIETSUDUNGVTTableAdapter.ClearBeforeFill = true;
            // 
            // vATTUGridControl
            // 
            this.vATTUGridControl.DataSource = this.vATTUBindingSource;
            this.vATTUGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.vATTUGridControl.Location = new System.Drawing.Point(0, 34);
            this.vATTUGridControl.MainView = this.gridView1;
            this.vATTUGridControl.Name = "vATTUGridControl";
            this.vATTUGridControl.Size = new System.Drawing.Size(1167, 297);
            this.vATTUGridControl.TabIndex = 1;
            this.vATTUGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colTENVT,
            this.colDONGIA});
            this.gridView1.GridControl = this.vATTUGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "Mã vật tư";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.MinWidth = 30;
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.OptionsColumn.AllowEdit = false;
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 0;
            this.colMAVT.Width = 112;
            // 
            // colTENVT
            // 
            this.colTENVT.Caption = "Tên vật tư";
            this.colTENVT.FieldName = "TENVT";
            this.colTENVT.MinWidth = 30;
            this.colTENVT.Name = "colTENVT";
            this.colTENVT.OptionsColumn.AllowEdit = false;
            this.colTENVT.Visible = true;
            this.colTENVT.VisibleIndex = 1;
            this.colTENVT.Width = 112;
            // 
            // colDONGIA
            // 
            this.colDONGIA.Caption = "Đơn giá";
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.MinWidth = 30;
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.OptionsColumn.AllowEdit = false;
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 2;
            this.colDONGIA.Width = 112;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(dONGIALabel);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(tENVTLabel);
            this.groupBox1.Controls.Add(this.txtEquipmentName);
            this.groupBox1.Controls.Add(mAVTLabel);
            this.groupBox1.Controls.Add(this.txtEquipmentId);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 331);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 434);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập liệu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Đồng";
            // 
            // txtPrice
            // 
            this.txtPrice.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vATTUBindingSource, "DONGIA", true));
            this.txtPrice.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtPrice.Location = new System.Drawing.Point(213, 219);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPrice.Properties.MaxValue = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.txtPrice.Size = new System.Drawing.Size(197, 28);
            this.txtPrice.TabIndex = 5;
            // 
            // txtEquipmentName
            // 
            this.txtEquipmentName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vATTUBindingSource, "TENVT", true));
            this.txtEquipmentName.Location = new System.Drawing.Point(213, 161);
            this.txtEquipmentName.Name = "txtEquipmentName";
            this.txtEquipmentName.Properties.MaxLength = 50;
            this.txtEquipmentName.Size = new System.Drawing.Size(197, 28);
            this.txtEquipmentName.TabIndex = 3;
            // 
            // txtEquipmentId
            // 
            this.txtEquipmentId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vATTUBindingSource, "MAVT", true));
            this.txtEquipmentId.Location = new System.Drawing.Point(213, 96);
            this.txtEquipmentId.Name = "txtEquipmentId";
            this.txtEquipmentId.Properties.MaxLength = 10;
            this.txtEquipmentId.Size = new System.Drawing.Size(197, 28);
            this.txtEquipmentId.TabIndex = 1;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCancel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 4;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Caption = "Cancel";
            this.btnCancel.Id = 5;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.LargeImage")));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancel_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1167, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 765);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1167, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 731);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1167, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 731);
            // 
            // cHITIETSUDUNGVTBindingSource
            // 
            this.cHITIETSUDUNGVTBindingSource.DataMember = "FK_CHITIETSUDUNGVT_VATTU";
            this.cHITIETSUDUNGVTBindingSource.DataSource = this.vATTUBindingSource;
            // 
            // frmEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 765);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.vATTUGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmEquipment";
            this.Text = "Vật tư-Thuốc men";
            this.Load += new System.EventHandler(this.frmEquipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLBVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEquipmentName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEquipmentId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETSUDUNGVTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLBVDataSet qLBVDataSet;
        private System.Windows.Forms.BindingSource vATTUBindingSource;
        private QLBVDataSetTableAdapters.VATTUTableAdapter vATTUTableAdapter;
        private QLBVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl vATTUGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SpinEdit txtPrice;
        private DevExpress.XtraEditors.TextEdit txtEquipmentName;
        private DevExpress.XtraEditors.TextEdit txtEquipmentId;
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
        private QLBVDataSetTableAdapters.CHITIETSUDUNGVTTableAdapter cHITIETSUDUNGVTTableAdapter;
        private System.Windows.Forms.BindingSource cHITIETSUDUNGVTBindingSource;
    }
}