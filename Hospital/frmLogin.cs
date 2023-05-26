using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection conn_publisher = new SqlConnection();
        public frmLogin()
        {
            InitializeComponent();
        }
        private int ConnectToRootServer()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối về cơ sở dữ liệu gốc. \nBạn xem lại tên server của publisher và tên CSDL trong chuỗi kết nối.\n" + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLoginName.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được trống", "", MessageBoxButtons.OK);
                return;
            }
            Program.mLogin = txtLoginName.Text;
            Program.password = txtPassword.Text;

            if (Program.Connect() == 0) return;

            Program.mLoginDN = Program.mLogin;
            Program.passwordDN = Program.password;
            string strCmd = "EXEC GET_LOGIN_INFO '" + Program.mLoginDN + "'";

            Program.myReader = Program.ExecSqlDataReader(strCmd);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            Program.userName = Program.myReader.GetString(0);
            if (Convert.IsDBNull(Program.userName))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\nBạn xem lại tên đăng nhập, mật khẩu", "", MessageBoxButtons.OK);
                return;
            }
            LoginSuccessfully();
        }
        private void LoginSuccessfully()
        {
            Program.userName = Program.myReader.GetString(0).Trim();
            Program.mFullName = Program.myReader.GetString(1).Trim();
            Program.mGroup = Program.myReader.GetString(2).Trim();
            Program.myReader.Close();
            Program.conn.Close();


            Program.fMain.ShowMenu();
            if (Program.mGroup == "BenhVien")
            {
                Program.fMain.LoginByHospitalRole();
            }
            else if (Program.mGroup == "Boss")
            {
                Program.fMain.LoginByBossRole();
            }
            else if(Program.mGroup == "BacSi")
            {
                Program.fMain.LoginByDoctorRole();
            }
            else if (Program.mGroup == "YTa")
            {
                Program.fMain.LoginByNurseRole();
            }
        }
    }
}