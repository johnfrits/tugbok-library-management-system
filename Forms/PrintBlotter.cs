using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MPosInfoManagementSystem
{
    public partial class ExportBlotter : Form
    {

        string narrative;

        public string Narrative
        {
            get { return narrative; }
            set { narrative = value; }
        }
        public ExportBlotter()
        {
            InitializeComponent();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            ReportParameter[] parms = new ReportParameter[1];

            parms[0] = new ReportParameter("Narrative", Narrative);

            this.reportViewer1.LocalReport.SetParameters(parms);
            this.reportViewer1.RefreshReport();
        }
    }
}
