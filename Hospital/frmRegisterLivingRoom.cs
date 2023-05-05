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
    public partial class frmRegisterLivingRoom : DevExpress.XtraEditors.XtraForm
    {
        private List<string> typeLive = new List<string>() { "Nội trú", "Ngoại trú" };
        public frmRegisterLivingRoom()
        {
            InitializeComponent();
        }


        private void frmRegisterLivingRoom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBVDataSet.GIUONG' table. You can move, or remove it, as needed.
            this.gIUONGTableAdapter.Fill(this.qLBVDataSet.GIUONG);
            // TODO: This line of code loads data into the 'qLBVDataSet.CHITIETO' table. You can move, or remove it, as needed.
            this.cHITIETOTableAdapter.Fill(this.qLBVDataSet.CHITIETO);
            // TODO: This line of code loads data into the 'qLBVDataSet.PATIENT_NOT_REGISTER_LIVING_ROOM' table. You can move, or remove it, as needed.
            this.pATIENT_NOT_REGISTER_LIVING_ROOMTableAdapter.Fill(this.qLBVDataSet.PATIENT_NOT_REGISTER_LIVING_ROOM);
            // TODO: This line of code loads data into the 'qLBVDataSet.PHONG' table. You can move, or remove it, as needed.
            this.pHONGTableAdapter.Fill(this.qLBVDataSet.PHONG);
            // TODO: This line of code loads data into the 'qLBVDataSet.KHUCHUATRI' table. You can move, or remove it, as needed.
            this.kHUCHUATRITableAdapter.Fill(this.qLBVDataSet.KHUCHUATRI);
            if (cmbRoom.SelectedValue != null)
            {
                this.sP_GET_VACANT_ROOMTableAdapter.Fill(this.qLBVDataSet.SP_GET_VACANT_ROOM, cmbRoom.SelectedValue.ToString());
            }
          

            cmbType.DataSource = typeLive;
            ToggleOnGroupBoxEnterData(false);
            UpdateDataInGroupBox();
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbType.SelectedValue.ToString()=="Nội trú")
            {
                this.pATIENT_NOT_REGISTER_LIVING_ROOMBindingSource.Filter = "LOAI = 1";
            }
            else
            {
                this.pATIENT_NOT_REGISTER_LIVING_ROOMBindingSource.Filter = "LOAI = 0";
            }
        }

        private void cmbRoom_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbRoom.Text == "")
            {
                this.sP_GET_VACANT_ROOMTableAdapter.Fill(this.qLBVDataSet.SP_GET_VACANT_ROOM, "");
            }
            if (cmbRoom.SelectedValue != null)
            {
                this.sP_GET_VACANT_ROOMTableAdapter.Fill(this.qLBVDataSet.SP_GET_VACANT_ROOM, cmbRoom.SelectedValue.ToString());
            }
        }
        private void ToggleOnGroupBoxEnterData(bool state)
        {
            grbEnterData.Enabled = state;
            
        }


        private void cmbArea3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbArea3.SelectedValue != null)
            {
                this.sP_GET_DETAIL_LIVING_ROOMTableAdapter.Fill(this.qLBVDataSet.SP_GET_DETAIL_LIVING_ROOM, int.Parse(cmbArea3.SelectedValue.ToString()));
                UpdateDataInGroupBox();
            }
        }

        private void sP_GET_DETAIL_LIVING_ROOMGridControl_Click(object sender, EventArgs e)
        {
            
            UpdateDataInGroupBox();
            
        }
        private void UpdateDataInGroupBox()
        {
            if (sP_GET_DETAIL_LIVING_ROOMBindingSource.Count == 0) 
            {
                cmbGrArea.Text = cmbArea3.Text;
                txtPatientName.Text = "";
                txtPatientId.Text = "";
                txtStartTime.Text = "";
                txtEndTime.Text = "";
                return;
            }
            cmbGrArea.Text = cmbArea3.Text;
            cmbGrRoom.Text = ((DataRowView)sP_GET_DETAIL_LIVING_ROOMBindingSource[sP_GET_DETAIL_LIVING_ROOMBindingSource.Position])[5].ToString().Trim();
            cmbBed.Text = ((DataRowView)sP_GET_DETAIL_LIVING_ROOMBindingSource[sP_GET_DETAIL_LIVING_ROOMBindingSource.Position])[2].ToString().Trim();
            txtPatientName.Text = ((DataRowView)sP_GET_DETAIL_LIVING_ROOMBindingSource[sP_GET_DETAIL_LIVING_ROOMBindingSource.Position])[1].ToString().Trim();
            txtPatientId.Text = ((DataRowView)sP_GET_DETAIL_LIVING_ROOMBindingSource[sP_GET_DETAIL_LIVING_ROOMBindingSource.Position])[0].ToString().Trim();
            txtStartTime.Text = ((DataRowView)sP_GET_DETAIL_LIVING_ROOMBindingSource[sP_GET_DETAIL_LIVING_ROOMBindingSource.Position])[3].ToString().Trim();
            txtEndTime.Text = ((DataRowView)sP_GET_DETAIL_LIVING_ROOMBindingSource[sP_GET_DETAIL_LIVING_ROOMBindingSource.Position])[4].ToString().Trim();
        }
    }
}