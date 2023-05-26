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
    public partial class frmRoomAndArea : DevExpress.XtraEditors.XtraForm,IBoss
    {
        private bool isAddingArea = false;
        private bool isAddingRoom = false;
        private bool isHandleInAreaInput = false;
        private bool isHandleInRoomInput = false;
        private int areaPosition = 0;
        private int roomPosition = 0;
        public frmRoomAndArea()
        {
            InitializeComponent();
        }


        private void frmRoomAndArea_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBVDataSet.GIUONG' table. You can move, or remove it, as needed.
            this.gIUONGTableAdapter.Fill(this.qLBVDataSet.GIUONG);
            // TODO: This line of code loads data into the 'qLBVDataSet.CHITIETLAMVIECKHUCHUATRI' table. You can move, or remove it, as needed.
            this.cHITIETLAMVIECKHUCHUATRITableAdapter.Fill(this.qLBVDataSet.CHITIETLAMVIECKHUCHUATRI);
            // TODO: This line of code loads data into the 'qLBVDataSet.CHITIETLAMVIECKHUCHUATRI' table. You can move, or remove it, as needed.
            this.cHITIETLAMVIECKHUCHUATRITableAdapter.Fill(this.qLBVDataSet.CHITIETLAMVIECKHUCHUATRI);
            // TODO: This line of code loads data into the 'qLBVDataSet.PHONG' table. You can move, or remove it, as needed.
            this.pHONGTableAdapter.Fill(this.qLBVDataSet.PHONG);
            // TODO: This line of code loads data into the 'qLBVDataSet.KHUCHUATRI' table. You can move, or remove it, as needed.
            this.kHUCHUATRITableAdapter.Fill(this.qLBVDataSet.KHUCHUATRI);

            ToggleAddReloadButtons(true);
            ToggleAddRoomButtons(true);
            ToggleUpdateDeleteButtons(kHUCHUATRIBindingSource.Count > 0);
            ToggleUpdateDeleteRoomButtons(pHONGBindingSource.Count > 0);
            ToggleWriteCancelButtons(false);
            ToggleWriteCancelRoomButtons(false);
            ToggleTables(true);
            ToggleGroupBox(false);

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
            kHUCHUATRIGridControl.Enabled = state;
            pHONGGridControl.Enabled = state;
        }
        private void ToggleAddRoomButtons(bool state)
        {
            btnAddRoom.Enabled = state;
        }
        private void ToggleUpdateDeleteRoomButtons(bool state)
        {
            btnUpdateRoom.Enabled = btnDeleteRoom.Enabled = state;
        }
        private void ToggleWriteCancelRoomButtons(bool state)
        {
            btnWriteRoom.Enabled = btnCancelRoom.Enabled = state;
        }

        private void ToggleAreaInputText(bool isInArea)
        {
            txtAreaName.Enabled = isInArea;
            isHandleInAreaInput = isInArea;
            txtRoomId.Enabled = !isInArea;
            txtRoomNumber.Enabled = !isInArea;
        }
        private void ToggleAllInput(bool state)
        {
            txtAreaName.Enabled = state;
            isHandleInAreaInput = state;
            txtRoomId.Enabled = state;
            txtRoomNumber.Enabled = state;
        }
        private void ToggleAreaButtonFuction(bool state)
        {
            if (state)
            {
                ToggleAddReloadButtons(false);
                ToggleUpdateDeleteButtons(false);
                ToggleWriteCancelButtons(false);
            }
            else
            {
                ToggleAddReloadButtons(true);
                ToggleWriteCancelButtons(false);
                ToggleUpdateDeleteButtons(kHUCHUATRIBindingSource.Count > 0);
            }
        }

        #region Area
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isAddingArea = true;
            //area
            ToggleAddReloadButtons(false);
            ToggleGroupBox(true);
            ToggleTables(false);
            ToggleUpdateDeleteButtons(false);
            ToggleWriteCancelButtons(true);
            ToggleAreaInputText(true);
            areaPosition = kHUCHUATRIBindingSource.Position;
            kHUCHUATRIBindingSource.AddNew();
            txtAreaName.Focus();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cHITIETLAMVIECKHUCHUATRIBindingSource.Count > 0)
            {
                MessageBox.Show("Khu bạn muốn xóa đã có nhân viên đăng kí làm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc là muốn xóa khu này ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    kHUCHUATRIBindingSource.RemoveCurrent();
                    kHUCHUATRITableAdapter.Update(qLBVDataSet.KHUCHUATRI);
                    MessageBox.Show("Khu bạn xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xảy ra trong quá trình xóa.\nVui lòng thử lại.\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ToggleUpdateDeleteButtons(kHUCHUATRIBindingSource.Count > 0);
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            areaPosition = kHUCHUATRIBindingSource.Position;
            isAddingArea = false;
            ToggleAddReloadButtons(false);
            ToggleGroupBox(true);
            ToggleTables(false);
            ToggleUpdateDeleteButtons(false);
            ToggleWriteCancelButtons(true);
            ToggleAreaInputText(true);
        }

        private void btnWrite_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (txtAreaName.Text.Trim() == "")
                {
                    MessageBox.Show("Tên khu không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAreaName.Focus();
                    return;
                }

                try
                {
                    //write
                    kHUCHUATRIBindingSource.EndEdit();
                    kHUCHUATRIBindingSource.ResetCurrentItem();
                    if (qLBVDataSet.HasChanges())
                    {
                        kHUCHUATRITableAdapter.Update(qLBVDataSet.KHUCHUATRI);
                    }
                    kHUCHUATRIBindingSource.Position = areaPosition;
                    ToggleAddReloadButtons(true);
                    ToggleUpdateDeleteButtons(kHUCHUATRIBindingSource.Count > 0);
                    ToggleWriteCancelButtons(false);
                    ToggleTables(true);
                    ToggleGroupBox(false);
                    isHandleInAreaInput = false;

                    if (isAddingArea)
                    {
                        MessageBox.Show("Thêm khu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật khu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("UK"))
                    {
                        MessageBox.Show("Tên khu không được trùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtAreaName.Focus();
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                        MessageBox.Show("Lỗi ghi khu. Bạn kiểm tra lại thông tin khu trước khi ghi", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isAddingArea)
            {
                kHUCHUATRIBindingSource.RemoveCurrent();
            }
            kHUCHUATRITableAdapter.Fill(qLBVDataSet.KHUCHUATRI);
            ToggleWriteCancelButtons(false);
            ToggleAddReloadButtons(true);
            ToggleGroupBox(false);
            ToggleTables(true);
            ToggleUpdateDeleteButtons(kHUCHUATRIBindingSource.Count > 0);
            ToggleAllInput(true);
            isHandleInAreaInput = false;
            isHandleInRoomInput = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            kHUCHUATRITableAdapter.Fill(qLBVDataSet.KHUCHUATRI);
            pHONGTableAdapter.Fill(qLBVDataSet.PHONG);
        }
        #endregion

        #region Room
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            isAddingRoom = true;
            ToggleAddRoomButtons(false);
            ToggleGroupBox(true);
            ToggleTables(false);
            roomPosition = pHONGBindingSource.Position;
            pHONGBindingSource.AddNew();
            txtRoomId.Focus();
            ToggleAreaInputText(false);
            isHandleInRoomInput = true;
            ToggleAreaButtonFuction(true);
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            if (gIUONGBindingSource.Count > 0)
            {
                MessageBox.Show("Phòng bạn muốn xóa đã có giường", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc là muốn xóa phòng này ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    pHONGBindingSource.RemoveCurrent();
                    pHONGTableAdapter.Update(qLBVDataSet.PHONG);
                    MessageBox.Show("Phòng bạn xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xảy ra trong quá trình xóa.\nVui lòng thử lại.\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            roomPosition = pHONGBindingSource.Position;
            isAddingRoom = false;
            ToggleGroupBox(true);
            ToggleTables(false);
            ToggleAreaInputText(false);
            isHandleInRoomInput = true;
            ToggleAreaButtonFuction(true);
        }

        private void btnWriteRoom_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (txtRoomId.Text.Trim() == "")
                {
                    MessageBox.Show("Mã phòng không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRoomId.Focus();
                    return;
                }
                if (txtRoomNumber.Text.Trim() == "")
                {
                    MessageBox.Show("Số phòng không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRoomNumber.Focus();
                    return;
                }
                try
                {
                    //write
                    pHONGBindingSource.EndEdit();
                    pHONGBindingSource.ResetCurrentItem();
                    if (qLBVDataSet.HasChanges())
                    {
                        pHONGTableAdapter.Update(qLBVDataSet.PHONG);
                    }
                    pHONGBindingSource.Position = roomPosition;
                    ToggleTables(true);
                    ToggleGroupBox(false);
                    isHandleInRoomInput = false;

                    if (isAddingRoom)
                    {
                        MessageBox.Show("Thêm phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ToggleAreaButtonFuction(false);

                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("MAPHONG"))
                    {
                        MessageBox.Show("Mã phòng không được trùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtRoomId.Focus();
                    }
                    else if (ex.Message.Contains("UK"))
                    {
                        MessageBox.Show("Số phòng của khu này không được trùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtRoomNumber.Focus();
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                        MessageBox.Show("Lỗi ghi phòng. Bạn kiểm tra lại thông tin phòng trước khi ghi", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void btnCancelRoom_Click(object sender, EventArgs e)
        {
            isHandleInRoomInput = false;
            if (isAddingRoom)
            {
                pHONGBindingSource.RemoveCurrent();
            }
            pHONGTableAdapter.Fill(qLBVDataSet.PHONG);
            ToggleGroupBox(false);
            ToggleTables(true);
            ToggleAllInput(true);
            isHandleInAreaInput = false;
            isHandleInRoomInput = false;
            ToggleAreaButtonFuction(false);
        }
        #endregion

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (isHandleInAreaInput)
            {
                btnAddRoom.Enabled = btnDeleteRoom.Enabled = btnCancelRoom.Enabled = btnUpdateRoom.Enabled = btnWriteRoom.Enabled = false;
                return;
            }
            
            if (isHandleInRoomInput)
            {
                btnAddRoom.Enabled = false;
                ToggleUpdateDeleteRoomButtons(false);
                ToggleWriteCancelRoomButtons(true);
            }
            else
            {
                btnAddRoom.Enabled = true;
                ToggleUpdateDeleteRoomButtons(pHONGBindingSource.Count > 0);
                ToggleWriteCancelRoomButtons(false);
            }
           

        }

        public void InitialSetting()
        {
            ToggleAddReloadButtons(false);
            isHandleInAreaInput = true;
            ToggleUpdateDeleteButtons(false);
            ToggleWriteCancelButtons(false);
        }
    }
}