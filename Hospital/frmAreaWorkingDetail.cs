using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class frmAreaWorkingDetail : DevExpress.XtraEditors.XtraForm,IBoss
    {
        private List<int> areaIds = new List<int>();
        private bool isAdding = false;
        public frmAreaWorkingDetail()
        {
            InitializeComponent();
        }


        private void frmAreaWorkingDetail_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'qLBVDataSet.KHUCHUATRI' table. You can move, or remove it, as needed.
            this.kHUCHUATRITableAdapter.Fill(this.qLBVDataSet.KHUCHUATRI);
            this.gET_STAFFTableAdapter.Fill(this.qLBVDataSet.GET_STAFF);

            if (kHUCHUATRIBindingSource.Count > 0)
            {
                int id = int.Parse(((DataRowView)kHUCHUATRIBindingSource[kHUCHUATRIBindingSource.Position])[0].ToString().Trim());
                wORKING_DETAIL_AREATableAdapter.Fill(qLBVDataSet.WORKING_DETAIL_AREA, id);
            }

            ToggleWriteCancelButtons(false);
            ToggleRegisterReloadButtons(true);
            ToggleGroupBox(false);
            HandleWorkingDetailDataClick();
            txtStartDate.Properties.MaxValue = DateTime.Now;
            txtStartDate.Properties.MinValue = DateTime.Now;
            txtEndDate.Properties.MaxValue = DateTime.Now;
            txtEndDate.Properties.MinValue = DateTime.Now;
        }
        private void HandleWorkingDetailClick()
        {
            if (Program.mGroup != "Boss")
            {
                ToggleUpdateCancelRegisterButtons(wORKING_DETAIL_AREABindingSource.Count > 0);
            }
            
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
            kHUCHUATRIGridControl.Enabled = state;
            gET_STAFFGridControl.Enabled = state;
            wORKING_DETAIL_AREAGridControl.Enabled = state;
        }

        private void HandleWorkingDetailDataClick()
        {
            HandleWorkingDetailClick();
            if (wORKING_DETAIL_AREABindingSource.Count == 0) { return; }
            txtStaffId.Text = ((DataRowView)wORKING_DETAIL_AREABindingSource[wORKING_DETAIL_AREABindingSource.Position])[1].ToString().Trim();
            txtStaffName.Text = ((DataRowView)wORKING_DETAIL_AREABindingSource[wORKING_DETAIL_AREABindingSource.Position])[2].ToString().Trim();
            txtAreaId.Text = ((DataRowView)wORKING_DETAIL_AREABindingSource[wORKING_DETAIL_AREABindingSource.Position])[3].ToString().Trim();
            txtAreaName.Text = ((DataRowView)wORKING_DETAIL_AREABindingSource[wORKING_DETAIL_AREABindingSource.Position])[4].ToString().Trim();
            txtEndDate.Text = "";
            string startDateStr = ((DataRowView)wORKING_DETAIL_AREABindingSource[wORKING_DETAIL_AREABindingSource.Position])[5].ToString().Trim();
            string endDateStr = ((DataRowView)wORKING_DETAIL_AREABindingSource[wORKING_DETAIL_AREABindingSource.Position])[6].ToString().Trim();
            string format = "dd/MM/yyyy";
            DateTime startDate;
            DateTime endDate;
            if (DateTime.TryParseExact(startDateStr, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out startDate))
            {
                txtStartDate.DateTime = startDate;
            }
            if (DateTime.TryParseExact(endDateStr, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out endDate))
            {
                txtEndDate.DateTime = endDate;
            }
        }

        private void btnRegister_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gET_STAFFBindingSource.Count == 0)
            {
                MessageBox.Show("Không có nhân viên nào được chọn để đăng kí cả", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (kHUCHUATRIBindingSource.Count == 0)
            {
                MessageBox.Show("Không có khu nào để chọn đăng kí", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!CanRegister())
            {
                MessageBox.Show("Nhân viên đang được làm việc ở khu vực khác.\nBạn vui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ToggleRegisterReloadButtons(false);
            ToggleWriteCancelButtons(true);
            ToggleUpdateCancelRegisterButtons(false);
            ToggleTables(false);
            ToggleGroupBox(true);
            txtStaffId.Text = ((DataRowView)gET_STAFFBindingSource[gET_STAFFBindingSource.Position])[0].ToString().Trim();
            txtStaffName.Text = ((DataRowView)gET_STAFFBindingSource[gET_STAFFBindingSource.Position])[1].ToString().Trim() + " " + ((DataRowView)gET_STAFFBindingSource[gET_STAFFBindingSource.Position])[2].ToString().Trim();
            txtAreaId.Text = ((DataRowView)kHUCHUATRIBindingSource[kHUCHUATRIBindingSource.Position])[0].ToString().Trim();
            txtAreaName.Text = ((DataRowView)kHUCHUATRIBindingSource[kHUCHUATRIBindingSource.Position])[1].ToString().Trim();
            txtStartDate.DateTime = DateTime.Today;
            txtEndDate.Text = "";
            txtStartDate.Focus();
            isAdding = true;

        }

        private void btnWrite_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (txtEndDate.Text != "")
            //{
            //    if (txtStartDate.DateTime >= txtEndDate.DateTime)
            //    {
            //        MessageBox.Show("Thời gian bắt đầu làm không thể lớn hơn thời gian kết thúc làm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        txtEndDate.Focus();
            //        return;
            //    }
            //}
            if (!CanRegisterWithDay())
            {
                MessageBox.Show("Thời gian bắt đầu đang ở trong một khoảng thời gian làm việc khác của nhân viên này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStartDate.Focus();
                return;
            }
            if (Program.Connect() == 0) { return; }
            string cmd = "";
            if (isAdding)
            {
                if (txtEndDate.Text == "")
                {
                    cmd = string.Format("INSERT INTO CHITIETLAMVIECKHUCHUATRI(DANHDINHKHU, MANV, NGAYBATDAULAM) VALUES({0},'{1}','{2}')", int.Parse(txtAreaId.Text), txtStaffId.Text, txtStartDate.DateTime.ToString());
                }
                else
                {
                    cmd = string.Format("INSERT INTO CHITIETLAMVIECKHUCHUATRI(DANHDINHKHU, MANV, NGAYBATDAULAM,NGAYKETTHUCLAM) VALUES({0},'{1}','{2}','{3}')", int.Parse(txtAreaId.Text), txtStaffId.Text, txtStartDate.DateTime.ToString(), txtEndDate.DateTime.ToString());
                }

            }
            else
            {
                int id = int.Parse(((DataRowView)wORKING_DETAIL_AREABindingSource[wORKING_DETAIL_AREABindingSource.Position])[0].ToString().Trim());
                if (txtEndDate.Text == "")
                {
                    cmd = string.Format("UPDATE CHITIETLAMVIECKHUCHUATRI SET DANHDINHKHU = {0}, MANV = '{1}', NGAYBATDAULAM = '{2}', NGAYKETTHUCLAM = NULL WHERE ID_CTLV = {3}", int.Parse(txtAreaId.Text), txtStaffId.Text, txtStartDate.DateTime.ToString(), id);
                }
                else
                {
                    cmd = string.Format("UPDATE CHITIETLAMVIECKHUCHUATRI SET DANHDINHKHU = {0}, MANV = '{1}', NGAYBATDAULAM = '{2}', NGAYKETTHUCLAM = '{3}' WHERE ID_CTLV = {4}", int.Parse(txtAreaId.Text), txtStaffId.Text, txtStartDate.DateTime.ToString(), txtEndDate.DateTime.ToString(), id);
                }
            }
            int result = Program.ExecSqlNonQuery(cmd);
            if (result == 0)
            {
                if (kHUCHUATRIBindingSource.Count > 0)
                {
                    int id = int.Parse(((DataRowView)kHUCHUATRIBindingSource[kHUCHUATRIBindingSource.Position])[0].ToString().Trim());
                    wORKING_DETAIL_AREATableAdapter.Fill(qLBVDataSet.WORKING_DETAIL_AREA, id);
                }
                if (isAdding)
                {
                    MessageBox.Show("Đăng kí thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa đăng kí thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ToggleRegisterReloadButtons(true);
                ToggleWriteCancelButtons(false);
                ToggleUpdateCancelRegisterButtons(wORKING_DETAIL_AREABindingSource.Count > 0);
                ToggleTables(true);
                ToggleGroupBox(false);
                gridView1.RefreshData();
                txtStartDate.Enabled = true;
            }
            else
            {
                MessageBox.Show("Không thể hiệu chỉnh đăng kí này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void kHUCHUATRIGridControl_Click(object sender, EventArgs e)
        {
            if (kHUCHUATRIBindingSource.Count > 0)
            {
                int id = int.Parse(((DataRowView)kHUCHUATRIBindingSource[kHUCHUATRIBindingSource.Position])[0].ToString().Trim());
                wORKING_DETAIL_AREATableAdapter.Fill(qLBVDataSet.WORKING_DETAIL_AREA, id);
            }
            if (Program.mGroup != "Boss")
            {
                ToggleUpdateCancelRegisterButtons(wORKING_DETAIL_AREABindingSource.Count > 0);
            }
            
        }
        private void HandleWorkingAreaClick()
        {
            if (kHUCHUATRIBindingSource.Count > 0)
            {
                int id = int.Parse(((DataRowView)kHUCHUATRIBindingSource[kHUCHUATRIBindingSource.Position])[0].ToString().Trim());
                wORKING_DETAIL_AREATableAdapter.Fill(qLBVDataSet.WORKING_DETAIL_AREA, id);
            }
            if (Program.mGroup != "Boss")
            {
                ToggleUpdateCancelRegisterButtons(wORKING_DETAIL_AREABindingSource.Count > 0);
            }
            
        }

        private bool CanCancelRegister()
        {
            int id = int.Parse(((DataRowView)wORKING_DETAIL_AREABindingSource[wORKING_DETAIL_AREABindingSource.Position])[0].ToString().Trim());
            string cmd = string.Format("DECLARE	@return_value int " +
                        " EXEC    @return_value = [dbo].[CHECK_CAN_DELETE_WORKING_DETAIL] " +
                        "@ID_CTLV = {0} " +
                        " SELECT  'Return Value' = @return_value", id);
            if (Program.Connect() == 0) { return false; }
            SqlDataReader reader = Program.ExecSqlDataReader(cmd);
            reader.Read();

            int result = reader.GetInt32(0);
            reader.Close();
            return result == 1;
        }
        private bool CanRegister()
        {

            string staffId = ((DataRowView)gET_STAFFBindingSource[gET_STAFFBindingSource.Position])[0].ToString().Trim();
            string cmd = string.Format("DECLARE	@return_value int " +
                        " EXEC    @return_value = [dbo].[CAN_REGISTER_WORKING_AREA_DETAIL] " +
                        "@MANV = '{0}' " +
                        " SELECT  'Return Value' = @return_value", staffId);
            if (Program.Connect() == 0) { return false; }
            SqlDataReader reader = Program.ExecSqlDataReader(cmd);
            reader.Read();

            int result = reader.GetInt32(0);
            reader.Close();
            return result == 1;
        }
        private bool CanRegisterWithDay()
        {
            if (wORKING_DETAIL_AREABindingSource.Count == 0) { return true; }
            int id = int.Parse(((DataRowView)wORKING_DETAIL_AREABindingSource[wORKING_DETAIL_AREABindingSource.Position])[0].ToString().Trim());
            string cmd = string.Format("DECLARE	@return_value int " +
                        " EXEC    @return_value = [dbo].[CAN_REGISTER_WITH_DAY] " +
                        "@MANV = '{0}' ," + "@NGAYBATDAULAM = '{1}' ," + "@ID = {2}" +
                        " SELECT  'Return Value' = @return_value", txtStaffId.Text, txtStartDate.DateTime.ToString("dd/MM/yyyy"), id);
            if (Program.Connect() == 0) { return false; }
            SqlDataReader reader = Program.ExecSqlDataReader(cmd);
            reader.Read();

            int result = reader.GetInt32(0);
            reader.Close();
            return result == 1;
        }

        private void btnCancelRegister_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CanCancelRegister())
            {
                MessageBox.Show("Không thể hủy đăng kí này bởi vì đã ghi nhận thời gian làm việc trong tuần", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc muốn hủy đăng kí này chứ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                int id = int.Parse(((DataRowView)wORKING_DETAIL_AREABindingSource[wORKING_DETAIL_AREABindingSource.Position])[0].ToString().Trim());
                string cmd = string.Format("DELETE CHITIETLAMVIECKHUCHUATRI WHERE ID_CTLV = {0}", id);
                int resultt = Program.ExecSqlNonQuery(cmd);
                if (resultt == 0)
                {
                    HandleWorkingAreaClick();
                    MessageBox.Show("Xóa đăng kí thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridView1.RefreshData();
                }
                else
                {
                    MessageBox.Show("Xóa đăng kí thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ToggleRegisterReloadButtons(true);
            ToggleWriteCancelButtons(false);
            ToggleUpdateCancelRegisterButtons(wORKING_DETAIL_AREABindingSource.Count > 0);
            ToggleTables(true);
            ToggleGroupBox(false);
            txtStartDate.Enabled = true;
            HandleWorkingDetailDataClick();
        }

        private void wORKING_DETAIL_AREAGridControl_Click(object sender, EventArgs e)
        {
            HandleWorkingDetailDataClick();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            kHUCHUATRITableAdapter.Fill(qLBVDataSet.KHUCHUATRI);
            gET_STAFFTableAdapter.Fill(qLBVDataSet.GET_STAFF);
            if (kHUCHUATRIBindingSource.Count > 0)
            {
                int id = int.Parse(((DataRowView)kHUCHUATRIBindingSource[kHUCHUATRIBindingSource.Position])[0].ToString().Trim());
                wORKING_DETAIL_AREATableAdapter.Fill(qLBVDataSet.WORKING_DETAIL_AREA, id);
            }

        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ToggleRegisterReloadButtons(false);
            ToggleWriteCancelButtons(true);
            ToggleUpdateCancelRegisterButtons(false);
            ToggleTables(false);
            ToggleGroupBox(true);
            txtStartDate.Enabled = false;
            txtEndDate.Focus();
            txtStaffId.Text = ((DataRowView)wORKING_DETAIL_AREABindingSource[wORKING_DETAIL_AREABindingSource.Position])[1].ToString().Trim();
            txtStaffName.Text = ((DataRowView)wORKING_DETAIL_AREABindingSource[wORKING_DETAIL_AREABindingSource.Position])[2].ToString().Trim();
            txtAreaId.Text = ((DataRowView)wORKING_DETAIL_AREABindingSource[wORKING_DETAIL_AREABindingSource.Position])[3].ToString().Trim();
            txtAreaName.Text = ((DataRowView)wORKING_DETAIL_AREABindingSource[wORKING_DETAIL_AREABindingSource.Position])[4].ToString().Trim();
            isAdding = false;
            string startDateStr = ((DataRowView)wORKING_DETAIL_AREABindingSource[wORKING_DETAIL_AREABindingSource.Position])[5].ToString().Trim();
            string endDateStr = ((DataRowView)wORKING_DETAIL_AREABindingSource[wORKING_DETAIL_AREABindingSource.Position])[6].ToString().Trim();
            string format = "dd/MM/yyyy";
            txtEndDate.Text = "";
            DateTime startDate;
            DateTime endDate;
            if (DateTime.TryParseExact(startDateStr, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out startDate))
            {
                txtStartDate.DateTime = startDate;
            }
            if (DateTime.TryParseExact(endDateStr, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out endDate))
            {
                txtEndDate.DateTime = endDate;
            }
        }

        public void InitialSetting()
        {
            ToggleRegisterReloadButtons(false);
            ToggleUpdateCancelRegisterButtons(false);
            ToggleWriteCancelButtons(false);
        }
    }
}