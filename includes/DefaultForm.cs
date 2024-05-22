using System;
using System.Windows.Forms;

namespace LauncherSAMPInt
{
    public partial class DefaultForm : MetroFramework.Forms.MetroForm
    {
        public DefaultForm() => InitializeComponent();

        private void DefaultButtons(Button button)
        {
            button.TabStop = false;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Activate();
            DefaultButtons(ConnectButton);
            DefaultButtons(SettingsButton);
            ContentPanel.Controls.Add(new ConnectForm { Dock = DockStyle.Fill }, 1, 0);
            Data.defaultform_generally = this;
        }

        public void LoadControl(UserControl userControl)
        {
            ContentPanel.Controls.Remove(ContentPanel.GetControlFromPosition(1, 0));
            ContentPanel.Controls.Add(userControl, 1, 0);
        }

        private void ConnectButton_Click(object sender, EventArgs e) => LoadControl(new ConnectForm { Dock = DockStyle.Fill });

        private void SettingsButton_Click(object sender, EventArgs e) => LoadControl(new Settings { Dock = DockStyle.Fill });
    }
}
