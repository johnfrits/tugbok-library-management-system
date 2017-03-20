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
    public partial class FrmReleasedDetainee : MetroForm
    {
        InsertUpdateFunctions IF = new InsertUpdateFunctions();
        SelectDeleteFunctions SF = new SelectDeleteFunctions();
        private FrmManageDetainee fmd = null;
        public FrmReleasedDetainee(Form fmd)
        {
            this.fmd = fmd as FrmManageDetainee;
            InitializeComponent();
        }
        int detaineNo;

        public int DetaineNo
        {
            get { return detaineNo; }
            set { detaineNo = value; }
        }
        bool view;

        public bool View
        {
            get { return view; }
            set { view = value; }
        } 

        private void metroButtonReleased_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroTextBoxReason.Text.Length > 0)
                {
                    this.fmd.status.Text = "Released";
                    this.fmd.Refresh();
                    this.fmd.Update();
                    this.fmd.metroGridDetainee.Refresh();
                    IF.InsertToReleasedDetainee(DetaineNo, DateTime.Now.ToString(), metroTextBoxReason.Text);
                    MetroMessageBox.Show(this, "Detainee Released");
                    this.Hide();
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "Error Occured");
            }
        }

        private void FrmReleasedDetainee_Load(object sender, EventArgs e)
        {
            try
            {
                if (View == true)
                {
                    metroTextBoxReason.Text = "REASON OF RELEASING: " + Environment.NewLine + (SF.GetRD(DetaineNo).ElementAt(1)).ToString() + Environment.NewLine + "DATE AND TIME RELEASED: " + (SF.GetRD(DetaineNo).ElementAt(0)).ToString();
                    metroButtonReleased.Visible = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
