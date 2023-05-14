using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace Hospital
{
    public partial class XrptHoursWorkingWeek : DevExpress.XtraReports.UI.XtraReport
    {
        public XrptHoursWorkingWeek(int areaId, int weekId)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = areaId;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = weekId;
            this.sqlDataSource1.Fill();
        }

    }
}
