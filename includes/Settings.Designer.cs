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
            this.label1 = new System.Windows.Forms.Label();
            this.Personalization = new System.Windows.Forms.Label();
            this.About = new System.Windows.Forms.Label();
            this.Advanced = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 47);
            this.label1.TabIndex = 11;
            this.label1.Text = "Settings";
            // 
            // Personalization
            // 
            this.Personalization.AutoSize = true;
            this.Personalization.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Personalization.Location = new System.Drawing.Point(79, 109);
            this.Personalization.Name = "Personalization";
            this.Personalization.Size = new System.Drawing.Size(153, 30);
            this.Personalization.TabIndex = 15;
            this.Personalization.Text = "Personalization";
            this.Personalization.Click += new System.EventHandler(this.Personalization_Click);
            // 
            // About
            // 
            this.About.AutoSize = true;
            this.About.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About.Location = new System.Drawing.Point(79, 209);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(69, 30);
            this.About.TabIndex = 16;
            this.About.Text = "About";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Advanced
            // 
            this.Advanced.AutoSize = true;
            this.Advanced.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Advanced.Location = new System.Drawing.Point(79, 159);
            this.Advanced.Name = "Advanced";
            this.Advanced.Size = new System.Drawing.Size(182, 30);
            this.Advanced.TabIndex = 17;
            this.Advanced.Text = "Advanced settings";
            this.Advanced.Click += new System.EventHandler(this.Advanced_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.Advanced);
            this.Controls.Add(this.About);
            this.Controls.Add(this.Personalization);
            this.Controls.Add(this.label1);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(839, 407);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Personalization;
        private System.Windows.Forms.Label About;
        private System.Windows.Forms.Label Advanced;
    }
}
