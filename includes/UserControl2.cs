using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using SAMP;
using System.Drawing;

namespace Neo_San_Andras_Multiplayer
{
#pragma warning disable IDE1006 // Naming Styles
    public struct ip_type {public string epsilon;};
    public partial class UserControl2 : UserControl
    {
        ip_type[] method = new ip_type[100];
        public UserControl2() { InitializeComponent(); }
        int all = 0;
        public void counter(int gamma) { all = gamma; }
        public int getcounter() { return all; }
        public void loading(string ip)
        {
            string[] output = new string[10];
            string min_playeri = "";
            string max_playeri = "";
            string hostname = "";
            string password = "";
            string gamemode = "";
            using (Query q = new Query(ip))
            {
                bool result = q.Send('i');
                if (result == true)
                {
                    try
                    {
                        int j = 0;
                        foreach (string str in q.Recieve())
                        {
                            output[j++] = str;
                        }
                    }
                    catch{ }
                 
                }
            }
            string ping = "";
            using (Query q = new Query(ip))
            {
                bool result = q.Send('p');
                if (result == true)
                {
                    string[] epsilon = new string[2];
                    epsilon = q.Recieve();
                    try
                    {
                        ping = epsilon[0];
                    }
                    catch
                    {
                        ping = "inf";
                    }
                }
            }
            min_playeri = output[1];
            max_playeri = output[2];
            hostname = output[3];
            gamemode = output[4];
            output[1] = hostname;
            output[2] = min_playeri + " / " + max_playeri;
            if (ping == null)
                output[3] = "";
            else output[3] = ping;
            output[5] = ip;
            if (hostname == null || max_playeri == null || min_playeri == null || password == null)
            {
                    string[] complete = new string[6];
                    complete[0] = "Offline";
                    complete[1] = ip;
                    complete[2] = "0 / 0";
                    complete[3] = "inf";
                    complete[4] = "-";
                    complete[5] = ip;
                    dataGridView1.Rows.Add(complete);
            }
            else
            {
                if (output[0] == "0") output[0] = "Online";
                else output[0] = "Protected";
                    dataGridView1.Rows.Add(output);
            }
            dataGridView1.Update();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            Show();
            Select();
            reloading();
        }
        public void reloading()
        {
            int j = 0;
            dataGridView1.Rows.Clear();
            string load = "@%appdata%\\NeoSAMP";
            var save = "@%appdata%\\NeoSAMP\\dataname.db";
            var servers = "@%appdata%\\NeoSAMP\\servers.db";
            if (!Directory.Exists(load)) Directory.CreateDirectory(load);
            else
            {
                if (File.Exists(save))
                {
                    metroTextBox1.Text = File.ReadAllText(save);
                }
                if (File.Exists(servers))
                {
                    string[] alpha = File.ReadAllLines(servers);
                    string[] clean = alpha.Distinct().ToArray();

                        if (clean != null)
                        {
                            foreach (string gamma in clean){
                            
                            string[] ex = gamma.Split(':');
                            string[] output = new string[6];
                            string gamma1 = "";
                            System.Net.IPAddress[] host = new System.Net.IPAddress[2];
                            try
                            {
                                host = System.Net.Dns.GetHostAddresses(ex[0]);
                                foreach (System.Net.IPAddress host1 in host)
                                {
                                    gamma1 = host1.ToString();
                                    method[j].epsilon = gamma1;
                                    j++;
                                    break;
                                }
                            }
                            catch
                            {
                                method[j].epsilon = ex[0];
                                j++;
                            }
                                loading(gamma1);
                        }
                        counter(j);
                    }
                }
            }



        }

