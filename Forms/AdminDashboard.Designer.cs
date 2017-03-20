namespace MPosInfoManagementSystem
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.metroTabPageChangePass = new MetroFramework.Controls.MetroTabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabelRetype = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxRe = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxOldPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxNewP = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelNewPassword = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroButtonAva = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxRetype = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxPersonneID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPageLogout = new MetroFramework.Controls.MetroTabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPageChangePass.SuspendLayout();
            this.panel1.SuspendLayout();
            this.metroTabControl.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // metroTabPageChangePass
            // 
            this.metroTabPageChangePass.Controls.Add(this.panel1);
            this.metroTabPageChangePass.HorizontalScrollbarBarColor = true;
            this.metroTabPageChangePass.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageChangePass.HorizontalScrollbarSize = 10;
            this.metroTabPageChangePass.Location = new System.Drawing.Point(4, 41);
            this.metroTabPageChangePass.Name = "metroTabPageChangePass";
            this.metroTabPageChangePass.Size = new System.Drawing.Size(689, 346);
            this.metroTabPageChangePass.TabIndex = 2;
            this.metroTabPageChangePass.Text = "Change Password";
            this.metroTabPageChangePass.VerticalScrollbarBarColor = true;
            this.metroTabPageChangePass.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageChangePass.VerticalScrollbarSize = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroButton1);
            this.panel1.Controls.Add(this.metroLabelRetype);
            this.panel1.Controls.Add(this.metroTextBoxRe);
            this.panel1.Controls.Add(this.metroTextBoxOldPassword);
            this.panel1.Controls.Add(this.metroLabel7);
            this.panel1.Controls.Add(this.metroTextBoxNewP);
            this.panel1.Controls.Add(this.metroLabelNewPassword);
            this.panel1.Location = new System.Drawing.Point(58, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 225);
            this.panel1.TabIndex = 15;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.metroButton1.ForeColor = System.Drawing.Color.Orange;
            this.metroButton1.Location = new System.Drawing.Point(273, 188);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(106, 23);
            this.metroButton1.TabIndex = 15;
            this.metroButton1.Text = "Change Password";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabelRetype
            // 
            this.metroLabelRetype.AutoSize = true;
            this.metroLabelRetype.BackColor = System.Drawing.Color.Transparent;
            this.metroLabelRetype.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelRetype.Location = new System.Drawing.Point(201, 125);
            this.metroLabelRetype.Name = "metroLabelRetype";
            this.metroLabelRetype.Size = new System.Drawing.Size(113, 19);
            this.metroLabelRetype.TabIndex = 13;
            this.metroLabelRetype.Text = "Retype Password";
            this.metroLabelRetype.UseCustomBackColor = true;
            // 
            // metroTextBoxRe
            // 
            this.metroTextBoxRe.Lines = new string[0];
            this.metroTextBoxRe.Location = new System.Drawing.Point(201, 147);
            this.metroTextBoxRe.MaxLength = 32767;
            this.metroTextBoxRe.Name = "metroTextBoxRe";
            this.metroTextBoxRe.PasswordChar = '●';
            this.metroTextBoxRe.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxRe.SelectedText = "";
            this.metroTextBoxRe.Size = new System.Drawing.Size(178, 23);
            this.metroTextBoxRe.TabIndex = 14;
            this.metroTextBoxRe.UseSelectable = true;
            this.metroTextBoxRe.UseSystemPasswordChar = true;
            // 
            // metroTextBoxOldPassword
            // 
            this.metroTextBoxOldPassword.Lines = new string[0];
            this.metroTextBoxOldPassword.Location = new System.Drawing.Point(201, 51);
            this.metroTextBoxOldPassword.MaxLength = 32767;
            this.metroTextBoxOldPassword.Name = "metroTextBoxOldPassword";
            this.metroTextBoxOldPassword.PasswordChar = '\0';
            this.metroTextBoxOldPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxOldPassword.SelectedText = "";
            this.metroTextBoxOldPassword.Size = new System.Drawing.Size(178, 23);
            this.metroTextBoxOldPassword.TabIndex = 9;
            this.metroTextBoxOldPassword.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(201, 29);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(93, 19);
            this.metroLabel7.TabIndex = 10;
            this.metroLabel7.Text = "Old Password";
            this.metroLabel7.UseCustomBackColor = true;
            // 
            // metroTextBoxNewP
            // 
            this.metroTextBoxNewP.Lines = new string[0];
            this.metroTextBoxNewP.Location = new System.Drawing.Point(201, 99);
            this.metroTextBoxNewP.MaxLength = 32767;
            this.metroTextBoxNewP.Name = "metroTextBoxNewP";
            this.metroTextBoxNewP.PasswordChar = '●';
            this.metroTextBoxNewP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxNewP.SelectedText = "";
            this.metroTextBoxNewP.Size = new System.Drawing.Size(178, 23);
            this.metroTextBoxNewP.TabIndex = 12;
            this.metroTextBoxNewP.UseSelectable = true;
            this.metroTextBoxNewP.UseSystemPasswordChar = true;
            // 
            // metroLabelNewPassword
            // 
            this.metroLabelNewPassword.AutoSize = true;
            this.metroLabelNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.metroLabelNewPassword.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelNewPassword.Location = new System.Drawing.Point(201, 77);
            this.metroLabelNewPassword.Name = "metroLabelNewPassword";
            this.metroLabelNewPassword.Size = new System.Drawing.Size(98, 19);
            this.metroLabelNewPassword.TabIndex = 11;
            this.metroLabelNewPassword.Text = "New Password";
            this.metroLabelNewPassword.UseCustomBackColor = true;
            // 
            // metroTabControl
            // 
            this.metroTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControl.Controls.Add(this.metroTabPageChangePass);
            this.metroTabControl.Controls.Add(this.metroTabPage1);
            this.metroTabControl.Controls.Add(this.metroTabPageLogout);
            this.metroTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.metroTabControl.Location = new System.Drawing.Point(23, 75);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.SelectedIndex = 0;
            this.metroTabControl.Size = new System.Drawing.Size(697, 391);
            this.metroTabControl.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTabControl.TabIndex = 1;
            this.metroTabControl.UseSelectable = true;
            this.metroTabControl.Click += new System.EventHandler(this.metroTabControl1_Click);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.panel3);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(689, 346);
            this.metroTabPage1.TabIndex = 5;
            this.metroTabPage1.Text = "Add New User";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.metroButtonAva);
            this.panel3.Controls.Add(this.metroButton2);
            this.panel3.Controls.Add(this.metroLabel2);
            this.panel3.Controls.Add(this.metroTextBoxRetype);
            this.panel3.Controls.Add(this.metroTextBoxPersonneID);
            this.panel3.Controls.Add(this.metroLabel3);
            this.panel3.Controls.Add(this.metroTextBoxPassword);
            this.panel3.Controls.Add(this.metroLabel4);
            this.panel3.Location = new System.Drawing.Point(66, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(556, 225);
            this.panel3.TabIndex = 16;
            // 
            // metroButtonAva
            // 
            this.metroButtonAva.BackColor = System.Drawing.Color.DarkSlateGray;
            this.metroButtonAva.ForeColor = System.Drawing.Color.Orange;
            this.metroButtonAva.Location = new System.Drawing.Point(400, 36);
            this.metroButtonAva.Name = "metroButtonAva";
            this.metroButtonAva.Size = new System.Drawing.Size(106, 23);
            this.metroButtonAva.TabIndex = 16;
            this.metroButtonAva.Text = "Check Avaibility";
            this.metroButtonAva.UseCustomBackColor = true;
            this.metroButtonAva.UseCustomForeColor = true;
            this.metroButtonAva.UseSelectable = true;
            this.metroButtonAva.Click += new System.EventHandler(this.metroButtonAva_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.metroButton2.ForeColor = System.Drawing.Color.Orange;
            this.metroButton2.Location = new System.Drawing.Point(292, 171);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(106, 23);
            this.metroButton2.TabIndex = 15;
            this.metroButton2.Text = "Add User";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseCustomForeColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(101, 128);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(113, 19);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "Retype Password";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // metroTextBoxRetype
            // 
            this.metroTextBoxRetype.Lines = new string[0];
            this.metroTextBoxRetype.Location = new System.Drawing.Point(220, 124);
            this.metroTextBoxRetype.MaxLength = 32767;
            this.metroTextBoxRetype.Name = "metroTextBoxRetype";
            this.metroTextBoxRetype.PasswordChar = '●';
            this.metroTextBoxRetype.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxRetype.SelectedText = "";
            this.metroTextBoxRetype.Size = new System.Drawing.Size(178, 23);
            this.metroTextBoxRetype.TabIndex = 14;
            this.metroTextBoxRetype.UseSelectable = true;
            this.metroTextBoxRetype.UseSystemPasswordChar = true;
            // 
            // metroTextBoxPersonneID
            // 
            this.metroTextBoxPersonneID.Lines = new string[0];
            this.metroTextBoxPersonneID.Location = new System.Drawing.Point(220, 36);
            this.metroTextBoxPersonneID.MaxLength = 32767;
            this.metroTextBoxPersonneID.Name = "metroTextBoxPersonneID";
            this.metroTextBoxPersonneID.PasswordChar = '\0';
            this.metroTextBoxPersonneID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPersonneID.SelectedText = "";
            this.metroTextBoxPersonneID.Size = new System.Drawing.Size(178, 23);
            this.metroTextBoxPersonneID.TabIndex = 9;
            this.metroTextBoxPersonneID.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(131, 40);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(83, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "PersonnelID";
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // metroTextBoxPassword
            // 
            this.metroTextBoxPassword.Lines = new string[0];
            this.metroTextBoxPassword.Location = new System.Drawing.Point(220, 79);
            this.metroTextBoxPassword.MaxLength = 32767;
            this.metroTextBoxPassword.Name = "metroTextBoxPassword";
            this.metroTextBoxPassword.PasswordChar = '●';
            this.metroTextBoxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPassword.SelectedText = "";
            this.metroTextBoxPassword.Size = new System.Drawing.Size(178, 23);
            this.metroTextBoxPassword.TabIndex = 12;
            this.metroTextBoxPassword.UseSelectable = true;
            this.metroTextBoxPassword.UseSystemPasswordChar = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(147, 83);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(67, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Password";
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // metroTabPageLogout
            // 
            this.metroTabPageLogout.HorizontalScrollbarBarColor = true;
            this.metroTabPageLogout.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageLogout.HorizontalScrollbarSize = 10;
            this.metroTabPageLogout.Location = new System.Drawing.Point(4, 41);
            this.metroTabPageLogout.Name = "metroTabPageLogout";
            this.metroTabPageLogout.Size = new System.Drawing.Size(689, 346);
            this.metroTabPageLogout.TabIndex = 4;
            this.metroTabPageLogout.Text = "Log out";
            this.metroTabPageLogout.VerticalScrollbarBarColor = true;
            this.metroTabPageLogout.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageLogout.VerticalScrollbarSize = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Location = new System.Drawing.Point(0, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 484);
            this.panel2.TabIndex = 148;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(396, 37);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(0, 0);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 489);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.metroTabControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "AdminDashboard";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.metroTabPageChangePass.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.metroTabControl.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroTabPage metroTabPageChangePass;
        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabelRetype;
        private MetroFramework.Controls.MetroTextBox metroTextBoxRe;
        private MetroFramework.Controls.MetroTextBox metroTextBoxOldPassword;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox metroTextBoxNewP;
        private MetroFramework.Controls.MetroLabel metroLabelNewPassword;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTabPage metroTabPageLogout;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBoxRetype;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPersonneID;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPassword;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton metroButtonAva;

    }
}