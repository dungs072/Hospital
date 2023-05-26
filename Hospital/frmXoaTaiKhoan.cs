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
    public partial class frmXoaTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public frmXoaTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmXoaTaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBVDataSet.SP_DS_NHANVIEN_CO_TAI_KHOAN' table. You can move, or remove it, as needed.
            this.sP_DS_NHANVIEN_CO_TAI_KHOANTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_DS_NHANVIEN_CO_TAI_KHOANTableAdapter.Fill(this.qLBVDataSet.SP_DS_NHANVIEN_CO_TAI_KHOAN, Program.userName,Program.mGroup);

        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (bdsNhanVienCoTK.Count == 0) { return; }
            string loginname = "";
            string username = "";
            DataRowView drv = (DataRowView)bdsNhanVienCoTK[bdsNhanVienCoTK.Position];
            username = drv["MANV"].ToString().Trim();
            String TimLoginName = "LAY_LOGINNAM_FROM_USERNAME '" + username + "'";
            try
            {
                Program.myReader = Program.ExecSqlDataReader(TimLoginName);
                if (Program.myReader == null)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Program.myReader.Read();
            loginname = Program.myReader.GetValue(0).ToString();

            Program.myReader.Close();
            string truyvan = "EXEC SP_XOATAIKHOAN" + "'" + loginname + "','" + username+ "'";
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
            Program.myReader.Close();
            MessageBox.Show("Xóa tài khoản của nhân viên có mã " + username + " thành công", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);

            this.sP_DS_NHANVIEN_CO_TAI_KHOANTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_DS_NHANVIEN_CO_TAI_KHOANTableAdapter.Fill(this.qLBVDataSet.SP_DS_NHANVIEN_CO_TAI_KHOAN, Program.userName,Program.mGroup);
            return;

        }

    }
}