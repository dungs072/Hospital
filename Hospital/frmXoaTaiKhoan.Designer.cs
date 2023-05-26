namespace Hospital
{
    partial class frmXoaTaiKhoan
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
            this.bdsNhanVienCoTK = new System.Windows.Forms.BindingSource(this.components);
            this.sP_DS_NHANVIEN_CO_TAI_KHOANTableAdapter = new Hospital.QLBVDataSetTableAdapters.SP_DS_NHANVIEN_CO_TAI_KHOANTableAdapter();
            this.tableAdapterManager = new Hospital.QLBVDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.sP_DS_NHANVIEN_CO_TAI_KHOANGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCONGVIEC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQUYEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOGIN = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.qLBVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVienCoTK)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DS_NHANVIEN_CO_TAI_KHOANGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // qLBVDataSet
            // 
            this.qLBVDataSet.DataSetName = "QLBVDataSet";
            this.qLBVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsNhanVienCoTK
            // 
            this.bdsNhanVienCoTK.DataMember = "SP_DS_NHANVIEN_CO_TAI_KHOAN";
            this.bdsNhanVienCoTK.DataSource = this.qLBVDataSet;
            // 
            // sP_DS_NHANVIEN_CO_TAI_KHOANTableAdapter
            // 
            this.sP_DS_NHANVIEN_CO_TAI_KHOANTableAdapter.ClearBeforeFill = true;
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
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1088, 78);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH NHÂN VIÊN CÓ TÀI KHOẢN";
            // 
            // sP_DS_NHANVIEN_CO_TAI_KHOANGridControl
            // 
            this.sP_DS_NHANVIEN_CO_TAI_KHOANGridControl.DataSource = this.bdsNhanVienCoTK;
            this.sP_DS_NHANVIEN_CO_TAI_KHOANGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.sP_DS_NHANVIEN_CO_TAI_KHOANGridControl.Location = new System.Drawing.Point(0, 78);
            this.sP_DS_NHANVIEN_CO_TAI_KHOANGridControl.MainView = this.gridView1;
            this.sP_DS_NHANVIEN_CO_TAI_KHOANGridControl.Name = "sP_DS_NHANVIEN_CO_TAI_KHOANGridControl";
            this.sP_DS_NHANVIEN_CO_TAI_KHOANGridControl.Size = new System.Drawing.Size(1088, 286);
            this.sP_DS_NHANVIEN_CO_TAI_KHOANGridControl.TabIndex = 1;
            this.sP_DS_NHANVIEN_CO_TAI_KHOANGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colCONGVIEC,
            this.colQUYEN,
            this.colTENLOGIN});
            this.gridView1.GridControl = this.sP_DS_NHANVIEN_CO_TAI_KHOANGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 364);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1088, 190);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.btnDeleteAccount);
            this.panel3.Location = new System.Drawing.Point(176, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(718, 100);
            this.panel3.TabIndex = 2;
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteAccount.Location = new System.Drawing.Point(274, 31);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(153, 40);
            this.btnDeleteAccount.TabIndex = 0;
            this.btnDeleteAccount.Text = "XÓA TÀI KHOẢN";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
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
            // colCONGVIEC
            // 
            this.colCONGVIEC.Caption = "Công việc";
            this.colCONGVIEC.FieldName = "CONGVIEC";
            this.colCONGVIEC.MinWidth = 30;
            this.colCONGVIEC.Name = "colCONGVIEC";
            this.colCONGVIEC.OptionsColumn.AllowEdit = false;
            this.colCONGVIEC.Visible = true;
            this.colCONGVIEC.VisibleIndex = 3;
            this.colCONGVIEC.Width = 112;
            // 
            // colQUYEN
            // 
            this.colQUYEN.Caption = "Quyền";
            this.colQUYEN.FieldName = "QUYEN";
            this.colQUYEN.MinWidth = 30;
            this.colQUYEN.Name = "colQUYEN";
            this.colQUYEN.OptionsColumn.AllowEdit = false;
            this.colQUYEN.Visible = true;
            this.colQUYEN.VisibleIndex = 4;
            this.colQUYEN.Width = 112;
            // 
            // colTENLOGIN
            // 
            this.colTENLOGIN.Caption = "Tên đăng nhập";
            this.colTENLOGIN.FieldName = "TENLOGIN";
            this.colTENLOGIN.MinWidth = 30;
            this.colTENLOGIN.Name = "colTENLOGIN";
            this.colTENLOGIN.OptionsColumn.AllowEdit = false;
            this.colTENLOGIN.Visible = true;
            this.colTENLOGIN.VisibleIndex = 5;
            this.colTENLOGIN.Width = 112;
            // 
            // frmXoaTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sP_DS_NHANVIEN_CO_TAI_KHOANGridControl);
            this.Controls.Add(this.panel1);
            this.Name = "frmXoaTaiKhoan";
            this.Text = "Xóa tài khoản";
            this.Load += new System.EventHandler(this.frmXoaTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLBVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVienCoTK)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DS_NHANVIEN_CO_TAI_KHOANGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private QLBVDataSet qLBVDataSet;
        private System.Windows.Forms.BindingSource bdsNhanVienCoTK;
        private QLBVDataSetTableAdapters.SP_DS_NHANVIEN_CO_TAI_KHOANTableAdapter sP_DS_NHANVIEN_CO_TAI_KHOANTableAdapter;
        private QLBVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl sP_DS_NHANVIEN_CO_TAI_KHOANGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDeleteAccount;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colCONGVIEC;
        private DevExpress.XtraGrid.Columns.GridColumn colQUYEN;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOGIN;
    }
}