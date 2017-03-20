namespace MPosInfoManagementSystem
{
    partial class FrmReleasedDetainee
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
            this.metroButtonReleased = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxReason = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroButtonReleased
            // 
            this.metroButtonReleased.Location = new System.Drawing.Point(333, 113);
            this.metroButtonReleased.Name = "metroButtonReleased";
            this.metroButtonReleased.Size = new System.Drawing.Size(131, 31);
            this.metroButtonReleased.TabIndex = 0;
            this.metroButtonReleased.Text = "Released";
            this.metroButtonReleased.UseSelectable = true;
            this.metroButtonReleased.Click += new System.EventHandler(this.metroButtonReleased_Click);
            // 
            // metroTextBoxReason
            // 
            this.metroTextBoxReason.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxReason.Lines = new string[0];
            this.metroTextBoxReason.Location = new System.Drawing.Point(25, 22);
            this.metroTextBoxReason.MaxLength = 32767;
            this.metroTextBoxReason.Multiline = true;
            this.metroTextBoxReason.Name = "metroTextBoxReason";
            this.metroTextBoxReason.PasswordChar = '\0';
            this.metroTextBoxReason.PromptText = "REASON OF RELEASING";
            this.metroTextBoxReason.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxReason.SelectedText = "";
            this.metroTextBoxReason.Size = new System.Drawing.Size(441, 84);
            this.metroTextBoxReason.TabIndex = 1;
            this.metroTextBoxReason.UseSelectable = true;
            // 
            // FrmReleasedDetainee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 148);
            this.Controls.Add(this.metroTextBoxReason);
            this.Controls.Add(this.metroButtonReleased);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "FrmReleasedDetainee";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Load += new System.EventHandler(this.FrmReleasedDetainee_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButtonReleased;
        private MetroFramework.Controls.MetroTextBox metroTextBoxReason;
    }
}