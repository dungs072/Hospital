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
    public partial class frmEquipment : DevExpress.XtraEditors.XtraForm,IBoss
    {
        private bool isAdding = false;
        private int position = 0;
        public frmEquipment()
        {
            InitializeComponent();
        }

        private void frmEquipment_Load(object sender, EventArgs e)
        {
            qLBVDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'qLBVDataSet.CHITIETSUDUNGVT' table. You can move, or remove it, as needed.
            this.cHITIETSUDUNGVTTableAdapter.Fill(this.qLBVDataSet.CHITIETSUDUNGVT);
            // TODO: This line of code loads data into the 'qLBVDataSet.VATTU' table. You can move, or remove it, as needed.
            this.vATTUTableAdapter.Fill(this.qLBVDataSet.VATTU);
            ToggleAddReloadButtons(true);
            ToggleGroupBox(false);
            ToggleTables(true);
            ToggleUpdateDeleteButtons(vATTUBindingSource.Count > 0);
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
            vATTUGridControl.Enabled = state;
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isAdding = true;
            ToggleAddReloadButtons(false);
            ToggleGroupBox(true);
            ToggleTables(false);
            ToggleUpdateDeleteButtons(false);
            ToggleWriteCancelButtons(true);
            position = vATTUBindingSource.Position;
            vATTUBindingSource.AddNew();
            txtEquipmentId.Focus();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cHITIETSUDUNGVTBindingSource.Count > 0)
            {
                MessageBox.Show("Vật tư bạn muốn xóa đã được sử dụng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc là muốn xóa vật tư này ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    vATTUBindingSource.RemoveCurrent();
                    vATTUTableAdapter.Update(qLBVDataSet.VATTU);
                    MessageBox.Show("Vật tư bạn xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xảy ra trong quá trình xóa.\nVui lòng thử lại.\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ToggleUpdateDeleteButtons(vATTUBindingSource.Count > 0);
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = vATTUBindingSource.Position;
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
                if (txtEquipmentId.Text.Trim() == "")
                {
                    MessageBox.Show("Mã vật tư không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEquipmentId.Focus();
                    return;
                }
                if (txtEquipmentName.Text.Trim() == "")
                {
                    MessageBox.Show("Tên vật tư không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEquipmentName.Focus();
                    return;
                }
                if (txtPrice.Text.Trim() == "")
                {
                    MessageBox.Show("Giá không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrice.Focus();
                    return;
                }

                try
                {
                    //write
                    vATTUBindingSource.EndEdit();
                    vATTUBindingSource.ResetCurrentItem();
                    if (qLBVDataSet.HasChanges())
                    {
                        vATTUTableAdapter.Update(qLBVDataSet.VATTU);
                    }
                    vATTUBindingSource.Position = position;
                    ToggleAddReloadButtons(true);
                    ToggleUpdateDeleteButtons(vATTUBindingSource.Count > 0);
                    ToggleWriteCancelButtons(false);
                    ToggleTables(true);
                    ToggleGroupBox(false);


                    if (isAdding)
                    {
                        MessageBox.Show("Thêm vật tư thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật vật tư thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("PK"))
                    {
                        MessageBox.Show("Mã vật tư không được trùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEquipmentId.Focus();
                    }
                    else if (ex.Message.Contains("unique"))
                    {
                        MessageBox.Show("Tên vật tư không được trùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEquipmentName.Focus();
                    }
                    else if (ex.Message.Contains("CK"))
                    {
                        MessageBox.Show("Giá vật tư phải lớn hơn 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                        MessageBox.Show("Lỗi ghi vật tư. Bạn kiểm tra lại thông tin vật tư trước khi ghi", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vATTUTableAdapter.Fill(qLBVDataSet.VATTU);
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isAdding)
            {
                vATTUBindingSource.RemoveCurrent();

            }
            vATTUTableAdapter.Fill(qLBVDataSet.VATTU);
            ToggleWriteCancelButtons(false);
            ToggleAddReloadButtons(true);
            ToggleGroupBox(false);
            ToggleTables(true);
            ToggleUpdateDeleteButtons(vATTUBindingSource.Count > 0);
        }

        public void InitialSetting()
        {
            ToggleAddReloadButtons(false);
            ToggleUpdateDeleteButtons(false);
            ToggleWriteCancelButtons(false);
        }
    }
}