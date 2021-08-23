using System;
using System.Windows.Forms;
using System.IO;

namespace LauncherSAMPInt
{
    public partial class AddServer : MetroFramework.Forms.MetroForm
    {
        private readonly Connect_Form load;
        public AddServer(Connect_Form load)
        {
            InitializeComponent();
            this.load = load;
        }

        private void Close_Click(object sender, EventArgs e) => Close();
        private void Save_Click(object sender, EventArgs e)
        {
            if (ServerTextBox.Text.Length > 0 && PortTextBox.Text.Length > 0)
            {
                    int port = 0;
                    try
                    {
                        port = int.Parse(PortTextBox.Text);
                    }
                    catch
                    {
                        MessageBox.Show("You introduced a bad port", "Bad port", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                    }

                    string dns = "";
                    try
                    {
                        foreach (System.Net.IPAddress host in System.Net.Dns.GetHostAddresses(ServerTextBox.Text))
                        {
                            dns = host.ToString();
                            break;
                        }
                    }
                    catch{}
                    File.AppendAllText(Data.ServersLocation, ServerTextBox.Text + ":" + port.ToString() + Environment.NewLine);
                    load.RetrieveSAMPServer(dns);
                    Close();
            }
            else
            {
                MessageBox.Show("You need to insert data", "Empty data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
    }
}
