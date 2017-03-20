namespace MPosInfoManagementSystem
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelPersonelName = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.timerPanelMovement = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timerPanelAdmin = new System.Windows.Forms.Timer(this.components);
            this.metroPanelMain = new System.Windows.Forms.Panel();
            this.labelRank = new System.Windows.Forms.Label();
            this.pictureBoxPersonnel = new System.Windows.Forms.PictureBox();
            this.metroTileStatisticalReports = new MetroFramework.Controls.MetroTile();
            this.metroTileLogging = new MetroFramework.Controls.MetroTile();
            this.metroTileAddIncident = new MetroFramework.Controls.MetroTile();
            this.metroTileManagePersonnel = new MetroFramework.Controls.MetroTile();
            this.metroBlotterReports = new MetroFramework.Controls.MetroTile();
            this.metroTileAddNewDetainee = new MetroFramework.Controls.MetroTile();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPersonnel)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Orange;
            this.panel4.Location = new System.Drawing.Point(8, -4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 58);
            this.panel4.TabIndex = 149;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Orange;
            this.panel3.Location = new System.Drawing.Point(35, -4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 58);
            this.panel3.TabIndex = 148;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Location = new System.Drawing.Point(21, -4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 58);
            this.panel2.TabIndex = 147;
            // 
            // labelPersonelName
            // 
            this.labelPersonelName.AutoSize = true;
            this.labelPersonelName.BackColor = System.Drawing.Color.Transparent;
            this.labelPersonelName.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPersonelName.ForeColor = System.Drawing.Color.Orange;
            this.labelPersonelName.Location = new System.Drawing.Point(101, 27);
            this.labelPersonelName.Name = "labelPersonelName";
            this.labelPersonelName.Size = new System.Drawing.Size(177, 25);
            this.labelPersonelName.TabIndex = 4;
            this.labelPersonelName.Text = "REJABA, JOHNFRITS";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F);
            this.labelTime.ForeColor = System.Drawing.Color.Orange;
            this.labelTime.Location = new System.Drawing.Point(1037, 15);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(26, 25);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "w";
            this.labelTime.Click += new System.EventHandler(this.labelTime_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F);
            this.labelDate.ForeColor = System.Drawing.Color.Orange;
            this.labelDate.Location = new System.Drawing.Point(752, 15);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(26, 25);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "w";
            // 
            // timerPanelMovement
            // 
            this.timerPanelMovement.Enabled = true;
            this.timerPanelMovement.Interval = 1;
            this.timerPanelMovement.Tick += new System.EventHandler(this.timerPanelMovement_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(14, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hello Admin!";
            this.label2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroPanel2_MouseClick);
            this.label2.MouseLeave += new System.EventHandler(this.metroPanel2_MouseLeave);
            this.label2.MouseHover += new System.EventHandler(this.metroPanel2_MouseHover);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroPanel2.Controls.Add(this.pictureBox1);
            this.metroPanel2.Controls.Add(this.label2);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(968, 26);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(182, 62);
            this.metroPanel2.TabIndex = 0;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            this.metroPanel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroPanel2_MouseClick);
            this.metroPanel2.MouseLeave += new System.EventHandler(this.metroPanel2_MouseLeave);
            this.metroPanel2.MouseHover += new System.EventHandler(this.metroPanel2_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MPosInfoManagementSystem.Properties.Resources.policeman1;
            this.pictureBox1.Location = new System.Drawing.Point(126, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroPanel2_MouseClick);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.metroPanel2_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.metroPanel2_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(119, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 65);
            this.label1.TabIndex = 5;
            this.label1.Text = "Menu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Location = new System.Drawing.Point(0, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 623);
            this.panel1.TabIndex = 146;
            // 
            // timerPanelAdmin
            // 
            this.timerPanelAdmin.Interval = 1;
            this.timerPanelAdmin.Tick += new System.EventHandler(this.timerPanelAdmin_Tick);
            // 
            // metroPanelMain
            // 
            this.metroPanelMain.BackColor = System.Drawing.Color.DarkSlateGray;
            this.metroPanelMain.Controls.Add(this.labelRank);
            this.metroPanelMain.Controls.Add(this.panel4);
            this.metroPanelMain.Controls.Add(this.panel2);
            this.metroPanelMain.Controls.Add(this.labelTime);
            this.metroPanelMain.Controls.Add(this.labelPersonelName);
            this.metroPanelMain.Controls.Add(this.labelDate);
            this.metroPanelMain.Controls.Add(this.pictureBoxPersonnel);
            this.metroPanelMain.Controls.Add(this.panel3);
            this.metroPanelMain.Location = new System.Drawing.Point(0, 549);
            this.metroPanelMain.Name = "metroPanelMain";
            this.metroPanelMain.Size = new System.Drawing.Size(1191, 55);
            this.metroPanelMain.TabIndex = 147;
            // 
            // labelRank
            // 
            this.labelRank.AutoSize = true;
            this.labelRank.BackColor = System.Drawing.Color.Transparent;
            this.labelRank.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRank.ForeColor = System.Drawing.Color.Orange;
            this.labelRank.Location = new System.Drawing.Point(101, 5);
            this.labelRank.Name = "labelRank";
            this.labelRank.Size = new System.Drawing.Size(140, 25);
            this.labelRank.TabIndex = 150;
            this.labelRank.Text = "Police Officer 1";
            // 
            // pictureBoxPersonnel
            // 
            this.pictureBoxPersonnel.Location = new System.Drawing.Point(50, 5);
            this.pictureBoxPersonnel.Name = "pictureBoxPersonnel";
            this.pictureBoxPersonnel.Size = new System.Drawing.Size(48, 47);
            this.pictureBoxPersonnel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPersonnel.TabIndex = 147;
            this.pictureBoxPersonnel.TabStop = false;
            // 
            // metroTileStatisticalReports
            // 
            this.metroTileStatisticalReports.ActiveControl = null;
            this.metroTileStatisticalReports.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTileStatisticalReports.BackColor = System.Drawing.Color.DarkSlateGray;
            this.metroTileStatisticalReports.ForeColor = System.Drawing.Color.White;
            this.metroTileStatisticalReports.Location = new System.Drawing.Point(723, 313);
            this.metroTileStatisticalReports.Name = "metroTileStatisticalReports";
            this.metroTileStatisticalReports.Size = new System.Drawing.Size(242, 148);
            this.metroTileStatisticalReports.TabIndex = 6;
            this.metroTileStatisticalReports.Text = "Statistical Reports";
            this.metroTileStatisticalReports.TileImage = global::MPosInfoManagementSystem.Properties.Resources.statistics12;
            this.metroTileStatisticalReports.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileStatisticalReports.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileStatisticalReports.UseCustomBackColor = true;
            this.metroTileStatisticalReports.UseCustomForeColor = true;
            this.metroTileStatisticalReports.UseSelectable = true;
            this.metroTileStatisticalReports.UseTileImage = true;
            this.metroTileStatisticalReports.Click += new System.EventHandler(this.metroTileStatisticalReports_Click);
            this.metroTileStatisticalReports.MouseLeave += new System.EventHandler(this.metroTileStatisticalReports_MouseLeave);
            this.metroTileStatisticalReports.MouseHover += new System.EventHandler(this.metroTileStatisticalReports_MouseHover);
            // 
            // metroTileLogging
            // 
            this.metroTileLogging.ActiveControl = null;
            this.metroTileLogging.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTileLogging.BackColor = System.Drawing.Color.DarkSlateGray;
            this.metroTileLogging.ForeColor = System.Drawing.Color.White;
            this.metroTileLogging.Location = new System.Drawing.Point(723, 158);
            this.metroTileLogging.Name = "metroTileLogging";
            this.metroTileLogging.Size = new System.Drawing.Size(242, 148);
            this.metroTileLogging.TabIndex = 5;
            this.metroTileLogging.Text = "Activity Logging";
            this.metroTileLogging.TileImage = global::MPosInfoManagementSystem.Properties.Resources.log2;
            this.metroTileLogging.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileLogging.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileLogging.UseCustomBackColor = true;
            this.metroTileLogging.UseCustomForeColor = true;
            this.metroTileLogging.UseSelectable = true;
            this.metroTileLogging.UseTileImage = true;
            this.metroTileLogging.Click += new System.EventHandler(this.metroTileLogging_Click);
            this.metroTileLogging.MouseLeave += new System.EventHandler(this.metroTileLogging_MouseLeave);
            this.metroTileLogging.MouseHover += new System.EventHandler(this.metroTileLogging_MouseHover);
            // 
            // metroTileAddIncident
            // 
            this.metroTileAddIncident.ActiveControl = null;
            this.metroTileAddIncident.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTileAddIncident.BackColor = System.Drawing.Color.DarkSlateGray;
            this.metroTileAddIncident.ForeColor = System.Drawing.Color.White;
            this.metroTileAddIncident.Location = new System.Drawing.Point(227, 159);
            this.metroTileAddIncident.Name = "metroTileAddIncident";
            this.metroTileAddIncident.Size = new System.Drawing.Size(242, 148);
            this.metroTileAddIncident.TabIndex = 1;
            this.metroTileAddIncident.Text = "Manage Incident Record";
            this.metroTileAddIncident.TileImage = global::MPosInfoManagementSystem.Properties.Resources._4;
            this.metroTileAddIncident.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAddIncident.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileAddIncident.UseCustomBackColor = true;
            this.metroTileAddIncident.UseCustomForeColor = true;
            this.metroTileAddIncident.UseSelectable = true;
            this.metroTileAddIncident.UseTileImage = true;
            this.metroTileAddIncident.Click += new System.EventHandler(this.metroTileAddIncident_Click);
            this.metroTileAddIncident.MouseLeave += new System.EventHandler(this.metroTileAddIncident_MouseLeave);
            this.metroTileAddIncident.MouseHover += new System.EventHandler(this.metroTileAddIncident_MouseHover);
            // 
            // metroTileManagePersonnel
            // 
            this.metroTileManagePersonnel.ActiveControl = null;
            this.metroTileManagePersonnel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTileManagePersonnel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.metroTileManagePersonnel.ForeColor = System.Drawing.Color.White;
            this.metroTileManagePersonnel.Location = new System.Drawing.Point(475, 313);
            this.metroTileManagePersonnel.Name = "metroTileManagePersonnel";
            this.metroTileManagePersonnel.Size = new System.Drawing.Size(242, 148);
            this.metroTileManagePersonnel.TabIndex = 4;
            this.metroTileManagePersonnel.Text = "Manage Personnel";
            this.metroTileManagePersonnel.TileImage = global::MPosInfoManagementSystem.Properties.Resources.policeman1__1_;
            this.metroTileManagePersonnel.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileManagePersonnel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileManagePersonnel.UseCustomBackColor = true;
            this.metroTileManagePersonnel.UseCustomForeColor = true;
            this.metroTileManagePersonnel.UseSelectable = true;
            this.metroTileManagePersonnel.UseTileImage = true;
            this.metroTileManagePersonnel.Click += new System.EventHandler(this.metroTileManagePersonnel_Click);
            this.metroTileManagePersonnel.MouseLeave += new System.EventHandler(this.metroTileManagePersonnel_MouseLeave);
            this.metroTileManagePersonnel.MouseHover += new System.EventHandler(this.metroTileManagePersonnel_MouseHover);
            // 
            // metroBlotterReports
            // 
            this.metroBlotterReports.ActiveControl = null;
            this.metroBlotterReports.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroBlotterReports.BackColor = System.Drawing.Color.DarkSlateGray;
            this.metroBlotterReports.ForeColor = System.Drawing.Color.White;
            this.metroBlotterReports.Location = new System.Drawing.Point(475, 159);
            this.metroBlotterReports.Name = "metroBlotterReports";
            this.metroBlotterReports.Size = new System.Drawing.Size(242, 148);
            this.metroBlotterReports.TabIndex = 3;
            this.metroBlotterReports.Text = "Blotter Reports";
            this.metroBlotterReports.TileImage = global::MPosInfoManagementSystem.Properties.Resources.t;
            this.metroBlotterReports.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroBlotterReports.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroBlotterReports.UseCustomBackColor = true;
            this.metroBlotterReports.UseCustomForeColor = true;
            this.metroBlotterReports.UseSelectable = true;
            this.metroBlotterReports.UseTileImage = true;
            this.metroBlotterReports.Click += new System.EventHandler(this.metroBlotterReports_Click);
            this.metroBlotterReports.MouseLeave += new System.EventHandler(this.metroBlotterReports_MouseLeave);
            this.metroBlotterReports.MouseHover += new System.EventHandler(this.metroBlotterReports_MouseHover);
            // 
            // metroTileAddNewDetainee
            // 
            this.metroTileAddNewDetainee.ActiveControl = null;
            this.metroTileAddNewDetainee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTileAddNewDetainee.BackColor = System.Drawing.Color.DarkSlateGray;
            this.metroTileAddNewDetainee.ForeColor = System.Drawing.Color.White;
            this.metroTileAddNewDetainee.Location = new System.Drawing.Point(227, 313);
            this.metroTileAddNewDetainee.Name = "metroTileAddNewDetainee";
            this.metroTileAddNewDetainee.Size = new System.Drawing.Size(242, 148);
            this.metroTileAddNewDetainee.TabIndex = 2;
            this.metroTileAddNewDetainee.Text = "Manage Detainee";
            this.metroTileAddNewDetainee.TileImage = global::MPosInfoManagementSystem.Properties.Resources.police19;
            this.metroTileAddNewDetainee.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAddNewDetainee.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileAddNewDetainee.UseCustomBackColor = true;
            this.metroTileAddNewDetainee.UseCustomForeColor = true;
            this.metroTileAddNewDetainee.UseSelectable = true;
            this.metroTileAddNewDetainee.UseTileImage = true;
            this.metroTileAddNewDetainee.Click += new System.EventHandler(this.metroTileAddNewDetainee_Click);
            this.metroTileAddNewDetainee.MouseLeave += new System.EventHandler(this.metroTileAddNewDetainee_MouseLeave);
            this.metroTileAddNewDetainee.MouseHover += new System.EventHandler(this.metroTileAddNewDetainee_MouseHover);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 627);
            this.Controls.Add(this.metroPanelMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroTileStatisticalReports);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroTileLogging);
            this.Controls.Add(this.metroTileAddIncident);
            this.Controls.Add(this.metroTileManagePersonnel);
            this.Controls.Add(this.metroBlotterReports);
            this.Controls.Add(this.metroTileAddNewDetainee);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "FrmMain";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseUp);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroPanelMain.ResumeLayout(false);
            this.metroPanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPersonnel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerPanelMovement;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTile metroBlotterReports;
        private MetroFramework.Controls.MetroTile metroTileAddNewDetainee;
        private MetroFramework.Controls.MetroTile metroTileManagePersonnel;
        private MetroFramework.Controls.MetroTile metroTileAddIncident;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTile metroTileStatisticalReports;
        private MetroFramework.Controls.MetroTile metroTileLogging;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPersonelName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxPersonnel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer timerPanelAdmin;
        private System.Windows.Forms.Panel metroPanelMain;
        private System.Windows.Forms.Label labelRank;

    }
}