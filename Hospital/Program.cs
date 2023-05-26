using DevExpress.Skins;
using DevExpress.UserSkins;
using Hospital.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Hospital
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static String connstr_publisher = "Data Source=DESKTOP-0M15LMD\\GHOSTNHD;Initial Catalog=QLBV;Integrated Security=True";

        public static SqlDataReader myReader;
        public static String serverName = "DESKTOP-0M15LMD\\GHOSTNHD";
        public static String userName = "";
        public static String mLogin = "";
        public static String password = "";

        public static String database = "QLBV";
        public static String remoteLogin = "T";
        public static String remotePassword = "123";
        public static String mLoginDN = "";
        public static String passwordDN = "";
        public static String mGroup = "";
        public static String mFullName = "";
        public static int mFacility = 0;
        public static BindingSource bds_fragList = new BindingSource();
        public static frmMain fMain;

        // lưu danh sách các nhóm quyền
        public static List<RoleClass> roles = new List<RoleClass> {
                new RoleClass("BenhVien", "Nhóm Bệnh Viện"),
                new RoleClass("BacSi", "Nhóm Bác Sĩ"),
                new RoleClass("YTa", "Nhóm Y Tá")
        };

        public static string MaNhanVienChon = "";
        public static int Connect()
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                connstr = "Data Source=" + serverName + ";Initial Catalog=" +
                        database + ";User ID=" +
                        mLogin + ";password=" + password;
                conn.ConnectionString = connstr;
                conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n" + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public static SqlDataReader ExecSqlDataReader(string cmd)
        {
            SqlDataReader myReader;
            SqlCommand sqlcmd = new SqlCommand(cmd, conn);
            sqlcmd.CommandType = System.Data.CommandType.Text;
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            try
            {
                myReader = sqlcmd.ExecuteReader();
                return myReader;
            }
            catch (SqlException ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public static DataTable ExecSqlDataTable(string cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static int ExecSqlNonQuery(string strCmd)
        {
            SqlCommand sqlCmd = new SqlCommand(strCmd, conn);
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandTimeout = 600;//10 mins
            if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
            try
            {
                sqlCmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return ex.State+1;
            }
        }
        public static void ResetStripStatus()
        {
            userName = "";
            mFullName = "";
            mGroup = "";
        }
        public static void RestartData()
        {
            ResetStripStatus();
            myReader = null;
            serverName = "";
            userName = "";
            mLogin = "";
            password = "";
            mLoginDN = "";
            passwordDN = "";
            mGroup = "";
            mFullName = "";
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            fMain = new frmMain();
            fMain.WindowState = FormWindowState.Maximized;
            Application.Run(fMain);
        }

    }
}

