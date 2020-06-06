using System;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.IO;

namespace Neo_San_Andras_Multiplayer
{

#pragma warning disable IDE1006 // Naming Styles
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        bool online;


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

        public void enable(bool yes)
        {
            if(yes == true)
            {
                button1.Enabled = true; button3.Enabled = true;  button2.Enabled = true;
                this.Refresh();
            }
            else
            {
                button1.Enabled = false; button3.Enabled = false; button2.Enabled = false;
            }
        }
        public Form1(bool onlinex) { online = onlinex; InitializeComponent(); }
        private void Form1_Load(object sender, EventArgs e)
        {
            Activate();
            if (online == true)
            {
                userControl22.Show(); userControl62.Hide(); enable(true); Refresh();
                userControl12.Hide(); userControl32.Hide();
            }
        }
#pragma warning disable IDE1006 // Naming Styles
        private void button1_Click(object sender, EventArgs e) { userControl12.Hide(); userControl32.Hide(); if (!PingHost("www.google.com")) userControl62.Show(); else {userControl22.Show(); userControl22.BringToFront(); }}
        private void panel1_Paint(object sender, PaintEventArgs e){}
        private void button5_Click(object sender, EventArgs e)
        { string s = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\GTA San Andreas User Files\\settings.set";
            try
            {
                File.Delete(s);

                var epsilon = File.Create(s);
                epsilon.Close();
                Reading q = new Reading();
                bool location = q.recieve("Location");
                bool beta = q.recieve("Beta");
                bool dark = q.recieve("Dark");
                bool close = q.recieve("Close");
                string[] s1 = new string[4];
                if (location == false)
                    s1[0] = "Location 0";
                else
                    s1[0] = "Location 1";
                if (beta == false)
                    s1[1] = "Beta 0";
                else
                    s1[1] = "Beta 1";
                if (dark == false)
                    s1[2] = "Dark 0";
                else
                    s1[2] = "Dark 1";
                if (close == false)
                    s1[3] = "Close 0";
                else
                    s1[3] = "Close 1";
                foreach (string temp in s1)
                {
                    File.AppendAllText(s, temp + Environment.NewLine);
                }
            }
            catch { }
            Environment.Exit(0);
        }
        private void button2_Click(object sender, EventArgs e){ userControl22.Hide(); userControl32.Hide(); if (!PingHost("www.google.com")) userControl62.Show(); else { userControl12.Show(); userControl12.BringToFront(); } }
        private void button3_Click(object sender, EventArgs e)
        { userControl12.Hide(); userControl22.Hide(); if (!PingHost("www.google.com")) userControl62.Show(); else { userControl32.Show(); userControl32.BringToFront(); } }
        private void label1_Click(object sender, EventArgs e){}
        private void userControl62_Load(object sender, EventArgs e){}

        private void button4_Click(object sender, EventArgs e)
        {
            var x = new Form4();
            x.ShowDialog();
        }
    }
}
#pragma warning restore IDE1006 // Naming Styles