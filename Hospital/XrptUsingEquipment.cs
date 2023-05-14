using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace Hospital
{
    public partial class XrptUsingEquipment : DevExpress.XtraReports.UI.XtraReport
    {
        public XrptUsingEquipment(string patientId)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = patientId;
            this.sqlDataSource1.Fill();
        }

    }
}
