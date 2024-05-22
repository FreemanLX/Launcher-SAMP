using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;

namespace LauncherSAMPInt
{
    public partial class ConnectForm : UserControl
    {
        public ConnectForm() => InitializeComponent();

        async public void RetrieveSAMPServer(string ip, int port, int index = -1)
        {
            List<string> output = new List<string>();
            try
            {
                using (Query query = new Query(ip, port))
                {
                    if (await query.Send())
                    {
                        string[] dataReceived = await query.Recieve();
                        foreach (string data in dataReceived)
                        {
                            if (string.IsNullOrEmpty(data) ||
                                 string.IsNullOrWhiteSpace(data) ||
                                  data == null)
                                     throw new Exception();
                            output.Add(data);
                        }
                    }
                    else throw new Exception();
                }
                output.Add(ip);
            }
            catch
            {
                output = new List<string> { "Offline", ip, port.ToString(), "0 / 0", "inf", "-", ip };
            }
            if (index == -1)
                ServerList.Rows.Add(output.ToArray());

            else ServerList.Rows[index].SetValues(output.ToArray());
        }

        public static async Task SetInterval(Action action, TimeSpan timeout)
        {
            await Task.Delay(timeout).ConfigureAwait(false);
            action();
            await SetInterval(action, timeout);
        }

        private async void ConnectForm_Load(object sender, EventArgs e)
        {
            LoadData();
            await SetInterval(() => Invoke(new Action(() => RefreshServers())), TimeSpan.FromSeconds(3)); //Refreshing the server list ever 2 seconds.
        }

        public void RefreshServers()
        {
            if (ServerList.Rows.Count < 1) return;
            for (int index = 0; index < ServerList.Rows.Count; index++)
            {
                string port = ServerList.Rows[index].Cells["Port"].Value.ToString();
                string ip = ServerList.Rows[index].Cells["Ip"].Value.ToString();
                RetrieveSAMPServer(ip, int.Parse(port), index);
            }
        }

        public void LoadData()
        {
            ServerList.Rows.Clear();
            
            if (!Directory.Exists(Data.folderLocation)) Directory.CreateDirectory(Data.folderLocation);
            else
            {
                if (File.Exists(Data.nicknameLocation))
                {
                    NicknameTextBox.Text = File.ReadAllText(Data.nicknameLocation);
                }
                if (File.Exists(Data.serversLocation))
                {
                    string[] serverLists = File.ReadAllLines(Data.serversLocation).Distinct().ToArray();
                    if (serverLists.Length > 0)
                    {
                        foreach (string serverList in serverLists)
                        {
                            int port = int.Parse(serverList.Split(':')[1]);
                            string ip = serverList.Split(':')[0];
                            try
                            {
                                ip = System.Net.Dns.GetHostAddresses(ip)[0].ToString();
                            }
                            catch
                            {
                                Console.WriteLine("Unable to grab the IP from the DNS");
                            }
                            RetrieveSAMPServer(ip, port);
                        }
                        
                    }
                }
            }
        }

        private async void RefreshAllButton_Click(object sender, EventArgs e)
        {
            RefreshAllButton.Enabled = false;
            RefreshServers();
            await Task.Delay(1500);
            RefreshAllButton.Enabled = true;
        }

        private void ServerList_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => new ConnectToServer(ServerList[5, ServerList.CurrentCell.RowIndex].Value.ToString(),
                ServerList[1, ServerList.CurrentCell.RowIndex].Value.ToString(),
                ServerList[4, ServerList.CurrentCell.RowIndex].Value.ToString(),
                NicknameTextBox.Text, ServerList[2, ServerList.CurrentCell.RowIndex].Value.ToString(), ServerList[0, ServerList.CurrentCell.RowIndex].Value.ToString()).ShowDialog();



        private void AddServerButton_Click(object sender, EventArgs e) => new AddServer(this).ShowDialog();

        private async void DeleteSelectedServerButton_Click(object sender, EventArgs e)
        {
            DeleteSelectedServerButton.Enabled = false;
            Delete();
            await Task.Delay(500);
            DeleteSelectedServerButton.Enabled = true;
        }
                
        private void ServerList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip m = new ContextMenuStrip();
                int currentMouseOverRow = ServerList.HitTest(e.X, e.Y).RowIndex;
                    m.Items.Add("Delete").Name = "Delete";
                    m.Items.Add("Refresh").Name = "Refresh";
                    m.Items.Add("Connect").Name = "Connect";
                
                m.Show(ServerList, new Point(e.X, e.Y));
                m.ItemClicked += new ToolStripItemClickedEventHandler(ItemClicked);
            }
        }

        public void Delete()
        {
            ServerList.Rows.Clear();
            File.Create(Data.serversLocation).Close();
        }

        void RefreshList()
        {
             RetrieveSAMPServer(ServerList[5, ServerList.CurrentCell.RowIndex].Value.ToString(), ServerList.CurrentCell.RowIndex);   
        }

        void ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name.ToString())
            {
                case "Delete":
                    Delete();
                    break;

                case "Refresh":
                    RefreshList();
                    break;

                case "Connect":
                    int columnIndex = ServerList.CurrentCell.RowIndex;
                    new ConnectToServer(ServerList[5, columnIndex].Value.ToString(), ServerList[1, columnIndex].Value.ToString(), ServerList[3, columnIndex].Value.ToString(), NicknameTextBox.Text, ServerList[2, columnIndex].Value.ToString(), ServerList[0, columnIndex].Value.ToString()).ShowDialog();
                    break;
            }


        }

        private void NicknameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (NicknameTextBox.Text.Length > 0)
            {
                File.WriteAllText(Data.nicknameLocation, NicknameTextBox.Text);
            }
        }
    }
}
