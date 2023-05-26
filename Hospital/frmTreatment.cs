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
    public partial class frmTreatment : DevExpress.XtraEditors.XtraForm,IBoss
    {
        private bool isAdding = false;
        private int position = 0;
        public frmTreatment()
        {
            InitializeComponent();
        }

        private void lOAICHUATRIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOAICHUATRIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLBVDataSet);

        }

        private void frmTreatment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBVDataSet.CHITIETCHUATRI' table. You can move, or remove it, as needed.
            this.cHITIETCHUATRITableAdapter.Fill(this.qLBVDataSet.CHITIETCHUATRI);

            // TODO: This line of code loads data into the 'qLBVDataSet.LOAICHUATRI' table. You can move, or remove it, as needed.
            this.lOAICHUATRITableAdapter.Fill(this.qLBVDataSet.LOAICHUATRI);
            ToggleAddReloadButtons(true);
            ToggleGroupBox(false);
            ToggleTables(true);
            ToggleUpdateDeleteButtons(lOAICHUATRIBindingSource.Count > 0);
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
            lOAICHUATRIGridControl.Enabled = state;
        }


        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isAdding = true;
            ToggleAddReloadButtons(false);
            ToggleGroupBox(true);
            ToggleTables(false);
            ToggleUpdateDeleteButtons(false);
            ToggleWriteCancelButtons(true);
            position = lOAICHUATRIBindingSource.Position;
            lOAICHUATRIBindingSource.AddNew();
            txtTypeId.Focus();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cHITIETCHUATRIBindingSource.Count > 0)
            {
                MessageBox.Show("Loại chữa trị bạn muốn xóa đã được sử dụng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc là muốn xóa loại chữa trị này ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    lOAICHUATRIBindingSource.RemoveCurrent();
                    lOAICHUATRITableAdapter.Update(qLBVDataSet.LOAICHUATRI);
                    MessageBox.Show("Loại chữa trị bạn xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xảy ra trong quá trình xóa.\nVui lòng thử lại.\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ToggleUpdateDeleteButtons(lOAICHUATRIBindingSource.Count > 0);
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = lOAICHUATRIBindingSource.Position;
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
                if (txtTypeId.Text.Trim() == "")
                {
                    MessageBox.Show("Mã loại chữa trị không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTypeId.Focus();
                    return;
                }
                if (txtTypeName.Text.Trim() == "")
                {
                    MessageBox.Show("Tên loại chữa trị không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTypeName.Focus();
                    return;
                }
                try
                {
                    //write
                    lOAICHUATRIBindingSource.EndEdit();
                    lOAICHUATRIBindingSource.ResetCurrentItem();
                    if (qLBVDataSet.HasChanges())
                    {
                        lOAICHUATRITableAdapter.Update(qLBVDataSet.LOAICHUATRI);
                    }
                    lOAICHUATRIBindingSource.Position = position;
                    ToggleAddReloadButtons(true);
                    ToggleUpdateDeleteButtons(lOAICHUATRIBindingSource.Count > 0);
                    ToggleWriteCancelButtons(false);
                    ToggleTables(true);
                    ToggleGroupBox(false);


                    if (isAdding)
                    {
                        MessageBox.Show("Thêm loại chữa trị thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật loại chữa trị thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("MA"))
                    {
                        MessageBox.Show("Mã loại chữa trị không được trùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTypeId.Focus();
                    }
                    else if (ex.Message.Contains("TEN"))
                    {
                        MessageBox.Show("Tên loại chữa trị không được trùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTypeName.Focus();
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                        MessageBox.Show("Lỗi ghi loại chữa trị. Bạn kiểm tra lại thông tin loại chữa trị trước khi ghi", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lOAICHUATRITableAdapter.Fill(qLBVDataSet.LOAICHUATRI);
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isAdding)
            {
                lOAICHUATRIBindingSource.RemoveCurrent();

            }
            lOAICHUATRITableAdapter.Fill(qLBVDataSet.LOAICHUATRI);
            ToggleWriteCancelButtons(false);
            ToggleAddReloadButtons(true);
            ToggleGroupBox(false);
            ToggleTables(true);
            ToggleUpdateDeleteButtons(lOAICHUATRIBindingSource.Count > 0);
        }

        public void InitialSetting()
        {
            ToggleAddReloadButtons(false);
            ToggleUpdateDeleteButtons(false);
            ToggleWriteCancelButtons(false);
        }
    }
}