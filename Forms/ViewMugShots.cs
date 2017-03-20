using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MPosInfoManagementSystem
{
    public partial class ViewMugShots : Form
    {
        public ViewMugShots()
        {
            InitializeComponent();
        }
        Image l1;

        public Image L1
        {
            get { return l1; }
            set { l1 = value; }
        }
        Image f1;

        public Image F1
        {
            get { return f1; }
            set { f1 = value; }
        }
        Image r1;

        public Image R1
        {
            get { return r1; }
            set { r1 = value; }
        }

        private void ViewMugShots_Load(object sender, EventArgs e)
        {
            pictureBox3.Image = L1;
            pictureBox2.Image = F1;
            pictureBox1.Image = R1;
        }
    }
}
