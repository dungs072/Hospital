namespace Hospital
{
    partial class frmTaoTK
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnTao = new System.Windows.Forms.Button();
            this.l = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChonNhanVien = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbQuyen = new System.Windows.Forms.ComboBox();
            this.txtPassWordXacNhan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên : ";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Enabled = false;
            this.txtMaNhanVien.Location = new System.Drawing.Point(378, 127);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(175, 27);
            this.txtMaNhanVien.TabIndex = 1;
            // 
            // txtLoginName
            // 
            this.txtLoginName.Location = new System.Drawing.Point(377, 182);
            this.txtLoginName.MaxLength = 30;
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(176, 27);
            this.txtLoginName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên tài khoản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật khẩu:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(377, 237);
            this.txtPassword.MaxLength = 30;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(176, 27);
            this.txtPassword.TabIndex = 5;
            // 
            // btnTao
            // 
            this.btnTao.BackColor = System.Drawing.Color.Teal;
            this.btnTao.Location = new System.Drawing.Point(176, 416);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(166, 43);
            this.btnTao.TabIndex = 6;
            this.btnTao.Text = "TẠO TÀI KHOẢN";
            this.btnTao.UseVisualStyleBackColor = false;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.Location = new System.Drawing.Point(235, 16);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(439, 34);
            this.l.TabIndex = 7;
            this.l.Text = "TẠO TÀI KHOẢN CHO NHÂN VIÊN";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Teal;
            this.btnCancel.Location = new System.Drawing.Point(511, 416);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(163, 43);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChonNhanVien
            // 
            this.btnChonNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnChonNhanVien.Location = new System.Drawing.Point(593, 119);
            this.btnChonNhanVien.Name = "btnChonNhanVien";
            this.btnChonNhanVien.Size = new System.Drawing.Size(157, 41);
            this.btnChonNhanVien.TabIndex = 9;
            this.btnChonNhanVien.Text = "CHỌN NHÂN VIÊN";
            this.btnChonNhanVien.UseVisualStyleBackColor = false;
            this.btnChonNhanVien.Click += new System.EventHandler(this.btnChonNhanVien_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nhóm quyền:";
            // 
            // cbbQuyen
            // 
            this.cbbQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbQuyen.FormattingEnabled = true;
            this.cbbQuyen.Location = new System.Drawing.Point(377, 349);
            this.cbbQuyen.Name = "cbbQuyen";
            this.cbbQuyen.Size = new System.Drawing.Size(175, 27);
            this.cbbQuyen.TabIndex = 11;
            this.cbbQuyen.SelectedIndexChanged += new System.EventHandler(this.cbbQuyen_SelectedIndexChanged);
            // 
            // txtPassWordXacNhan
            // 
            this.txtPassWordXacNhan.Location = new System.Drawing.Point(378, 293);
            this.txtPassWordXacNhan.MaxLength = 30;
            this.txtPassWordXacNhan.Name = "txtPassWordXacNhan";
            this.txtPassWordXacNhan.PasswordChar = '*';
            this.txtPassWordXacNhan.Size = new System.Drawing.Size(176, 27);
            this.txtPassWordXacNhan.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Xác nhận mật khẩu:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.txtPassWordXacNhan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtMaNhanVien);
            this.panel1.Controls.Add(this.cbbQuyen);
            this.panel1.Controls.Add(this.txtLoginName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnChonNhanVien);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.l);
            this.panel1.Controls.Add(this.btnTao);
            this.panel1.Location = new System.Drawing.Point(56, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 466);
            this.panel1.TabIndex = 14;
            // 
            // frmTaoTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 499);
            this.Controls.Add(this.panel1);
            this.Name = "frmTaoTK";
            this.Text = "Tạo tài khoản";
            this.Load += new System.EventHandler(this.frmTaoTK_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChonNhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbQuyen;
        private System.Windows.Forms.TextBox txtPassWordXacNhan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}