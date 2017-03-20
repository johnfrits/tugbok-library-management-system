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
using MetroFramework.Controls;

namespace MPosInfoManagementSystem
{
    public partial class FrmManageDetainee : MetroForm
    {
        SelectDeleteFunctions SF = new SelectDeleteFunctions();
        InsertUpdateFunctions IF = new InsertUpdateFunctions();
        ActivityLogBank ALB = new ActivityLogBank();
        bool s = false;
        public FrmManageDetainee()
        {
            InitializeComponent();
        }
        int personnelID;

        public int PersonnelID
        {
            get { return personnelID; }
            set { personnelID = value; }
        }

        private void FrmManageDetainee_Load(object sender, EventArgs e)
        {
            this.Location = new Point(237, 80);
            metroGridDetainee.DataSource = SF.GetAllDetainee("Detainee");
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButtonAddDetainee_Click_1(object sender, EventArgs e)
        {
            FrmAddNewDetainee fadnd = new FrmAddNewDetainee();
            fadnd.PersonnelID = PersonnelID;
            fadnd.ShowDialog();
        }

        private void metroGridDetainee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                DataGridViewRow row = this.metroGridDetainee.Rows[e.RowIndex];


                deNo.Text = row.Cells[0].Value.ToString();
                crime.Text = SF.GetCrimeIncident(Convert.ToInt32(row.Cells[1].Value.ToString()));
                status.Text = row.Cells[2].Value.ToString();
                string fname = row.Cells[4].Value.ToString() + " " + row.Cells[5].Value.ToString().Remove(1) + ". " + row.Cells[3].Value.ToString();
                fullname.Text = fname;
                nickname.Text = row.Cells[6].Value.ToString();
                sex.Text = row.Cells[7].Value.ToString();
                personalStatus.Text = row.Cells[8].Value.ToString();
                dob.Text = row.Cells[9].Value.ToString();
                age.Text = row.Cells[10].Value.ToString();
                pob.Text = row.Cells[11].Value.ToString();
                mob.Text = row.Cells[12].Value.ToString();
                address.Text = row.Cells[13].Value.ToString();
                occupation.Text = row.Cells[14].Value.ToString();
                height.Text = row.Cells[15].Value.ToString();
                weight.Text = row.Cells[16].Value.ToString();
                doe.Text = row.Cells[17].Value.ToString();
                doh.Text = row.Cells[18].Value.ToString();
                underF.Text = row.Cells[19].Value.ToString();
                otherF.Text = row.Cells[20].Value.ToString();
                timeanddate.Text = row.Cells[21].Value.ToString();
                placecaught.Text = row.Cells[22].Value.ToString();


                metroGridShots.DataSource = SF.GetMugshots(Convert.ToInt32(deNo.Text));
                var data = (Byte[])(metroGridShots.Rows[0].Cells[2].Value);
                var stream = new MemoryStream(data);
                pictureBox1.Image = Image.FromStream(stream);
            }

        }

        private void metroTxtBoxSearchWord_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (s == true)
                {
                    if (metroTxtBoxSearchWord.Text.Length > 0)
                    {
                        string column = metroComboBoxSelected.SelectedIndex == 0 ? "LastName" : "DetaineeNo";
                        int rowIndex = -1;
                        DataGridViewRow row = metroGridDetainee.Rows
                            .Cast<DataGridViewRow>()
                            .Where(r => r.Cells[column].Value.ToString().Contains(metroTxtBoxSearchWord.Text))
                            .First();

                        rowIndex = row.Index;
                        metroGridDetainee.ClearSelection();
                        metroGridDetainee.Rows[rowIndex].Selected = true;
                    }
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void metroComboBoxSelected_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroComboBoxSelected_Click(object sender, EventArgs e)
        {
            s = true;
        }

        private void metroButtonRelease_Click(object sender, EventArgs e)
        {
            if (deNo.Text.Length > 0)
            {
                FrmReleasedDetainee frm = new FrmReleasedDetainee(this);
                frm.DetaineNo = Convert.ToInt32(deNo.Text);
                frm.ShowDialog();
            }
        }
        private void clear()
        {
            foreach (Control txtb in this.metroPanel1.Controls)
            {
                if (txtb is MetroTextBox)
                {
                    ((MetroTextBox)txtb).Text = "";
                }
                pictureBox1.Image = null;
            }
        }

        private void viewReleased_CheckedChanged(object sender, EventArgs e)
        {
         
            if(viewReleased.Checked == true)
            {
                metroButtonShowDetails.Visible = true;
                metroGridDetainee.DataSource = null;
                metroGridDetainee.DataSource = SF.GetReleasedDetainee();
                clear();
            }

            if (viewReleased.Checked == false)
            {
                metroButtonShowDetails.Visible = false;
                metroGridDetainee.DataSource = null;
                metroGridDetainee.DataSource = SF.GetAllDetainee("Detainee");
                clear();
            }
   
        }

        private void metroButtonShowDetails_Click(object sender, EventArgs e)
        {
            FrmReleasedDetainee frd = new FrmReleasedDetainee(this);
            frd.View = true;
            frd.DetaineNo = Convert.ToInt32(deNo.Text);
            frd.ShowDialog();
        }

        private void status_TextChanged(object sender, EventArgs e)
        {
            if (status.Text == "Released")
            {
                metroButtonShowDetails.Visible = true;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Info Updated");
            IF.UpdateSuspectDetainee(Convert.ToInt32(deNo.Text));
            ALB.ActivityLogging(PersonnelID, "RELEASED DETAINEE");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (deNo.Text.Length > 0)
            {
                ViewMugShots vm = new ViewMugShots();

                var data1 = (Byte[])(metroGridShots.Rows[0].Cells[1].Value);
                var stream1 = new MemoryStream(data1);
                vm.L1 = Image.FromStream(stream1);

                var data2 = (Byte[])(metroGridShots.Rows[0].Cells[2].Value);
                var stream2 = new MemoryStream(data2);
                vm.F1 = Image.FromStream(stream2);

                var data3 = (Byte[])(metroGridShots.Rows[0].Cells[3].Value);
                var stream3 = new MemoryStream(data3);
                vm.R1 = Image.FromStream(stream3);

                vm.Show();
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (deNo.Text.Length > 0)
            {
                FrmFingerPrints ffp = new FrmFingerPrints(this);
                ffp.DetaineeNo = Convert.ToInt32(deNo.Text);
                ffp.View = true;
                ffp.ShowDialog();
            }
        }

        private void metroTxtBoxSearchWord_Click(object sender, EventArgs e)
        {

        }   
    }
}
