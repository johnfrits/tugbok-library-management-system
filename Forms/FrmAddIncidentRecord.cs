using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using Microsoft.Reporting.WinForms;
using MetroFramework.Controls;
using MetroFramework;

namespace MPosInfoManagementSystem
{
    public partial class FrmAddIncidentRecord : Form
    {
        Random rand = new Random();
        Boolean click = false;
        InsertUpdateFunctions IF = new InsertUpdateFunctions();
        SelectDeleteFunctions SF = new SelectDeleteFunctions();
        ActivityLogBank ALB = new ActivityLogBank();
        string underofInfluence = "";
        string dob = "";
        string status = "";
        string Ntime = "";
        int age;
        int reportingPersonNo, victimNo, suspectNo;

        private string personnelID;

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

        public FrmAddIncidentRecord()
        {
            InitializeComponent();
        }

        private void FrmIncidentRecord_Load(object sender, EventArgs e)
        {
            this.Focus();
            this.Location = new Point(250, 77);

            reportingPersonNo = rand.Next(000000, 999999);
            metroTbBlotterNumber.Text = (SF.RecentEntryNumber() + 1).ToString();

            //Populate Combobox Year
            for (int i = 1900; i <= DateTime.Now.Year; i++)
            {
                metroComboBoxYear.Items.Add(i.ToString());
                metroComboBoxYear2.Items.Add(i.ToString());
                metroComboBoxYear3.Items.Add(i.ToString());
            }
        }
        private void radioButtonSuspects_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSuspects.Checked == true)
                panelSuspect.Visible = false;
        }

        private void metroButtonCancel_Click(object sender, EventArgs e)
        {

            if (metroGridSuspect.Rows.Count > 0 || metroGridVictim.Rows.Count > 0)
            {
                SF.RemoveSuspect(Convert.ToInt32(metroTbBlotterNumber.Text));
            }

            panelSuspect.Visible = true;
        }

        private void radioButtontwo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtontwo.Checked == true)
                panelVictim.Visible = false;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            if (metroGridSuspect.Rows.Count > 0 || metroGridVictim.Rows.Count > 0)
                SF.RemoveVictim(Convert.ToInt32(metroTbBlotterNumber.Text));

            panelVictim.Visible = true;
        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            if (metroGridSuspect.Rows.Count > 0 || metroGridVictim.Rows.Count > 0)
                SF.RemoveSuspectAndVictim(Convert.ToInt32(metroTbBlotterNumber.Text));

            FrmAddIncidentRecord.ActiveForm.Close();
        }
        private void InsertAll()
        {
            try
            {

                Ntime = maskedTextBoxNTime.Text + "/" + metroComboBoxAMPM.SelectedItem.ToString();
                dob = metroComboBoxMonth.SelectedItem.ToString() + "/" + metroComboBoxDay.SelectedIndex.ToString() + "/" + metroComboBoxYear.SelectedItem.ToString();
                int age = DateTime.Now.Year - Convert.ToInt32(metroComboBoxYear.SelectedItem.ToString());


                if (radioButtonVictim.Checked == true)
                {
                    victimNo = rand.Next(000000, 999999);
                    IF.VictimInsert(victimNo, Convert.ToInt32(metroTbBlotterNumber.Text), rLastName.Text, rFirstName.Text, rMiddleName.Text, rNickName.Text,
                                             rComboBoxSex.SelectedItem.ToString(), rComboBoxStatus.SelectedItem.ToString(), dob, age, rPlaceOfBirth.Text, rMobileNo.Text,
                                             rAddress.Text, rOccupation.Text, rEmailAddress.Text, rIdCard.Text);
                }

                IF.ReportingPersonInsert(reportingPersonNo, Convert.ToInt32(metroTbBlotterNumber.Text), rLastName.Text, rFirstName.Text, rMiddleName.Text, rNickName.Text,
                                         rComboBoxSex.SelectedItem.ToString(), rComboBoxStatus.SelectedItem.ToString(), dob, age, rPlaceOfBirth.Text, rMobileNo.Text,
                                         rAddress.Text, rOccupation.Text, rEmailAddress.Text, rIdCard.Text);

                IF.InsertToIRF(Convert.ToInt32(metroTbBlotterNumber.Text), Convert.ToInt32(PersonnelID), DateTime.Now.ToLocalTime(), metroTBIncident.Text, reportingPersonNo, metroDateTimeNarrative.Value.ToShortDateString(),
                       Ntime, Naddresstxt.Text, mTextBNarrative.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void metroButtonConfirm_Click(object sender, EventArgs e)
        {
            try
            {


                if(metroTBIncident.Text.Length < 0 )
                {
                    MetroMessageBox.Show(this, "Indicate What Type of Incident");
                    metroTBIncident.Focus();
                }
                InsertAll();
                string repFullName = rLastName.Text + ", " + rFirstName.Text;
                DateTime dt = metroDateTimeNarrative.Value;
          
                string IDP = metroTBIncident.Text + " / " + dt.Date.ToShortDateString() + "/" + maskedTextBoxNTime.Text + metroComboBoxAMPM.SelectedItem.ToString() +  " / " + Naddresstxt.Text;

           

                PrintForm pf = new PrintForm();

                pf.ReportingPersonName = repFullName;
                pf.PersonnelName = PersonnelName;
                pf.AddressRepPerName = rAddress.Text;
                pf.EntryBlotterNumber = metroTbBlotterNumber.Text;
                pf.IDP1 = IDP;
                pf.ShowDialog();


                ALB.ActivityLogging(Convert.ToInt32(PersonnelID), "Added New Incident Record");
                FrmAddIncidentRecord.ActiveForm.Close();
            }
            catch
            {
                MetroMessageBox.Show(this, "Fill Up All Important Fields");
            }
        }
        private void metroButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                suspectNo = rand.Next(000000, 999999);  

                if (click == true)
                {
                    dob = metroComboBoxD.SelectedItem.ToString() + "/" + metroComboBoxM.SelectedItem.ToString() + "/" + metroComboBoxYear2.SelectedItem.ToString();
                    age = DateTime.Now.Year - Convert.ToInt32(metroComboBoxYear2.SelectedItem.ToString());
                    status = sStatus.SelectedItem.ToString();
                }
                if (click == false)
                    dob = "";

                underofInfluence = sNo.Checked == true ? sNo.Text : sOthers.Text;

                IF.SuspectInsert(suspectNo, Convert.ToInt32(metroTbBlotterNumber.Text), "Suspect", sLastName.Text, sfirstName.Text, sMiddleName.Text, sNickName.Text, sSex.SelectedItem.ToString(), status,
                                 dob, age, sPOB.Text, sMobileNo.Text, sAddress.Text, sOccupation.Text, sHeight.Text, sWeight.Text, sDescEyes.Text, sDescHair.Text, underofInfluence, sFeatures.Text);

                metroGridSuspect.DataSource = SF.GetSuspect(Convert.ToInt32(metroTbBlotterNumber.Text));
                metroGridSuspect.Refresh();
                metroGridSuspect.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void metroButtonDelete_Click(object sender, EventArgs e)
        {
            SF.DeleteSuspect(Convert.ToInt32(metroGridSuspect.SelectedRows[0].Cells[0].Value));
            metroGridSuspect.Rows.RemoveAt(metroGridSuspect.SelectedRows[0].Index);
        }
        private void metroComboBoxM_Click(object sender, EventArgs e)
        {
            click = true;
        }
        private void metroButtonVicAdd_Click(object sender, EventArgs e)
        {
            try
            {
                dob = metroComboBox9.SelectedItem.ToString() + "/" + metroComboBox8.SelectedItem.ToString() + "/" + metroComboBoxYear3.SelectedItem.ToString();
                age = DateTime.Now.Year - Convert.ToInt32(metroComboBoxYear3.SelectedItem);
                victimNo = rand.Next(000000, 999999);

                IF.VictimInsert(victimNo, Convert.ToInt32(metroTbBlotterNumber.Text), vLastName.Text, vfirstName.Text, vMiddleName.Text, vNickName.Text, vSex.SelectedItem.ToString(),
                                vStatus.SelectedItem.ToString(), dob, age, vPOB.Text, vMobileNo.Text, vAddress.Text, vOccupation.Text, vEmailAdd.Text, vIdCard.Text);

                metroGridVictim.DataSource = SF.GetVictim(Convert.ToInt32(metroTbBlotterNumber.Text));
                metroGridVictim.Refresh();
                metroGridVictim.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void metroButtonVicDel_Click(object sender, EventArgs e)
        {
            SF.DeleteVictim(Convert.ToInt32(metroGridVictim.SelectedRows[0].Index));
            metroGridVictim.Rows.RemoveAt(metroGridVictim.SelectedRows[0].Index);
        }
    }
}
