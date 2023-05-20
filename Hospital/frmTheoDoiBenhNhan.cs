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
    public partial class frmTheoDoiBenhNhan : DevExpress.XtraEditors.XtraForm
    {
        string mabacsi = "";
        public frmTheoDoiBenhNhan()
        {
            InitializeComponent();
        }

       
        private void frmTheoDoiBenhNhan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLBVDataSet.SP_BENHNHAN_KHONG_THEO_DOI' table. You can move, or remove it, as needed.


            this.QLBVDataSet.EnforceConstraints = false;
            this.sP_BENHNHAN_KHONG_THEO_DOITableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_BENHNHAN_KHONG_THEO_DOITableAdapter.Fill(this.QLBVDataSet.SP_BENHNHAN_KHONG_THEO_DOI);
            // TODO: This line of code loads data into the 'QLBVDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nHANVIENTableAdapter.FillByBacSi(this.QLBVDataSet.NHANVIEN);
            // TODO: This line of code loads data into the 'QLBVDataSet.BENHNHAN' table. You can move, or remove it, as needed.
            this.bENHNHANTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bENHNHANTableAdapter.Fill(this.QLBVDataSet.BENHNHAN);
            
            

        }

        private void bENHNHANGridControl_FocusedViewChanged(object sender, DevExpress.XtraGrid.ViewFocusEventArgs e)
        {
            MessageBox.Show("thay đổi row", "Thông báo", MessageBoxButtons.OK);
            return;
        }

        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataRowView drv = (DataRowView)bdsBacSi[bdsBacSi.Position];
            mabacsi = drv["MANV"].ToString();
            txtMaBacSiTheoDoi.Text = mabacsi;
            DialogResult dr = MessageBox.Show("Bạn có muốn thêm bệnh nhân vào danh sách theo dõi ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                String truyvan = "UPDATE BENHNHAN SET MABSTD = '" + mabacsi + "' WHERE MABN = '" + txtMaBenhNhan.Text.Trim() + "'";
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
                //ketqua = int.Parse(Program.myReader.GetValue(0).ToString());

                Program.myReader.Close();
                this.QLBVDataSet.EnforceConstraints = false;
                //this.sP_BENHNHAN_KHONG_THEO_DOITableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_BENHNHAN_KHONG_THEO_DOITableAdapter.Fill(this.QLBVDataSet.SP_BENHNHAN_KHONG_THEO_DOI);
                // TODO: This line of code loads data into the 'QLBVDataSet.NHANVIEN' table. You can move, or remove it, as needed.
                this.nHANVIENTableAdapter.FillByBacSi(this.QLBVDataSet.NHANVIEN);
                // TODO: This line of code loads data into the 'QLBVDataSet.BENHNHAN' table. You can move, or remove it, as needed.
                this.bENHNHANTableAdapter.Fill(this.QLBVDataSet.BENHNHAN);
            }


        }

        private void btnGHI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            
            
        }

        private void btnSUA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataRowView drv = (DataRowView)bdsBenhNhanCoBS[bdsBenhNhanCoBS.Position];
            string mabenhnhan = drv["MABN"].ToString();
            DialogResult dr = MessageBox.Show("Bạn có muốn thêm bệnh nhân vào danh sách theo dõi ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                String truyvan = "UPDATE BENHNHAN SET MABSTD = NULL WHERE MABN = '" + mabenhnhan + "'";
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
                //ketqua = int.Parse(Program.myReader.GetValue(0).ToString());

                Program.myReader.Close();
                this.QLBVDataSet.EnforceConstraints = false;
                //this.sP_BENHNHAN_KHONG_THEO_DOITableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_BENHNHAN_KHONG_THEO_DOITableAdapter.Fill(this.QLBVDataSet.SP_BENHNHAN_KHONG_THEO_DOI);
                // TODO: This line of code loads data into the 'QLBVDataSet.NHANVIEN' table. You can move, or remove it, as needed.
                this.nHANVIENTableAdapter.FillByBacSi(this.QLBVDataSet.NHANVIEN);
                // TODO: This line of code loads data into the 'QLBVDataSet.BENHNHAN' table. You can move, or remove it, as needed.
                this.bENHNHANTableAdapter.Fill(this.QLBVDataSet.BENHNHAN);
            }
              
        }

        private void btnLAMMOI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.QLBVDataSet.EnforceConstraints = false;
            //this.sP_BENHNHAN_KHONG_THEO_DOITableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_BENHNHAN_KHONG_THEO_DOITableAdapter.Fill(this.QLBVDataSet.SP_BENHNHAN_KHONG_THEO_DOI);
            // TODO: This line of code loads data into the 'QLBVDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.FillByBacSi(this.QLBVDataSet.NHANVIEN);
            // TODO: This line of code loads data into the 'QLBVDataSet.BENHNHAN' table. You can move, or remove it, as needed.
            this.bENHNHANTableAdapter.Fill(this.QLBVDataSet.BENHNHAN);
        }

        private void mABSTDLabel_Click(object sender, EventArgs e)
        {

        }
    }
}