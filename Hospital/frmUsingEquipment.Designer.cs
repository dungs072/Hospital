
namespace Hospital
{
    partial class frmUsingEquipment
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
            this.qLBVDataSet = new Hospital.QLBVDataSet();
            this.tableAdapterManager = new Hospital.QLBVDataSetTableAdapters.TableAdapterManager();
            this.btnPreview = new System.Windows.Forms.Button();
            this.gET_ALL_PATIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gET_ALL_PATIENTTableAdapter = new Hospital.QLBVDataSetTableAdapters.GET_ALL_PATIENTTableAdapter();
            this.gET_ALL_PATIENTGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMABN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBACSITHEODOI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBACSITEPNHAN = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.qLBVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_ALL_PATIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_ALL_PATIENTGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // qLBVDataSet
            // 
            this.qLBVDataSet.DataSetName = "QLBVDataSet";
            this.qLBVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // btnPreview
            // 
            this.btnPreview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPreview.Location = new System.Drawing.Point(425, 324);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(229, 63);
            this.btnPreview.TabIndex = 2;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // gET_ALL_PATIENTBindingSource
            // 
            this.gET_ALL_PATIENTBindingSource.DataMember = "GET_ALL_PATIENT";
            this.gET_ALL_PATIENTBindingSource.DataSource = this.qLBVDataSet;
            // 
            // gET_ALL_PATIENTTableAdapter
            // 
            this.gET_ALL_PATIENTTableAdapter.ClearBeforeFill = true;
            // 
            // gET_ALL_PATIENTGridControl
            // 
            this.gET_ALL_PATIENTGridControl.DataSource = this.gET_ALL_PATIENTBindingSource;
            this.gET_ALL_PATIENTGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.gET_ALL_PATIENTGridControl.Location = new System.Drawing.Point(0, 0);
            this.gET_ALL_PATIENTGridControl.MainView = this.gridView1;
            this.gET_ALL_PATIENTGridControl.Name = "gET_ALL_PATIENTGridControl";
            this.gET_ALL_PATIENTGridControl.Size = new System.Drawing.Size(1147, 261);
            this.gET_ALL_PATIENTGridControl.TabIndex = 3;
            this.gET_ALL_PATIENTGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMABN,
            this.colHO,
            this.colTEN,
            this.colNGAYSINH,
            this.colBACSITHEODOI,
            this.colLOAI,
            this.colBACSITEPNHAN});
            this.gridView1.GridControl = this.gET_ALL_PATIENTGridControl;
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
            // colBACSITHEODOI
            // 
            this.colBACSITHEODOI.Caption = "Bác sĩ theo dõi";
            this.colBACSITHEODOI.FieldName = "BACSITHEODOI";
            this.colBACSITHEODOI.MinWidth = 30;
            this.colBACSITHEODOI.Name = "colBACSITHEODOI";
            this.colBACSITHEODOI.OptionsColumn.AllowEdit = false;
            this.colBACSITHEODOI.Visible = true;
            this.colBACSITHEODOI.VisibleIndex = 4;
            this.colBACSITHEODOI.Width = 112;
            // 
            // colLOAI
            // 
            this.colLOAI.Caption = "Loại";
            this.colLOAI.FieldName = "LOAI";
            this.colLOAI.MinWidth = 30;
            this.colLOAI.Name = "colLOAI";
            this.colLOAI.OptionsColumn.AllowEdit = false;
            this.colLOAI.Visible = true;
            this.colLOAI.VisibleIndex = 5;
            this.colLOAI.Width = 112;
            // 
            // colBACSITEPNHAN
            // 
            this.colBACSITEPNHAN.Caption = "Bác sĩ tiếp nhận";
            this.colBACSITEPNHAN.FieldName = "BACSITEPNHAN";
            this.colBACSITEPNHAN.MinWidth = 30;
            this.colBACSITEPNHAN.Name = "colBACSITEPNHAN";
            this.colBACSITEPNHAN.OptionsColumn.AllowEdit = false;
            this.colBACSITEPNHAN.Visible = true;
            this.colBACSITEPNHAN.VisibleIndex = 6;
            this.colBACSITEPNHAN.Width = 112;
            // 
            // frmUsingEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 440);
            this.Controls.Add(this.gET_ALL_PATIENTGridControl);
            this.Controls.Add(this.btnPreview);
            this.Name = "frmUsingEquipment";
            this.Text = "Bệnh nhân sử dụng vật tư";
            this.Load += new System.EventHandler(this.frmUsingEquipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLBVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_ALL_PATIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_ALL_PATIENTGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private QLBVDataSet qLBVDataSet;
        private QLBVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.BindingSource gET_ALL_PATIENTBindingSource;
        private QLBVDataSetTableAdapters.GET_ALL_PATIENTTableAdapter gET_ALL_PATIENTTableAdapter;
        private DevExpress.XtraGrid.GridControl gET_ALL_PATIENTGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMABN;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colBACSITHEODOI;
        private DevExpress.XtraGrid.Columns.GridColumn colLOAI;
        private DevExpress.XtraGrid.Columns.GridColumn colBACSITEPNHAN;
    }
}