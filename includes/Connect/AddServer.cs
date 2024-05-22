using System;
using System.Windows.Forms;
using System.IO;

namespace LauncherSAMPInt
{
    public partial class AddServer : MetroFramework.Forms.MetroForm
    {
        private readonly ConnectForm load;
        public AddServer(ConnectForm load)
        {
            InitializeComponent();
            this.load = load;
        }

        private void Close_Click(object sender, EventArgs e) => Close();
        private void Save_Click(object sender, EventArgs e)
        {
            if (ServerTextBox.Text.Length > 0 && PortTextBox.Text.Length > 0)
            {
                string ip = "";
                if (System.Text.RegularExpressions.Regex.IsMatch(ServerTextBox.Text, @"^([a-zA-Z0-9]|[a-zA-Z0-9][a-zA-Z0-9\-]{0,61}[a-zA-Z0-9])(\.([a-zA-Z0-9]|[a-zA-Z0-9][a-zA-Z0-9\-]{0,61}[a-zA-Z0-9]))*$
"))
                {
                    MessageBox.Show("Please enter a proper hostname");
                    return;
                }
                File.AppendAllText(Data.serversLocation, ServerTextBox.Text + ":" + PortTextBox.Text + Environment.NewLine);
                try
                {
                    ip = System.Net.Dns.GetHostAddresses(ServerTextBox.Text)[0].ToString();
                }
                catch
                {
                    MessageBox.Show("Unable to get ip address from the inserted hostname");
                    return;
                }
                load.RetrieveSAMPServer(ip, int.Parse(PortTextBox.Text));
                Close();
            }
            else
            {
                MessageBox.Show("You need to insert data", "Empty data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void PortTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(PortTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                PortTextBox.Text = PortTextBox.Text.Remove(PortTextBox.Text.Length - 1);
            }
        }
    }
}
