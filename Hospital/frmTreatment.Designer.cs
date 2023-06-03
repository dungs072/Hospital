
namespace Hospital
{
    partial class frmTreatment
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
            System.Windows.Forms.Label mALOAI_CTLabel;
            System.Windows.Forms.Label tENLOAILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTreatment));
            this.qLBVDataSet = new Hospital.QLBVDataSet();
            this.lOAICHUATRIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOAICHUATRITableAdapter = new Hospital.QLBVDataSetTableAdapters.LOAICHUATRITableAdapter();
            this.tableAdapterManager = new Hospital.QLBVDataSetTableAdapters.TableAdapterManager();
            this.cHITIETCHUATRITableAdapter = new Hospital.QLBVDataSetTableAdapters.CHITIETCHUATRITableAdapter();
            this.lOAICHUATRIGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOAI_CT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTypeName = new DevExpress.XtraEditors.TextEdit();
            this.txtTypeId = new DevExpress.XtraEditors.TextEdit();
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
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.cHITIETCHUATRIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            mALOAI_CTLabel = new System.Windows.Forms.Label();
            tENLOAILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLBVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAICHUATRIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAICHUATRIGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTypeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTypeId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETCHUATRIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOAI_CTLabel
            // 
            mALOAI_CTLabel.AutoSize = true;
            mALOAI_CTLabel.Location = new System.Drawing.Point(27, 62);
            mALOAI_CTLabel.Name = "mALOAI_CTLabel";
            mALOAI_CTLabel.Size = new System.Drawing.Size(65, 19);
            mALOAI_CTLabel.TabIndex = 0;
            mALOAI_CTLabel.Text = "Mã loại:";
            // 
            // tENLOAILabel
            // 
            tENLOAILabel.AutoSize = true;
            tENLOAILabel.Location = new System.Drawing.Point(27, 137);
            tENLOAILabel.Name = "tENLOAILabel";
            tENLOAILabel.Size = new System.Drawing.Size(72, 19);
            tENLOAILabel.TabIndex = 2;
            tENLOAILabel.Text = "Tên loại:";
            // 
            // qLBVDataSet
            // 
            this.qLBVDataSet.DataSetName = "QLBVDataSet";
            this.qLBVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOAICHUATRIBindingSource
            // 
            this.lOAICHUATRIBindingSource.DataMember = "LOAICHUATRI";
            this.lOAICHUATRIBindingSource.DataSource = this.qLBVDataSet;
            // 
            // lOAICHUATRITableAdapter
            // 
            this.lOAICHUATRITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BACSITableAdapter = null;
            this.tableAdapterManager.BENHNHANTableAdapter = null;
            this.tableAdapterManager.CHITIETCHUATRITableAdapter = this.cHITIETCHUATRITableAdapter;
            this.tableAdapterManager.CHITIETLAMVIECKHUCHUATRITableAdapter = null;
            this.tableAdapterManager.CHITIETOTableAdapter = null;
            this.tableAdapterManager.CHITIETSUDUNGVTTableAdapter = null;
            this.tableAdapterManager.GIUONGTableAdapter = null;
            this.tableAdapterManager.KHUCHUATRITableAdapter = null;
            this.tableAdapterManager.LOAICHUATRITableAdapter = this.lOAICHUATRITableAdapter;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHONGTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Hospital.QLBVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VATTUTableAdapter = null;
            this.tableAdapterManager.YTATableAdapter = null;
            // 
            // cHITIETCHUATRITableAdapter
            // 
            this.cHITIETCHUATRITableAdapter.ClearBeforeFill = true;
            // 
            // lOAICHUATRIGridControl
            // 
            this.lOAICHUATRIGridControl.DataSource = this.lOAICHUATRIBindingSource;
            this.lOAICHUATRIGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.lOAICHUATRIGridControl.Location = new System.Drawing.Point(0, 34);
            this.lOAICHUATRIGridControl.MainView = this.gridView1;
            this.lOAICHUATRIGridControl.Name = "lOAICHUATRIGridControl";
            this.lOAICHUATRIGridControl.Size = new System.Drawing.Size(1141, 312);
            this.lOAICHUATRIGridControl.TabIndex = 1;
            this.lOAICHUATRIGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOAI_CT,
            this.colTENLOAI});
            this.gridView1.GridControl = this.lOAICHUATRIGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMALOAI_CT
            // 
            this.colMALOAI_CT.Caption = "Mã loại chữa trị";
            this.colMALOAI_CT.FieldName = "MALOAI_CT";
            this.colMALOAI_CT.MinWidth = 30;
            this.colMALOAI_CT.Name = "colMALOAI_CT";
            this.colMALOAI_CT.OptionsColumn.AllowEdit = false;
            this.colMALOAI_CT.Visible = true;
            this.colMALOAI_CT.VisibleIndex = 0;
            this.colMALOAI_CT.Width = 112;
            // 
            // colTENLOAI
            // 
            this.colTENLOAI.Caption = "Tên loại chữa trị";
            this.colTENLOAI.FieldName = "TENLOAI";
            this.colTENLOAI.MinWidth = 30;
            this.colTENLOAI.Name = "colTENLOAI";
            this.colTENLOAI.OptionsColumn.AllowEdit = false;
            this.colTENLOAI.Visible = true;
            this.colTENLOAI.VisibleIndex = 1;
            this.colTENLOAI.Width = 112;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(tENLOAILabel);
            this.groupBox1.Controls.Add(this.txtTypeName);
            this.groupBox1.Controls.Add(mALOAI_CTLabel);
            this.groupBox1.Controls.Add(this.txtTypeId);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 346);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 305);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập liệu";
            // 
            // txtTypeName
            // 
            this.txtTypeName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOAICHUATRIBindingSource, "TENLOAI", true));
            this.txtTypeName.Location = new System.Drawing.Point(180, 133);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Properties.MaxLength = 50;
            this.txtTypeName.Size = new System.Drawing.Size(269, 28);
            this.txtTypeName.TabIndex = 3;
            // 
            // txtTypeId
            // 
            this.txtTypeId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOAICHUATRIBindingSource, "MALOAI_CT", true));
            this.txtTypeId.Location = new System.Drawing.Point(180, 58);
            this.txtTypeId.Name = "txtTypeId";
            this.txtTypeId.Properties.MaxLength = 5;
            this.txtTypeId.Size = new System.Drawing.Size(269, 28);
            this.txtTypeId.TabIndex = 1;
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
            this.barButtonItem2,
            this.btnUpdate,
            this.btnWrite,
            this.btnReload,
            this.btnCancel,
            this.btnDelete});
            this.barManager1.MaxItemId = 7;
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
            this.btnDelete.Id = 6;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1141, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 651);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1141, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 617);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1141, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 617);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Xóa";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // cHITIETCHUATRIBindingSource
            // 
            this.cHITIETCHUATRIBindingSource.DataMember = "FK_CHITIETCHUATRI_LOAICHUATRI";
            this.cHITIETCHUATRIBindingSource.DataSource = this.lOAICHUATRIBindingSource;
            // 
            // frmTreatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 651);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lOAICHUATRIGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmTreatment";
            this.Text = "Các loại chữa trị";
            this.Load += new System.EventHandler(this.frmTreatment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLBVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAICHUATRIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAICHUATRIGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTypeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTypeId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETCHUATRIBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLBVDataSet qLBVDataSet;
        private System.Windows.Forms.BindingSource lOAICHUATRIBindingSource;
        private QLBVDataSetTableAdapters.LOAICHUATRITableAdapter lOAICHUATRITableAdapter;
        private QLBVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl lOAICHUATRIGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOAI_CT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOAI;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtTypeName;
        private DevExpress.XtraEditors.TextEdit txtTypeId;
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
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private QLBVDataSetTableAdapters.CHITIETCHUATRITableAdapter cHITIETCHUATRITableAdapter;
        private System.Windows.Forms.BindingSource cHITIETCHUATRIBindingSource;
    }
}