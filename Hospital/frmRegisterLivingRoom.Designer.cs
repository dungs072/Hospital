
namespace Hospital
{
    partial class frmRegisterLivingRoom
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sP_GET_VACANT_ROOMGridControl = new DevExpress.XtraGrid.GridControl();
            this.sP_GET_VACANT_ROOMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBVDataSet = new Hospital.QLBVDataSet();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGIUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOGIUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.fKPHONGKHUCHUATRIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHUCHUATRIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pATIENT_NOT_REGISTER_LIVING_ROOMGridControl = new DevExpress.XtraGrid.GridControl();
            this.pATIENT_NOT_REGISTER_LIVING_ROOMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMABN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.tableAdapterManager = new Hospital.QLBVDataSetTableAdapters.TableAdapterManager();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kHUCHUATRITableAdapter = new Hospital.QLBVDataSetTableAdapters.KHUCHUATRITableAdapter();
            this.pHONGTableAdapter = new Hospital.QLBVDataSetTableAdapters.PHONGTableAdapter();
            this.pATIENT_NOT_REGISTER_LIVING_ROOMTableAdapter = new Hospital.QLBVDataSetTableAdapters.PATIENT_NOT_REGISTER_LIVING_ROOMTableAdapter();
            this.sP_GET_VACANT_ROOMTableAdapter = new Hospital.QLBVDataSetTableAdapters.SP_GET_VACANT_ROOMTableAdapter();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GET_VACANT_ROOMGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GET_VACANT_ROOMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKPHONGKHUCHUATRIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHUCHUATRIBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENT_NOT_REGISTER_LIVING_ROOMGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENT_NOT_REGISTER_LIVING_ROOMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1729, 282);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.sP_GET_VACANT_ROOMGridControl);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(994, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(735, 282);
            this.panel3.TabIndex = 1;
            // 
            // sP_GET_VACANT_ROOMGridControl
            // 
            this.sP_GET_VACANT_ROOMGridControl.DataSource = this.sP_GET_VACANT_ROOMBindingSource;
            this.sP_GET_VACANT_ROOMGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_GET_VACANT_ROOMGridControl.Location = new System.Drawing.Point(0, 104);
            this.sP_GET_VACANT_ROOMGridControl.MainView = this.gridView2;
            this.sP_GET_VACANT_ROOMGridControl.MenuManager = this.barManager1;
            this.sP_GET_VACANT_ROOMGridControl.Name = "sP_GET_VACANT_ROOMGridControl";
            this.sP_GET_VACANT_ROOMGridControl.Size = new System.Drawing.Size(733, 176);
            this.sP_GET_VACANT_ROOMGridControl.TabIndex = 2;
            this.sP_GET_VACANT_ROOMGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // sP_GET_VACANT_ROOMBindingSource
            // 
            this.sP_GET_VACANT_ROOMBindingSource.DataMember = "SP_GET_VACANT_ROOM";
            this.sP_GET_VACANT_ROOMBindingSource.DataSource = this.qLBVDataSet;
            // 
            // qLBVDataSet
            // 
            this.qLBVDataSet.DataSetName = "QLBVDataSet";
            this.qLBVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGIUONG,
            this.colSOGIUONG});
            this.gridView2.GridControl = this.sP_GET_VACANT_ROOMGridControl;
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
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1729, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 683);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1729, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 663);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1729, 20);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 663);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label5);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 68);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(733, 36);
            this.panel7.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(229, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "DANH SÁCH GIƯỜNG CÒN TRỐNG";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.cmbRoom);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.cmbArea);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(733, 68);
            this.panel5.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phòng:";
            // 
            // cmbRoom
            // 
            this.cmbRoom.DataSource = this.fKPHONGKHUCHUATRIBindingSource;
            this.cmbRoom.DisplayMember = "SOPHONG";
            this.cmbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(375, 20);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(179, 27);
            this.cmbRoom.TabIndex = 4;
            this.cmbRoom.ValueMember = "MAPHONG";
           
            this.cmbRoom.SelectedValueChanged += new System.EventHandler(this.cmbRoom_SelectedValueChanged);
            // 
            // fKPHONGKHUCHUATRIBindingSource
            // 
            this.fKPHONGKHUCHUATRIBindingSource.DataMember = "FK_PHONG_KHUCHUATRI";
            this.fKPHONGKHUCHUATRIBindingSource.DataSource = this.kHUCHUATRIBindingSource;
            // 
            // kHUCHUATRIBindingSource
            // 
            this.kHUCHUATRIBindingSource.DataMember = "KHUCHUATRI";
            this.kHUCHUATRIBindingSource.DataSource = this.qLBVDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Khu:";
            // 
            // cmbArea
            // 
            this.cmbArea.DataSource = this.kHUCHUATRIBindingSource;
            this.cmbArea.DisplayMember = "TEN";
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(56, 20);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(247, 27);
            this.cmbArea.TabIndex = 2;
            this.cmbArea.ValueMember = "DANHDINHKHU";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pATIENT_NOT_REGISTER_LIVING_ROOMGridControl);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(994, 282);
            this.panel2.TabIndex = 0;
            // 
            // pATIENT_NOT_REGISTER_LIVING_ROOMGridControl
            // 
            this.pATIENT_NOT_REGISTER_LIVING_ROOMGridControl.DataSource = this.pATIENT_NOT_REGISTER_LIVING_ROOMBindingSource;
            this.pATIENT_NOT_REGISTER_LIVING_ROOMGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pATIENT_NOT_REGISTER_LIVING_ROOMGridControl.Location = new System.Drawing.Point(0, 104);
            this.pATIENT_NOT_REGISTER_LIVING_ROOMGridControl.MainView = this.gridView1;
            this.pATIENT_NOT_REGISTER_LIVING_ROOMGridControl.MenuManager = this.barManager1;
            this.pATIENT_NOT_REGISTER_LIVING_ROOMGridControl.Name = "pATIENT_NOT_REGISTER_LIVING_ROOMGridControl";
            this.pATIENT_NOT_REGISTER_LIVING_ROOMGridControl.Size = new System.Drawing.Size(992, 176);
            this.pATIENT_NOT_REGISTER_LIVING_ROOMGridControl.TabIndex = 2;
            this.pATIENT_NOT_REGISTER_LIVING_ROOMGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // pATIENT_NOT_REGISTER_LIVING_ROOMBindingSource
            // 
            this.pATIENT_NOT_REGISTER_LIVING_ROOMBindingSource.DataMember = "PATIENT_NOT_REGISTER_LIVING_ROOM";
            this.pATIENT_NOT_REGISTER_LIVING_ROOMBindingSource.DataSource = this.qLBVDataSet;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMABN,
            this.colHO,
            this.colTEN,
            this.colNGAYSINH,
            this.colLOAI});
            this.gridView1.GridControl = this.pATIENT_NOT_REGISTER_LIVING_ROOMGridControl;
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
            this.colLOAI.Width = 112;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 68);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(992, 36);
            this.panel6.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(251, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(413, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "DANH SÁCH BỆNH NHÂN CHƯA ĐĂNG KÍ GIƯỜNG";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.cmbType);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(992, 68);
            this.panel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kiểu:";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(84, 20);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(179, 27);
            this.cmbType.TabIndex = 0;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
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
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.GIUONGTableAdapter = null;
            this.tableAdapterManager.KHUCHUATRITableAdapter = null;
            this.tableAdapterManager.LOAICHUATRITableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHONGTableAdapter = null;
            this.tableAdapterManager.TUANTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Hospital.QLBVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VATTUTableAdapter = null;
            // 
            // popupMenu1
            // 
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 302);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 381);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // kHUCHUATRITableAdapter
            // 
            this.kHUCHUATRITableAdapter.ClearBeforeFill = true;
            // 
            // pHONGTableAdapter
            // 
            this.pHONGTableAdapter.ClearBeforeFill = true;
            // 
            // pATIENT_NOT_REGISTER_LIVING_ROOMTableAdapter
            // 
            this.pATIENT_NOT_REGISTER_LIVING_ROOMTableAdapter.ClearBeforeFill = true;
            // 
            // sP_GET_VACANT_ROOMTableAdapter
            // 
            this.sP_GET_VACANT_ROOMTableAdapter.ClearBeforeFill = true;
            // 
            // frmRegisterLivingRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1729, 683);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmRegisterLivingRoom";
            this.Text = "Đăng kí phòng ở";
            this.Load += new System.EventHandler(this.frmRegisterLivingRoom_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sP_GET_VACANT_ROOMGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GET_VACANT_ROOMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKPHONGKHUCHUATRIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHUCHUATRIBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pATIENT_NOT_REGISTER_LIVING_ROOMGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENT_NOT_REGISTER_LIVING_ROOMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbType;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private QLBVDataSet qLBVDataSet;
        private QLBVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource kHUCHUATRIBindingSource;
        private QLBVDataSetTableAdapters.KHUCHUATRITableAdapter kHUCHUATRITableAdapter;
        private System.Windows.Forms.BindingSource fKPHONGKHUCHUATRIBindingSource;
        private QLBVDataSetTableAdapters.PHONGTableAdapter pHONGTableAdapter;
        private System.Windows.Forms.BindingSource pATIENT_NOT_REGISTER_LIVING_ROOMBindingSource;
        private QLBVDataSetTableAdapters.PATIENT_NOT_REGISTER_LIVING_ROOMTableAdapter pATIENT_NOT_REGISTER_LIVING_ROOMTableAdapter;
        private DevExpress.XtraGrid.GridControl pATIENT_NOT_REGISTER_LIVING_ROOMGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMABN;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colLOAI;
        private System.Windows.Forms.BindingSource sP_GET_VACANT_ROOMBindingSource;
        private QLBVDataSetTableAdapters.SP_GET_VACANT_ROOMTableAdapter sP_GET_VACANT_ROOMTableAdapter;
        private DevExpress.XtraGrid.GridControl sP_GET_VACANT_ROOMGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGIUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colSOGIUONG;
    }
}