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
using MetroFramework.Controls;
using MetroFramework;

namespace MPosInfoManagementSystem
{
    public partial class FrmAddPersonnel : MetroForm
    {
        InsertUpdateFunctions IF = new InsertUpdateFunctions();
        public FrmAddPersonnel()
        {
            InitializeComponent();
        }
        int personnelID;

        public int PersonnelID
        {
            get { return personnelID; }
            set { personnelID = value; }
        }

        ActivityLogBank ALB = new ActivityLogBank();
        private void metroButtonBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.InitialDirectory = "Desktop";
                openFileDialog1.Title = "Insert Image";
                openFileDialog1.FileName = "";
                openFileDialog1.Filter = "JPEG Images|*.jpg";

                openFileDialog1.ShowDialog();
                string chosenFile = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(chosenFile);
            }
            catch
            {
                return;
            }
        }

        private void metroButtonAddPersonnel_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream stream = new MemoryStream();
                pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] pic = stream.ToArray();

                IF.InsertPersonnel(Convert.ToInt32(metroTextBoxPersonnelD.Text), metroTextBoxRank.Text, metroTextBoxPosition.Text, metroTextBoxName.Text, metroDateTime1.Value.ToShortDateString(), pic);
                MessageBox.Show("Personnel Added");

                ALB.ActivityLogging(PersonnelID, "NEW PERSONNEL ADDED");
                clear();
                pictureBox1.Image = null;
            }
            catch
            {
                MetroMessageBox.Show(this, "Personnel Image Required");
            }
        }
        
        private void metroButtonClear_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {

            pictureBox1.Image = null;
            foreach (Control txt in this.Controls)
            {
                if (txt is MetroTextBox)
                {
                    ((MetroTextBox)txt).Text = string.Empty;
                }
            }
        }
    }
}
