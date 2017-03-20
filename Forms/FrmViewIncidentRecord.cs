using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace MPosInfoManagementSystem
{
    public partial class FrmViewIncidentRecord : MetroForm
    {
        SelectDeleteFunctions SF = new SelectDeleteFunctions();

        int entryNumber;

        public int EntryNumber
        {
            get { return entryNumber; }
            set { entryNumber = value; }
        }

        string personnelID;

        public string PersonnelID
        {
            get { return personnelID; }
            set { personnelID = value; }
        }

        string incident;

        public string Incident
        {
            get { return incident; }
            set { incident = value; }
        }
        string dateTimeCreated;

        public string DateTimeCreated
        {
            get { return dateTimeCreated; }
            set { dateTimeCreated = value; }
        }

        string dateHappened;

        public string DateHappened
        {
            get { return dateHappened; }
            set { dateHappened = value; }
        }
        string timeHappened;

        public string TimeHappened
        {
            get { return timeHappened; }
            set { timeHappened = value; }
        }
        string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        string rpNo;

        public string RpNo
        {
            get { return rpNo; }
            set { rpNo = value; }
        }
        string placehappened;

        public string Placehappened
        {
            get { return placehappened; }
            set { placehappened = value; }
        }

        string narrative;

        public string Narrative
        {
            get { return narrative; }
            set { narrative = value; }
        }

        public FrmViewIncidentRecord()
        {
            InitializeComponent();
        }

        private void FrmViewIncidentRecord_Load(object sender, EventArgs e)
        {
            paneSuspect.Visible = false;
            try
            {
                e1.Text = EntryNumber.ToString();
                e2.Text = Incident;
                e4.Text = Placehappened;
                DateTime dt = Convert.ToDateTime(DateHappened);
                e5.Text = dt.ToShortDateString();
                e6.Text = TimeHappened;
                e7.Text = Narrative;
                e8.Text = SF.GetPersonnelName(Convert.ToInt32(PersonnelID));
                e9.Text = DateTimeCreated;
                metroGridrp.DataSource = SF.GetReportingPerson(Convert.ToInt32(RpNo));
                metroGridsp.DataSource = SF.GetSuspect(EntryNumber);
                metroGridvc.DataSource = SF.GetVictim(EntryNumber);

                metroGridrp.Update();
                metroGridsp.Update();
                metroGridvc.Update();
                metroGridrp.Refresh();
                metroGridsp.Refresh();
                metroGridvc.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void metroGridrp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            paneSuspect.Visible = false;
            lblview.Text = "Reporting Person";

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.metroGridrp.Rows[e.RowIndex];

                string fullname = row.Cells[2].Value.ToString() + ", " + row.Cells[3].Value.ToString() + " " + row.Cells[4].Value.ToString();
                nc.Text = row.Cells[5].Value.ToString();
                name.Text = fullname;
                sex.Text = row.Cells[6].Value.ToString();
                stats.Text = row.Cells[7].Value.ToString();
                string dobb = row.Cells[8].Value.ToString();
                DateTime dt = Convert.ToDateTime(dobb);
                dob.Text = dt.ToShortDateString();
                age.Text = row.Cells[9].Value.ToString();
                pob.Text = row.Cells[10].Value.ToString();
                mobileno.Text = row.Cells[11].Value.ToString();
                address.Text = row.Cells[12].Value.ToString();
                occupation.Text = row.Cells[13].Value.ToString();
                eadd.Text = row.Cells[14].Value.ToString();
                idcard.Text = row.Cells[15].Value.ToString();
            }
        }

        private void metroGridvc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            paneSuspect.Visible = false;
            if (e.RowIndex >= 0)
            {
                lblview.Text = "Victim";

                DataGridViewRow row = this.metroGridvc.Rows[e.RowIndex];

                string fullname = row.Cells[2].Value.ToString() + ", " + row.Cells[3].Value.ToString() + " " + row.Cells[4].Value.ToString();
                nc.Text = row.Cells[5].Value.ToString();
                name.Text = fullname;
                sex.Text = row.Cells[6].Value.ToString();
                stats.Text = row.Cells[7].Value.ToString();
                string dobb = row.Cells[8].Value.ToString();
                DateTime dt = Convert.ToDateTime(dobb);
                dob.Text = dt.ToShortDateString();
                age.Text = row.Cells[9].Value.ToString();
                pob.Text = row.Cells[10].Value.ToString();
                mobileno.Text = row.Cells[11].Value.ToString();
                address.Text = row.Cells[12].Value.ToString();
                occupation.Text = row.Cells[13].Value.ToString();
                eadd.Text = row.Cells[14].Value.ToString();
                idcard.Text = row.Cells[15].Value.ToString();
            }
        }

        private void metroGridsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                paneSuspect.Visible = true;
                if (e.RowIndex >= 0)
                {
                    lblview.Text = "Suspect";

                    DataGridViewRow row = this.metroGridsp.Rows[e.RowIndex];
            
                    string fullname = row.Cells[3].Value.ToString() + ", " + row.Cells[4].Value.ToString() + " " + row.Cells[5].Value.ToString();
                    string dobb = row.Cells[9].Value.ToString();
                    DateTime dt = Convert.ToDateTime(dobb);
                    sStats.Text = row.Cells[2].Value.ToString();
                    sname.Text = fullname;
                    snick.Text = row.Cells[6].Value.ToString();
                    sSex.Text = row.Cells[7].Value.ToString();
                    sPs.Text = row.Cells[8].Value.ToString();
                    sDob.Text = dt.ToShortDateString();
                    sAge.Text = row.Cells[10].Value.ToString();
                    sPob.Text = row.Cells[11].Value.ToString();
                    sMob.Text = row.Cells[12].Value.ToString();
                    sadd.Text = row.Cells[13].Value.ToString();
                    sOccu.Text = row.Cells[14].Value.ToString();
                    sHeight.Text = row.Cells[15].Value.ToString();
                    sWeight.Text = row.Cells[16].Value.ToString();
                    sDOE.Text = row.Cells[17].Value.ToString();
                    sDOH.Text = row.Cells[18].Value.ToString();
                    sUIO.Text = row.Cells[19].Value.ToString();
                    sOF.Text = row.Cells[20].Value.ToString();
                }
            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void paneSuspect_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
