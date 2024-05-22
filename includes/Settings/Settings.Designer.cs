namespace LauncherSAMPInt
{
    partial class Settings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.differentLocationLabel = new System.Windows.Forms.Label();
            this.closeLabel = new System.Windows.Forms.Label();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.metroToggle2 = new MetroFramework.Controls.MetroToggle();
            this.differentLocationTextBox = new System.Windows.Forms.TextBox();
            this.differentLocationTextLabel = new System.Windows.Forms.Label();
            this.differentLocationButton = new System.Windows.Forms.Button();
            this.metroToggle3 = new MetroFramework.Controls.MetroToggle();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.changeColorLabel = new System.Windows.Forms.Label();
            this.darkModeLabel = new System.Windows.Forms.Label();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // differentLocationLabel
            // 
            this.differentLocationLabel.AutoSize = true;
            this.differentLocationLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.differentLocationLabel.Location = new System.Drawing.Point(57, 213);
            this.differentLocationLabel.Name = "differentLocationLabel";
            this.differentLocationLabel.Size = new System.Drawing.Size(301, 25);
            this.differentLocationLabel.TabIndex = 7;
            this.differentLocationLabel.Text = "Run GTA:SA on a different directory";
            // 
            // closeLabel
            // 
            this.closeLabel.AutoSize = true;
            this.closeLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeLabel.Location = new System.Drawing.Point(57, 173);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(343, 25);
            this.closeLabel.TabIndex = 8;
            this.closeLabel.Text = "Close this application during the connect";
            // 
            // metroToggle1
            // 
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroToggle1.Location = new System.Drawing.Point(717, 181);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(80, 17);
            this.metroToggle1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroToggle1.TabIndex = 9;
            this.metroToggle1.Text = "Off";
            this.metroToggle1.UseVisualStyleBackColor = true;
            this.metroToggle1.CheckedChanged += new System.EventHandler(this.ClosingToggle_CheckedChanged);
            // 
            // metroToggle2
            // 
            this.metroToggle2.AutoSize = true;
            this.metroToggle2.Checked = true;
            this.metroToggle2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroToggle2.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroToggle2.Location = new System.Drawing.Point(717, 221);
            this.metroToggle2.Name = "metroToggle2";
            this.metroToggle2.Size = new System.Drawing.Size(80, 17);
            this.metroToggle2.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroToggle2.TabIndex = 10;
            this.metroToggle2.Text = "On";
            this.metroToggle2.UseVisualStyleBackColor = true;
            this.metroToggle2.CheckedChanged += new System.EventHandler(this.LocationToggle_CheckedChanged);
            // 
            // differentLocationTextBox
            // 
            this.differentLocationTextBox.Enabled = false;
            this.differentLocationTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.differentLocationTextBox.Location = new System.Drawing.Point(62, 304);
            this.differentLocationTextBox.Name = "differentLocationTextBox";
            this.differentLocationTextBox.Size = new System.Drawing.Size(574, 27);
            this.differentLocationTextBox.TabIndex = 11;
            this.differentLocationTextBox.Visible = false;
            // 
            // differentLocationTextLabel
            // 
            this.differentLocationTextLabel.AutoSize = true;
            this.differentLocationTextLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.differentLocationTextLabel.Location = new System.Drawing.Point(57, 265);
            this.differentLocationTextLabel.Name = "differentLocationTextLabel";
            this.differentLocationTextLabel.Size = new System.Drawing.Size(228, 25);
            this.differentLocationTextLabel.TabIndex = 12;
            this.differentLocationTextLabel.Text = "GTA San Andreas Location";
            this.differentLocationTextLabel.Visible = false;
            // 
            // differentLocationButton
            // 
            this.differentLocationButton.BackColor = System.Drawing.Color.Teal;
            this.differentLocationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.differentLocationButton.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.differentLocationButton.ForeColor = System.Drawing.Color.Transparent;
            this.differentLocationButton.Location = new System.Drawing.Point(679, 298);
            this.differentLocationButton.Name = "differentLocationButton";
            this.differentLocationButton.Size = new System.Drawing.Size(118, 39);
            this.differentLocationButton.TabIndex = 13;
            this.differentLocationButton.Text = "Browse Folder";
            this.differentLocationButton.UseVisualStyleBackColor = false;
            this.differentLocationButton.Visible = false;
            this.differentLocationButton.Click += new System.EventHandler(this.BrowseLocation_Click);
            // 
            // metroToggle3
            // 
            this.metroToggle3.AutoSize = true;
            this.metroToggle3.Enabled = false;
            this.metroToggle3.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroToggle3.Location = new System.Drawing.Point(717, 99);
            this.metroToggle3.Name = "metroToggle3";
            this.metroToggle3.Size = new System.Drawing.Size(80, 17);
            this.metroToggle3.TabIndex = 17;
            this.metroToggle3.Text = "Off";
            this.metroToggle3.UseVisualStyleBackColor = true;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.Enabled = false;
            this.metroComboBox1.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 19;
            this.metroComboBox1.Location = new System.Drawing.Point(679, 137);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 25);
            this.metroComboBox1.TabIndex = 16;
            // 
            // changeColorLabel
            // 
            this.changeColorLabel.AutoSize = true;
            this.changeColorLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F);
            this.changeColorLabel.Location = new System.Drawing.Point(57, 131);
            this.changeColorLabel.Name = "changeColorLabel";
            this.changeColorLabel.Size = new System.Drawing.Size(121, 25);
            this.changeColorLabel.TabIndex = 15;
            this.changeColorLabel.Text = "Change color";
            // 
            // darkModeLabel
            // 
            this.darkModeLabel.AutoSize = true;
            this.darkModeLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F);
            this.darkModeLabel.Location = new System.Drawing.Point(57, 91);
            this.darkModeLabel.Name = "darkModeLabel";
            this.darkModeLabel.Size = new System.Drawing.Size(103, 25);
            this.darkModeLabel.TabIndex = 14;
            this.darkModeLabel.Text = "Dark mode";
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Font = new System.Drawing.Font("Segoe UI Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLabel.Location = new System.Drawing.Point(25, 19);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(135, 47);
            this.settingsLabel.TabIndex = 18;
            this.settingsLabel.Text = "Settings";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.settingsLabel);
            this.Controls.Add(this.metroToggle3);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.changeColorLabel);
            this.Controls.Add(this.darkModeLabel);
            this.Controls.Add(this.differentLocationButton);
            this.Controls.Add(this.differentLocationTextLabel);
            this.Controls.Add(this.differentLocationTextBox);
            this.Controls.Add(this.metroToggle2);
            this.Controls.Add(this.metroToggle1);
            this.Controls.Add(this.closeLabel);
            this.Controls.Add(this.differentLocationLabel);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(839, 407);
            this.Load += new System.EventHandler(this.Advanced_settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label differentLocationLabel;
        private System.Windows.Forms.Label closeLabel;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private MetroFramework.Controls.MetroToggle metroToggle2;
        private System.Windows.Forms.TextBox differentLocationTextBox;
        private System.Windows.Forms.Label differentLocationTextLabel;
        private System.Windows.Forms.Button differentLocationButton;
        private MetroFramework.Controls.MetroToggle metroToggle3;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.Label changeColorLabel;
        private System.Windows.Forms.Label darkModeLabel;
        private System.Windows.Forms.Label settingsLabel;
    }
}
