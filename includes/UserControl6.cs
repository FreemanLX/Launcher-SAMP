using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Neo_San_Andras_Multiplayer
{
#pragma warning disable IDE1006 // Naming Styles
    public partial class UserControl6 : UserControl
    {
        

        public UserControl6()
        {
            InitializeComponent();
        }

        public static bool PingHost(string nameOrAddress)
        {
            bool pingable = false;
            Ping pinger = null;

            try
            {
                pinger = new Ping();
                PingReply reply = pinger.Send(nameOrAddress);
                pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                return false;
            }
            finally
            {
                if (pinger != null)
                {
                    pinger.Dispose();
                }
            }

            return pingable;
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (PingHost("www.google.com"))
            {
                this.Hide();
                var x = new UserControl1();
                x.Show();
            }
            else
            {}
        }

        private void UserControl6_Load(object sender, EventArgs e)
        {

        }
    }
}
#pragma warning restore IDE1006 // Naming Styles