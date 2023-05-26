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
    public partial class frmPatient : DevExpress.XtraEditors.XtraForm,IBoss
    {
        private List<string> types = new List<string>() { "Nội trú","Ngoại trú"};
        private bool isAdding = false;
        private int position = 0;
        public frmPatient()
        {
            InitializeComponent();
        }


        private void frmPatient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBVDataSet.GET_DOCTORS' table. You can move, or remove it, as needed.
            this.gET_DOCTORSTableAdapter.Fill(this.qLBVDataSet.GET_DOCTORS);
            // TODO: This line of code loads data into the 'qLBVDataSet.CHITIETO' table. You can move, or remove it, as needed.
            this.cHITIETOTableAdapter.Fill(this.qLBVDataSet.CHITIETO);
            // TODO: This line of code loads data into the 'qLBVDataSet.CHITIETCHUATRI' table. You can move, or remove it, as needed.
            this.cHITIETCHUATRITableAdapter.Fill(this.qLBVDataSet.CHITIETCHUATRI);
            qLBVDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'qLBVDataSet.BENHNHAN' table. You can move, or remove it, as needed.
            this.bENHNHANTableAdapter.Fill(this.qLBVDataSet.BENHNHAN);
            
            cmbType.DataSource = types;
            cmbType.ValueMember = null;

            ToggleAddReloadButtons(true);
            ToggleGroupBox(false);
            ToggleTables(true);
            ToggleUpdateDeleteButtons(bENHNHANBindingSource.Count > 0);
            ToggleWriteCancelButtons(false);


            if (bENHNHANBindingSource.Count == 0)
            {
                cmbType.SelectedIndex = 0;
                return;
            }
            cmbType.SelectedItem = ((DataRowView)bENHNHANBindingSource[bENHNHANBindingSource.Position])["LOAI"].ToString().Trim();
            txtBirthday.Properties.MaxValue = DateTime.Now;
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
            bENHNHANGridControl.Enabled = state;
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isAdding = true;
            ToggleAddReloadButtons(false);
            ToggleGroupBox(true);
            ToggleTables(false);
            ToggleUpdateDeleteButtons(false);
            ToggleWriteCancelButtons(true);
            position = bENHNHANBindingSource.Position;
            bENHNHANBindingSource.AddNew();
            txtPatientId.Focus();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cHITIETCHUATRIBindingSource.Count > 0)
            {
                MessageBox.Show("Bệnh nhân đã được chữa trị, bạn không thể xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cHITIETOBindingSource.Count > 0)
            {
                MessageBox.Show("Bệnh nhân đã ở phòng trong bệnh viện, bạn không thể xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc là muốn xóa bệnh nhân này ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    bENHNHANBindingSource.RemoveCurrent();
                    bENHNHANTableAdapter.Update(qLBVDataSet.BENHNHAN);
                    MessageBox.Show("Bệnh nhân bạn xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xảy ra trong quá trình xóa.\nVui lòng thử lại.\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ToggleUpdateDeleteButtons(bENHNHANBindingSource.Count > 0);
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = bENHNHANBindingSource.Position;
            isAdding = false;
            ToggleAddReloadButtons(false);
            ToggleGroupBox(true);
            ToggleTables(false);
            ToggleUpdateDeleteButtons(false);
            ToggleWriteCancelButtons(true);
        }

        private void btnWrite_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (txtPatientId.Text.Trim() == "")
                {
                    MessageBox.Show("Mã bệnh nhân không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPatientId.Focus();
                    return;
                }
                if (txtFirstName.Text.Trim() == "")
                {
                    MessageBox.Show("Họ bệnh nhân không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFirstName.Focus();
                    return;
                }
                if (txtLastName.Text.Trim() == "")
                {
                    MessageBox.Show("Tên bệnh nhân không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLastName.Focus();
                    return;
                }
                if (cmbType.Text.Trim() == "")
                {
                    MessageBox.Show("Loại không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbType.Focus();
                    return;
                }

                try
                {
                    //write
                    ((DataRowView)bENHNHANBindingSource[bENHNHANBindingSource.Position])["LOAI"] = cmbType.Text;
                    ((DataRowView)bENHNHANBindingSource[bENHNHANBindingSource.Position])["MABSTN"] = cmbWelcomDoctor.SelectedValue;
                    bENHNHANBindingSource.EndEdit();
                    bENHNHANBindingSource.ResetCurrentItem();
                    if (qLBVDataSet.HasChanges())
                    {
                        bENHNHANTableAdapter.Update(qLBVDataSet.BENHNHAN);
                    }
                    bENHNHANBindingSource.Position = position;
                    ToggleAddReloadButtons(true);
                    ToggleUpdateDeleteButtons(bENHNHANBindingSource.Count > 0);
                    ToggleWriteCancelButtons(false);
                    ToggleTables(true);
                    ToggleGroupBox(false);


                    if (isAdding)
                    {
                        MessageBox.Show("Thêm bệnh nhân thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật bệnh nhân thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("PK"))
                    {
                        MessageBox.Show("Mã bệnh nhân không được trùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                        MessageBox.Show("Lỗi ghi bệnh nhân. Bạn kiểm tra lại thông tin bệnh nhân trước khi ghi", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bENHNHANTableAdapter.Fill(qLBVDataSet.BENHNHAN);
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isAdding)
            {
                bENHNHANBindingSource.RemoveCurrent();
            }
            bENHNHANTableAdapter.Fill(qLBVDataSet.BENHNHAN);
            ToggleWriteCancelButtons(false);
            ToggleAddReloadButtons(true);
            ToggleGroupBox(false);
            ToggleTables(true);
            ToggleUpdateDeleteButtons(bENHNHANBindingSource.Count > 0);
        }

        private void bENHNHANGridControl_Click_1(object sender, EventArgs e)
        {
            if (bENHNHANBindingSource.Count == 0)
            {
                cmbType.SelectedIndex = 0;
                return;
            }
            cmbType.SelectedItem = ((DataRowView)bENHNHANBindingSource[bENHNHANBindingSource.Position])["LOAI"].ToString().Trim();
            if (gETDOCTORSBindingSource.Count == 0) { return; }
            cmbWelcomDoctor.SelectedValue = ((DataRowView)bENHNHANBindingSource[bENHNHANBindingSource.Position])["MABSTN"].ToString().Trim();
        }

        public void InitialSetting()
        {
            ToggleAddReloadButtons(false);
            ToggleUpdateDeleteButtons(false);
            ToggleWriteCancelButtons(false);
        }
    }
}