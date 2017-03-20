namespace MPosInfoManagementSystem
{
    partial class FrmBlotterReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTextBoxFinalNarrative = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonEdit = new MetroFramework.Controls.MetroButton();
            this.metroButtonSave = new MetroFramework.Controls.MetroButton();
            this.metroButtonPrint = new MetroFramework.Controls.MetroButton();
            this.metroGridNarrative = new MetroFramework.Controls.MetroGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSearchRecNo = new System.Windows.Forms.Button();
            this.metroLabelen = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridNarrative)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTextBoxFinalNarrative
            // 
            this.metroTextBoxFinalNarrative.Lines = new string[0];
            this.metroTextBoxFinalNarrative.Location = new System.Drawing.Point(169, 127);
            this.metroTextBoxFinalNarrative.MaxLength = 32767;
            this.metroTextBoxFinalNarrative.Multiline = true;
            this.metroTextBoxFinalNarrative.Name = "metroTextBoxFinalNarrative";
            this.metroTextBoxFinalNarrative.PasswordChar = '\0';
            this.metroTextBoxFinalNarrative.ReadOnly = true;
            this.metroTextBoxFinalNarrative.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxFinalNarrative.SelectedText = "";
            this.metroTextBoxFinalNarrative.Size = new System.Drawing.Size(661, 402);
            this.metroTextBoxFinalNarrative.TabIndex = 0;
            this.metroTextBoxFinalNarrative.UseSelectable = true;
            this.metroTextBoxFinalNarrative.KeyDown += new System.Windows.Forms.KeyEventHandler(this.metroTextBoxFinalNarrative_KeyDown);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(22, 65);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(140, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Blotter Entry Number";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // metroTextBoxSearch
            // 
            this.metroTextBoxSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroTextBoxSearch.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroTextBoxSearch.Lines = new string[0];
            this.metroTextBoxSearch.Location = new System.Drawing.Point(164, 60);
            this.metroTextBoxSearch.MaxLength = 32767;
            this.metroTextBoxSearch.Multiline = true;
            this.metroTextBoxSearch.Name = "metroTextBoxSearch";
            this.metroTextBoxSearch.PasswordChar = '\0';
            this.metroTextBoxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxSearch.SelectedText = "";
            this.metroTextBoxSearch.Size = new System.Drawing.Size(106, 24);
            this.metroTextBoxSearch.TabIndex = 4;
            this.metroTextBoxSearch.UseCustomBackColor = true;
            this.metroTextBoxSearch.UseCustomForeColor = true;
            this.metroTextBoxSearch.UseSelectable = true;
            // 
            // metroButtonEdit
            // 
            this.metroButtonEdit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.metroButtonEdit.ForeColor = System.Drawing.Color.Orange;
            this.metroButtonEdit.Location = new System.Drawing.Point(593, 98);
            this.metroButtonEdit.Name = "metroButtonEdit";
            this.metroButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.metroButtonEdit.TabIndex = 7;
            this.metroButtonEdit.Text = "EDIT";
            this.metroButtonEdit.UseCustomBackColor = true;
            this.metroButtonEdit.UseCustomForeColor = true;
            this.metroButtonEdit.UseSelectable = true;
            this.metroButtonEdit.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButtonSave
            // 
            this.metroButtonSave.BackColor = System.Drawing.Color.DarkSlateGray;
            this.metroButtonSave.ForeColor = System.Drawing.Color.Orange;
            this.metroButtonSave.Location = new System.Drawing.Point(674, 98);
            this.metroButtonSave.Name = "metroButtonSave";
            this.metroButtonSave.Size = new System.Drawing.Size(75, 23);
            this.metroButtonSave.TabIndex = 9;
            this.metroButtonSave.Text = "SAVE";
            this.metroButtonSave.UseCustomBackColor = true;
            this.metroButtonSave.UseCustomForeColor = true;
            this.metroButtonSave.UseSelectable = true;
            this.metroButtonSave.Click += new System.EventHandler(this.metroButtonSave_Click);
            // 
            // metroButtonPrint
            // 
            this.metroButtonPrint.BackColor = System.Drawing.Color.DarkSlateGray;
            this.metroButtonPrint.ForeColor = System.Drawing.Color.Orange;
            this.metroButtonPrint.Location = new System.Drawing.Point(755, 98);
            this.metroButtonPrint.Name = "metroButtonPrint";
            this.metroButtonPrint.Size = new System.Drawing.Size(75, 23);
            this.metroButtonPrint.TabIndex = 10;
            this.metroButtonPrint.Text = "EXPORT";
            this.metroButtonPrint.UseCustomBackColor = true;
            this.metroButtonPrint.UseCustomForeColor = true;
            this.metroButtonPrint.UseSelectable = true;
            this.metroButtonPrint.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroGridNarrative
            // 
            this.metroGridNarrative.AllowUserToAddRows = false;
            this.metroGridNarrative.AllowUserToDeleteRows = false;
            this.metroGridNarrative.AllowUserToResizeRows = false;
            this.metroGridNarrative.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridNarrative.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridNarrative.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridNarrative.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridNarrative.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGridNarrative.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridNarrative.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGridNarrative.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGridNarrative.EnableHeadersVisualStyles = false;
            this.metroGridNarrative.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridNarrative.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridNarrative.Location = new System.Drawing.Point(0, 0);
            this.metroGridNarrative.Name = "metroGridNarrative";
            this.metroGridNarrative.ReadOnly = true;
            this.metroGridNarrative.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridNarrative.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGridNarrative.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridNarrative.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridNarrative.Size = new System.Drawing.Size(145, 400);
            this.metroGridNarrative.TabIndex = 11;
            this.metroGridNarrative.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroGridNarrative.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridNarrative_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Location = new System.Drawing.Point(0, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 559);
            this.panel2.TabIndex = 149;
            // 
            // buttonSearchRecNo
            // 
            this.buttonSearchRecNo.BackgroundImage = global::MPosInfoManagementSystem.Properties.Resources.magnifying7;
            this.buttonSearchRecNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearchRecNo.Location = new System.Drawing.Point(273, 60);
            this.buttonSearchRecNo.Name = "buttonSearchRecNo";
            this.buttonSearchRecNo.Size = new System.Drawing.Size(27, 24);
            this.buttonSearchRecNo.TabIndex = 8;
            this.buttonSearchRecNo.UseVisualStyleBackColor = true;
            this.buttonSearchRecNo.Click += new System.EventHandler(this.buttonSearchRecNo_Click);
            // 
            // metroLabelen
            // 
            this.metroLabelen.AutoSize = true;
            this.metroLabelen.BackColor = System.Drawing.Color.Transparent;
            this.metroLabelen.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelen.Location = new System.Drawing.Point(309, 106);
            this.metroLabelen.Name = "metroLabelen";
            this.metroLabelen.Size = new System.Drawing.Size(0, 0);
            this.metroLabelen.TabIndex = 150;
            this.metroLabelen.UseCustomBackColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(165, 105);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(143, 19);
            this.metroLabel2.TabIndex = 151;
            this.metroLabel2.Text = "Blotter Entry Number:";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.metroGridNarrative);
            this.panel1.Location = new System.Drawing.Point(16, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 402);
            this.panel1.TabIndex = 152;
            // 
            // FrmBlotterReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabelen);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.metroButtonPrint);
            this.Controls.Add(this.metroButtonSave);
            this.Controls.Add(this.buttonSearchRecNo);
            this.Controls.Add(this.metroButtonEdit);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTextBoxSearch);
            this.Controls.Add(this.metroTextBoxFinalNarrative);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "FrmBlotterReport";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Blotter Reports";
            this.Load += new System.EventHandler(this.FrmBlotterReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridNarrative)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBoxFinalNarrative;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSearch;
        private MetroFramework.Controls.MetroButton metroButtonEdit;
        private System.Windows.Forms.Button buttonSearchRecNo;
        private MetroFramework.Controls.MetroButton metroButtonSave;
        private MetroFramework.Controls.MetroButton metroButtonPrint;
        private MetroFramework.Controls.MetroGrid metroGridNarrative;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel metroLabelen;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Panel panel1;
    }
}