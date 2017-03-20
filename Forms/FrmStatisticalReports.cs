using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MPosInfoManagementSystem
{
    public partial class FrmStatisticalReports : MetroForm
    {
        SelectDeleteFunctions SF = new SelectDeleteFunctions();
        public FrmStatisticalReports()
        {
            InitializeComponent();
        }

        private void FrmStatisticalReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mPosDBDataSet.View1' table. You can move, or remove it, as needed.
            this.view1TableAdapter.Fill(this.mPosDBDataSet.View1);
            // TODO: This line of code loads data into the 'mPosDBDataSet2.View_2' table. You can move, or remove it, as needed.
            this.view_2TableAdapter.Fill(this.mPosDBDataSet2.View_2);
        
            metroTextBoxd.Text = SF.CountDetainee();
            metroTextBoxs.Text = SF.CountSuspect();
            metroTextBoxrd.Text = SF.CountReleasedDetainee();

            // TODO: This line of code loads data into the 'mPosDBDataSet1.View1' table. You can move, or remove it, as needed

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            chart1.Visible = true;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            chart2.Visible = true;
        }
    }
}
