using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace MPosInfoManagementSystem
{
    public partial class PrintForm : Form
    {
        public PrintForm()
        {
            InitializeComponent();
        }

        string reportingPersonName;

        public string ReportingPersonName
        {
            get { return reportingPersonName; }
            set { reportingPersonName = value; }
        }
        string personnelName;

        public string PersonnelName
        {
            get { return personnelName; }
            set { personnelName = value; }
        }
        string addressRepPerName;

        public string AddressRepPerName
        {
            get { return addressRepPerName; }
            set { addressRepPerName = value; }
        }
        string entryBlotterNumber;

        public string EntryBlotterNumber
        {
            get { return entryBlotterNumber; }
            set { entryBlotterNumber = value; }
        }
        string IDP;

        public string IDP1
        {
            get { return IDP; }
            set { IDP = value; }
        }
        //string 
        private void PrintForm_Load(object sender, EventArgs e)
        {

            ReportParameter[] parms = new ReportParameter[6];

            parms[0] = new ReportParameter("ReportingPersonName",ReportingPersonName);
            parms[1] = new ReportParameter("PersonnelName", PersonnelName);
            parms[2] = new ReportParameter("AddressReportingPerson", AddressRepPerName);
            parms[3] = new ReportParameter("EntryBlotterNumber", EntryBlotterNumber);
            parms[4] = new ReportParameter("IDP", IDP1);
            parms[5] = new ReportParameter("TimeDate", DateTime.Now.ToString());
            
            this.reportViewer1.LocalReport.SetParameters(parms);

            this.reportViewer1.RefreshReport();
        }
    }
}
