
namespace Hospital
{
    partial class frmStaffList
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOANGridControl = new DevExpress.XtraGrid.GridControl();
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBVDataSet = new Hospital.QLBVDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOANTableAdapter = new Hospital.QLBVDataSetTableAdapters.SP_DS_NHANVIEN_KHONG_TAI_KHOANTableAdapter();
            this.tableAdapterManager = new Hospital.QLBVDataSetTableAdapters.TableAdapterManager();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DS_NHANVIEN_KHONG_TAI_KHOANGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DS_NHANVIEN_KHONG_TAI_KHOANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(131, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 384);
            this.panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.Location = new System.Drawing.Point(459, 343);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 33);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSelect.Location = new System.Drawing.Point(162, 343);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(130, 33);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Chọn";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.sP_DS_NHANVIEN_KHONG_TAI_KHOANGridControl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(785, 340);
            this.panel3.TabIndex = 2;
            // 
            // sP_DS_NHANVIEN_KHONG_TAI_KHOANGridControl
            // 
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOANGridControl.DataSource = this.sP_DS_NHANVIEN_KHONG_TAI_KHOANBindingSource;
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOANGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOANGridControl.Location = new System.Drawing.Point(0, 0);
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOANGridControl.MainView = this.gridView1;
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOANGridControl.Name = "sP_DS_NHANVIEN_KHONG_TAI_KHOANGridControl";
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOANGridControl.Size = new System.Drawing.Size(785, 269);
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOANGridControl.TabIndex = 0;
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOANGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sP_DS_NHANVIEN_KHONG_TAI_KHOANBindingSource
            // 
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOANBindingSource.DataMember = "SP_DS_NHANVIEN_KHONG_TAI_KHOAN";
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOANBindingSource.DataSource = this.qLBVDataSet;
            // 
            // qLBVDataSet
            // 
            this.qLBVDataSet.DataSetName = "QLBVDataSet";
            this.qLBVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN});
            this.gridView1.GridControl = this.sP_DS_NHANVIEN_KHONG_TAI_KHOANGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Title);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(785, 52);
            this.panel2.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Title.Location = new System.Drawing.Point(279, 20);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(205, 19);
            this.Title.TabIndex = 0;
            this.Title.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // sP_DS_NHANVIEN_KHONG_TAI_KHOANTableAdapter
            // 
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOANTableAdapter.ClearBeforeFill = true;
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
            this.colHO.Caption = "Họ ";
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
            // frmStaffList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 479);
            this.Controls.Add(this.panel1);
            this.Name = "frmStaffList";
            this.Text = "Danh sách nhân viên";
            this.Load += new System.EventHandler(this.frmStaffList_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sP_DS_NHANVIEN_KHONG_TAI_KHOANGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DS_NHANVIEN_KHONG_TAI_KHOANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private QLBVDataSet qLBVDataSet;
        private System.Windows.Forms.BindingSource sP_DS_NHANVIEN_KHONG_TAI_KHOANBindingSource;
        private QLBVDataSetTableAdapters.SP_DS_NHANVIEN_KHONG_TAI_KHOANTableAdapter sP_DS_NHANVIEN_KHONG_TAI_KHOANTableAdapter;
        private QLBVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Title;
        private DevExpress.XtraGrid.GridControl sP_DS_NHANVIEN_KHONG_TAI_KHOANGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
    }
}