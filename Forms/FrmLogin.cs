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
    public partial class FrmLogin : MetroForm
    {
        //Declaration
        int X1, X2;
        bool f;
        int d;
        Image[] arrImage;
        bool b = true;
        SelectDeleteFunctions selectFunctions = new SelectDeleteFunctions();
        FrmMain frmMain = new FrmMain();
        ActivityLogBank ALB = new ActivityLogBank();
        Random rnd = new Random();
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        public FrmLogin()
        {
           
            InitializeComponent();
            X1 = pictureBox1.Location.X;
            arrImage = new Image[]{ MPosInfoManagementSystem.Properties.Resources.d3_4, 
                                    MPosInfoManagementSystem.Properties.Resources.policemen_salute_9,
                                    MPosInfoManagementSystem.Properties.Resources.LEAD_PNP_1440x900 };
            
            pictureBox1.Image = arrImage[0];
            pictureBox4.Image = arrImage[1];
            f = false;
        }
        private void metroButtonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectFunctions.UserSearch(mTBoxpersonnelID.Text, mTBoxPassword.Text) == true)
                {
                    MetroMessageBox.Show(this, "Login Successful");
                    ALB.ActivityLogging(Convert.ToInt32(mTBoxpersonnelID.Text), "LOGGED IN");
                    frmMain.PersonnelID = mTBoxpersonnelID.Text;
                    frmMain.Show();
                    this.Hide();
                }
                else
                    MetroMessageBox.Show(this, "Login Failed");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }
        private void SlidingEffect()
        {
         
            X1 -= 1;
            X2 -= 1;
            if (f)
            {
                if (X1 + pictureBox1.Width < 0)
                {
                    X1 = panel4.Width;
                    pictureBox1.Image = arrImage[0];
                    f = false;
                }
            }
            if (!f)
            {
                if (X2 + pictureBox4.Width < 0)
                {
                    X2 = panel4.Width;
                    f = true;

                    if (b == true)
                    {
                        pictureBox4.Image = arrImage[2];
                        b = false;
                    }
                    if(b == false)
                    {
                        pictureBox4.Image = arrImage[1];  
                        b = true;
                    }
                }
            }

            pictureBox1.Location = new Point(X1, 0);
            pictureBox4.Location = new Point(X2, 0);

        }

        private void timerPanel_Tick(object sender, EventArgs e)
        {
            SlidingEffect();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