        void reloading_t(string ip, int index)
        {
            string[] output = new string[10];
            string min_playeri = "";
            string max_playeri = "";
            string hostname = "";
            string password = "";
            string gamemode = "";
            using (Query q = new Query(ip))
            {
                bool result = q.Send('i');
                if (result == true)
                {
                    try
                    {
                        int j = 0;
                        foreach (string str in q.Recieve())
                        {
                            output[j++] = str;
                        }
                    }
                    catch { }

                }
            }
            string ping = "";
            using (Query q = new Query(ip))
            {
                bool result = q.Send('p');
                if (result == true)
                {
                    string[] epsilon = new string[2];
                    epsilon = q.Recieve();
                    try
                    {
                        ping = epsilon[0];
                    }
                    catch
                    {
                        ping = "inf";
                    }
                }
            }
            min_playeri = output[1];
            max_playeri = output[2];
            hostname = output[3];
            gamemode = output[4];
            output[1] = hostname;
            output[2] = min_playeri + " / " + max_playeri;
            if (ping == null)
                output[3] = "";
            else output[3] = ping;
            output[5] = ip;
            if (hostname == null || max_playeri == null || min_playeri == null || password == null)
            {
                string[] complete = new string[6];
                complete[0] = "Offline";
                complete[1] = ip;
                complete[2] = "0 / 0";
                complete[3] = "inf";
                complete[4] = "-";
                complete[5] = ip;
                for (int i = 0; i <= 5; i++)
                {
                    dataGridView1[i, index].Value = complete[i];
                }
            }
            else
            {
                if (output[0] == "0") output[0] = "Online";
                else output[0] = "Protected";
                for (int i = 0; i <= 5; i++)
                {
                    dataGridView1[i, index].Value = output[i];
                }
            }
            dataGridView1.Update();

        }

        private async void metroButton3_Click_1(object sender, EventArgs e)
        {
            metroButton3.Enabled = false;
            int j = 0;
            dataGridView1.Rows.Clear();
            string load = "@%appdata%\\NeoSAMP";
            var save = "@%appdata%\\NeoSAMP\\dataname.db";
            var servers = "@%appdata%\\NeoSAMP\\servers.db";
            if (!Directory.Exists(load))
            {
                Directory.CreateDirectory(load);
            }
            else
            {
                if (File.Exists(save))
                {
                    metroTextBox1.Text = File.ReadAllText(save);
                }
                if (File.Exists(servers))
                {
                    string[] alpha = File.ReadAllLines(servers);
                    string[] clean = alpha.Distinct().ToArray();
                    foreach (string gamma in clean)
                    {
                        if (clean != null)
                        {
                            string[] ex = gamma.Split(':');
                            string[] output = new string[6];
                            string gamma1 = "";
                            System.Net.IPAddress[] host = new System.Net.IPAddress[2];
                            try
                            {
                                host = System.Net.Dns.GetHostAddresses(ex[0]);
                                foreach (System.Net.IPAddress host1 in host)
                                {
                                    gamma1 = host1.ToString();
                                    method[j].epsilon = gamma1;
                                    j++;
                                    break;
                                }
                            }
                            catch
                            {
                                gamma1 = ex[0];
                            }
                            loading(gamma1);
                        }
                        counter(j);
                    }
                }
            }
            await System.Threading.Tasks.Task.Delay(1500);
            metroButton3.Enabled = true;
        }
     
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = dataGridView1.CurrentCell.RowIndex;
            var form3 = new Form3(dataGridView1[5, columnIndex].Value.ToString(), dataGridView1[1, columnIndex].Value.ToString(), dataGridView1[3, columnIndex].Value.ToString(), metroTextBox1.Text, "No", dataGridView1[0, columnIndex].Value.ToString());
            form3.ShowDialog();

        }
        
        private async void load_t()
        {
            while (true)
            {
                try
                {
                    reloading_t(dataGridView1[5, dataGridView1.CurrentCell.RowIndex].Value.ToString(), dataGridView1.CurrentCell.RowIndex);
                }
                catch { }
                await System.Threading.Tasks.Task.Delay(1000);
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem("Delete"));
                m.MenuItems.Add(new MenuItem("Refresh"));
                m.MenuItems.Add(new MenuItem("Connect"));

                int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    m.MenuItems.Add(new MenuItem(string.Format("Do something to row {0}", currentMouseOverRow.ToString())));
                }

