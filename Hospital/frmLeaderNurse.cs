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
    public partial class frmLeaderNurse : DevExpress.XtraEditors.XtraForm,IBoss
    {
        public frmLeaderNurse()
        {
            InitializeComponent();
        }

        private void frmLeaderNurse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBVDataSet.GET_NURSE_NOT_LEADER' table. You can move, or remove it, as needed.
            this.gET_NURSE_NOT_LEADERTableAdapter.Fill(this.qLBVDataSet.GET_NURSE_NOT_LEADER);
            // TODO: This line of code loads data into the 'qLBVDataSet.GET_NURSE_NOT_LEADER' table. You can move, or remove it, as needed.
            this.gET_NURSE_NOT_LEADERTableAdapter.Fill(this.qLBVDataSet.GET_NURSE_NOT_LEADER);
            // TODO: This line of code loads data into the 'qLBVDataSet.GET_CURE_AREA' table. You can move, or remove it, as needed.
            this.gET_CURE_AREATableAdapter.Fill(this.qLBVDataSet.GET_CURE_AREA);
            HandleClickCureArea();
            ToggleReloadButton(true);
            groupBox1.Enabled = false;
        }

        private void ToggleRegister(bool state)
        {
            btnRegister.Enabled = state;
        }
        private void ToggleCancelRegister(bool state)
        {
            btnCancelRegister.Enabled = state;
        }
        private void ToggleReloadButton(bool state)
        {
            btnReload.Enabled = state;
        }
       

        private void gET_CURE_AREAGridControl_Click(object sender, EventArgs e)
        {
            HandleClickCureArea();
           

        }
        private void HandleClickCureArea()
        {
            if (gET_CURE_AREABindingSource.Count == 0) { return; }
            string data = ((DataRowView)gET_CURE_AREABindingSource[gET_CURE_AREABindingSource.Position])["TENYT"].ToString().Trim();
            if (Program.mGroup != "Boss")
            {
                ToggleCancelRegister(data != "");
                ToggleRegister(data == "");
            }
           
            txtAreaId.Text = ((DataRowView)gET_CURE_AREABindingSource[gET_CURE_AREABindingSource.Position])[0].ToString().Trim();
            txtAreaName.Text = ((DataRowView)gET_CURE_AREABindingSource[gET_CURE_AREABindingSource.Position])[1].ToString().Trim();
            txtNurse.Text = data;
        }

        private void btnRegister_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
            string nurseId = ((DataRowView)gET_NURSE_NOT_LEADERBindingSource[gET_NURSE_NOT_LEADERBindingSource.Position])[0].ToString().Trim();
            if (Program.Connect() == 0) { return; }
            string cmd = string.Format("UPDATE KHUCHUATRI SET MAYT = '{0}' WHERE DANHDINHKHU = {1}", nurseId, txtAreaId.Text);
            int result = Program.ExecSqlNonQuery(cmd);
            if (result == 0)
            {
                Reload();
                MessageBox.Show("Đăng kí thành công y tá trưởng cho khu " + txtAreaName.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Không thể đăng kí y tá trưởng cho khu " + txtAreaName.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnCancelRegister_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult resultt = MessageBox.Show("Bạn có chắc muốn hủy đăng kí y tá trưởng cho khu này không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (resultt == DialogResult.OK)
            {
                if (Program.Connect() == 0) { return; }
                string cmd = string.Format("UPDATE KHUCHUATRI SET MAYT = NULL WHERE DANHDINHKHU = {0}", txtAreaId.Text);
                int result = Program.ExecSqlNonQuery(cmd);
                if (result == 0)
                {
                    Reload();
                    MessageBox.Show("Hủy đăng kí thành công y tá trưởng cho khu " + txtAreaName.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                }
                else
                {
                    MessageBox.Show("Không thể hủy đăng kí y tá trưởng cho khu " + txtAreaName.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
         
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Reload();
        }
        private void Reload()
        {
            gET_CURE_AREATableAdapter.Fill(qLBVDataSet.GET_CURE_AREA);
            gET_NURSE_NOT_LEADERTableAdapter.Fill(qLBVDataSet.GET_NURSE_NOT_LEADER);
        }

        public void InitialSetting()
        {
            ToggleRegister(false);
            ToggleCancelRegister(false);
            ToggleReloadButton(false);
        }
    }
}