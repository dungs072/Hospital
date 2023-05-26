using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
    public partial class frmUsingEquipment : DevExpress.XtraEditors.XtraForm
    {
        public frmUsingEquipment()
        {
            InitializeComponent();
        }


        private void frmUsingEquipment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBVDataSet.GET_ALL_PATIENT' table. You can move, or remove it, as needed.
            this.gET_ALL_PATIENTTableAdapter.Fill(this.qLBVDataSet.GET_ALL_PATIENT);
           

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (gET_ALL_PATIENTBindingSource.Count == 0) { return; }
            string id = ((DataRowView)gET_ALL_PATIENTBindingSource[gET_ALL_PATIENTBindingSource.Position])[0].ToString().Trim();
            string fullName = ((DataRowView)gET_ALL_PATIENTBindingSource[gET_ALL_PATIENTBindingSource.Position])[1].ToString().Trim()+" "+ ((DataRowView)gET_ALL_PATIENTBindingSource[gET_ALL_PATIENTBindingSource.Position])[2].ToString().Trim();

            XrptUsingEquipment rpt = new XrptUsingEquipment(id);
            rpt.fullName.Text = fullName;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

    }
}