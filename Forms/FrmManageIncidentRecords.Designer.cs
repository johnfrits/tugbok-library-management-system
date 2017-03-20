namespace MPosInfoManagementSystem
{
    partial class FrmManageIncidentRecord
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroComboBoxSby = new MetroFramework.Controls.MetroComboBox();
            this.metroTextBoxSearchWord = new MetroFramework.Controls.MetroTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.metroGridIncident = new MetroFramework.Controls.MetroGrid();
            this.buttonSearchRecNo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.metroButtonRefresh = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridIncident)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.metroButton1.ForeColor = System.Drawing.Color.Orange;
            this.metroButton1.Location = new System.Drawing.Point(561, 111);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(172, 34);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "ADD NEW INCIDENT RECORD";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroComboBoxSby
            // 
            this.metroComboBoxSby.FormattingEnabled = true;
            this.metroComboBoxSby.ItemHeight = 23;
            this.metroComboBoxSby.Items.AddRange(new object[] {
            "Entry Number",
            "Incident/Crime"});
            this.metroComboBoxSby.Location = new System.Drawing.Point(56, 111);
            this.metroComboBoxSby.Name = "metroComboBoxSby";
            this.metroComboBoxSby.Size = new System.Drawing.Size(121, 29);
            this.metroComboBoxSby.TabIndex = 8;
            this.metroComboBoxSby.UseSelectable = true;
            // 
            // metroTextBoxSearchWord
            // 
            this.metroTextBoxSearchWord.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxSearchWord.Lines = new string[0];
            this.metroTextBoxSearchWord.Location = new System.Drawing.Point(181, 111);
            this.metroTextBoxSearchWord.MaxLength = 32767;
            this.metroTextBoxSearchWord.Multiline = true;
            this.metroTextBoxSearchWord.Name = "metroTextBoxSearchWord";
            this.metroTextBoxSearchWord.PasswordChar = '\0';
            this.metroTextBoxSearchWord.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxSearchWord.SelectedText = "";
            this.metroTextBoxSearchWord.Size = new System.Drawing.Size(159, 29);
            this.metroTextBoxSearchWord.TabIndex = 6;
            this.metroTextBoxSearchWord.UseSelectable = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Location = new System.Drawing.Point(0, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 557);
            this.panel2.TabIndex = 149;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "*Double click row to view full Information";
            // 
            // metroGridIncident
            // 
            this.metroGridIncident.AllowUserToAddRows = false;
            this.metroGridIncident.AllowUserToDeleteRows = false;
            this.metroGridIncident.AllowUserToResizeRows = false;
            this.metroGridIncident.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.metroGridIncident.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridIncident.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridIncident.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridIncident.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridIncident.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridIncident.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridIncident.EnableHeadersVisualStyles = false;
            this.metroGridIncident.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridIncident.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridIncident.Location = new System.Drawing.Point(56, 170);
            this.metroGridIncident.Name = "metroGridIncident";
            this.metroGridIncident.ReadOnly = true;
            this.metroGridIncident.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridIncident.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridIncident.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.metroGridIncident.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridIncident.Size = new System.Drawing.Size(855, 366);
            this.metroGridIncident.TabIndex = 0;
            this.metroGridIncident.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridIncident_CellDoubleClick);
            // 
            // buttonSearchRecNo
            // 
            this.buttonSearchRecNo.BackgroundImage = global::MPosInfoManagementSystem.Properties.Resources.magnifying7;
            this.buttonSearchRecNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearchRecNo.Location = new System.Drawing.Point(341, 111);
            this.buttonSearchRecNo.Name = "buttonSearchRecNo";
            this.buttonSearchRecNo.Size = new System.Drawing.Size(27, 29);
            this.buttonSearchRecNo.TabIndex = 7;
            this.buttonSearchRecNo.UseVisualStyleBackColor = true;
            this.buttonSearchRecNo.Click += new System.EventHandler(this.buttonSearchRecNo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(53, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 151;
            this.label1.Text = "Search by: ";
            // 
            // metroButtonRefresh
            // 
            this.metroButtonRefresh.BackColor = System.Drawing.Color.DarkSlateGray;
            this.metroButtonRefresh.ForeColor = System.Drawing.Color.Orange;
            this.metroButtonRefresh.Location = new System.Drawing.Point(739, 111);
            this.metroButtonRefresh.Name = "metroButtonRefresh";
            this.metroButtonRefresh.Size = new System.Drawing.Size(172, 34);
            this.metroButtonRefresh.TabIndex = 152;
            this.metroButtonRefresh.Text = "REFRESH";
            this.metroButtonRefresh.UseCustomBackColor = true;
            this.metroButtonRefresh.UseCustomForeColor = true;
            this.metroButtonRefresh.UseSelectable = true;
            this.metroButtonRefresh.Click += new System.EventHandler(this.metroButtonRefresh_Click);
            // 
            // FrmManageIncidentRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 559);
            this.Controls.Add(this.metroButtonRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroGridIncident);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.metroComboBoxSby);
            this.Controls.Add(this.buttonSearchRecNo);
            this.Controls.Add(this.metroTextBoxSearchWord);
            this.Controls.Add(this.metroButton1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "FrmManageIncidentRecord";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "INCIDENT RECORDS";
            this.Load += new System.EventHandler(this.FrmManageIncidentRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridIncident)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroComboBox metroComboBoxSby;
        private System.Windows.Forms.Button buttonSearchRecNo;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSearchWord;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroGrid metroGridIncident;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton metroButtonRefresh;
    }
}