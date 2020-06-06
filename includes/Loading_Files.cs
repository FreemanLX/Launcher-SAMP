using System;
using System.Net.NetworkInformation;
using System.Threading;
using System.IO;



namespace Neo_San_Andras_Multiplayer
{
#pragma warning disable IDE1006 // Naming Styles
    public partial class Loading_Files : MetroFramework.Forms.MetroForm
    {
        public Loading_Files()
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
            // Discard PingExceptions and return false;
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
        bool internet;

        private void Loading()
        {

            string t = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\GTA San Andreas User Files";
            if (Directory.Exists(t))
            {

                string s = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\GTA San Andreas User Files\\settings.set";
                if (!File.Exists(s))
                {
                    var what = File.Create(s);
                    what.Close();
                    bool location = false;
                    bool beta = true;
                    bool dark = false;
                    bool close = false;
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
                    Reading q = new Reading("Location", location);
                    Reading q1 = new Reading("Beta", beta);
                    Reading q2 = new Reading("Dark", dark);
                    Reading q3 = new Reading("Close", close);
                    foreach (string temp in s1)
                    {
                        File.AppendAllText(s, temp + Environment.NewLine);
                    }
                }
                else
                {
                    string[] read = File.ReadAllLines(s);
                    foreach (string temp in read)
                    {
                        string[] temp1 = temp.Split(' ');
                        if (temp1[1] == "1")
                        {
                            Reading q = new Reading(temp1[0], true);
                        }
                        else
                        {
                            Reading q = new Reading(temp1[0], false);
                        }
                    }
                }
            }
            

        }
        private void Loading_Files_Load(object sender, EventArgs e)
        {
            Activate();
            Loading();
            this.Shown += new System.EventHandler(this.xShown);
        }

        static WaitHandle[] waitHandles = new WaitHandle[]
        {
            new AutoResetEvent(false)
        };

        void do_t(Object state)
        {
            AutoResetEvent are = (AutoResetEvent)state;
            Thread.Sleep(10000);
            if (PingHost("www.google.com"))
                internet = true;
            else
                internet = false;
            are.Set();
            }
        public void xShown(object sender, EventArgs e)
        {

            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Show();
            pictureBox1.Refresh();
            var ga = new Loading_Files();
            ga = this;
            Thread t1 = new Thread(
                () =>
            {
                Thread.Sleep(5000);
                internet = PingHost("www.google.com");
                Invoke(new Action(() =>
                {
                    this.Hide();
                }));
                if (internet == true)
                {
                    ///ga.Hide();   
                    var frm1 = new Form1(true);
                    frm1.ShowDialog();
                    frm1.BringToFront();
                    ///ga.Close();
                }
                if (internet == false)
                {
                    ///ga.Hide();
                    var frm1 = new Form1(true);
                    frm1.ShowDialog();
                    frm1.Dispose();
                    frm1.BringToFront();
                    ///ga.Close();
                }
               Invoke(new Action(() =>
                {
                    this.Close();

                }));
            }
         )
            {IsBackground = true};
            t1.Start();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
