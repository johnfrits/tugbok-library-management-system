using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace MPosInfoManagementSystem
{
    public partial class FrmSearchRecordNo : MetroForm
    {
        SelectDeleteFunctions SF = new SelectDeleteFunctions();
        private FrmAddNewDetainee fad = null;
        public FrmSearchRecordNo(Form fad)
        {
            this.fad = fad as FrmAddNewDetainee;
            InitializeComponent();
        }

        private void FrmSearchRecordNo_Load(object sender, EventArgs e)
        {
            metroGridSearch.DataSource = SF.GetAllIncidents();
        }
        private void metroGridSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.metroGridSearch.Rows[e.RowIndex];
                this.fad.metroTextBoxEntryNumber.Text = row.Cells[0].Value.ToString();
            }
            this.Hide();
        }

        private void buttonSearchRecNo_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroTextBoxSearchWord.Text.Length > 0)
                {
                    string column = metroComboBoxSby.SelectedIndex == 0 ? "EntryNumber" : "TypeofIncident";
                    int rowIndex = -1;
                    DataGridViewRow row = metroGridSearch.Rows
                        .Cast<DataGridViewRow>()
                        .Where(r => r.Cells[column].Value.ToString().Contains(metroTextBoxSearchWord.Text))
                        .First();

                    rowIndex = row.Index;
                    metroGridSearch.ClearSelection();
                    metroGridSearch.Rows[rowIndex].Selected = true;
                }
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
