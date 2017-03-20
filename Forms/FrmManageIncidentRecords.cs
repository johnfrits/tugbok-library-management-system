using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using MetroFramework;
namespace MPosInfoManagementSystem
{
    public partial class FrmManageIncidentRecord : MetroForm
    {
        SelectDeleteFunctions SF = new SelectDeleteFunctions();
        public FrmManageIncidentRecord()
        {
            InitializeComponent();
        }

        string personnelID;

        public string PersonnelID
        {
            get { return personnelID; }
            set { personnelID = value; }
        }
        private string personnelName;

        public string PersonnelName
        {
            get { return personnelName; }
            set { personnelName = value; }
        }

        private void FrmManageIncidentRecord_Load(object sender, EventArgs e)
        {
            this.Location = new Point(230, 80);

            metroGridIncident.DataSource = SF.GetAllIncidents();
            metroGridIncident.Refresh();
            metroGridIncident.Update();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            FrmAddIncidentRecord frmIR = new FrmAddIncidentRecord();
            frmIR.PersonnelID = PersonnelID;
            frmIR.PersonnelName = PersonnelName;
            frmIR.ShowDialog();
        }

        private void metroButtonRefresh_Click(object sender, EventArgs e)
        {
            this.Refresh();

            metroGridIncident.DataSource = SF.GetAllIncidents();
            metroGridIncident.Refresh();
            metroGridIncident.Update();
        }

        private void buttonSearchRecNo_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroTextBoxSearchWord.Text.Length > 0)
                {
                    string column = metroComboBoxSby.SelectedIndex == 0 ? "EntryNumber" : "TypeofIncident";
                    int rowIndex = -1;
                    DataGridViewRow row = metroGridIncident.Rows
                        .Cast<DataGridViewRow>()
                        .Where(r => r.Cells[column].Value.ToString().Contains(metroTextBoxSearchWord.Text))
                        .First();

                    rowIndex = row.Index;
                    metroGridIncident.ClearSelection();
                    metroGridIncident.Rows[rowIndex].Selected = true;
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void metroGridIncident_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmViewIncidentRecord fvir = new FrmViewIncidentRecord();

            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.metroGridIncident.Rows[e.RowIndex];

                fvir.EntryNumber = Convert.ToInt32(row.Cells[0].Value.ToString());
                fvir.PersonnelID = row.Cells[1].Value.ToString();
                fvir.DateTimeCreated = row.Cells[2].Value.ToString();
                fvir.Incident = row.Cells[3].Value.ToString();
                fvir.RpNo = row.Cells[4].Value.ToString();
                fvir.DateHappened = row.Cells[5].Value.ToString();
                fvir.TimeHappened = row.Cells[6].Value.ToString();
                fvir.Placehappened = row.Cells[7].Value.ToString();
                fvir.Narrative = row.Cells[8].Value.ToString();

                fvir.ShowDialog();
            }
          
        }
    }
}
