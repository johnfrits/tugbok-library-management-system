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
    public partial class AdminDashboard : MetroForm
    {
        InsertUpdateFunctions IF = new InsertUpdateFunctions();
        SelectDeleteFunctions SF = new SelectDeleteFunctions();
        ActivityLogBank ALB = new ActivityLogBank();
        Boolean available = false;
        public AdminDashboard()
        {
            InitializeComponent();

        }

        private string personnelID;

        public string PersonnelID
        {
            get { return personnelID; }
            set { personnelID = value; }
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }
        private void metroTabControl1_Click(object sender, EventArgs e)
        {
            if (metroTabControl.SelectedTab == metroTabPageLogout)
            {
                if (MetroMessageBox.Show(this, "Are you sure do you want to logout ?", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    ALB.ActivityLogging(Convert.ToInt32(PersonnelID), "LOGGED OUT");
                    Application.Restart();
                }
                else this.Hide();
            }
        }
        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (available)
            {
                if (metroTextBoxPassword.Text != metroTextBoxRetype.Text)
                    return;
                else
                {
                    try
                    {
                        IF.AddUser(Convert.ToInt32(metroTextBoxPersonneID.Text), metroTextBoxPassword.Text);
                        ALB.ActivityLogging(Convert.ToInt32(PersonnelID), "ADDED A NEW USER");
                        MetroMessageBox.Show(this, "User Added");
                        clear();
                    }
                    catch (Exception)
                    {
                        MetroMessageBox.Show(this, "User Cannot Be Duplicated");
                    }
                }
            }
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroTextBoxNewP.Text == metroTextBoxRe.Text)
            {
                if (SF.CheckExistingPassword(Convert.ToInt32(PersonnelID), metroTextBoxOldPassword.Text) == true)
                {
                    IF.ChangePassword(Convert.ToInt32(PersonnelID), metroTextBoxNewP.Text);
                    ALB.ActivityLogging(Convert.ToInt32(PersonnelID), "CHANGED PASSWORD");
                    MetroMessageBox.Show(this, "Password Changed");
                    clear();
                }
            }
        }
        private void clear()
        {
            foreach (Control txtb in metroTabControl.SelectedTab.Controls)
            {
                if (txtb is MetroTextBox)
                {
                    ((MetroTextBox)txtb).Text = string.Empty;
                }   
            }
        }

        private void metroButtonAva_Click(object sender, EventArgs e)
        {
            try
            {
                if (SF.CheckExistPidFromPersonnel(Convert.ToInt32(metroTextBoxPersonneID.Text)) == true)
                {
                    if (SF.CheckUsersPersonnelID(Convert.ToInt32(metroTextBoxPersonneID.Text)) == true)
                    {
                        MetroMessageBox.Show(this, "Try Again", "PERSONNEL ID NOT AVAILABLE");
                        return;
                    }
                    if (SF.CheckUsersPersonnelID(Convert.ToInt32(metroTextBoxPersonneID.Text)) == false)
                    {
                        MetroMessageBox.Show(this, "Proceed to the next item", "PERSONNEL ID AVAILABLE");
                        available = true;
                    }
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "Try Again", "PERSONEL ID DIDNT EXIST");
                return;
            }

        }
    }
}
