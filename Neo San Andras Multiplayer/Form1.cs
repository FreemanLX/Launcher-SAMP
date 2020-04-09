using System;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace Neo_San_Andras_Multiplayer
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {

            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Show();
            this.Select();
            try
            {
                Ping g = new Ping();
                PingReply pg = g.Send("www.google.com");
                if (pg.Status == IPStatus.Success)
                {
                    if (pg.RoundtripTime > 100)
                    {
                        metroLabel2.Visible = true;
                        metroLabel2.Text = metroLabel2.Text + " Ping: " + pg.RoundtripTime.ToString() + " ms";
                        metroLabel2.Refresh();
                    }
                    if (pg.RoundtripTime < 50)
                    {
                        metroLabel2.Visible = true;
                        metroLabel2.Text = "You have a good internet connection";
                        metroLabel2.Refresh();
                    }

                }
            }
            catch
            {
                try
                {
                    metroLabel2.Visible = true;
                    metroLabel2.Text = metroLabel2.Text + " Ping: 9999 ms";
                }
                catch
                {

                }

            }
            userControl21.Show();
            userControl11.Hide();
            userControl31.Hide();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl31.Hide();
            userControl21.Show();
            userControl21.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }




        private void button2_Click(object sender, EventArgs e)
        {
            userControl21.Hide();
            userControl11.Hide();
            userControl11.Show();
            userControl11.BringToFront();
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControl21.Hide();
            userControl11.Hide();
            userControl31.Show();
            userControl31.BringToFront();
        }
    }
}