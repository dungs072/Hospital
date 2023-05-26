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
    public partial class frmStaffList : DevExpress.XtraEditors.XtraForm
    {
        string typeRole = "";

        public frmStaffList(string typeRole)
        {
            this.typeRole = typeRole;
            InitializeComponent();
        }

        private void frmStaffList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBVDataSet.SP_DS_NHANVIEN_KHONG_TAI_KHOAN' table. You can move, or remove it, as needed.
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOANTableAdapter.Fill(this.qLBVDataSet.SP_DS_NHANVIEN_KHONG_TAI_KHOAN,typeRole);
            if (typeRole == "BS")
            {
                Title.Text = "DANH SÁCH BÁC SĨ";
            }
            else if (typeRole == "YT")
            {
                Title.Text = "DANH SÁCH Y TÁ";
            }
            else
            {
                Title.Text = "DANH SÁCH CÁC NHÂN VIÊN";
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)sP_DS_NHANVIEN_KHONG_TAI_KHOANBindingSource[sP_DS_NHANVIEN_KHONG_TAI_KHOANBindingSource.Position];
            Program.MaNhanVienChon = drv["MANV"].ToString();
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}