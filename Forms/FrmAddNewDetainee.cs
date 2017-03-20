using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using MetroFramework.Controls;

namespace MPosInfoManagementSystem
{
    public partial class FrmAddNewDetainee : MetroForm
    {
        public FrmAddNewDetainee()
        {
            InitializeComponent();
        }
        SelectDeleteFunctions SF = new SelectDeleteFunctions();
        InsertUpdateFunctions IF = new InsertUpdateFunctions();
        ActivityLogBank ALB = new ActivityLogBank();
        int getSuspectNo;
        Boolean f = false;
        Random rnd = new Random();

        int personnelID;

        public int PersonnelID
        {
            get { return personnelID; }
            set { personnelID = value; }
        }

        byte[] rthumb;

        public byte[] Rthumb
        {
            get { return rthumb; }
            set { rthumb = value; }
        }

        byte[] lthumb;

        public byte[] Lthumb
        {
            get { return lthumb; }
            set { lthumb = value; }
        }

        byte[] leftface;

        public byte[] Leftface
        {
            get { return leftface; }
            set { leftface = value; }
        }

        byte[] frontface;

        public byte[] Frontface
        {
            get { return frontface; }
            set { frontface = value; }
        }

        byte[] rightface;

        public byte[] Rightface
        {
            get { return rightface; }
            set { rightface = value; }
        }

        private void FrmAddNewDetainee_Load(object sender, EventArgs e)
        {
        }

        private void buttonSearchRecNo_Click_1(object sender, EventArgs e)
        {
            FrmSearchRecordNo fsr = new FrmSearchRecordNo(this);
            fsr.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (metroTextBoxEntryNumber.Text.Length > 0)
            {
                FrmDetaineeAddMugshots fdam = new FrmDetaineeAddMugshots(this);
                fdam.ShowDialog();
            }
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Leftface == null || Rightface == null || Frontface == null)
                {
                    MetroMessageBox.Show(this, "ADD MUGSHOTS FIRST");
                    return;
                }
                if (metroTextBoxstatus.Text == "Suspect")
                {
                    metroTextBoxstatus.Text = "Detainee";
                }
                if (getSuspectNo == 0)
                {
                    getSuspectNo = rnd.Next(000000, 999999);
                }

                string uio = none.Checked == true ? none.Text : underF.Text;
                string datetimeApprehend = metroDateTime1.Value.ToShortDateString() + "-" + maskedTextBoxtime.Text + metroComboBoxampm.SelectedItem.ToString();

                IF.DetaineeInsert(getSuspectNo, Convert.ToInt32(metroTextBoxEntryNumber.Text), metroTextBoxstatus.Text, lastname.Text, firstname.Text, middlename.Text, nickname.Text, metroComboBoxSex.SelectedItem.ToString(), metroComboBoxStatus.SelectedItem.ToString(), birthday.Value.ToShortDateString(), DateTime.Now.Year - Convert.ToInt32(birthday.Value.Year),
                  pob.Text, mobileno.Text, address.Text, occupation.Text, height.Text, weight.Text, doe.Text, doh.Text, uio, otherfeatures.Text, datetimeApprehend, placeapprehended.Text);
                metroGridD.DataSource = SF.GetDetainee(Convert.ToInt32(metroTextBoxEntryNumber.Text));
                IF.InsertDetaineeMugshots(getSuspectNo, Leftface, Frontface, Rightface);
                IF.UpdateStatus(getSuspectNo);
                IF.InsertFingerPrints(getSuspectNo, Rthumb, Lthumb);

                MetroMessageBox.Show(this, "Added New Detainee");
                ALB.ActivityLogging(PersonnelID, "ADDED NEW DETAINEE");
                clear();
                this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString());
                return;
            }
        }

        private void metroTextBoxEntryNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (metroTextBoxEntryNumber.Text.Length > 0)
                {
                    if (SF.CheckIfSuspectExist(Convert.ToInt32(metroTextBoxEntryNumber.Text)) == false)
                    {
                        MetroMessageBox.Show(this, "No Suspect Found");
                        metroTextBoxstatus.Text = "Detainee";
                    }
                    else
                        metroGridS.DataSource = SF.GetDetainedSuspect(Convert.ToInt32(metroTextBoxEntryNumber.Text));
                    crimecommited.Text = SF.GetCrimeIncident(Convert.ToInt32(metroTextBoxEntryNumber.Text));
                }
                else
                    return;
            }
            catch
            {
                return;
            }

        }
        private void clear()
        {
            foreach (Control txtb in this.Controls)
            {
                if (txtb is MetroTextBox)
                {
                    ((MetroTextBox)txtb).Text = string.Empty;
                }
            }

            pictureBox1.Image = null;
            Leftface = null;
            Frontface = null;
            Rightface = null;
            this.Refresh();
        }

        private void metroGridS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                underF.Clear();
                DataGridViewRow row = this.metroGridS.Rows[e.RowIndex];

                getSuspectNo = Convert.ToInt32(row.Cells[0].Value.ToString());
                metroTextBoxstatus.Text = row.Cells[2].Value.ToString();
                lastname.Text = row.Cells[3].Value.ToString();
                firstname.Text = row.Cells[4].Value.ToString();
                middlename.Text = row.Cells[5].Value.ToString();
                nickname.Text = row.Cells[6].Value.ToString();
                metroComboBoxSex.Text = row.Cells[7].Value.ToString();
                metroComboBoxStatus.Text = row.Cells[8].Value.ToString();
                DateTime dt = Convert.ToDateTime(row.Cells[9].Value.ToString());
                birthday.Value = dt;
                pob.Text = row.Cells[11].Value.ToString();
                mobileno.Text = row.Cells[12].Value.ToString();
                address.Text = row.Cells[13].Value.ToString();
                occupation.Text = row.Cells[14].Value.ToString();
                height.Text = row.Cells[15].Value.ToString();
                weight.Text = row.Cells[16].Value.ToString();
                doe.Text = row.Cells[17].Value.ToString();
                doh.Text = row.Cells[18].Value.ToString();
                if (row.Cells[19].Value.ToString() == "NONE")
                    none.Checked = true;
                else
                {
                    none.Checked = false;
                    underF.Text = row.Cells[19].Value.ToString();
                }
                otherfeatures.Text = row.Cells[20].Value.ToString();
                f = true;
            }
        }
        private void metroButtonClearAll_Click(object sender, EventArgs e)
        {
            clear();
            maskedTextBoxtime.Clear();
            mobileno.Clear();
            this.Refresh();
            metroGridD.DataSource = null;
            metroGridS.DataSource = null;


        }
        private void metroButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SF.DeleteDetainee(Convert.ToInt32(metroGridD.SelectedRows[0].Cells[0].Value.ToString()));
                metroGridD.Rows.RemoveAt(metroGridD.SelectedRows[0].Index);
            }
            catch
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmFingerPrints frp = new FrmFingerPrints(this);
            frp.ShowDialog();
        }
    }
}
