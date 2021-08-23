using System;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace LauncherSAMPInt
{
    public partial class Settings : UserControl
    {
        public Settings() => InitializeComponent();
        private void UserControl1_Load(object sender, EventArgs e) {
            
        }
        Control userControlGeneral;

        public void Set_click(UserControl userControl)
        {
            foreach(Control control in Controls)
            {
                if(userControlGeneral != control)
                {
                    control.Hide();
                }
            }
            Controls.Remove(userControlGeneral);
            userControlGeneral = userControl;
            Controls.Add(userControl);
        }
        
        private void Personalization_Click(object sender, EventArgs e)
        {
            Settings_Personalization settings_Personalization = new Settings_Personalization
            {
                Location = new Point(145, 72),
                Dock = DockStyle.Fill
            };
            Set_click(settings_Personalization);
        }

        private void Advanced_Click(object sender, EventArgs e)
        {
            Set_click(new Advanced_settings
            {
                Location = new Point(145, 72),
                Dock = DockStyle.Fill
            });
        }

        private void About_Click(object sender, EventArgs e)
        {
            Set_click(new About
            {
                Location = new Point(145, 72),
                Dock = DockStyle.Fill
            });
        }
    }
}
