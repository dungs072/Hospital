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
        public frmRegisterLivingRoom()
        {
            InitializeComponent();
        }

        private void bENHNHANBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bENHNHANBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLBVDataSet);

        }

        private void frmRegisterLivingRoom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBVDataSet.BENHNHAN' table. You can move, or remove it, as needed.
            this.bENHNHANTableAdapter.Fill(this.qLBVDataSet.BENHNHAN);

        }
    }
}