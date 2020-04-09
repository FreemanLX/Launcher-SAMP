using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Neo_San_Andras_Multiplayer
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Ping g = new Ping();
                PingReply pg = g.Send("www.google.com");
                if (pg.Status == IPStatus.Success)
                {
                    MessageBox.Show("You Ping is: " + pg.RoundtripTime.ToString() + " ms!", "Ping test",  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch
            {
                
            }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
