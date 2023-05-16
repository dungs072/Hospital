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
    public partial class frmWeek : DevExpress.XtraEditors.XtraForm
    {
        private bool isAdding = false;
        private int position = 0;
        public frmWeek()
        {
            InitializeComponent();
        }

        private void frmWeek_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBVDataSet.CHITIETGIOLAMVIEC' table. You can move, or remove it, as needed.
            this.cHITIETGIOLAMVIECTableAdapter.Fill(this.qLBVDataSet.CHITIETGIOLAMVIEC);
            qLBVDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'qLBVDataSet.TUAN' table. You can move, or remove it, as needed.
            this.tUANTableAdapter.Fill(this.qLBVDataSet.TUAN);
            ToggleAddReloadButtons(true);
            ToggleGroupBox(false);
            ToggleTables(true);
            ToggleUpdateDeleteButtons(tUANBindingSource.Count > 0);
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
            tUANGridControl.Enabled = state;
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isAdding = true;
            ToggleAddReloadButtons(false);
            ToggleGroupBox(true);
            ToggleTables(false);
            ToggleUpdateDeleteButtons(false);
            ToggleWriteCancelButtons(true);
            position = tUANBindingSource.Position;
            tUANBindingSource.AddNew();
            txtNumberWeek.Focus();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cHITIETGIOLAMVIECBindingSource.Count > 0)
            {
                MessageBox.Show("Tuần bạn muốn xóa đã có nhân viên ghi thời gian làm việc", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc là muốn xóa tuần này ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    tUANBindingSource.RemoveCurrent();
                    tUANTableAdapter.Update(qLBVDataSet.TUAN);
                    MessageBox.Show("Tuần bạn xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xảy ra trong quá trình xóa.\nVui lòng thử lại.\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ToggleUpdateDeleteButtons(tUANBindingSource.Count > 0);
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = tUANBindingSource.Position;
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
                if (txtNumberWeek.Text.Trim() == "")
                {
                    MessageBox.Show("Tuần số không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNumberWeek.Focus();
                    return;
                }
                if (txtStartDate.Text.Trim() == "")
                {
                    MessageBox.Show("Ngày bắt đầu không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtStartDate.Focus();
                    return;
                }
                if (txtEndDate.Text.Trim() == "")
                {
                    MessageBox.Show("Ngày kết thúc không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEndDate.Focus();
                    return;
                }

                try
                {
                    //write
                    tUANBindingSource.EndEdit();
                    tUANBindingSource.ResetCurrentItem();
                    if (qLBVDataSet.HasChanges())
                    {
                        tUANTableAdapter.Update(qLBVDataSet.TUAN);
                    }
                    tUANBindingSource.Position = position;
                    ToggleAddReloadButtons(true);
                    ToggleUpdateDeleteButtons(tUANBindingSource.Count > 0);
                    ToggleWriteCancelButtons(false);
                    ToggleTables(true);
                    ToggleGroupBox(false);


                    if (isAdding)
                    {
                        MessageBox.Show("Thêm tuần thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật tuần thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                 
                    if (ex.Message.Contains("unique"))
                    {
                        MessageBox.Show("Tuần số không được trùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNumberWeek.Focus();
                    }
                    else if (ex.Message.Contains("CK"))
                    {
                        MessageBox.Show("Ngày bắt đầu trong tuần phải bé hơn ngày kết thúc trong tuần", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                        MessageBox.Show("Lỗi ghi tuần. Bạn kiểm tra lại thông tin tuần trước khi ghi", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tUANTableAdapter.Fill(qLBVDataSet.TUAN);
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isAdding)
            {
                tUANBindingSource.RemoveCurrent();

            }
            tUANTableAdapter.Fill(qLBVDataSet.TUAN);
            ToggleWriteCancelButtons(false);
            ToggleAddReloadButtons(true);
            ToggleGroupBox(false);
            ToggleTables(true);
            ToggleUpdateDeleteButtons(tUANBindingSource.Count > 0);
        }
    }
}