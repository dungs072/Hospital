using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class frmRegisterLivingRoom : DevExpress.XtraEditors.XtraForm,IBoss
    {
        private bool isAdding = false;
        public frmRegisterLivingRoom()
        {
            InitializeComponent();
        }


        private void frmRegisterLivingRoom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBVDataSet.GIUONG' table. You can move, or remove it, as needed.
            this.gIUONGTableAdapter.Fill(this.qLBVDataSet.GIUONG);
            // TODO: This line of code loads data into the 'qLBVDataSet.PATIENT_NOT_REGISTER_LIVING_ROOM' table. You can move, or remove it, as needed.
            this.pATIENT_NOT_REGISTER_LIVING_ROOMTableAdapter.Fill(this.qLBVDataSet.PATIENT_NOT_REGISTER_LIVING_ROOM);
            // TODO: This line of code loads data into the 'qLBVDataSet.PHONG' table. You can move, or remove it, as needed.
            this.pHONGTableAdapter.Fill(this.qLBVDataSet.PHONG);
            // TODO: This line of code loads data into the 'qLBVDataSet.KHUCHUATRI' table. You can move, or remove it, as needed.
            this.kHUCHUATRITableAdapter.Fill(this.qLBVDataSet.KHUCHUATRI);
            if (cmbRoom.SelectedValue != null)
            {
                this.sP_GET_VACANT_ROOMTableAdapter.Fill(this.qLBVDataSet.SP_GET_VACANT_ROOM, cmbRoom.SelectedValue.ToString());
            }
         
            ToggleOnGroupBoxEnterData(false);
            ToggleRegisterReloadButtons(true);
            ToggleCancelWriteButtons(false);
            UpdateDataInGroupBox();
            ToggleCancelRegisterUpdateButtons(sP_GET_DETAIL_LIVING_ROOMBindingSource.Count > 0);


        }

        private void cmbRoom_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbRoom.Text == "")
            {
                this.sP_GET_VACANT_ROOMTableAdapter.Fill(this.qLBVDataSet.SP_GET_VACANT_ROOM, "");
            }
            if (cmbRoom.SelectedValue != null)
            {
                this.sP_GET_VACANT_ROOMTableAdapter.Fill(this.qLBVDataSet.SP_GET_VACANT_ROOM, cmbRoom.SelectedValue.ToString());
            }
        }
        private void ToggleOnGroupBoxEnterData(bool state)
        {
            grbEnterData.Enabled = state;
            
        }


        private void cmbArea3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbArea3.SelectedValue != null)
            {
                this.sP_GET_DETAIL_LIVING_ROOMTableAdapter.Fill(this.qLBVDataSet.SP_GET_DETAIL_LIVING_ROOM, int.Parse(cmbArea3.SelectedValue.ToString()));
                UpdateDataInGroupBox();
            }
            if (Program.mGroup != "Boss")
            {
                ToggleCancelRegisterUpdateButtons(sP_GET_DETAIL_LIVING_ROOMBindingSource.Count > 0);
            }
            
        }

        private void sP_GET_DETAIL_LIVING_ROOMGridControl_Click(object sender, EventArgs e)
        {
            if (Program.mGroup != "Boss")
            {
                ToggleCancelRegisterUpdateButtons(sP_GET_DETAIL_LIVING_ROOMBindingSource.Count > 0);
            }
           
            UpdateDataInGroupBox();
            
        }
        private void UpdateDataInGroupBox()
        {
            HandleDataOnGroupBox();
        }
        private void HandleDataOnGroupBox()
        {
            if (sP_GET_DETAIL_LIVING_ROOMBindingSource.Count == 0)
            {
                cmbGrArea.Text = cmbArea3.Text;
                txtPatientName.Text = "";
                txtPatientId.Text = "";
                txtStartTime.Text = "";
                txtEndTime.Text = "";
                return;
            }
            cmbGrArea.Text = cmbArea3.Text;
            int tempPosition = sP_GET_DETAIL_LIVING_ROOMBindingSource.Position;
            cmbGrRoom.Text = ((DataRowView)sP_GET_DETAIL_LIVING_ROOMBindingSource[tempPosition])[5].ToString().Trim();
            cmbBed.Text = ((DataRowView)sP_GET_DETAIL_LIVING_ROOMBindingSource[tempPosition])[2].ToString().Trim();
            txtPatientName.Text = ((DataRowView)sP_GET_DETAIL_LIVING_ROOMBindingSource[tempPosition])[1].ToString().Trim();
            txtPatientId.Text = ((DataRowView)sP_GET_DETAIL_LIVING_ROOMBindingSource[tempPosition])[0].ToString().Trim();
            string startDate = ((DataRowView)sP_GET_DETAIL_LIVING_ROOMBindingSource[tempPosition])[3].ToString().Trim();
            string endDate = ((DataRowView)sP_GET_DETAIL_LIVING_ROOMBindingSource[tempPosition])[4].ToString().Trim();

            DateTime startDateTime = CastDateTime(startDate);
            txtStartTime.DateTime = startDateTime;
            if (endDate == "")
            {
                txtEndTime.Text = "";
            }
            else
            {
                DateTime endDateTime = CastDateTime(endDate);
                txtEndTime.DateTime = endDateTime;
            }
        }
        private void ToggleRegisterReloadButtons(bool state)
        {
            btnBarRegister.Enabled =  btnBarReload.Enabled = state;
        }
        private void ToggleCancelWriteButtons(bool state)
        {
            btnBarCancel.Enabled = btnBarWrite.Enabled = state;
        }
        private void ToggleCancelRegisterUpdateButtons(bool state)
        {
            btnBarCancelRegister.Enabled = btnBarUpdate.Enabled = state;
        }
        private void ToggleRegisterTables(bool state)
        {
            sP_GET_VACANT_ROOMGridControl.Enabled = pATIENT_NOT_REGISTER_LIVING_ROOMGridControl.Enabled = sP_GET_DETAIL_LIVING_ROOMGridControl.Enabled = state;
            cmbArea.Enabled = cmbArea3.Enabled = cmbRoom.Enabled = state;
        }
        private void ToggleCmbInGroupBox(bool state)
        {
            cmbGrArea.Enabled = cmbGrRoom.Enabled = cmbBed.Enabled = state;
        }
        private void HandleAfterAction()
        {
            ToggleOnGroupBoxEnterData(false);
            ToggleCancelWriteButtons(false);
            ToggleRegisterTables(true);
            ToggleCmbInGroupBox(true);
            ToggleCancelRegisterUpdateButtons(sP_GET_DETAIL_LIVING_ROOMBindingSource.Count > 0);
            ToggleRegisterReloadButtons(true);

            HandleDataOnGroupBox();
        }

        private void btnBarRegister_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (pATIENT_NOT_REGISTER_LIVING_ROOMBindingSource.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn bệnh nhân để đăng kí", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (sP_GET_VACANT_ROOMBindingSource.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn giường trống để đăng kí", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            isAdding = true;
            cmbArea3.Text = cmbArea.Text;
            txtStartTime.Focus();
            ToggleOnGroupBoxEnterData(true);
            ToggleCancelWriteButtons(true);
            ToggleRegisterTables(false);
            ToggleCmbInGroupBox(false);
            ToggleCancelRegisterUpdateButtons(false);
            ToggleRegisterReloadButtons(false);
            cmbGrArea.Text = cmbArea.Text;
            cmbGrRoom.Text = cmbRoom.Text;
            cmbBed.Text = ((DataRowView)sP_GET_VACANT_ROOMBindingSource[sP_GET_VACANT_ROOMBindingSource.Position])[1].ToString().Trim();
            txtPatientName.Text = ((DataRowView)pATIENT_NOT_REGISTER_LIVING_ROOMBindingSource[pATIENT_NOT_REGISTER_LIVING_ROOMBindingSource.Position])[1].ToString().Trim()+" "+ ((DataRowView)pATIENT_NOT_REGISTER_LIVING_ROOMBindingSource[pATIENT_NOT_REGISTER_LIVING_ROOMBindingSource.Position])[2].ToString().Trim();
            txtPatientId.Text = ((DataRowView)pATIENT_NOT_REGISTER_LIVING_ROOMBindingSource[pATIENT_NOT_REGISTER_LIVING_ROOMBindingSource.Position])[0].ToString().Trim();
            txtStartTime.Text = "";
            txtEndTime.Text = "";
        }

        private void btnBarCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HandleAfterAction();
            txtStartTime.Enabled = true;
        }

        private void btnBarWrite_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cmbGrRoom.Text == "")
            {
                MessageBox.Show("Phòng không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbBed.Text == "")
            {
                MessageBox.Show("Giường không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtStartTime.Text.Trim() == "")
            {
                MessageBox.Show("Thời gian bắt đầu không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (Program.Connect() == 0) { return; }
            string patientId = txtPatientId.Text;
            string bedId = cmbBed.SelectedValue.ToString();
            string startTime = txtStartTime.Text;
            string cmd = "";
            
            if (isAdding)
            {
                if (txtEndTime.Text.Trim() == "")
                {
                    int result = CheckTImeIsValidWithEndTimeIsNull(patientId, startTime);
                    if (result == 1)
                    {
                        MessageBox.Show("Bệnh nhân này chưa được ra khỏi giường hiện tại đang ở", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (result == 2)
                    {
                        MessageBox.Show("Thời gian bạn thiết lập chưa chính xác", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    int result = CheckTimeIsValid(patientId, startTime, txtEndTime.Text);
                    if (result == 1)
                    {
                        MessageBox.Show("Bệnh nhân này chưa được ra khỏi giường hiện tại đang ở", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (result == 2)
                    {
                        MessageBox.Show("Thời gian bạn thiết lập chưa chính xác", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (txtEndTime.Text.Trim() == "")
                {
                    cmd = string.Format("INSERT INTO CHITIETO(MABN,MAGIUONG,THOIGIANBATDAU) VALUES('{0}','{1}',CONVERT(datetime, '{2}', 105))", patientId, bedId, startTime);
                }
                else
                {
                    cmd = string.Format("INSERT INTO CHITIETO(MABN,MAGIUONG,THOIGIANBATDAU,THOIGIANKETTHUC) VALUES('{0}','{1}',CONVERT(datetime, '{2}', 105),CONVERT(datetime, '{3}', 105))", patientId, bedId, startTime, txtEndTime.Text);
                }
            }
            else
            {
                txtStartTime.Enabled = true;
                if (txtEndTime.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn chưa cập nhật gì cả cho thời gian kết thúc của bệnh nhân này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    cmd = string.Format("UPDATE CHITIETO SET THOIGIANKETTHUC = CONVERT(datetime, '{0}', 105) WHERE MABN = '{1}' AND MAGIUONG = '{2}' AND THOIGIANBATDAU = CONVERT(datetime, '{3}', 105)", txtEndTime.Text, patientId, bedId, startTime);
                }
            }

                SqlCommand sqlCmd = new SqlCommand(cmd, Program.conn);
                sqlCmd.CommandType = System.Data.CommandType.Text;
                sqlCmd.CommandTimeout = 600;//10 mins
                if (Program.conn.State == System.Data.ConnectionState.Closed) Program.conn.Open();
                try
                {
                    sqlCmd.ExecuteNonQuery();
                    Program.conn.Close();
                    pATIENT_NOT_REGISTER_LIVING_ROOMTableAdapter.Fill(qLBVDataSet.PATIENT_NOT_REGISTER_LIVING_ROOM);
                    if (cmbRoom.SelectedValue != null)
                    {
                        sP_GET_VACANT_ROOMTableAdapter.Fill(qLBVDataSet.SP_GET_VACANT_ROOM, cmbRoom.SelectedValue.ToString());
                    }
                    if (cmbArea3.SelectedValue != null)
                    {
                        sP_GET_DETAIL_LIVING_ROOMTableAdapter.Fill(qLBVDataSet.SP_GET_DETAIL_LIVING_ROOM, int.Parse(cmbArea3.SelectedValue.ToString()));
                    }
                    
                    HandleAfterAction();
                    MessageBox.Show("ghi đăng kí thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    if (ex.Message.Contains("CK"))
                    {
                        MessageBox.Show("Không thể ghi thời gian kết thúc ở cho bệnh nhân.\nVì thời gian kết thúc ở bé hơn thời gian bắt đầu ở", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra, Không thể ghi\n"+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
        }

        private void btnBarCancelRegister_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn về việc hủy đăng kí phòng cho bệnh nhân " + txtPatientName.Text + " này chứ ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                if (Program.Connect() == 0) { return; }
                string patientId = txtPatientId.Text;
                string bedId = cmbBed.SelectedValue.ToString();
                string startTime = txtStartTime.Text;
                cmbArea.Text = cmbArea3.Text;
                cmbRoom.Text = cmbGrRoom.Text;
                string cmd = string.Format("DELETE FROM CHITIETO WHERE MABN = '{0}' AND MAGIUONG = '{1}' AND THOIGIANBATDAU = CONVERT(datetime,'{2}',105)", patientId, bedId, startTime);
                int tempResult = Program.ExecSqlNonQuery(cmd);
                if (tempResult == 0)
                {
                
                    pATIENT_NOT_REGISTER_LIVING_ROOMTableAdapter.Fill(qLBVDataSet.PATIENT_NOT_REGISTER_LIVING_ROOM);
                    sP_GET_VACANT_ROOMTableAdapter.Fill(qLBVDataSet.SP_GET_VACANT_ROOM, cmbRoom.SelectedValue.ToString());
                    sP_GET_DETAIL_LIVING_ROOMTableAdapter.Fill(qLBVDataSet.SP_GET_DETAIL_LIVING_ROOM, int.Parse(cmbArea3.SelectedValue.ToString()));
                    HandleAfterAction();
                    MessageBox.Show("Hủy đăng kí thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        private void btnBarUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isAdding = false;
            ToggleOnGroupBoxEnterData(true);
            ToggleCancelWriteButtons(true);
            ToggleRegisterTables(false);
            ToggleCmbInGroupBox(false);
            ToggleCancelRegisterUpdateButtons(false);
            ToggleRegisterReloadButtons(false);
            txtStartTime.Enabled = false;
            txtEndTime.Focus();
        }

        private void btnBarReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pATIENT_NOT_REGISTER_LIVING_ROOMTableAdapter.Fill(qLBVDataSet.PATIENT_NOT_REGISTER_LIVING_ROOM);
            if (cmbRoom.SelectedValue != null)
            {
                sP_GET_VACANT_ROOMTableAdapter.Fill(qLBVDataSet.SP_GET_VACANT_ROOM, cmbRoom.SelectedValue.ToString());
            }
            if (cmbArea3.SelectedValue != null)
            {
                sP_GET_DETAIL_LIVING_ROOMTableAdapter.Fill(qLBVDataSet.SP_GET_DETAIL_LIVING_ROOM, int.Parse(cmbArea3.SelectedValue.ToString()));
            }
            
        }
        private int CheckTimeIsValid(string patientId, string startTime, string endTime)
        {
            string cmd = string.Format("DECLARE @RESULT INT " +
                                    "EXEC @RESULT = CHECK_TIME_IS_VALID '{0}','{1}','{2}' "
                                    +"SELECT @RESULT ",patientId,startTime,endTime);
            SqlDataReader timeReader = Program.ExecSqlDataReader(cmd);
            timeReader.Read();
            int result = timeReader.GetInt32(0);
            timeReader.Close();
            return result;
        }
        private int CheckTImeIsValidWithEndTimeIsNull(string patientId, string startTime)
        {

            string cmd = string.Format("DECLARE @RESULT INT " +
                                    "EXEC @RESULT = CHECK_TIME_IS_VALID '{0}','{1}',NULL "
                                    + "SELECT @RESULT ", patientId, startTime);
            SqlDataReader timeReader = Program.ExecSqlDataReader(cmd);
            timeReader.Read();
            int result = timeReader.GetInt32(0);
            timeReader.Close();
            return result;
        }
        private DateTime CastDateTime(string dateTimeStr)
        {
            DateTime dateTimeValue;
            if (DateTime.TryParseExact(dateTimeStr, "MM/dd/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTimeValue))
            {
            }
            else if(DateTime.TryParseExact(dateTimeStr, "M/d/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTimeValue))
            {
                
            }
            else if(DateTime.TryParseExact(dateTimeStr, "M/dd/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTimeValue))
            {

            }
            else if(DateTime.TryParseExact(dateTimeStr, "MM/d/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTimeValue))
            {

            }
            else if (DateTime.TryParseExact(dateTimeStr, "MM/dd/yyyy h:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTimeValue))
            {
            }
            else if (DateTime.TryParseExact(dateTimeStr, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTimeValue))
            {

            }
            else if (DateTime.TryParseExact(dateTimeStr, "M/dd/yyyy h:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTimeValue))
            {

            }
            else if (DateTime.TryParseExact(dateTimeStr, "MM/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTimeValue))
            {

            }

            return dateTimeValue;

        }

        public void InitialSetting()
        {
            ToggleRegisterReloadButtons(false);
            ToggleCancelRegisterUpdateButtons(false);
            ToggleCancelWriteButtons(false);
        }
    }
}