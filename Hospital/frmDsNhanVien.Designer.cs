namespace Hospital
{
    partial class frmDsNhanVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.qLBVDataSet = new Hospital.QLBVDataSet();
            this.bdsNhanVienKhongTK = new System.Windows.Forms.BindingSource(this.components);
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOANTableAdapter = new Hospital.QLBVDataSetTableAdapters.SP_DS_NHANVIEN_KHONG_TAI_KHOANTableAdapter();
            this.tableAdapterManager = new Hospital.QLBVDataSetTableAdapters.TableAdapterManager();
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOANGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLBVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVienKhongTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DS_NHANVIEN_KHONG_TAI_KHOANGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "DANH SÁCH NHÂN VIÊN ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 80);
            this.panel1.TabIndex = 4;
            // 
            // qLBVDataSet
            // 
            this.qLBVDataSet.DataSetName = "QLBVDataSet";
            this.qLBVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsNhanVienKhongTK
            // 
            this.bdsNhanVienKhongTK.DataMember = "SP_DS_NHANVIEN_KHONG_TAI_KHOAN";
            this.bdsNhanVienKhongTK.DataSource = this.qLBVDataSet;
            // 
            // sP_DS_NHANVIEN_KHONG_TAI_KHOANTableAdapter
            // 
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOANTableAdapter.ClearBeforeFill = true;
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
            // sP_DS_NHANVIEN_KHONG_TAI_KHOANGridControl
            // 
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOANGridControl.DataSource = this.bdsNhanVienKhongTK;
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOANGridControl.Location = new System.Drawing.Point(97, 134);
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOANGridControl.MainView = this.gridView1;
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOANGridControl.Name = "sP_DS_NHANVIEN_KHONG_TAI_KHOANGridControl";
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOANGridControl.Size = new System.Drawing.Size(646, 278);
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOANGridControl.TabIndex = 5;
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOANGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colMACV});
            this.gridView1.GridControl = this.sP_DS_NHANVIEN_KHONG_TAI_KHOANGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMANV
            // 
            this.colMANV.Caption = "MÃ NHÂN VIÊN";
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 30;
            this.colMANV.Name = "colMANV";
            this.colMANV.OptionsColumn.AllowEdit = false;
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            this.colMANV.Width = 112;
            // 
            // colHO
            // 
            this.colHO.Caption = "HỌ";
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
            this.colTEN.Caption = "TÊN";
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 30;
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.AllowEdit = false;
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 112;
            // 
            // colMACV
            // 
            this.colMACV.Caption = "MÃ CHỨC VỤ";
            this.colMACV.FieldName = "MACV";
            this.colMACV.MinWidth = 30;
            this.colMACV.Name = "colMACV";
            this.colMACV.OptionsColumn.AllowEdit = false;
            this.colMACV.Visible = true;
            this.colMACV.VisibleIndex = 3;
            this.colMACV.Width = 112;
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(197, 449);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(107, 48);
            this.btnChon.TabIndex = 6;
            this.btnChon.Text = "CHỌN ";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(510, 449);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 48);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmDsNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 542);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.sP_DS_NHANVIEN_KHONG_TAI_KHOANGridControl);
            this.Controls.Add(this.panel1);
            this.Name = "frmDsNhanVien";
            this.Text = "frmDsNhanVien";
            this.Load += new System.EventHandler(this.frmDsNhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLBVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVienKhongTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DS_NHANVIEN_KHONG_TAI_KHOANGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private QLBVDataSet qLBVDataSet;
        private System.Windows.Forms.BindingSource bdsNhanVienKhongTK;
        private QLBVDataSetTableAdapters.SP_DS_NHANVIEN_KHONG_TAI_KHOANTableAdapter sP_DS_NHANVIEN_KHONG_TAI_KHOANTableAdapter;
        private QLBVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sP_DS_NHANVIEN_KHONG_TAI_KHOANGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnCancel;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colMACV;
    }
}