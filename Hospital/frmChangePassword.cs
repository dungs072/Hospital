using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class frmChangePassword : DevExpress.XtraEditors.XtraForm
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtOldPassword.Text == "")
            {
                MessageBox.Show("Mật khẩu cũ không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOldPassword.Focus();
                return;
            }
            if (txtNewPassword.Text == "")
            {
                MessageBox.Show("Mật khẩu mới không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNewPassword.Focus();
                return;
            }
            if (txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Xác nhận mật khẩu mới không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmPassword.Focus();
                return;
            }
            if (txtConfirmPassword.Text != txtNewPassword.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không trùng với mật khẩu mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmPassword.Focus();
                return;
            }
            if (txtOldPassword.Text != Program.password)
            {
                MessageBox.Show("Mật khẩu cũ không chính xác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOldPassword.Focus();
                return;
            }
            if (Program.Connect() == 0) { return; }
            string cmd = string.Format("EXEC CHANGE_PASSWORD '{0}','{1}'", Program.mLogin, txtNewPassword.Text);
            int result = Program.ExecSqlNonQuery(cmd);
            if (result == 0)
            {
                MessageBox.Show("Thay đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtConfirmPassword.Text = "";
                txtNewPassword.Text = "";
                txtOldPassword.Text = "";
            }
        }
    }
}