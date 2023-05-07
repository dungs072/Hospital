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
    public partial class frmEquipmentDetail : DevExpress.XtraEditors.XtraForm
    {
        private bool isAdding = false;
        public frmEquipmentDetail()
        {
            InitializeComponent();
        }

        private void frmEquipmentDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBVDataSet.VATTU' table. You can move, or remove it, as needed.
            this.vATTUTableAdapter.Fill(this.qLBVDataSet.VATTU);
            // TODO: This line of code loads data into the 'qLBVDataSet.LOAICHUATRI' table. You can move, or remove it, as needed.
            this.lOAICHUATRITableAdapter.Fill(this.qLBVDataSet.LOAICHUATRI);
            // TODO: This line of code loads data into the 'qLBVDataSet.GET_ALL_DETAIL_CURE' table. You can move, or remove it, as needed.
            this.gET_ALL_DETAIL_CURETableAdapter.Fill(this.qLBVDataSet.GET_ALL_DETAIL_CURE);

            HandleCureDetailClick();
            HandleEquipmentDetailClick();
            ToggleAddReloadButtons(true);
            ToggleWriteCancelButtons(false);
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
            gET_ALL_DETAIL_CUREGridControl.Enabled = state;
            vATTUGridControl.Enabled = state;
            gET_MEDICINE_EQUIPMENT_DETAILGridControl.Enabled = state;
        }
        private void HandleCureDetailClick()
        {
            if (gET_ALL_DETAIL_CUREBindingSource.Count == 0)
            {
                gET_MEDICINE_EQUIPMENT_DETAILTableAdapter.Fill(qLBVDataSet.GET_MEDICINE_EQUIPMENT_DETAIL, -1);
            }
            else
            {
                int id = int.Parse(((DataRowView)gET_ALL_DETAIL_CUREBindingSource[gET_ALL_DETAIL_CUREBindingSource.Position])[8].ToString().Trim());
                gET_MEDICINE_EQUIPMENT_DETAILTableAdapter.Fill(qLBVDataSet.GET_MEDICINE_EQUIPMENT_DETAIL, id);
            }
        }
        private void HandleEquipmentDetailClick()
        {
            if (gET_MEDICINE_EQUIPMENT_DETAILBindingSource.Count == 0)
            {
                txtCureId.Text = "";
                txtEquipmentId.Text = "";
                txtAmount.Text = "";
                txtEquipmentName.Text = "";
                ToggleUpdateDeleteButtons(false);
            }
            else
            {
                txtCureId.Text = ((DataRowView)gET_MEDICINE_EQUIPMENT_DETAILBindingSource[gET_MEDICINE_EQUIPMENT_DETAILBindingSource.Position])[0].ToString().Trim();
                txtEquipmentId.Text = ((DataRowView)gET_MEDICINE_EQUIPMENT_DETAILBindingSource[gET_MEDICINE_EQUIPMENT_DETAILBindingSource.Position])[1].ToString().Trim();
                txtEquipmentName.Text = ((DataRowView)gET_MEDICINE_EQUIPMENT_DETAILBindingSource[gET_MEDICINE_EQUIPMENT_DETAILBindingSource.Position])[2].ToString().Trim();
                txtAmount.Text = ((DataRowView)gET_MEDICINE_EQUIPMENT_DETAILBindingSource[gET_MEDICINE_EQUIPMENT_DETAILBindingSource.Position])[3].ToString().Trim();
                ToggleUpdateDeleteButtons(true);
            }
        }

        private void gET_ALL_DETAIL_CUREGridControl_Click(object sender, EventArgs e)
        {
            HandleCureDetailClick();
            HandleEquipmentDetailClick();
        }

        private void gET_MEDICINE_EQUIPMENT_DETAILGridControl_Click(object sender, EventArgs e)
        {
            HandleEquipmentDetailClick();
        }
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gET_ALL_DETAIL_CUREBindingSource.Position < 0)
            {
                MessageBox.Show("Bạn chưa chọn chi tiết chữa trị để chọn vật tư", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (vATTUBindingSource.Position < 0)
            {
                MessageBox.Show("Bạn chưa chọn vật tư nào cả", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            isAdding = true;
            ToggleAddReloadButtons(false);
            ToggleUpdateDeleteButtons(false);
            ToggleWriteCancelButtons(true);
            ToggleTables(false);
            ToggleGroupBox(true);
            txtCureId.Text = ((DataRowView)gET_ALL_DETAIL_CUREBindingSource[gET_ALL_DETAIL_CUREBindingSource.Position])[8].ToString().Trim();
            txtEquipmentId.Text = ((DataRowView)vATTUBindingSource[vATTUBindingSource.Position])[0].ToString().Trim();
            txtAmount.Value = 1;
            txtEquipmentName.Text = ((DataRowView)vATTUBindingSource[vATTUBindingSource.Position])[1].ToString().Trim();

        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isAdding = false;
            ToggleAddReloadButtons(false);
            ToggleUpdateDeleteButtons(false);
            ToggleWriteCancelButtons(true);
            ToggleTables(false);
            ToggleGroupBox(true);
            txtCureId.Text = ((DataRowView)gET_MEDICINE_EQUIPMENT_DETAILBindingSource[gET_MEDICINE_EQUIPMENT_DETAILBindingSource.Position])[0].ToString().Trim();
            txtEquipmentId.Text = ((DataRowView)gET_MEDICINE_EQUIPMENT_DETAILBindingSource[gET_MEDICINE_EQUIPMENT_DETAILBindingSource.Position])[1].ToString().Trim();
            txtEquipmentName.Text = ((DataRowView)gET_MEDICINE_EQUIPMENT_DETAILBindingSource[gET_MEDICINE_EQUIPMENT_DETAILBindingSource.Position])[2].ToString().Trim();
            txtAmount.Text = ((DataRowView)gET_MEDICINE_EQUIPMENT_DETAILBindingSource[gET_MEDICINE_EQUIPMENT_DETAILBindingSource.Position])[3].ToString().Trim();
            
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc là muốn xóa đơn sử dụng vật tư này không ?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                if (Program.Connect() == 0) { return; }
                string cmd = string.Format("DELETE CHITIETSUDUNGVT WHERE ID_CTCT = {0} AND MAVT = '{1}'", int.Parse(txtCureId.Text), txtEquipmentId.Text);
                int tResult = Program.ExecSqlNonQuery(cmd);
                if (tResult == 0)
                {
                    gET_MEDICINE_EQUIPMENT_DETAILTableAdapter.Fill(qLBVDataSet.GET_MEDICINE_EQUIPMENT_DETAIL, int.Parse(txtCureId.Text));
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Xóa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnWrite_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtAmount.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string cmd = string.Format("EXEC MERGE_EQUIPMENT_DETAIL {0},'{1}',{2},{3}", txtCureId.Text, txtEquipmentId.Text, int.Parse(txtAmount.Value.ToString()),!isAdding);
            if (Program.Connect() == 0) { return; }
            int result = Program.ExecSqlNonQuery(cmd);
            if (result == 0)
            {
                ToggleAddReloadButtons(true);
                ToggleUpdateDeleteButtons(gET_MEDICINE_EQUIPMENT_DETAILBindingSource.Count>0);
                ToggleWriteCancelButtons(false);
                ToggleTables(true);
                ToggleGroupBox(false);
                gET_MEDICINE_EQUIPMENT_DETAILTableAdapter.Fill(qLBVDataSet.GET_MEDICINE_EQUIPMENT_DETAIL, int.Parse(txtCureId.Text));
                MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ToggleAddReloadButtons(true);
            ToggleUpdateDeleteButtons(gET_MEDICINE_EQUIPMENT_DETAILBindingSource.Count>0);
            ToggleWriteCancelButtons(false);
            ToggleTables(true);
            ToggleGroupBox(false);
            HandleEquipmentDetailClick();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gET_ALL_DETAIL_CURETableAdapter.Fill(qLBVDataSet.GET_ALL_DETAIL_CURE);
            vATTUTableAdapter.Fill(qLBVDataSet.VATTU);
            HandleCureDetailClick();
            HandleEquipmentDetailClick();
        }
    }
}