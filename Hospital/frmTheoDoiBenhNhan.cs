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
    public partial class frmTheoDoiBenhNhan : DevExpress.XtraEditors.XtraForm,IBoss
    {
        string mabacsi = "";
        public frmTheoDoiBenhNhan()
        {
            InitializeComponent();
        }

       
        private void frmTheoDoiBenhNhan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLBVDataSet.GET_PATIENT_HAVE_STALK_DOCTOR' table. You can move, or remove it, as needed.
            this.gET_PATIENT_HAVE_STALK_DOCTORTableAdapter.Fill(this.QLBVDataSet.GET_PATIENT_HAVE_STALK_DOCTOR);
            // TODO: This line of code loads data into the 'QLBVDataSet.GET_FULL_DOCTORS' table. You can move, or remove it, as needed.
            this.gET_FULL_DOCTORSTableAdapter.Fill(this.QLBVDataSet.GET_FULL_DOCTORS);
            // TODO: This line of code loads data into the 'QLBVDataSet.SP_BENHNHAN_KHONG_THEO_DOI' table. You can move, or remove it, as needed.


            this.QLBVDataSet.EnforceConstraints = false;
            this.sP_BENHNHAN_KHONG_THEO_DOITableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_BENHNHAN_KHONG_THEO_DOITableAdapter.Fill(this.QLBVDataSet.SP_BENHNHAN_KHONG_THEO_DOI);
            // TODO: This line of code loads data into the 'QLBVDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'QLBVDataSet.BENHNHAN' table. You can move, or remove it, as needed.
            this.bENHNHANTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bENHNHANTableAdapter.Fill(this.QLBVDataSet.BENHNHAN);

            HandleClick();

        }

        private void bENHNHANGridControl_FocusedViewChanged(object sender, DevExpress.XtraGrid.ViewFocusEventArgs e)
        {
            MessageBox.Show("thay đổi row", "Thông báo", MessageBoxButtons.OK);
            return;
        }

        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataRowView drv = (DataRowView)gET_FULL_DOCTORSBindingSource[gET_FULL_DOCTORSBindingSource.Position];
            DataRowView drvv = (DataRowView)sP_BENHNHAN_KHONG_THEO_DOIBindingSource[sP_BENHNHAN_KHONG_THEO_DOIBindingSource.Position];
            mabacsi = drv["MANV"].ToString();
            string patientId = drvv["MABN"].ToString();
            string namePatient = drvv["HO"].ToString() + " " + drvv["TEN"].ToString();
            string nameDoctor = drv["HO"].ToString() + " " + drv["TEN"].ToString();
            txtMaBacSiTheoDoi.Text = mabacsi;
            DialogResult dr = MessageBox.Show("Bạn có muốn bác sĩ "+ nameDoctor +" theo dõi bệnh nhân "+namePatient, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                String truyvan = "UPDATE BENHNHAN SET MABSTD = '" + mabacsi + "' WHERE MABN = '" + patientId + "'";
                if (Program.Connect() == 0) { return; }
                int result = Program.ExecSqlNonQuery(truyvan);
                if (result == 0)
                {
                    this.QLBVDataSet.EnforceConstraints = false;
                    //this.sP_BENHNHAN_KHONG_THEO_DOITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sP_BENHNHAN_KHONG_THEO_DOITableAdapter.Fill(this.QLBVDataSet.SP_BENHNHAN_KHONG_THEO_DOI);
                    // TODO: This line of code loads data into the 'QLBVDataSet.GET_PATIENT_HAVE_STALK_DOCTOR' table. You can move, or remove it, as needed.
                    this.gET_PATIENT_HAVE_STALK_DOCTORTableAdapter.Fill(this.QLBVDataSet.GET_PATIENT_HAVE_STALK_DOCTOR);
                    HandleClick();
                    MessageBox.Show("Đăng kí bác sĩ theo dõi thành công cho bệnh nhân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đăng kí bác sĩ theo dõi thất bại cho bệnh nhân này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }


        }
      
        private void btnLAMMOI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.QLBVDataSet.EnforceConstraints = false;
            //this.sP_BENHNHAN_KHONG_THEO_DOITableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_BENHNHAN_KHONG_THEO_DOITableAdapter.Fill(this.QLBVDataSet.SP_BENHNHAN_KHONG_THEO_DOI);
            // TODO: This line of code loads data into the 'QLBVDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            //this.nHANVIENTableAdapter.FillByBacSi(this.QLBVDataSet.NHANVIEN);
            // TODO: This line of code loads data into the 'QLBVDataSet.BENHNHAN' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'QLBVDataSet.GET_PATIENT_HAVE_STALK_DOCTOR' table. You can move, or remove it, as needed.
            this.gET_PATIENT_HAVE_STALK_DOCTORTableAdapter.Fill(this.QLBVDataSet.GET_PATIENT_HAVE_STALK_DOCTOR);
            HandleClick();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataRowView drv = (DataRowView)gET_PATIENT_HAVE_STALK_DOCTORBindingSource[gET_PATIENT_HAVE_STALK_DOCTORBindingSource.Position];
            string mabenhnhan = drv["MABN"].ToString();
            string fullNamePatient = drv["HO"].ToString() + " " + drv["TEN"].ToString();
            DialogResult dr = MessageBox.Show("Bạn có chắc việc hủy đăng kí theo dõi cho bệnh nhân "+ fullNamePatient, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                String truyvan = "UPDATE BENHNHAN SET MABSTD = NULL WHERE MABN = '" + mabenhnhan + "'";
                if (Program.Connect() == 0) { return; }
                int result = Program.ExecSqlNonQuery(truyvan);
                if (result == 0)
                {
                    
                    this.QLBVDataSet.EnforceConstraints = false;
                    //this.sP_BENHNHAN_KHONG_THEO_DOITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sP_BENHNHAN_KHONG_THEO_DOITableAdapter.Fill(this.QLBVDataSet.SP_BENHNHAN_KHONG_THEO_DOI);
                    // TODO: This line of code loads data into the 'QLBVDataSet.GET_PATIENT_HAVE_STALK_DOCTOR' table. You can move, or remove it, as needed.
                    this.gET_PATIENT_HAVE_STALK_DOCTORTableAdapter.Fill(this.QLBVDataSet.GET_PATIENT_HAVE_STALK_DOCTOR);
                    HandleClick();
                    MessageBox.Show("Hủy đăng kí bác sĩ theo dõi thành công cho bệnh nhân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Hủy đăng kí bác sĩ theo dõi thất bại cho bệnh nhân này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void sP_BENHNHAN_KHONG_THEO_DOIGridControl_Click(object sender, EventArgs e)
        {
            if (Program.mGroup != "Boss")
            {
                HandleClick();
            }
           

        }
        private void HandleClick()
        {
           
            btnDelete.Enabled = gET_PATIENT_HAVE_STALK_DOCTORBindingSource.Count > 0;
            btnTHEM.Enabled = sP_BENHNHAN_KHONG_THEO_DOIBindingSource.Count > 0;
        }

        private void gET_PATIENT_HAVE_STALK_DOCTORGridControl_Click(object sender, EventArgs e)
        {
            if (Program.mGroup != "Boss")
            {
                HandleClick();
            }

        }

        public void InitialSetting()
        {
            btnTHEM.Enabled = btnLAMMOI.Enabled = btnDelete.Enabled = false;
        }
    }
}