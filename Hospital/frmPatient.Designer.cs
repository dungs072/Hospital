
namespace Hospital
{
    partial class frmPatient
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
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label lOAILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatient));
            this.qLBVDataSet = new Hospital.QLBVDataSet();
            this.bENHNHANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bENHNHANTableAdapter = new Hospital.QLBVDataSetTableAdapters.BENHNHANTableAdapter();
            this.tableAdapterManager = new Hospital.QLBVDataSetTableAdapters.TableAdapterManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbWelcomDoctor = new System.Windows.Forms.ComboBox();
            this.gETDOCTORSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtBirthday = new DevExpress.XtraEditors.DateEdit();
            this.txtLastName = new DevExpress.XtraEditors.TextEdit();
            this.txtFirstName = new DevExpress.XtraEditors.TextEdit();
            this.txtPatientId = new DevExpress.XtraEditors.TextEdit();
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
            this.cHITIETCHUATRIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHITIETCHUATRITableAdapter = new Hospital.QLBVDataSetTableAdapters.CHITIETCHUATRITableAdapter();
            this.cHITIETOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHITIETOTableAdapter = new Hospital.QLBVDataSetTableAdapters.CHITIETOTableAdapter();
            this.bENHNHANGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMABN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMABSTN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gET_DOCTORSTableAdapter = new Hospital.QLBVDataSetTableAdapters.GET_DOCTORSTableAdapter();
            mABNLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            lOAILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLBVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bENHNHANBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gETDOCTORSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirthday.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirthday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatientId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETCHUATRIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bENHNHANGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mABNLabel
            // 
            mABNLabel.AutoSize = true;
            mABNLabel.Location = new System.Drawing.Point(14, 30);
            mABNLabel.Name = "mABNLabel";
            mABNLabel.Size = new System.Drawing.Size(115, 19);
            mABNLabel.TabIndex = 0;
            mABNLabel.Text = "Mã bệnh nhân:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(14, 93);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(35, 19);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "Họ:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(14, 156);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(42, 19);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "Tên:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(14, 219);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(85, 19);
            nGAYSINHLabel.TabIndex = 6;
            nGAYSINHLabel.Text = "Ngày sinh:";
            // 
            // lOAILabel
            // 
            lOAILabel.AutoSize = true;
            lOAILabel.Location = new System.Drawing.Point(14, 286);
            lOAILabel.Name = "lOAILabel";
            lOAILabel.Size = new System.Drawing.Size(44, 19);
            lOAILabel.TabIndex = 8;
            lOAILabel.Text = "Loại:";
            // 
            // qLBVDataSet
            // 
            this.qLBVDataSet.DataSetName = "QLBVDataSet";
            this.qLBVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bENHNHANBindingSource
            // 
            this.bENHNHANBindingSource.DataMember = "BENHNHAN";
            this.bENHNHANBindingSource.DataSource = this.qLBVDataSet;
            // 
            // bENHNHANTableAdapter
            // 
            this.bENHNHANTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BACSITableAdapter = null;
            this.tableAdapterManager.BENHNHANTableAdapter = this.bENHNHANTableAdapter;
            this.tableAdapterManager.CHITIETCHUATRITableAdapter = null;
            this.tableAdapterManager.CHITIETLAMVIECKHUCHUATRITableAdapter = null;
            this.tableAdapterManager.CHITIETOTableAdapter = null;
            this.tableAdapterManager.CHITIETSUDUNGVTTableAdapter = null;
            this.tableAdapterManager.GIUONGTableAdapter = null;
            this.tableAdapterManager.KHUCHUATRITableAdapter = null;
            this.tableAdapterManager.LOAICHUATRITableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHONGTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Hospital.QLBVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VATTUTableAdapter = null;
            this.tableAdapterManager.YTATableAdapter = null;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbWelcomDoctor);
            this.groupBox1.Controls.Add(this.cmbType);
            this.groupBox1.Controls.Add(lOAILabel);
            this.groupBox1.Controls.Add(nGAYSINHLabel);
            this.groupBox1.Controls.Add(this.txtBirthday);
            this.groupBox1.Controls.Add(tENLabel);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(hOLabel);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(mABNLabel);
            this.groupBox1.Controls.Add(this.txtPatientId);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 424);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập liệu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Bác sĩ tiếp nhận:";
            // 
            // cmbWelcomDoctor
            // 
            this.cmbWelcomDoctor.DataSource = this.gETDOCTORSBindingSource;
            this.cmbWelcomDoctor.DisplayMember = "HOTEN";
            this.cmbWelcomDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWelcomDoctor.FormattingEnabled = true;
            this.cmbWelcomDoctor.Location = new System.Drawing.Point(159, 343);
            this.cmbWelcomDoctor.Name = "cmbWelcomDoctor";
            this.cmbWelcomDoctor.Size = new System.Drawing.Size(206, 27);
            this.cmbWelcomDoctor.TabIndex = 10;
            this.cmbWelcomDoctor.ValueMember = "MANV";
            // 
            // gETDOCTORSBindingSource
            // 
            this.gETDOCTORSBindingSource.DataMember = "GET_DOCTORS";
            this.gETDOCTORSBindingSource.DataSource = this.qLBVDataSet;
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(159, 283);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(206, 27);
            this.cmbType.TabIndex = 9;
            // 
            // txtBirthday
            // 
            this.txtBirthday.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bENHNHANBindingSource, "NGAYSINH", true));
            this.txtBirthday.EditValue = null;
            this.txtBirthday.Location = new System.Drawing.Point(159, 215);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtBirthday.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtBirthday.Size = new System.Drawing.Size(206, 28);
            this.txtBirthday.TabIndex = 7;
            // 
            // txtLastName
            // 
            this.txtLastName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bENHNHANBindingSource, "TEN", true));
            this.txtLastName.Location = new System.Drawing.Point(159, 152);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Properties.MaxLength = 30;
            this.txtLastName.Size = new System.Drawing.Size(206, 28);
            this.txtLastName.TabIndex = 5;
            // 
            // txtFirstName
            // 
            this.txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bENHNHANBindingSource, "HO", true));
            this.txtFirstName.Location = new System.Drawing.Point(159, 84);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Properties.MaxLength = 50;
            this.txtFirstName.Size = new System.Drawing.Size(206, 28);
            this.txtFirstName.TabIndex = 3;
            // 
            // txtPatientId
            // 
            this.txtPatientId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bENHNHANBindingSource, "MABN", true));
            this.txtPatientId.Location = new System.Drawing.Point(159, 26);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.Properties.MaxLength = 10;
            this.txtPatientId.Size = new System.Drawing.Size(206, 28);
            this.txtPatientId.TabIndex = 1;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1133, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 738);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1133, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 704);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1133, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 704);
            // 
            // cHITIETCHUATRIBindingSource
            // 
            this.cHITIETCHUATRIBindingSource.DataMember = "FK_CHITIETCHUATRI_BENHNHAN";
            this.cHITIETCHUATRIBindingSource.DataSource = this.bENHNHANBindingSource;
            // 
            // cHITIETCHUATRITableAdapter
            // 
            this.cHITIETCHUATRITableAdapter.ClearBeforeFill = true;
            // 
            // cHITIETOBindingSource
            // 
            this.cHITIETOBindingSource.DataMember = "FK_CHITIETO_BENHNHAN";
            this.cHITIETOBindingSource.DataSource = this.bENHNHANBindingSource;
            // 
            // cHITIETOTableAdapter
            // 
            this.cHITIETOTableAdapter.ClearBeforeFill = true;
            // 
            // bENHNHANGridControl
            // 
            this.bENHNHANGridControl.DataSource = this.bENHNHANBindingSource;
            this.bENHNHANGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.bENHNHANGridControl.Location = new System.Drawing.Point(0, 34);
            this.bENHNHANGridControl.MainView = this.gridView1;
            this.bENHNHANGridControl.MenuManager = this.barManager1;
            this.bENHNHANGridControl.Name = "bENHNHANGridControl";
            this.bENHNHANGridControl.Size = new System.Drawing.Size(1133, 280);
            this.bENHNHANGridControl.TabIndex = 5;
            this.bENHNHANGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.bENHNHANGridControl.Click += new System.EventHandler(this.bENHNHANGridControl_Click_1);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMABN,
            this.colHO,
            this.colTEN,
            this.colNGAYSINH,
            this.colLOAI,
            this.colMABSTN});
            this.gridView1.GridControl = this.bENHNHANGridControl;
            this.gridView1.Name = "gridView1";
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
            this.colMABN.Width = 112;
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
            this.colNGAYSINH.Width = 112;
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
            this.colLOAI.Width = 112;
            // 
            // colMABSTN
            // 
            this.colMABSTN.Caption = "Bác sĩ tiếp nhận";
            this.colMABSTN.FieldName = "MABSTN";
            this.colMABSTN.MinWidth = 30;
            this.colMABSTN.Name = "colMABSTN";
            this.colMABSTN.OptionsColumn.AllowEdit = false;
            this.colMABSTN.Visible = true;
            this.colMABSTN.VisibleIndex = 5;
            this.colMABSTN.Width = 112;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 314);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 424);
            this.panel1.TabIndex = 6;
            // 
            // gET_DOCTORSTableAdapter
            // 
            this.gET_DOCTORSTableAdapter.ClearBeforeFill = true;
            // 
            // frmPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 738);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bENHNHANGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmPatient";
            this.Text = " Bệnh nhân";
            this.Load += new System.EventHandler(this.frmPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLBVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bENHNHANBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gETDOCTORSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirthday.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirthday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatientId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETCHUATRIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bENHNHANGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLBVDataSet qLBVDataSet;
        private System.Windows.Forms.BindingSource bENHNHANBindingSource;
        private QLBVDataSetTableAdapters.BENHNHANTableAdapter bENHNHANTableAdapter;
        private QLBVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbType;
        private DevExpress.XtraEditors.DateEdit txtBirthday;
        private DevExpress.XtraEditors.TextEdit txtLastName;
        private DevExpress.XtraEditors.TextEdit txtFirstName;
        private DevExpress.XtraEditors.TextEdit txtPatientId;
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
        private System.Windows.Forms.BindingSource cHITIETCHUATRIBindingSource;
        private QLBVDataSetTableAdapters.CHITIETCHUATRITableAdapter cHITIETCHUATRITableAdapter;
        private System.Windows.Forms.BindingSource cHITIETOBindingSource;
        private QLBVDataSetTableAdapters.CHITIETOTableAdapter cHITIETOTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl bENHNHANGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbWelcomDoctor;
        private DevExpress.XtraGrid.Columns.GridColumn colMABN;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colLOAI;
        private DevExpress.XtraGrid.Columns.GridColumn colMABSTN;
        private System.Windows.Forms.BindingSource gETDOCTORSBindingSource;
        private QLBVDataSetTableAdapters.GET_DOCTORSTableAdapter gET_DOCTORSTableAdapter;
    }
}