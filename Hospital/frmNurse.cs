using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class frmNurse : DevExpress.XtraEditors.XtraForm,IBoss
    {
        private List<string> sex = new List<string>() { "Nam", "Nữ" };
        private List<string> educations = new List<string>() { "CHỮA TRỊ", "CHĂM SÓC", "QUẢN TRỊ", "PHỤ TÁ", "" };
        private bool isAdding = false;
        public frmNurse()
        {
            InitializeComponent();
        }

        private void frmNurse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBVDataSet.GET_FULL_NURSE' table. You can move, or remove it, as needed.
            this.gET_FULL_NURSETableAdapter.Fill(this.qLBVDataSet.GET_FULL_NURSE);
            cmbSex.DataSource = sex;
            cmbEducation.DataSource = educations;
            cmbSex.ValueMember = null;
            cmbEducation.ValueMember = null;
            HandleClick(false);
            NormalToggle(true);
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
            gET_FULL_NURSEGridControl.Enabled = state;
        }
        private void NormalToggle(bool state)
        {
            ToggleAddReloadButtons(state);
            ToggleGroupBox(!state);
            ToggleUpdateDeleteButtons(gET_FULL_NURSEBindingSource.Count > 0);
            ToggleWriteCancelButtons(!state);
            ToggleTables(state);
        }


        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NormalToggle(false);
            ToggleUpdateDeleteButtons(false);
            isAdding = true;
            HandleClick(true);
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            DialogResult resultt = MessageBox.Show("Bạn có chắc muốn xóa y tá này không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (resultt == DialogResult.OK)
            {
                string id = ((DataRowView)gET_FULL_NURSEBindingSource[gET_FULL_NURSEBindingSource.Position])["MANV"].ToString().Trim();
                string cmd = string.Format("EXEC SP_DELETE_INFOR_NURSE '{0}'", id);
                SqlCommand sqlCmd = new SqlCommand(cmd, Program.conn);
                sqlCmd.CommandType = System.Data.CommandType.Text;
                sqlCmd.CommandTimeout = 600;//10 mins
                if (Program.conn.State == System.Data.ConnectionState.Closed) Program.conn.Open();
                try
                {
                    sqlCmd.ExecuteNonQuery();
                    Program.conn.Close();
                    gET_FULL_NURSETableAdapter.Fill(qLBVDataSet.GET_FULL_NURSE);
                    HandleClick(false);
                    MessageBox.Show("Xóa y tá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (SqlException ex)
                {
                    if(ex.Message.Contains("FK_KHUCHUATRI_YTA"))
                    {
                        MessageBox.Show("Y tá này đang có dữ liệu là y tá trưởng của một khu trong khoảng thời gian", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   
                    Program.conn.Close();
                }
            }
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NormalToggle(false);
            ToggleUpdateDeleteButtons(false);
            isAdding = false;
        }

        private void btnWrite_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtDoctorId.Text == "")
            {
                MessageBox.Show("Không được bỏ trống mã y tá", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtFirstName.Text == "")
            {
                MessageBox.Show("Không được bỏ trống họ y tá", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtLastName.Text == "")
            {
                MessageBox.Show("Không được bỏ trống tên y tá", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtPhoneNumber.Text == "")
            {
                MessageBox.Show("Không được bỏ trống số điện thoại của y tá", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtPersonalId.Text == "")
            {
                MessageBox.Show("Không được bỏ trống mã căn cước công dân của y tá", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(!ValidatePhoneNumber(txtPhoneNumber.Text))
            {
                MessageBox.Show("Số điện thoại không đúng định dạng ở Việt Nam", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(txtPersonalId.Text.Length!=12)
            {
                MessageBox.Show("Số căn cước công dân không đúng định dạng ở Việt Nam", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string cmd = "";
            if (isAdding)
            {
                cmd = string.Format("EXEC SP_WRITE_INFOR_NURSE '{0}',N'{1}',N'{2}',N'{3}',N'{4}','{5}','{6}',N'{7}',NULL",
                    txtDoctorId.Text, txtFirstName.Text, txtLastName.Text, cmbSex.Text, txtAddress.Text, txtPhoneNumber.Text, txtPersonalId.Text, cmbEducation.Text);
            }
            else
            {
                string oldId = ((DataRowView)gET_FULL_NURSEBindingSource[gET_FULL_NURSEBindingSource.Position])["MANV"].ToString().Trim();
                cmd = string.Format("EXEC SP_WRITE_INFOR_NURSE '{0}',N'{1}',N'{2}',N'{3}',N'{4}','{5}','{6}',N'{7}','{8}'",
                    txtDoctorId.Text, txtFirstName.Text, txtLastName.Text, cmbSex.Text, txtAddress.Text, txtPhoneNumber.Text, txtPersonalId.Text, cmbEducation.Text, oldId);
            }
            SqlCommand sqlCmd = new SqlCommand(cmd, Program.conn);
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandTimeout = 600;//10 mins
            if (Program.conn.State == System.Data.ConnectionState.Closed) Program.conn.Open();
            try
            {
                sqlCmd.ExecuteNonQuery();
                Program.conn.Close();
                gET_FULL_NURSETableAdapter.Fill(qLBVDataSet.GET_FULL_NURSE);
                HandleClick(false);
                if (isAdding)
                {
                    MessageBox.Show("Thêm y tá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("cập nhật y tá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                NormalToggle(true);
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("PK"))
                {
                    MessageBox.Show("Mã nhân viên không được trùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Message.Contains("UK_CCCD"))
                {
                    MessageBox.Show("Số căn cước công dân không được trùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Message.Contains("UK_SDT"))
                {
                    MessageBox.Show("Số điện thoại không được trùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Không hiệu chỉnh y tá\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Program.conn.Close();
            }
        }
        private bool ValidatePhoneNumber(string phoneNumber)
        {
            // Pattern for validating phone number in Vietnam
            string pattern = @"^(0[2-9]|84[2-9])(\d{8}|\d{9})$";

            // Create a Regex object with the pattern
            Regex regex = new Regex(pattern);

            // Use the Match method to check if the phone number matches the pattern
            Match match = regex.Match(phoneNumber);

            // Return true if there is a match, indicating a valid phone number
            return match.Success;
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NormalToggle(true);
            HandleClick(false);
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gET_FULL_NURSETableAdapter.Fill(qLBVDataSet.GET_FULL_NURSE);
        }

        private void gET_FULL_NURSEGridControl_Click(object sender, EventArgs e)
        {
            HandleClick(false);
        }
        private void HandleClick(bool isAdding)
        {
            if (isAdding || gET_FULL_NURSEBindingSource.Count == 0)
            {
                txtDoctorId.Text = "";
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtPhoneNumber.Text = "";
                txtPersonalId.Text = "";
                txtAddress.Text = "";
                cmbEducation.SelectedIndex = 0;
                cmbSex.SelectedIndex = 0;
            }
            else
            {
                txtDoctorId.Text = ((DataRowView)gET_FULL_NURSEBindingSource[gET_FULL_NURSEBindingSource.Position])["MANV"].ToString().Trim();
                txtFirstName.Text = ((DataRowView)gET_FULL_NURSEBindingSource[gET_FULL_NURSEBindingSource.Position])["HO"].ToString().Trim();
                txtLastName.Text = ((DataRowView)gET_FULL_NURSEBindingSource[gET_FULL_NURSEBindingSource.Position])["TEN"].ToString().Trim();
                cmbSex.SelectedItem = ((DataRowView)gET_FULL_NURSEBindingSource[gET_FULL_NURSEBindingSource.Position])["PHAI"].ToString().Trim();
                txtAddress.Text = ((DataRowView)gET_FULL_NURSEBindingSource[gET_FULL_NURSEBindingSource.Position])["DIACHI"].ToString().Trim();
                txtPhoneNumber.Text = ((DataRowView)gET_FULL_NURSEBindingSource[gET_FULL_NURSEBindingSource.Position])["DIENTHOAI"].ToString().Trim();
                txtPersonalId.Text = ((DataRowView)gET_FULL_NURSEBindingSource[gET_FULL_NURSEBindingSource.Position])["CCCD"].ToString().Trim();
                cmbEducation.SelectedItem = ((DataRowView)gET_FULL_NURSEBindingSource[gET_FULL_NURSEBindingSource.Position])["NGHIEPVU"].ToString().Trim();
            }
        }

        public void InitialSetting()
        {
            ToggleAddReloadButtons(false);
            ToggleUpdateDeleteButtons(false);
            ToggleWriteCancelButtons(false);
        }
    }
}