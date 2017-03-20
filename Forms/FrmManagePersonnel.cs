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
    public partial class FrmManagePersonnel : MetroForm
    {
        SelectDeleteFunctions SF = new SelectDeleteFunctions();
        InsertUpdateFunctions IF = new InsertUpdateFunctions();
        ActivityLogBank ALB = new ActivityLogBank();
        bool save = false;
        bool s;

        int personnelID;

        public int PersonnelID
        {
            get { return personnelID; }
            set { personnelID = value; }
        }

        public FrmManagePersonnel()
        {
            InitializeComponent();
        }

        private void metroButtonAddPersonnel_Click(object sender, EventArgs e)
        {
            FrmAddPersonnel fap = new FrmAddPersonnel();
            fap.PersonnelID = PersonnelID;
            fap.ShowDialog();
        }

        private void FrmManagePersonnel_Load(object sender, EventArgs e)
        {
            metroGrid1.DataSource = SF.GetAllPersonnel();
        }

        private void metroButtonReassign_Click(object sender, EventArgs e)
        {
            metroTextBoxPosCharge.ReadOnly = false;
            this.metroTextBoxPosCharge.Focus();
            save = true;
        }

        private void metroButtonPromoteDemote_Click(object sender, EventArgs e)
        {
            metroTextBoxRank.ReadOnly = false;
            this.metroTextBoxRank.Focus();
            save = true;
        }

        private void metroGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.metroGrid1.Rows[e.RowIndex];

                metroTextBoxPID.Text = row.Cells[0].Value.ToString();
                metroTextBoxRank.Text = row.Cells[1].Value.ToString();
                metroTextBoxPosCharge.Text = row.Cells[2].Value.ToString();
                metroTextBoxName.Text = row.Cells[3].Value.ToString();
                metroTextBoxDate.Text = row.Cells[4].Value.ToString();

                var data = SF.PersonnelPic(Convert.ToInt32(metroTextBoxPID.Text));
                var stream = new MemoryStream(data);
                pictureBox1.Image = Image.FromStream(stream);
            }
        }

        private void metroButtonSave_Click(object sender, EventArgs e)
        {
             try
            {
                if (save == true)
                {
                    IF.UpdatePersonnel(Convert.ToInt32(metroTextBoxPID.Text), metroTextBoxRank.Text, metroTextBoxPosCharge.Text);
                    MetroMessageBox.Show(this, "Save Changes Completed");
                    ALB.ActivityLogging(PersonnelID, "EDITED INFO");
                    metroGrid1.Update();
                    metroGrid1.Refresh();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void metroTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (s == true)
                {
                    if (metroTextBoxSearch.Text.Length > 0)
                    {
                        string column = metroComboBoxSearch.SelectedIndex == 0 ? "PersonnelID" : "Name";
                        int rowIndex = -1;
                        DataGridViewRow row = metroGrid1.Rows
                            .Cast<DataGridViewRow>()
                            .Where(r => r.Cells[column].Value.ToString().Contains(metroTextBoxSearch.Text))
                            .First();

                        rowIndex = row.Index;
                        metroGrid1.ClearSelection();
                        metroGrid1.Rows[rowIndex].Selected = true;
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void metroComboBoxSearch_Click(object sender, EventArgs e)
        {
            s = true;
        }
            
        
    }
}