                m.Show(dataGridView1, new Point(e.X, e.Y));

            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                reloading_t(dataGridView1[5, dataGridView1.CurrentCell.RowIndex].Value.ToString(), dataGridView1.CurrentCell.RowIndex);
            }
            catch { }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text.Length > 0)
            {
                string save = "@%appdata%\\NeoSAMP\\dataname.db";
                File.WriteAllText(save, metroTextBox1.Text);
            }
            var x = new Form2(this);
            x.ShowDialog();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text.Length > 0)
            {
                string save = "@%appdata%\\NeoSAMP\\dataname.db";
                File.WriteAllText(save, metroTextBox1.Text);
            }
            int columnIndex = dataGridView1.CurrentCell.RowIndex;
            var form3 = new Form3(dataGridView1[5, columnIndex].Value.ToString(), dataGridView1[1, columnIndex].Value.ToString(), dataGridView1[3, columnIndex].Value.ToString(), metroTextBox1.Text, "No", dataGridView1[0, columnIndex].Value.ToString());
            form3.ShowDialog();
        }

        private async void metroButton2_Click(object sender, EventArgs e)
        {
            metroButton2.Enabled = false;
            if (metroTextBox1.Text.Length > 0)
            {
                string save = "@%appdata%\\NeoSAMP\\dataname.db";
                File.WriteAllText(save, metroTextBox1.Text);
            }
            string find = "";
            try
            {
                int rowindex = dataGridView1.CurrentCell.RowIndex;
                for (int i = 0; i < all; i++)
                {                
                    if (dataGridView1[5, rowindex].Value.ToString() == method[i].epsilon)
                    {
                        find = method[i].epsilon;
                        break;
                    }
                }
                string save = "@%appdata%\\NeoSAMP\\servers.db";
                File.Create(save).Close();
                for (int i = 0; i < all; i++)
                {
                    string combine = method[i].epsilon;
                    if (combine != find)
                         File.AppendAllText(save, combine + Environment.NewLine);
                    
                    else
                        continue;
                    
                }
                dataGridView1.Rows.RemoveAt(rowindex);
            }
            catch
            {
                MessageBox.Show("You don't have nothing to delete or you didn't selected!");
            }
            await System.Threading.Tasks.Task.Delay(500);
            metroButton2.Enabled = true;
        }

        private void metroLabel2_Click(object sender, EventArgs e){}

        private async void metroButton5_Click(object sender, EventArgs e)
        {
            metroButton5.Enabled = false;
            try
            {
               reloading_t(dataGridView1[5, dataGridView1.CurrentCell.RowIndex].Value.ToString(), dataGridView1.CurrentCell.RowIndex);
            }
            catch { }
            await System.Threading.Tasks.Task.Delay(500);
            metroButton5.Enabled = true;
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip m = new ContextMenuStrip();
                int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                    m.Items.Add("Delete").Name = "Delete";
                    m.Items.Add("Refresh").Name = "Refresh";
                    m.Items.Add("Connect").Name = "Connect";
                
                m.Show(dataGridView1, new Point(e.X, e.Y));
                m.ItemClicked += new ToolStripItemClickedEventHandler(m_ItemClicked);

            }
        }

        void m_ItemClicked (object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name.ToString())
            {
                case "Delete":
                    if (metroTextBox1.Text.Length > 0)
                    {
                        string save = "@%appdata%\\NeoSAMP\\dataname.db";
                        File.WriteAllText(save, metroTextBox1.Text);
                    }
                    string find = "";
                    try
                    {
                        int rowindex = dataGridView1.CurrentCell.RowIndex;
                        for (int i = 0; i < all; i++)
                        {
                            if (dataGridView1[5, rowindex].Value.ToString() == method[i].epsilon)
                            {
                                find = method[i].epsilon;
                                break;
                            }
                        }
                        string save = "@%appdata%\\NeoSAMP\\servers.db";
                        File.Create(save).Close();
                        for (int i = 0; i < all; i++)
                        {
                            string combine = method[i].epsilon;
                            if (combine != find)
                                File.AppendAllText(save, combine + Environment.NewLine);

                            else
                                continue;

                        }
                        dataGridView1.Rows.RemoveAt(rowindex);
                    }
                    catch
                    {
                        MessageBox.Show("You don't have nothing to delete or you didn't selected!");
                    }
                    break;

                case "Refresh":
                    metroButton5.Enabled = false;
                    try
                    {
                        reloading_t(dataGridView1[5, dataGridView1.CurrentCell.RowIndex].Value.ToString(), dataGridView1.CurrentCell.RowIndex);
                    }
                    catch { }
                    metroButton5.Enabled = true;
                    break;

                case "Connect":
                    if (metroTextBox1.Text.Length > 0)
                    {
                        string save = "@%appdata%\\NeoSAMP\\dataname.db";
                        File.WriteAllText(save, metroTextBox1.Text);
                    }
                    int columnIndex = dataGridView1.CurrentCell.RowIndex;
                    var form3 = new Form3(dataGridView1[5, columnIndex].Value.ToString(), dataGridView1[1, columnIndex].Value.ToString(), dataGridView1[3, columnIndex].Value.ToString(), metroTextBox1.Text, "No", dataGridView1[0, columnIndex].Value.ToString());
                    form3.ShowDialog();
                    break;
            }


        } 

        private void M_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
#pragma warning restore IDE1006 // Naming Styles
