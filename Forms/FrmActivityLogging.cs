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
    public partial class FrmActivityLogging : MetroForm
    {
        SelectDeleteFunctions SF = new SelectDeleteFunctions();
      
        public FrmActivityLogging()
        {
            InitializeComponent();
        }

        private void FrmActivityLogging_Load(object sender, EventArgs e)
        {
            metroGrid1.DataSource = SF.GetActivityLogging();
        }
    }
}
