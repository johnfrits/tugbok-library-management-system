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
    public partial class FrmFingerPrints : MetroForm
    {
        SelectDeleteFunctions SF = new SelectDeleteFunctions();

        private FrmAddNewDetainee fad = null;
        public FrmFingerPrints(Form fad)
        {
            this.fad = fad as FrmAddNewDetainee;
            InitializeComponent();
        }
        int detaineeNo;

        public int DetaineeNo
        {
            get { return detaineeNo; }
            set { detaineeNo = value; }
        }
        bool view;

        public bool View
        {
            get { return view; }
            set { view = value; }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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

        private void metroButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream stream1 = new MemoryStream();
                pictureBox1.Image.Save(stream1, System.Drawing.Imaging.ImageFormat.Jpeg);
                this.fad.Lthumb = stream1.ToArray();

                MemoryStream stream2 = new MemoryStream();
                pictureBox2.Image.Save(stream2, System.Drawing.Imaging.ImageFormat.Jpeg);
                this.fad.Rthumb = stream2.ToArray();

                MessageBox.Show("Fingerprint Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void metroButtonCancel_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
        }

        private void FrmFingerPrints_Load(object sender, EventArgs e)
        {
            if (View == true)
            {
                metroButtonSave.Visible = false;
                metroButtonCancel.Visible = false;
                metroButton1.Visible = false;
                metroButton2.Visible = false;

                dataGridView1.DataSource = SF.GetFingerPrints(DetaineeNo);

                var data2 = (Byte[])(dataGridView1.Rows[0].Cells[1].Value);
                var stream2 = new MemoryStream(data2);
                pictureBox1.Image = Image.FromStream(stream2);

                var data3 = (Byte[])(dataGridView1.Rows[0].Cells[2].Value);
                var stream3 = new MemoryStream(data3);
                pictureBox2.Image = Image.FromStream(stream3);
            }
        }
    }
}
