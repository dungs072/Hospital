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
    public partial class frmCure : DevExpress.XtraEditors.XtraForm,IBoss
    {
        private bool isAdding = false;
        public frmCure()
        {
            InitializeComponent();
        }

        private void frmCure_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBVDataSet.GET_DOCTORS' table. You can move, or remove it, as needed.
            this.gET_DOCTORSTableAdapter.Fill(this.qLBVDataSet.GET_DOCTORS);
            qLBVDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'qLBVDataSet.GET_ALL_DETAIL_CURE' table. You can move, or remove it, as needed.
            this.gET_ALL_DETAIL_CURETableAdapter.Fill(this.qLBVDataSet.GET_ALL_DETAIL_CURE);
            // TODO: This line of code loads data into the 'qLBVDataSet.LOAICHUATRI' table. You can move, or remove it, as needed.
            this.lOAICHUATRITableAdapter.Fill(this.qLBVDataSet.LOAICHUATRI);
            // TODO: This line of code loads data into the 'qLBVDataSet.GET_ALL_PATIENT' table. You can move, or remove it, as needed.
            this.gET_ALL_PATIENTTableAdapter.Fill(this.qLBVDataSet.GET_ALL_PATIENT);
            // TODO: This line of code loads data into the 'qLBVDataSet.BENHNHAN' table. You can move, or remove it, as needed.
            this.bENHNHANTableAdapter.Fill(this.qLBVDataSet.BENHNHAN);
            HandleButtons();
            if (Program.mGroup == "BacSi")
            {
                gET_ALL_DETAIL_CUREBindingSource.Filter = "MABS = '" + Program.userName+"'";
                cmbDoctor.Enabled = false;
                cmbDoctor.SelectedValue = Program.userName;
            }

        }
        private void HandleButtons()
        {
            ToggleUpdateDeleteButtons(false);
            SetCureDetailData();
            ToggleAddReloadButtons(true);
            ToggleGroupBox(false);
            ToggleTables(true);
            ToggleWriteCancelButtons(false);
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
            gET_ALL_PATIENTGridControl.Enabled = state;
            lOAICHUATRIGridControl.Enabled = state;
            gET_ALL_DETAIL_CUREGridControl.Enabled = state;
        }

        private void gET_ALL_DETAIL_CUREGridControl_Click(object sender, EventArgs e)
        {
            SetCureDetailData();
        }
        private void SetCureDetailData()
        {
            if (gET_ALL_DETAIL_CUREBindingSource.Count == 0) 
            {
                txtPatientName.Text = "";
                txtPatientId.Text = "";
                txtType.Text = "";
                txtTime.Text = "";
                txtResult.Text = "";
                cmbDoctor.SelectedIndex = 0;
                return;
            }
            if (Program.mGroup != "Boss")
            {
                ToggleUpdateDeleteButtons(true);
            }
           
            int tempPosition = gET_ALL_DETAIL_CUREBindingSource.Position;
            txtPatientName.Text = ((DataRowView)gET_ALL_DETAIL_CUREBindingSource[tempPosition])[1].ToString().Trim();
            txtPatientId.Text = ((DataRowView)gET_ALL_DETAIL_CUREBindingSource[tempPosition])["MABN"].ToString().Trim();
            txtType.Text = ((DataRowView)gET_ALL_DETAIL_CUREBindingSource[tempPosition])[2].ToString().Trim();
            string timeStr = ((DataRowView)gET_ALL_DETAIL_CUREBindingSource[tempPosition])[3].ToString().Trim();
            txtResult.Text = ((DataRowView)gET_ALL_DETAIL_CUREBindingSource[tempPosition])[4].ToString().Trim();
            txtTypeId.Text = ((DataRowView)gET_ALL_DETAIL_CUREBindingSource[tempPosition])["MALOAI_CT"].ToString().Trim();
            cmbDoctor.SelectedValue = ((DataRowView)gET_ALL_DETAIL_CUREBindingSource[tempPosition])["MABS"].ToString().Trim();
            DateTime dateTimeValue;
            if (DateTime.TryParseExact(timeStr, "dd/MM/yyyy hh:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTimeValue))
            {
                txtTime.DateTime = dateTimeValue;
            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gET_ALL_PATIENTBindingSource.Position < 0)
            {
                MessageBox.Show("Bạn chưa chọn bệnh nhân", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lOAICHUATRIBindingSource.Position < 0)
            {
                MessageBox.Show("Bạn chưa chọn loại chữa trị", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
       
            ToggleAddReloadButtons(false);
            ToggleUpdateDeleteButtons(false);
            ToggleWriteCancelButtons(true);
            ToggleGroupBox(true);
            ToggleTables(false);

            txtPatientName.Text = ((DataRowView)gET_ALL_PATIENTBindingSource[gET_ALL_PATIENTBindingSource.Position])[1].ToString().Trim()+" "+ ((DataRowView)gET_ALL_PATIENTBindingSource[gET_ALL_PATIENTBindingSource.Position])[2].ToString().Trim();
            txtPatientId.Text = ((DataRowView)gET_ALL_PATIENTBindingSource[gET_ALL_PATIENTBindingSource.Position])[0].ToString().Trim();
            txtType.Text = ((DataRowView)lOAICHUATRIBindingSource[lOAICHUATRIBindingSource.Position])[0].ToString().Trim();
            txtTypeId.Text = ((DataRowView)lOAICHUATRIBindingSource[lOAICHUATRIBindingSource.Position])[1].ToString().Trim();
            txtResult.Text = "";
            isAdding = true;
            txtResult.Focus();
            txtTime.DateTime = DateTime.Now;

        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CanHandleOnThisRow())
            {
                MessageBox.Show("Tài khoản của bạn không có quyền điều chỉnh thông tin chi tiết chữa trị thuộc bác sĩ khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Program.Connect() == 0) { return; }
            string cmd = string.Format("DECLARE @RETURN INT" +
                "          EXEC @RETURN  = SP_CHECK_CAN_DELETE_CURE_DETAIL '{0}','{1}','{2}'" +
                "          SELECT @RETURN", txtPatientId.Text, txtTypeId.Text, txtTime.Text);
            SqlDataReader reader = Program.ExecSqlDataReader(cmd);
            reader.Read();
            int result = reader.GetInt32(0);
            reader.Close();
            if (result == 0)
            {
                MessageBox.Show("Không thể xóa chi tiết chữa trị của bệnh nhân này vì đã tồn tại việc sử dụng vật tư", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult resultDialog = MessageBox.Show("Bạn có muốn xóa chi tiết chữa trị của bệnh nhân " + txtPatientName.Text, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (resultDialog == DialogResult.OK)
            {
                int id = int.Parse(((DataRowView)gET_ALL_DETAIL_CUREBindingSource[gET_ALL_DETAIL_CUREBindingSource.Position])["ID_CTCT"].ToString().Trim());
                cmd = string.Format("DELETE FROM CHITIETCHUATRI WHERE ID_CTCT = {0}", id);
                result = Program.ExecSqlNonQuery(cmd);
                if (result == 0)
                {
                    gET_ALL_DETAIL_CURETableAdapter.Fill(qLBVDataSet.GET_ALL_DETAIL_CURE);
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CanHandleOnThisRow())
            {
                MessageBox.Show("Tài khoản của bạn không có quyền điều chỉnh thông tin chi tiết chữa trị thuộc bác sĩ khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ToggleAddReloadButtons(false);
            ToggleGroupBox(true);
            ToggleUpdateDeleteButtons(false);
            ToggleWriteCancelButtons(true);
            ToggleTables(false);
            cmbDoctor.Enabled = false;
            isAdding = false;
            txtResult.Focus();
        }

        private void btnWrite_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtResult.Text.Trim() == "")
            {
                MessageBox.Show("Kết quả điều trị không được bỏ trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Program.Connect() == 0) { return; }
            string staffId = cmbDoctor.SelectedValue.ToString().Trim();
            if (isAdding)
            {
                string cmd = string.Format("INSERT INTO CHITIETCHUATRI (MABS, MABN,MALOAI_CT,THOIGIAN, KETQUA) " +
               "                   VALUES('{0}','{1}','{2}',CONVERT(datetime, '{3}', 105),N'{4}')", staffId, txtPatientId.Text, txtTypeId.Text.Trim(), txtTime.Text, txtResult.Text);

                SqlCommand sqlCmd = new SqlCommand(cmd, Program.conn);
                sqlCmd.CommandType = System.Data.CommandType.Text;
                sqlCmd.CommandTimeout = 600;//10 mins
                if (Program.conn.State == System.Data.ConnectionState.Closed) Program.conn.Open();
                try
                {
                    sqlCmd.ExecuteNonQuery();
                    
                    gET_ALL_DETAIL_CURETableAdapter.Fill(qLBVDataSet.GET_ALL_DETAIL_CURE);
                    HandleButtons();
                    Program.conn.Close();
                    MessageBox.Show("Thêm thành công chi tiết chữa trị cho bệnh nhân " + txtPatientName.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    if (ex.Message.Contains("UK"))
                    {
                        MessageBox.Show("Không thể có mã nhân viên chữa trị cho bệnh nhân tại cùng một thời điểm được");
                    }
                    else
                    {
                        MessageBox.Show("Lỗi không thể thêm chi tiết chữa trị cho bệnh nhân này\n"+ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Program.conn.Close();
                }
            }
            else
            {
                string cmd = "";
                int id = int.Parse(((DataRowView)gET_ALL_DETAIL_CUREBindingSource[gET_ALL_DETAIL_CUREBindingSource.Position])["ID_CTCT"].ToString().Trim());
                if (txtTime.Text == "")
                {
                    cmd = string.Format("UPDATE CHITIETCHUATRI SET KETQUA = N'{0}' " +
                "                   WHERE ID_CTCT = {1}", txtResult.Text,id);
                }
                else
                {
                    cmd = cmd = string.Format("UPDATE CHITIETCHUATRI SET KETQUA = N'{0}', THOIGIAN = CONVERT(datetime, '{1}', 105) " +
                "                   WHERE ID_CTCT = {2}", txtResult.Text,txtTime.Text, id);
                }

                SqlCommand sqlCmd = new SqlCommand(cmd, Program.conn);
                sqlCmd.CommandType = System.Data.CommandType.Text;
                sqlCmd.CommandTimeout = 600;//10 mins
                if (Program.conn.State == System.Data.ConnectionState.Closed) Program.conn.Open();
                try
                {
                    sqlCmd.ExecuteNonQuery();
                    gET_ALL_DETAIL_CURETableAdapter.Fill(qLBVDataSet.GET_ALL_DETAIL_CURE);
                    HandleButtons();
                    Program.conn.Close();
                    cmbDoctor.Enabled = true;
                    MessageBox.Show("Cập nhật thành công chi tiết chữa trị cho bệnh nhân " + txtPatientName.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    if (ex.Message.Contains("UK"))
                    {
                        MessageBox.Show("Không thể có mã nhân viên chữa trị cho bệnh nhân tại cùng một thời điểm được");
                    }
                    else
                    {
                        MessageBox.Show("Lỗi không thể chỉnh sửa chi tiết chữa trị cho bệnh nhân này\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Program.conn.Close();
                }
            }
            
           
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ToggleAddReloadButtons(true);
            ToggleUpdateDeleteButtons(gET_ALL_DETAIL_CUREBindingSource.Count>0);
            ToggleWriteCancelButtons(false);
            ToggleGroupBox(false);
            ToggleTables(true);
            SetCureDetailData();
            cmbDoctor.Enabled = true;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gET_ALL_DETAIL_CURETableAdapter.Fill(this.qLBVDataSet.GET_ALL_DETAIL_CURE);
        
            // TODO: This line of code loads data into the 'qLBVDataSet.LOAICHUATRI' table. You can move, or remove it, as needed.
            this.lOAICHUATRITableAdapter.Fill(this.qLBVDataSet.LOAICHUATRI);
            // TODO: This line of code loads data into the 'qLBVDataSet.GET_ALL_PATIENT' table. You can move, or remove it, as needed.
            this.gET_ALL_PATIENTTableAdapter.Fill(this.qLBVDataSet.GET_ALL_PATIENT);
            // TODO: This line of code loads data into the 'qLBVDataSet.BENHNHAN' table. You can move, or remove it, as needed.
            this.bENHNHANTableAdapter.Fill(this.qLBVDataSet.BENHNHAN);
        }
        private bool CanHandleOnThisRow()
        {
            if (Program.mGroup != "BacSi")
            {
                return true;
            }
            string doctorId = ((DataRowView)gET_ALL_DETAIL_CUREBindingSource[gET_ALL_DETAIL_CUREBindingSource.Position])["MABS"].ToString().Trim();
            return doctorId == Program.userName;
            
        }

        public void InitialSetting()
        {
            ToggleAddReloadButtons(false);
            ToggleUpdateDeleteButtons(false);
            ToggleWriteCancelButtons(false);
        }
    }
}