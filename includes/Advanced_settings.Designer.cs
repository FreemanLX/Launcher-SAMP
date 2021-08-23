namespace LauncherSAMPInt
{
    partial class Advanced_settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Advanced_settings));
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.metroToggle2 = new MetroFramework.Controls.MetroToggle();
            this.button1 = new System.Windows.Forms.Button();
            this.TextLocation = new System.Windows.Forms.TextBox();
            this.LabelLocation = new System.Windows.Forms.Label();
            this.BrowseLocation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Advanced settings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(315, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Enable to use on a different directory";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(343, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Close this application during the connect";
            // 
            // metroToggle1
            // 
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroToggle1.Location = new System.Drawing.Point(717, 126);
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
            this.metroToggle2.Location = new System.Drawing.Point(717, 189);
            this.metroToggle2.Name = "metroToggle2";
            this.metroToggle2.Size = new System.Drawing.Size(80, 17);
            this.metroToggle2.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroToggle2.TabIndex = 10;
            this.metroToggle2.Text = "On";
            this.metroToggle2.UseVisualStyleBackColor = true;
            this.metroToggle2.CheckedChanged += new System.EventHandler(this.LocationToggle_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(20, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 54);
            this.button1.TabIndex = 3;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BackClick);
            // 
            // TextLocation
            // 
            this.TextLocation.Enabled = false;
            this.TextLocation.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLocation.Location = new System.Drawing.Point(62, 288);
            this.TextLocation.Name = "TextLocation";
            this.TextLocation.Size = new System.Drawing.Size(583, 27);
            this.TextLocation.TabIndex = 11;
            this.TextLocation.Visible = false;
            // 
            // LabelLocation
            // 
            this.LabelLocation.AutoSize = true;
            this.LabelLocation.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLocation.Location = new System.Drawing.Point(57, 247);
            this.LabelLocation.Name = "LabelLocation";
            this.LabelLocation.Size = new System.Drawing.Size(228, 25);
            this.LabelLocation.TabIndex = 12;
            this.LabelLocation.Text = "GTA San Andreas Location";
            this.LabelLocation.Visible = false;
            // 
            // BrowseLocation
            // 
            this.BrowseLocation.BackColor = System.Drawing.Color.Teal;
            this.BrowseLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseLocation.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseLocation.ForeColor = System.Drawing.Color.Transparent;
            this.BrowseLocation.Location = new System.Drawing.Point(679, 282);
            this.BrowseLocation.Name = "BrowseLocation";
            this.BrowseLocation.Size = new System.Drawing.Size(118, 39);
            this.BrowseLocation.TabIndex = 13;
            this.BrowseLocation.Text = "Browse Folder";
            this.BrowseLocation.UseVisualStyleBackColor = false;
            this.BrowseLocation.Visible = false;
            this.BrowseLocation.Click += new System.EventHandler(this.BrowseLocation_Click);
            // 
            // Advanced_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.BrowseLocation);
            this.Controls.Add(this.LabelLocation);
            this.Controls.Add(this.TextLocation);
            this.Controls.Add(this.metroToggle2);
            this.Controls.Add(this.metroToggle1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Name = "Advanced_settings";
            this.Size = new System.Drawing.Size(839, 407);
            this.Load += new System.EventHandler(this.Advanced_settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private MetroFramework.Controls.MetroToggle metroToggle2;
        private System.Windows.Forms.TextBox TextLocation;
        private System.Windows.Forms.Label LabelLocation;
        private System.Windows.Forms.Button BrowseLocation;
    }
}
