using System;
using System.Windows.Forms;
using System.IO;

namespace Neo_San_Andras_Multiplayer
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        private readonly UserControl2 load1;
        public Form2(UserControl2 load)
        {
            InitializeComponent();
            load1 = load;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text.Length > 0)
            {
                string port = "";
                if (metroTextBox2.Text.Length > 0)
                {
                    int ok = 0;
                    string temp = metroTextBox2.Text;
                    for (int i = 0; i < temp.Length; i++)
                    {
                        if (temp[i] < '0' || temp[i] > '9')
                        {
                            ok = 1;
                            break;
                        }

                    }
                    if (ok == 0)
                    {
                        MessageBox.Show("You introduced a bad port", "Bad port", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                    else
                    {
                        port = metroTextBox2.Text;
                 
                    }
                }
                else
                {
                    port = ":7777";
                }
                string ip = metroTextBox1.Text;
                string combine = ip + port;
                string dns = "";
                System.Net.IPAddress[] host = new System.Net.IPAddress[2];
                try
                {
                    host = System.Net.Dns.GetHostAddresses(ip);
                    foreach (System.Net.IPAddress host1 in host)
                    {
                        dns = host1.ToString();
                        break;
                    }
                }
                catch{}
                string save = "@%appdata%\\NeoSAMP\\servers.db";
                File.AppendAllText(save, combine + Environment.NewLine);
                load1.counter(load1.getcounter() + 1);
                load1.loading(dns);
                this.Close();
            }
            else
            {
                MessageBox.Show("You hadn't introduced any character in both text labels", "Error 001", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
