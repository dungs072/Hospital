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
    public partial class frmProvidePrivilege : DevExpress.XtraEditors.XtraForm
    {
        private bool isBackup = false;
        public static event Action<bool> OnHasPrivilege;
        public bool HasPrivilege { get; private set; }
        public frmProvidePrivilege(bool isBackup)
        {
            InitializeComponent();
            this.isBackup = isBackup;
        }

        private void btnGoTo_Click(object sender, EventArgs e)
        {
            if (txtLoginName.Text.Trim() == "" || txtPassword.Text.Trim() == "") { return; }
            if(hasPrivilege())
            {
                OnHasPrivilege?.Invoke(isBackup);
            }
        }
        private bool hasPrivilege()
        {
            string connstr = "Data Source=" + Program.serverName + ";Initial Catalog=" +
            Program.database + ";User ID=" +
            txtLoginName.Text.Trim() + ";password=" + txtPassword.Text.Trim(); ;
            SqlConnection conn = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(connstr))
                {
                    connection.Open(); // Attempt to open a connection
                }
            }
            catch (SqlException ex)
            {
                if (conn != null) { conn.Close(); }
                MessageBox.Show("Tên tài khoản và mật khẩu bạn nhập không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (conn != null) { conn.Close(); }
            if (Program.Connect() == 0) { return false; }
            string strCmd = "EXEC GET_LOGIN_INFO '" + txtLoginName.Text.Trim() + "'";
            Program.myReader = Program.ExecSqlDataReader(strCmd);
            if (Program.myReader == null) return false;
            Program.myReader.Read();

            string role = Program.myReader.GetString(2);
            if(role=="Boss")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Tên tài khoản và mật khẩu bạn nhập không có quyền thực thi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}