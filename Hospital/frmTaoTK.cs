using DevExpress.XtraEditors;
using Hospital.Class;
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
    public partial class frmTaoTK : DevExpress.XtraEditors.XtraForm
    {
        public frmTaoTK()
        {
            InitializeComponent();
        }

        private void btnChonNhanVien_Click(object sender, EventArgs e)
        {
            frmDsNhanVien ds = new frmDsNhanVien();
            ds.ShowDialog();
            txtMaNhanVien.Text = Program.MaNhanVienChon;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private bool kiemTra()
        {
            
                if (txtMaNhanVien.Text.Trim().Length == 0)
                {
                    MessageBox.Show("user  name không được để trống", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
            if (txtLoginName.Text.Trim().Length == 0) {
                MessageBox.Show("Login name không được để trống", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (txtPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if (txtPassWordXacNhan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mật khẩu xác nhận  không được để trống", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if (txtPassword.Text.Trim().CompareTo(txtPassWordXacNhan.Text.Trim()) !=0)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không trùng nhau", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void ResetLogin()
        {
            txtMaNhanVien.Text = "";
            txtLoginName.Text = "";
            txtPassword.Text = "";
            txtPassWordXacNhan.Text = "";
        }
        private void btnTao_Click(object sender, EventArgs e)
        {
            if(kiemTra()== false)
            {
                return;
            }
            String truyvan = "DECLARE @kq int EXEC @kq = sp_danh_sach_login_server '" + txtLoginName.Text.Trim() + "' SELECT @kq";
            try
            {
                Program.myReader = Program.ExecSqlDataReader(truyvan);
                if (Program.myReader == null)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Program.myReader.Read();
            int ketqua = int.Parse(Program.myReader.GetValue(0).ToString());

            Program.myReader.Close();

            if(ketqua == 1)
            {
                MessageBox.Show("Login name đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {

                try
                {
                    string truyvantaotk = "EXEC sp_TaoTaiKhoan1 '" + txtLoginName.Text.Trim() + "','" + txtPassword.Text.Trim() + "','" 
                    + txtMaNhanVien.Text.Trim() + "','" + cbbQuyen.SelectedValue.ToString() + "'" ;
                    Program.myReader = Program.ExecSqlDataReader(truyvantaotk);
                    if (Program.myReader == null)
                    {
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thực thi database thất bại " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Program.myReader.Close();
                MessageBox.Show("Tạo login" + txtMaNhanVien.Text + "thành công ", "WARNING", MessageBoxButtons.OK);
                ResetLogin();
            }

        }
        

        private void frmTaoTK_Load(object sender, EventArgs e)
        {

            var target = new List<RoleClass>(Program.roles);

            this.cbbQuyen.DataSource = target;
            this.cbbQuyen.DisplayMember = "MAQUYEN";
            this.cbbQuyen.ValueMember = "TENQUYEN";
            cbbQuyen.SelectedIndex = 0;
           
        }
    }
}