
namespace Hospital
{
    partial class frmProvidePrivilege
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGoTo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btnGoTo);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtLoginName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(217, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 272);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản:";
            // 
            // txtLoginName
            // 
            this.txtLoginName.Location = new System.Drawing.Point(223, 90);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(286, 27);
            this.txtLoginName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(50, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(519, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "YÊU CẦU NHẬP TÀI KHOẢN CÓ QUYỀN CAO HƠN ĐỂ THỰC THI";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(223, 153);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(286, 27);
            this.txtPassword.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật khẩu:";
            // 
            // btnGoTo
            // 
            this.btnGoTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGoTo.Location = new System.Drawing.Point(206, 213);
            this.btnGoTo.Name = "btnGoTo";
            this.btnGoTo.Size = new System.Drawing.Size(215, 36);
            this.btnGoTo.TabIndex = 5;
            this.btnGoTo.Text = "Go to";
            this.btnGoTo.UseVisualStyleBackColor = false;
            this.btnGoTo.Click += new System.EventHandler(this.btnGoTo_Click);
            // 
            // frmProvidePrivilege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 459);
            this.Controls.Add(this.panel1);
            this.Name = "frmProvidePrivilege";
            this.Text = "Cấp quyền ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGoTo;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.Label label1;
    }
}