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
    public partial class frmHourWorkingDetail : DevExpress.XtraEditors.XtraForm
    {
        private bool isAdding = false;
        public frmHourWorkingDetail()
        {
            InitializeComponent();
        }


        private void frmHourWorkingDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBVDataSet.GET_WEEK' table. You can move, or remove it, as needed.
            this.gET_WEEKTableAdapter.Fill(this.qLBVDataSet.GET_WEEK);

            // TODO: This line of code loads data into the 'qLBVDataSet.KHUCHUATRI' table. You can move, or remove it, as needed.
            this.kHUCHUATRITableAdapter.Fill(this.qLBVDataSet.KHUCHUATRI);

            if (cmbArea.SelectedIndex != -1)
            {
                
                this.sP_GET_STAFF_REGISTER_AREATableAdapter.Fill(qLBVDataSet.SP_GET_STAFF_REGISTER_AREA,int.Parse(cmbArea.SelectedValue.ToString()));
                if (cmbWeek.SelectedValue != null)
                {
                    this.sP_GET_WORKING_HOUR_IN_AREATableAdapter.Fill(qLBVDataSet.SP_GET_WORKING_HOUR_IN_AREA, int.Parse(cmbArea.SelectedValue.ToString()), int.Parse(cmbWeek.SelectedValue.ToString()));
                }
            }
            HandleClickButtons();
        }
        private void HandleClickButtons()
        {
            ToggleTables(true);
            ToggleRegisterReloadButtons(true);
            ToggleUpdateCancelRegisterButtons(sP_GET_WORKING_HOUR_IN_AREABindingSource.Count > 0);
            ToggleGroupBox(false);
            ToggleWriteCancelButtons(false);
        }

        private void cmbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbArea.SelectedValue != null)
            {
                this.sP_GET_STAFF_REGISTER_AREATableAdapter.Fill(qLBVDataSet.SP_GET_STAFF_REGISTER_AREA, int.Parse(cmbArea.SelectedValue.ToString()));
                if (cmbWeek.SelectedValue != null)
                {
                    this.sP_GET_WORKING_HOUR_IN_AREATableAdapter.Fill(qLBVDataSet.SP_GET_WORKING_HOUR_IN_AREA, int.Parse(cmbArea.SelectedValue.ToString()), int.Parse(cmbWeek.SelectedValue.ToString()));
                }
            }
            HandleClickButtons();
            HandlePassDataToGroupBox();
        }

        private void cmbWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbArea.SelectedValue != null)
            {
                if (cmbWeek.SelectedValue != null)
                {
                    this.sP_GET_WORKING_HOUR_IN_AREATableAdapter.Fill(qLBVDataSet.SP_GET_WORKING_HOUR_IN_AREA, int.Parse(cmbArea.SelectedValue.ToString()), int.Parse(cmbWeek.SelectedValue.ToString()));
                }
            }
            HandleClickButtons();
            HandlePassDataToGroupBox();
        }

        private void ToggleRegisterReloadButtons(bool state)
        {
            btnRegister.Enabled = btnReload.Enabled = state;
        }
        private void ToggleUpdateCancelRegisterButtons(bool state)
        {
            btnUpdate.Enabled = btnCancelRegister.Enabled = state;
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
            sP_GET_STAFF_REGISTER_AREAGridControl.Enabled = state;
            sP_GET_WORKING_HOUR_IN_AREAGridControl.Enabled = state;
            cmbArea.Enabled = state;
            cmbWeek.Enabled = state;
        }

        private void btnRegister_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int idWorkingHour = int.Parse(((DataRowView)sP_GET_STAFF_REGISTER_AREABindingSource[sP_GET_STAFF_REGISTER_AREABindingSource.Position])[4].ToString().Trim());
            int idWeek = int.Parse(cmbWeek.SelectedValue.ToString());
            if (!CanRegisterWorkingHour(idWorkingHour, idWeek))
            {
                MessageBox.Show("Không thể đăng kí giờ làm việc cho nhân viên này nữa.\nVì đã đăng kí cho nhân viên này rồi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ToggleGroupBox(true);
            ToggleTables(false);
            ToggleRegisterReloadButtons(false);
            ToggleWriteCancelButtons(true);
            ToggleUpdateCancelRegisterButtons(false);
            BindingDataFromStaffTableToGroupBox();
            txtAddTime.Focus();
            isAdding = true;
        }
        private void BindingDataFromStaffTableToGroupBox()
        {
            txtStaffId.Text = ((DataRowView)sP_GET_STAFF_REGISTER_AREABindingSource[sP_GET_STAFF_REGISTER_AREABindingSource.Position])[0].ToString().Trim();
            txtStaffName.Text = ((DataRowView)sP_GET_STAFF_REGISTER_AREABindingSource[sP_GET_STAFF_REGISTER_AREABindingSource.Position])[1].ToString().Trim();
            txtArea.Text = cmbArea.Text;
            txtWeek.Text = cmbWeek.Text;

        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ToggleGroupBox(true);
            ToggleTables(false);
            ToggleRegisterReloadButtons(false);
            ToggleWriteCancelButtons(true);
            ToggleUpdateCancelRegisterButtons(false);
            txtStaffName.Text = ((DataRowView)sP_GET_WORKING_HOUR_IN_AREABindingSource[sP_GET_WORKING_HOUR_IN_AREABindingSource.Position])[1].ToString().Trim();
            txtStaffId.Text = ((DataRowView)sP_GET_WORKING_HOUR_IN_AREABindingSource[sP_GET_WORKING_HOUR_IN_AREABindingSource.Position])[0].ToString().Trim();
            txtArea.Text = cmbArea.Text;
            txtWeek.Text = cmbWeek.Text;
            txtAddTime.Focus();
            isAdding = false;
        }

        private void btnCancelRegister_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int idWorkingHour = int.Parse(((DataRowView)sP_GET_WORKING_HOUR_IN_AREABindingSource[sP_GET_WORKING_HOUR_IN_AREABindingSource.Position])[3].ToString().Trim());
            int idWeek = int.Parse(cmbWeek.SelectedValue.ToString());
           
            DialogResult result = MessageBox.Show("Bạn có chắc là muốn hủy thời gian làm việc của nhân viên này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                if (Program.Connect() == 0)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string cmd = string.Format("DELETE CHITIETGIOLAMVIEC WHERE ID_CTLV = {0} AND ID_TUAN = {1}", idWorkingHour, idWeek);
                int resultT = Program.ExecSqlNonQuery(cmd);
                if (resultT == 0)
                {
                    if (cmbArea.SelectedValue != null)
                    {
                        if (cmbWeek.SelectedValue != null)
                        {
                            this.sP_GET_WORKING_HOUR_IN_AREATableAdapter.Fill(qLBVDataSet.SP_GET_WORKING_HOUR_IN_AREA, int.Parse(cmbArea.SelectedValue.ToString()), int.Parse(cmbWeek.SelectedValue.ToString()));
                        }
                    }
                    ToggleUpdateCancelRegisterButtons(sP_GET_WORKING_HOUR_IN_AREABindingSource.Count > 0);
                    MessageBox.Show("Hủy đăng kí thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Hủy đăng kí thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnWrite_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            int idWeek = int.Parse(cmbWeek.SelectedValue.ToString());
            int hours = (int)txtAddTime.Value;
            
            if (Program.Connect() == 0)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string cmd = "";
            if (isAdding)
            {
                if (hours < 0)
                {
                    MessageBox.Show("Tổng thời gian làm việc không thể bé hơn 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int idWorkingHour = int.Parse(((DataRowView)sP_GET_STAFF_REGISTER_AREABindingSource[sP_GET_STAFF_REGISTER_AREABindingSource.Position])[4].ToString().Trim());
                cmd = string.Format("INSERT INTO CHITIETGIOLAMVIEC(ID_CTLV, ID_TUAN,THOIGIANLAMVIEC) VALUES({0},{1},{2})", idWorkingHour, idWeek, hours);

            }
            else
            {
                int idWorkingHour = int.Parse(((DataRowView)sP_GET_WORKING_HOUR_IN_AREABindingSource[sP_GET_WORKING_HOUR_IN_AREABindingSource.Position])[3].ToString().Trim());
                cmd =string.Format("UPDATE CHITIETGIOLAMVIEC SET THOIGIANLAMVIEC = THOIGIANLAMVIEC + {0} WHERE ID_CTLV = {1} AND ID_TUAN = {2}",hours,idWorkingHour,idWeek);
            }
            SqlCommand sqlCmd = new SqlCommand(cmd, Program.conn);
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandTimeout = 600;//10 mins
            if (Program.conn.State == System.Data.ConnectionState.Closed) Program.conn.Open();
            try
            {
                sqlCmd.ExecuteNonQuery();
                Program.conn.Close();

            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("CK"))
                {
                    MessageBox.Show("Tổng thời gian làm việc không thể bé hơn 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                Program.conn.Close();
                return;
            }
            if (isAdding)
            {
                if (cmbArea.SelectedValue != null)
                {
                    if (cmbWeek.SelectedValue != null)
                    {
                        this.sP_GET_WORKING_HOUR_IN_AREATableAdapter.Fill(qLBVDataSet.SP_GET_WORKING_HOUR_IN_AREA, int.Parse(cmbArea.SelectedValue.ToString()), int.Parse(cmbWeek.SelectedValue.ToString()));
                    }
                }

                ToggleGroupBox(false);
                ToggleTables(true);
                ToggleRegisterReloadButtons(true);
                ToggleWriteCancelButtons(false);
                ToggleUpdateCancelRegisterButtons(sP_GET_WORKING_HOUR_IN_AREABindingSource.Count > 0);
                HandlePassDataToGroupBox();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (cmbArea.SelectedValue != null)
                {
                    if (cmbWeek.SelectedValue != null)
                    {
                        this.sP_GET_WORKING_HOUR_IN_AREATableAdapter.Fill(qLBVDataSet.SP_GET_WORKING_HOUR_IN_AREA, int.Parse(cmbArea.SelectedValue.ToString()), int.Parse(cmbWeek.SelectedValue.ToString()));
                    }
                }
                ToggleGroupBox(false);
                ToggleTables(true);
                ToggleRegisterReloadButtons(true);
                ToggleWriteCancelButtons(false);
                ToggleUpdateCancelRegisterButtons(sP_GET_WORKING_HOUR_IN_AREABindingSource.Count > 0);
                HandlePassDataToGroupBox();
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtAddTime.Value = 0;
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ToggleGroupBox(false);
            ToggleTables(true);
            ToggleRegisterReloadButtons(true);
            ToggleWriteCancelButtons(false);
            ToggleUpdateCancelRegisterButtons(sP_GET_WORKING_HOUR_IN_AREABindingSource.Count > 0);
            HandlePassDataToGroupBox();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (cmbArea.SelectedValue != null)
            {
                this.sP_GET_STAFF_REGISTER_AREATableAdapter.Fill(qLBVDataSet.SP_GET_STAFF_REGISTER_AREA, int.Parse(cmbArea.SelectedValue.ToString()));
                if (cmbWeek.SelectedValue != null)
                {
                    this.sP_GET_WORKING_HOUR_IN_AREATableAdapter.Fill(qLBVDataSet.SP_GET_WORKING_HOUR_IN_AREA, int.Parse(cmbArea.SelectedValue.ToString()), int.Parse(cmbWeek.SelectedValue.ToString()));
                }
            }
        }

        private void sP_GET_WORKING_HOUR_IN_AREAGridControl_Click(object sender, EventArgs e)
        {
            HandlePassDataToGroupBox();
        }
        private void HandlePassDataToGroupBox()
        {
            if (sP_GET_WORKING_HOUR_IN_AREABindingSource.Count > 0)
            {
                txtStaffName.Text = ((DataRowView)sP_GET_WORKING_HOUR_IN_AREABindingSource[sP_GET_WORKING_HOUR_IN_AREABindingSource.Position])[1].ToString().Trim();
                txtStaffId.Text = ((DataRowView)sP_GET_WORKING_HOUR_IN_AREABindingSource[sP_GET_WORKING_HOUR_IN_AREABindingSource.Position])[0].ToString().Trim();
                txtArea.Text = cmbArea.Text;
                txtWeek.Text = cmbWeek.Text;
            }
            else
            {
                txtStaffName.Text = "";
                txtStaffId.Text = "";
                txtArea.Text = "";
                txtWeek.Text = "";
            }
        }
        private bool CanRegisterWorkingHour(int idWorkingHour,int idWeek)
        {
            if (Program.Connect() == 0) { return false; }
            string cmd = string.Format("DECLARE	@return_value int " +
                        "EXEC  @return_value = [dbo].[SP_CAN_REGISTER_WORKING_HOUR] " +
                        "@ID_CTLV = {0}, " +
                        "@ID_TUAN = {1} " +
                        "SELECT  'Return Value' = @return_value", idWorkingHour, idWeek);
            SqlDataReader reader = Program.ExecSqlDataReader(cmd);
            reader.Read();
            int result = reader.GetInt32(0);
            reader.Close();
            return result == 1;
        }
    }
}