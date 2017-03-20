using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;

namespace MPosInfoManagementSystem
{
    public partial class FrmMain : MetroForm
    {
        string userId;
        int y;
        bool clicked = true;
        SelectDeleteFunctions SF = new SelectDeleteFunctions();
        public string PersonnelID
        {
            get { return userId; }
            set { userId = value; }
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        public FrmMain()
        {
            InitializeComponent();
            y = metroPanelMain.Location.Y;
        }

        private void SlidingEffect()
        {
            if (clicked == true)
            {
                y -= 6;
                if (metroPanelMain.Location.Y < 578)
                {
                    timerPanelAdmin.Enabled = false;
                    clicked = false;
                }
            }
            if(clicked == false)
            {
                y += 6;
                if(metroPanelMain.Location.Y > 660)
                {
                    timerPanelAdmin.Enabled = false;
                    clicked = true;
                }
            }
            metroPanelMain.Location = new Point(metroPanelMain.Location.X, y);
            metroPanelMain.Refresh();
        }
        private void DisplayPersonnelData()
        {
            try
            {
                labelRank.Text = (SF.GetPersonnel(Convert.ToInt32(PersonnelID)).ElementAt(0)).ToString();
                labelPersonelName.Text = (SF.GetPersonnel(Convert.ToInt32(PersonnelID)).ElementAt(1)).ToString();

                var pic = (Byte[])(SF.GetPersonnel(Convert.ToInt32(PersonnelID)).ElementAt(2));
                var stream = new MemoryStream(pic);
                pictureBoxPersonnel.Image = Image.FromStream(stream);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            labelDate.Text = (DateTime.Today).ToLongDateString();
            labelTime.Text = (DateTime.Now).ToLongTimeString();

            DisplayPersonnelData();
        
        }
     
        private void metroTileAddIncident_Click(object sender, EventArgs e)
        {
            FrmManageIncidentRecord fmir = new FrmManageIncidentRecord();
            fmir.PersonnelID = PersonnelID;
            fmir.PersonnelName = labelPersonelName.Text;
            fmir.ShowDialog();
        }
        private void metroTileAddNewDetainee_Click(object sender, EventArgs e)
        {
            FrmManageDetainee frmmD = new FrmManageDetainee();
            frmmD.PersonnelID = Convert.ToInt32(PersonnelID);
            frmmD.ShowDialog();
        }
        private void metroTileAddIncident_MouseHover(object sender, EventArgs e)
        {
            metroTileAddIncident.ForeColor = Color.Orange;
        }
        private void metroTileAddIncident_MouseLeave(object sender, EventArgs e)
        {
            metroTileAddIncident.ForeColor = Color.White;
        }
        private void timerPanelMovement_Tick(object sender, EventArgs e)
        {
            labelTime.Text = (DateTime.Now).ToLongTimeString();
        }
        private void metroTileAddNewDetainee_MouseHover(object sender, EventArgs e)
        {
            metroTileAddNewDetainee.ForeColor = Color.Orange;
        }
        private void metroTileAddNewDetainee_MouseLeave(object sender, EventArgs e)
        {
            metroTileAddNewDetainee.ForeColor = Color.White;
        }
        private void metroPanel2_MouseHover(object sender, EventArgs e)
        {
            metroPanel2.BackColor = Color.Gainsboro;
        }
        private void metroPanel2_MouseLeave(object sender, EventArgs e)
        {
            metroPanel2.BackColor = Color.Transparent;
        }
        private void metroBlotterReports_MouseHover(object sender, EventArgs e)
        {
            metroBlotterReports.ForeColor = Color.Orange;
        }
        private void metroBlotterReports_MouseLeave(object sender, EventArgs e)
        {
            metroBlotterReports.ForeColor = Color.White;
        }
        private void metroTileManagePersonnel_MouseHover(object sender, EventArgs e)
        {
            metroTileManagePersonnel.ForeColor = Color.Orange;
        }

        private void metroTileManagePersonnel_MouseLeave(object sender, EventArgs e)
        {
            metroTileManagePersonnel.ForeColor = Color.White;
        }
        private void metroTileLogging_MouseHover(object sender, EventArgs e)
        {
            metroTileLogging.ForeColor = Color.Orange;
        }
        private void metroTileLogging_MouseLeave(object sender, EventArgs e)
        {
            metroTileLogging.ForeColor = Color.White;
        }
        private void metroTileStatisticalReports_MouseHover(object sender, EventArgs e)
        {
            metroTileStatisticalReports.ForeColor = Color.Orange;
        }
        private void metroTileStatisticalReports_MouseLeave(object sender, EventArgs e)
        {
            metroTileStatisticalReports.ForeColor = Color.White;
        }
        //
        private void metroPanel2_MouseClick(object sender, MouseEventArgs e)
        {
            AdminDashboard ad = new AdminDashboard();
            ad.PersonnelID = PersonnelID;
            ad.ShowDialog();
        }

        private void metroBlotterReports_Click(object sender, EventArgs e)
        {
            FrmBlotterReport fbr = new FrmBlotterReport();
            fbr.PersonnelID = Convert.ToInt32(PersonnelID);
            fbr.ShowDialog();
        }

        private void timerPanelAdmin_Tick(object sender, EventArgs e)
        {
            SlidingEffect();
        }

        private void FrmMain_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                timerPanelAdmin.Enabled = true;
            }
        }

        private void metroTileLogging_Click(object sender, EventArgs e)
        {
            FrmActivityLogging fal = new FrmActivityLogging();
            fal.ShowDialog();
        }

        private void metroTileManagePersonnel_Click(object sender, EventArgs e)
        {
            FrmManagePersonnel fmp = new FrmManagePersonnel();
            fmp.PersonnelID = Convert.ToInt32(PersonnelID);
            fmp.ShowDialog();
        }

        private void metroTileStatisticalReports_Click(object sender, EventArgs e)
        {
            FrmStatisticalReports fsr = new FrmStatisticalReports();
            fsr.ShowDialog();
        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }
    }
}
