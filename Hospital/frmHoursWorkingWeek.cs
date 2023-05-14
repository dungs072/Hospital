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
    public partial class frmHoursWorkingWeek : DevExpress.XtraEditors.XtraForm
    {
        public frmHoursWorkingWeek()
        {
            InitializeComponent();
        }

        private void frmHoursWorkingWeek_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBVDataSet.GET_WEEK' table. You can move, or remove it, as needed.
            this.gET_WEEKTableAdapter.Fill(this.qLBVDataSet.GET_WEEK);
            // TODO: This line of code loads data into the 'qLBVDataSet.KHUCHUATRI' table. You can move, or remove it, as needed.
            this.kHUCHUATRITableAdapter.Fill(this.qLBVDataSet.KHUCHUATRI);

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (cmbArea.SelectedIndex == -1||cmbWeek.SelectedIndex==-1) { return; }
            int areaId = int.Parse(cmbArea.SelectedValue.ToString());
            int weekId = int.Parse(cmbWeek.SelectedValue.ToString());

            XrptHoursWorkingWeek rpt = new XrptHoursWorkingWeek(areaId,weekId);

            //rpt.fullName.Text = Program.mFullName;
            //rpt.className.Text = className;
            //rpt.subjectName.Text = cmbSubject.Text;
            //rpt.times.Text = "0" + txtTurn.Text;
            //rpt.testDate.Text = dateTime?.ToString("dd/MM/yyyy");
            rpt.week.Text = cmbWeek.Text;
            rpt.area.Text = cmbArea.Text;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}