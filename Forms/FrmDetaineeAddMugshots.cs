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
using MetroFramework;

namespace MPosInfoManagementSystem
{
    public partial class FrmDetaineeAddMugshots : MetroForm
    {
        private FrmAddNewDetainee fad = null;
        public FrmDetaineeAddMugshots(Form fad)
        {
            this.fad = fad as FrmAddNewDetainee;
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
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

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.InitialDirectory = "Desktop";
                openFileDialog1.Title = "Insert Image";
                openFileDialog1.FileName = "";
                openFileDialog1.Filter = "JPEG Images|*.jpg";


                openFileDialog1.ShowDialog();
                string chosenFile = openFileDialog1.FileName;
                pictureBox2.Image = Image.FromFile(chosenFile);

            }
            catch
            {
                return;
            }
        }
        private void metroButton3_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.InitialDirectory = "Desktop";
                openFileDialog1.Title = "Insert Image";
                openFileDialog1.FileName = "";
                openFileDialog1.Filter = "JPEG Images|*.jpg";


                openFileDialog1.ShowDialog();
                string chosenFile = openFileDialog1.FileName;
                pictureBox3.Image = Image.FromFile(chosenFile);

            }
            catch
            {
                return;
            }
        }

        private void metroButtonSave_Click(object sender, EventArgs e)
        {
            this.fad.pictureBox1.Image = pictureBox2.Image;
            this.fad.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            

            MemoryStream stream1 = new MemoryStream();
            pictureBox1.Image.Save(stream1, System.Drawing.Imaging.ImageFormat.Jpeg);
            this.fad.Leftface = stream1.ToArray();
            MemoryStream stream2 = new MemoryStream();
            pictureBox2.Image.Save(stream2, System.Drawing.Imaging.ImageFormat.Jpeg);
            this.fad.Frontface = stream2.ToArray();
            MemoryStream stream3 = new MemoryStream();
            pictureBox3.Image.Save(stream3, System.Drawing.Imaging.ImageFormat.Jpeg);
            this.fad.Rightface = stream3.ToArray();

            MetroMessageBox.Show(this, "Detainee's Mugshot Saved");

        }   
    }
}
