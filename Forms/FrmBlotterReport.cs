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

namespace MPosInfoManagementSystem
{
    public partial class FrmBlotterReport : MetroForm
    {
        SelectDeleteFunctions SF = new SelectDeleteFunctions();
        InsertUpdateFunctions IF = new InsertUpdateFunctions();
        ActivityLogBank ALB = new ActivityLogBank();
        bool print = true;

        int personnelID;

        public int PersonnelID
        {
            get { return personnelID; }
            set { personnelID = value; }
        }
        public FrmBlotterReport()
        {
            InitializeComponent();
        }
        bool edit = false;
        private void buttonSearchRecNo_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroTextBoxSearch.Text.Length > 0)
                {
                    int rowIndex = -1;
                    DataGridViewRow row = metroGridNarrative.Rows
                        .Cast<DataGridViewRow>()
                        .Where(r => r.Cells[0].Value.ToString().Contains(metroTextBoxSearch.Text))
                        .First();

                    rowIndex = row.Index;
                    metroGridNarrative.ClearSelection();
                    metroGridNarrative.Rows[rowIndex].Selected = true;
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void FrmBlotterReport_Load(object sender, EventArgs e)
        {
            this.Location = new Point(265, 80);
            metroGridNarrative.DataSource = SF.GetBlotter();
       
        }

        private void metroButtonSave_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "SAVE CHANGES?", null, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                IF.UpdateNarrative(Convert.ToInt32(metroLabelen.Text),metroTextBoxFinalNarrative.Text);
                MetroMessageBox.Show(this, "CHANGES SAVED");
                ALB.ActivityLogging(PersonnelID, "EDITED NARRATIVE REPORT");
                print = true;
                this.Refresh();
                this.metroGridNarrative.Refresh();
            }
            else return;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (metroTextBoxFinalNarrative.Text.Length > 0)
            {
                if (print == true)
                {
                    if (MetroMessageBox.Show(this, "EXPORT NARRATIVE?", null, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        ALB.ActivityLogging(PersonnelID, "EXPORTED NARRATIVE REPORT");
                        ExportBlotter eb = new ExportBlotter();
                        eb.Narrative = metroTextBoxFinalNarrative.Text;
                        eb.ShowDialog();
                    }
                    else
                        return;
                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            metroTextBoxFinalNarrative.ReadOnly = false;
            metroTextBoxFinalNarrative.Focus();
            print = false;
        }

        private void metroGridNarrative_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.metroGridNarrative.Rows[e.RowIndex];

                metroLabelen.Text = row.Cells[0].Value.ToString();
                metroTextBoxFinalNarrative.Text = row.Cells[1].Value.ToString();
            }
        }

        private void metroTextBoxFinalNarrative_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                MessageBox.Show("Cut/Copy and Paste Options are disabled");
            }
        }
    }
}
