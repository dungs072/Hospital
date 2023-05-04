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
    }
}