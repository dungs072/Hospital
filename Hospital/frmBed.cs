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
    public partial class frmBed : DevExpress.XtraEditors.XtraForm,IBoss
    {
        private string oldBedId = "";
        private bool isAdding = false;
        public frmBed()
        {
            InitializeComponent();
        }

        private void frmBed_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBVDataSet.GET_ROOMS' table. You can move, or remove it, as needed.
            this.gET_ROOMSTableAdapter.Fill(this.qLBVDataSet.GET_ROOMS);
            txtBedNumber.Properties.MaxValue = 100;
            txtBedNumber.Properties.MinValue = 1;
            HandleClickRoom();
            ToggleAddReloadButtons(true);
            ToggleGroupBox(false);
            ToggleUpdateDeleteButtons(gET_BEDS_BASE_ON_ROOMBindingSource.Count > 0);
            ToggleWriteCancelButtons(false);
            ToggleTables(true);
        }
        private void ToggleAddReloadButtons(bool state)
        {
            btnAdd.Enabled = btnReload.Enabled = state;
        }
        private void ToggleUpdateDeleteButtons(bool state)
        {
            btnUpdate.Enabled = btnDelete.Enabled = state;
        }
        private void ToggleWriteCancelButtons(bool state)
        {
            btnWrite.Enabled = btnCancel.Enabled = state;
        }
        private void ToggleGroupBox(bool state)
        {
            groupBox1.Enabled = state;

        }
        private void ToggleTables(bool state)
        {
            gET_BEDS_BASE_ON_ROOMGridControl.Enabled = state;
            gET_ROOMSGridControl.Enabled = state;
        }

        private void HandleClick(bool isAdded)
        {
            if (isAdded || gET_BEDS_BASE_ON_ROOMBindingSource.Count == 0)
            {
                if (gET_ROOMSBindingSource.Count == 0)
                {
                    txtRoomId.Text = "";
                }
                else
                {
                    txtRoomId.Text = ((DataRowView)gET_ROOMSBindingSource[gET_ROOMSBindingSource.Position])["MAPHONG"].ToString().Trim();
                    
                }
                txtBedId.Text = "";
                txtBedNumber.Text = "";

            }
            else
            {
                txtRoomId.Text = ((DataRowView)gET_BEDS_BASE_ON_ROOMBindingSource[gET_BEDS_BASE_ON_ROOMBindingSource.Position])["MAPHONG"].ToString().Trim();
                txtBedId.Text = ((DataRowView)gET_BEDS_BASE_ON_ROOMBindingSource[gET_BEDS_BASE_ON_ROOMBindingSource.Position])["MAGIUONG"].ToString().Trim();
                txtBedNumber.Text = ((DataRowView)gET_BEDS_BASE_ON_ROOMBindingSource[gET_BEDS_BASE_ON_ROOMBindingSource.Position])["SOGIUONG"].ToString().Trim();
            }
        }

        private void gET_ROOMSGridControl_Click(object sender, EventArgs e)
        {

            HandleClickRoom();
            
        }
        private void HandleClickRoom()
        {
           
            if (gET_ROOMSBindingSource.Count == 0)
            {
                gET_BEDS_BASE_ON_ROOMTableAdapter.Fill(qLBVDataSet.GET_BEDS_BASE_ON_ROOM, "");
            }
            else
            {
                string roomId = ((DataRowView)gET_ROOMSBindingSource[gET_ROOMSBindingSource.Position])["MAPHONG"].ToString().Trim();
                gET_BEDS_BASE_ON_ROOMTableAdapter.Fill(qLBVDataSet.GET_BEDS_BASE_ON_ROOM, roomId);
            }
            if (Program.mGroup != "Boss")
            {
                ToggleUpdateDeleteButtons(gET_BEDS_BASE_ON_ROOMBindingSource.Count > 0);
            }
            
            HandleClick(false);
        }

        private void gET_BEDS_BASE_ON_ROOMGridControl_Click(object sender, EventArgs e)
        {
            HandleClick(false);
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ToggleAddReloadButtons(false);
            ToggleWriteCancelButtons(true);
            ToggleTables(false);
            ToggleUpdateDeleteButtons(false);
            ToggleGroupBox(true);
            isAdding = true;
            HandleClick(true);
            txtBedNumber.Value = 1;
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string bedId = ((DataRowView)gET_BEDS_BASE_ON_ROOMBindingSource[gET_BEDS_BASE_ON_ROOMBindingSource.Position])["MAGIUONG"].ToString().Trim();
            if (!CanDeleteBed(bedId))
            {
                MessageBox.Show("Giường này đã từng được sử dụng qua. Không thể xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc là muốn xóa giường này không ?","Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                string cmd = string.Format("DELETE GIUONG WHERE MAGIUONG = '{0}'", bedId);
                int resultt = Program.ExecSqlNonQuery(cmd);
                if (resultt == 0)
                {
                    string roomId = ((DataRowView)gET_ROOMSBindingSource[gET_ROOMSBindingSource.Position])["MAPHONG"].ToString().Trim();
                    gET_BEDS_BASE_ON_ROOMTableAdapter.Fill(qLBVDataSet.GET_BEDS_BASE_ON_ROOM, roomId);
                    ToggleUpdateDeleteButtons(gET_BEDS_BASE_ON_ROOMBindingSource.Count > 0);
                    MessageBox.Show("Xóa giường thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Xóa giường không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private bool CanDeleteBed(string bedId)
        {
            if (Program.Connect() == 0) { return false; }
            string cmd = string.Format("DECLARE	@return_value int " +
                        "EXEC    @return_value = [dbo].[SP_CAN_DELETE_BED] " +
                        "@MAGIUONG = N'{0}' " +
                        " SELECT  'Return Value' = @return_value",bedId);
            SqlDataReader reader = Program.ExecSqlDataReader(cmd);
            reader.Read();
            int result = reader.GetInt32(0);
            reader.Close();
            return result == 1;
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ToggleAddReloadButtons(false);
            ToggleWriteCancelButtons(true);
            ToggleTables(false);
            ToggleUpdateDeleteButtons(false);
            ToggleGroupBox(true);
            isAdding = false;
            oldBedId = ((DataRowView)gET_BEDS_BASE_ON_ROOMBindingSource[gET_BEDS_BASE_ON_ROOMBindingSource.Position])["MAGIUONG"].ToString().Trim();
        }

        private void btnWrite_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtBedId.Text == "")
            {
                MessageBox.Show("Mã giường không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(txtBedNumber.Text == "")
            {
                MessageBox.Show("Số giường không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string cmd = "";
            if (isAdding)
            {
                cmd = string.Format("INSERT INTO GIUONG (MAPHONG, MAGIUONG, SOGIUONG) VALUES ('{0}','{1}',{2})", txtRoomId.Text,txtBedId.Text,(int)txtBedNumber.Value);
            }
            else
            {
                cmd = string.Format("UPDATE GIUONG SET MAGIUONG = '{0}', SOGIUONG = {1} WHERE MAGIUONG = '{2}'", txtBedId.Text, (int)txtBedNumber.Value, oldBedId);
            }
            SqlCommand sqlCmd = new SqlCommand(cmd, Program.conn);
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandTimeout = 600;//10 mins
            if (Program.conn.State == System.Data.ConnectionState.Closed) Program.conn.Open();
            try
            {
                sqlCmd.ExecuteNonQuery();
                Program.conn.Close();
                string roomId = ((DataRowView)gET_ROOMSBindingSource[gET_ROOMSBindingSource.Position])["MAPHONG"].ToString().Trim();
                gET_BEDS_BASE_ON_ROOMTableAdapter.Fill(qLBVDataSet.GET_BEDS_BASE_ON_ROOM, roomId);
                ToggleUpdateDeleteButtons(gET_BEDS_BASE_ON_ROOMBindingSource.Count > 0);
                ToggleAddReloadButtons(true);
                ToggleGroupBox(false);
                ToggleTables(true);
                ToggleWriteCancelButtons(false);
                if (isAdding)
                {
                    MessageBox.Show("Thêm giường thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật giường thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("PK"))
                {
                    MessageBox.Show("Mã giường đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Message.Contains("UK"))
                {
                    MessageBox.Show("Số giường tại phòng này đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                Program.conn.Close();
            }
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ToggleAddReloadButtons(true);
            ToggleWriteCancelButtons(false);
            ToggleTables(true);
            ToggleUpdateDeleteButtons(gET_BEDS_BASE_ON_ROOMBindingSource.Count>0);
            ToggleGroupBox(false);
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Reload();
        }
        private void Reload()
        {
            gET_ROOMSTableAdapter.Fill(qLBVDataSet.GET_ROOMS);
            if (gET_ROOMSBindingSource.Count == 0) { return; }
            string roomId = ((DataRowView)gET_ROOMSBindingSource[gET_ROOMSBindingSource.Position])["MAPHONG"].ToString().Trim();
            gET_BEDS_BASE_ON_ROOMTableAdapter.Fill(qLBVDataSet.GET_BEDS_BASE_ON_ROOM, roomId);
            ToggleUpdateDeleteButtons(gET_BEDS_BASE_ON_ROOMBindingSource.Count > 0);
        }

        public void InitialSetting()
        {
            ToggleAddReloadButtons(false);
            ToggleUpdateDeleteButtons(false);
            ToggleWriteCancelButtons(false);
        }
    }
}