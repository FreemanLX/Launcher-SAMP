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
            DefaultButtons(ChatlogButton);
            DefaultButtons(button1);
            button1.Font = ConnectButton.Font = SettingsButton.Font = 
                ChatlogButton.Font = new System.Drawing.Font("Segoe UI Semilight", 12);
            ContentPanel.Controls.Add(new Connect_Form { Dock = DockStyle.Fill }, 1, 0);
            Data.defaultform_generally = this;
        }

        protected override void OnClosed(EventArgs e)
        {
            Data.update.Abort();
            Environment.Exit(0);
            base.OnClosed(e);
        }

        public void LoadControl(UserControl userControl)
        {
            ContentPanel.Controls.Remove(ContentPanel.GetControlFromPosition(1, 0));
            ContentPanel.Controls.Add(userControl, 1, 0);
        }

        private void ChatlogButton_Click(object sender, EventArgs e) => LoadControl(new Chatlog { Dock = DockStyle.Fill });

        private void ConnectButton_Click(object sender, EventArgs e) => LoadControl(new Connect_Form { Dock = DockStyle.Fill });

        private void SettingsButton_Click(object sender, EventArgs e) => LoadControl(new Settings { Dock = DockStyle.Fill });

        private void ScreenshotsButton_Click(object sender, EventArgs e) => LoadControl(new Screenshots { Dock = DockStyle.Fill });
    }
}
