using MetroFramework.Controls;
using System.ComponentModel;
using System.Windows.Forms;

namespace LauncherSAMPInt
{
    partial class ConnectToServer
  {
        private string username;
        private IContainer components = null;
        private MetroLabel ipTextLabel;
        private MetroLabel titleLabel;
        private MetroLabel pingTextLabel;
        private MetroLabel ipLabel;
        private MetroLabel portTextLabel;
        private MetroLabel pingLabel;
        private MetroLabel portLabel;
        private MetroLabel statusTextLabel;
        private MetroLabel statusLabel;
        private MetroButton connectTextLabel;
        private MetroButton cancelButton;
        private MetroLabel passwordTextLabel;
        private MetroLabel passwordLabel;
        private MetroLabel dnsTextLabel;
        private TextBox dnsLabel;

        protected override void Dispose(bool disposing)
        {
          if (disposing && this.components != null)
            this.components.Dispose();
          base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.ipTextLabel = new MetroFramework.Controls.MetroLabel();
            this.titleLabel = new MetroFramework.Controls.MetroLabel();
            this.pingTextLabel = new MetroFramework.Controls.MetroLabel();
            this.ipLabel = new MetroFramework.Controls.MetroLabel();
            this.portTextLabel = new MetroFramework.Controls.MetroLabel();
            this.pingLabel = new MetroFramework.Controls.MetroLabel();
            this.portLabel = new MetroFramework.Controls.MetroLabel();
            this.statusTextLabel = new MetroFramework.Controls.MetroLabel();
            this.statusLabel = new MetroFramework.Controls.MetroLabel();
            this.connectTextLabel = new MetroFramework.Controls.MetroButton();
            this.cancelButton = new MetroFramework.Controls.MetroButton();
            this.passwordTextLabel = new MetroFramework.Controls.MetroLabel();
            this.passwordLabel = new MetroFramework.Controls.MetroLabel();
            this.dnsTextLabel = new MetroFramework.Controls.MetroLabel();
            this.dnsLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ipTextLabel
            // 
            this.ipTextLabel.AutoSize = true;
            this.ipTextLabel.ForeColor = System.Drawing.Color.Cyan;
            this.ipTextLabel.Location = new System.Drawing.Point(71, 60);
            this.ipTextLabel.Name = "ipTextLabel";
            this.ipTextLabel.Size = new System.Drawing.Size(23, 19);
            this.ipTextLabel.TabIndex = 1;
            this.ipTextLabel.Text = "IP:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.titleLabel.Location = new System.Drawing.Point(19, 17);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(148, 25);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Connect to Server";
            // 
            // pingTextLabel
            // 
            this.pingTextLabel.AutoSize = true;
            this.pingTextLabel.Location = new System.Drawing.Point(71, 88);
            this.pingTextLabel.Name = "pingTextLabel";
            this.pingTextLabel.Size = new System.Drawing.Size(38, 19);
            this.pingTextLabel.TabIndex = 5;
            this.pingTextLabel.Text = "Ping:";
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(212, 60);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(51, 19);
            this.ipLabel.TabIndex = 7;
            this.ipLabel.Text = "IPLabel";
            // 
            // portTextLabel
            // 
            this.portTextLabel.AutoSize = true;
            this.portTextLabel.Location = new System.Drawing.Point(71, 118);
            this.portTextLabel.Name = "portTextLabel";
            this.portTextLabel.Size = new System.Drawing.Size(37, 19);
            this.portTextLabel.TabIndex = 9;
            this.portTextLabel.Text = "Port:";
            // 
            // pingLabel
            // 
            this.pingLabel.AutoSize = true;
            this.pingLabel.Location = new System.Drawing.Point(212, 88);
            this.pingLabel.Name = "pingLabel";
            this.pingLabel.Size = new System.Drawing.Size(66, 19);
            this.pingLabel.TabIndex = 10;
            this.pingLabel.Text = "PingLabel";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(212, 118);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(65, 19);
            this.portLabel.TabIndex = 11;
            this.portLabel.Text = "PortLabel";
            // 
            // statusTextLabel
            // 
            this.statusTextLabel.AutoSize = true;
            this.statusTextLabel.Location = new System.Drawing.Point(71, 148);
            this.statusTextLabel.Name = "statusTextLabel";
            this.statusTextLabel.Size = new System.Drawing.Size(46, 19);
            this.statusTextLabel.TabIndex = 12;
            this.statusTextLabel.Text = "Status:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(212, 148);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(74, 19);
            this.statusLabel.TabIndex = 13;
            this.statusLabel.Text = "StatusLabel";
            // 
            // connectTextLabel
            // 
            this.connectTextLabel.Location = new System.Drawing.Point(23, 269);
            this.connectTextLabel.Name = "connectTextLabel";
            this.connectTextLabel.Size = new System.Drawing.Size(75, 23);
            this.connectTextLabel.TabIndex = 14;
            this.connectTextLabel.Text = "Connect";
            this.connectTextLabel.Click += new System.EventHandler(this.Connect_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(296, 269);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.CloseClick);
            // 
            // passwordTextLabel
            // 
            this.passwordTextLabel.AutoSize = true;
            this.passwordTextLabel.Location = new System.Drawing.Point(71, 180);
            this.passwordTextLabel.Name = "passwordTextLabel";
            this.passwordTextLabel.Size = new System.Drawing.Size(66, 19);
            this.passwordTextLabel.TabIndex = 16;
            this.passwordTextLabel.Text = "Password:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(212, 180);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(94, 19);
            this.passwordLabel.TabIndex = 17;
            this.passwordLabel.Text = "PasswordLabel";
            // 
            // dnsTextLabel
            // 
            this.dnsTextLabel.AutoSize = true;
            this.dnsTextLabel.ForeColor = System.Drawing.Color.Cyan;
            this.dnsTextLabel.Location = new System.Drawing.Point(71, 210);
            this.dnsTextLabel.Name = "dnsTextLabel";
            this.dnsTextLabel.Size = new System.Drawing.Size(38, 19);
            this.dnsTextLabel.TabIndex = 18;
            this.dnsTextLabel.Text = "DNS:";
            // 
            // dnsLabel
            // 
            this.dnsLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dnsLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dnsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dnsLabel.Location = new System.Drawing.Point(212, 210);
            this.dnsLabel.Name = "dnsLabel";
            this.dnsLabel.ReadOnly = true;
            this.dnsLabel.Size = new System.Drawing.Size(100, 22);
            this.dnsLabel.TabIndex = 19;
            // 
            // ConnectToServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(394, 315);
            this.ControlBox = false;
            this.Controls.Add(this.dnsLabel);
            this.Controls.Add(this.dnsTextLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.connectTextLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.statusTextLabel);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.pingLabel);
            this.Controls.Add(this.portTextLabel);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.pingTextLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.ipTextLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectToServer";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Load += new System.EventHandler(this.Connect_to_Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
      }
}
