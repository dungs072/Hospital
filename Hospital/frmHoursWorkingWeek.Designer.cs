
namespace Hospital
{
    partial class frmHoursWorkingWeek
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.cmbWeek = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.qLBVDataSet = new Hospital.QLBVDataSet();
            this.kHUCHUATRIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHUCHUATRITableAdapter = new Hospital.QLBVDataSetTableAdapters.KHUCHUATRITableAdapter();
            this.gETWEEKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gET_WEEKTableAdapter = new Hospital.QLBVDataSetTableAdapters.GET_WEEKTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLBVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHUCHUATRIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gETWEEKBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 380);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.btnPreview);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbWeek);
            this.groupBox1.Controls.Add(this.cmbArea);
            this.groupBox1.Location = new System.Drawing.Point(367, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn lựa";
            // 
            // cmbArea
            // 
            this.cmbArea.DataSource = this.kHUCHUATRIBindingSource;
            this.cmbArea.DisplayMember = "TEN";
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(108, 44);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(225, 27);
            this.cmbArea.TabIndex = 0;
            this.cmbArea.ValueMember = "DANHDINHKHU";
            // 
            // cmbWeek
            // 
            this.cmbWeek.DataSource = this.gETWEEKBindingSource;
            this.cmbWeek.DisplayMember = "INFOR";
            this.cmbWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWeek.FormattingEnabled = true;
            this.cmbWeek.Location = new System.Drawing.Point(108, 117);
            this.cmbWeek.Name = "cmbWeek";
            this.cmbWeek.Size = new System.Drawing.Size(225, 27);
            this.cmbWeek.TabIndex = 1;
            this.cmbWeek.ValueMember = "ID_TUAN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(24, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Khu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(24, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tuần:";
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPreview.Location = new System.Drawing.Point(142, 200);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(151, 41);
            this.btnPreview.TabIndex = 4;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
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
            // gETWEEKBindingSource
            // 
            this.gETWEEKBindingSource.DataMember = "GET_WEEK";
            this.gETWEEKBindingSource.DataSource = this.qLBVDataSet;
            // 
            // gET_WEEKTableAdapter
            // 
            this.gET_WEEKTableAdapter.ClearBeforeFill = true;
            // 
            // frmHoursWorkingWeek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 429);
            this.Controls.Add(this.panel1);
            this.Name = "frmHoursWorkingWeek";
            this.Text = "Thời gian làm việc theo tuần của các nhân viên";
            this.Load += new System.EventHandler(this.frmHoursWorkingWeek_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLBVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHUCHUATRIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gETWEEKBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbWeek;
        private System.Windows.Forms.ComboBox cmbArea;
        private QLBVDataSet qLBVDataSet;
        private System.Windows.Forms.BindingSource kHUCHUATRIBindingSource;
        private QLBVDataSetTableAdapters.KHUCHUATRITableAdapter kHUCHUATRITableAdapter;
        private System.Windows.Forms.BindingSource gETWEEKBindingSource;
        private QLBVDataSetTableAdapters.GET_WEEKTableAdapter gET_WEEKTableAdapter;
    }
}