using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;

namespace LauncherSAMPInt
{
    public partial class Connect_Form : UserControl
    {
        public List<string> methods;
        public List<string> ports;
        public Connect_Form() => InitializeComponent();
        
        async public void RetrieveSAMPServer(string ip, int index = -1)
        {
            List<string> output = new List<string>();
            try
            {
                using (Query query = new Query(ip, int.Parse(ports[ServerList.CurrentCell.RowIndex])))
                {
                    if (await query.Send())
                    {
                        string[] data_recieve = await query.Recieve();
                        foreach(string data in data_recieve)
                        {
                            if(string.IsNullOrEmpty(data) || 
                                string.IsNullOrWhiteSpace(data) ||
                                data == null)
                                throw new Exception();
                            output.Add(data);
                        }
                    }
                }
                output.Add(ip);
            }
            catch {
                output = new List<string> { "Offline", ip, "0 / 0", "inf", "-", ip };
            }
            if(index == -1)
                ServerList.Rows.Add((output.ToArray()));
            
            else ServerList.Rows[index].SetValues(output.ToArray());
        }



        string Old_nickname = "";

        private void UpdateData()
        {
            while (true)
            {
                if (NicknameTextBox.Text.Length > 0 && NicknameTextBox.Text != Old_nickname)
                {
                    File.WriteAllText(Data.NicknameLocation, NicknameTextBox.Text);
                    Old_nickname = NicknameTextBox.Text;
                }
                Invoke(new Action(() => RefreshList()));
                Thread.Sleep(500);
            }
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            Show();
            Select();
            Data.update = new Thread(UpdateData) { IsBackground = true };
            Data.update.Start();
            RefreshAll();
        }

        public void RefreshAll()
        {
            ServerList.Rows.Clear();
            methods = new List<string>();
            ports = new List<string>();
            string load = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\NeoSAMP";
            if (!Directory.Exists(load)) Directory.CreateDirectory(load);
            else
            {
                if (File.Exists(Data.NicknameLocation))
                {
                    NicknameTextBox.Text = File.ReadAllText(Data.NicknameLocation);
                }
                if (File.Exists(Data.ServersLocation))
                {
                        string[] server_lists = File.ReadAllLines(Data.ServersLocation).Distinct().ToArray();
                        if (server_lists != null)
                        {
                            foreach (string server_list in server_lists)
                            {
                                string port = "7777";
                                try
                                {
                                    port = server_list.Split(':')[1];
                                }
                                catch{}
                                string ip = server_list.Split(':')[0];
                                try
                                {
                                   ip = System.Net.Dns.GetHostAddresses(ip)[0].ToString();
                                }
                                catch { }
                                methods.Add(ip);
                                ports.Add(port);
                                RetrieveSAMPServer(ip);
                            }
                        
                       }
                }
            }
        }

        private async void RefreshAllButton_Click(object sender, EventArgs e)
        {
            RefreshAllButton.Enabled = false;
            RefreshAll();
            await System.Threading.Tasks.Task.Delay(1500);
            RefreshAllButton.Enabled = true;
        }

        private void ServerList_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => new Connect_to_Server(ServerList[5, ServerList.CurrentCell.RowIndex].Value.ToString(),
                ServerList[1, ServerList.CurrentCell.RowIndex].Value.ToString(),
                ServerList[3, ServerList.CurrentCell.RowIndex].Value.ToString(),
                NicknameTextBox.Text, ports[ServerList.CurrentCell.RowIndex], ServerList[0, ServerList.CurrentCell.RowIndex].Value.ToString()).ShowDialog();



        private void AddServerButton_Click(object sender, EventArgs e) => new AddServer(this).ShowDialog();

        private async void DeleteSelectedServerButton_Click(object sender, EventArgs e)
        {
            DeleteSelectedServerButton.Enabled = false;
            Delete();
            await System.Threading.Tasks.Task.Delay(500);
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
            try
            {
                File.Create(Data.ServersLocation).Close();
                for (int i = 0; i < methods.Count; i++)
                {
                    if (ServerList[5, ServerList.CurrentCell.RowIndex].Value.ToString() != methods[i])
                    {
                        File.AppendAllText(Data.ServersLocation, methods[i] + Environment.NewLine);
                    }
                }
                ServerList.Rows.RemoveAt(ServerList.CurrentCell.RowIndex);
                methods.RemoveAt(ServerList.CurrentCell.RowIndex);
                ports.RemoveAt(ServerList.CurrentCell.RowIndex);
            }
            catch
            {
                MessageBox.Show("You don't have nothing to delete or you didn't selected!");
            }
        }

        void RefreshList()
        {
            try
            {
                RetrieveSAMPServer(ServerList[5, ServerList.CurrentCell.RowIndex].Value.ToString(), ServerList.CurrentCell.RowIndex);
            }
            catch { }
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
                    new Connect_to_Server(ServerList[5, columnIndex].Value.ToString(), ServerList[1, columnIndex].Value.ToString(), ServerList[3, columnIndex].Value.ToString(), NicknameTextBox.Text, ports[columnIndex], ServerList[0, columnIndex].Value.ToString()).ShowDialog();
                    break;
            }


        } 
    }
}
