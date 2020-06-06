using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using SAMP;

namespace Neo_San_Andras_Multiplayer
{

    public struct ip_type
    {
        public string epsilon;
    };
    public partial class UserControl2 : UserControl
    {
        ip_type[] method = new ip_type[100];
        public UserControl2()
        {
            InitializeComponent();
        }

        int all = 0;
        public void counter(int gamma)
        {
            all = gamma;
        }

        public int getcounter()
        {
            return all;
        }
        public void loading(string ip, int reloading = -1)
        {
            int j = 0;
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
                        foreach (string str in q.Recieve())
                        {
                            output[j++] = str;
                        }
                    }
                    catch
                    { }
                 
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
                int i = 0;
                if (reloading != -1)
                {
                    dataGridView1[i++, reloading].Value = "Offline";
                    dataGridView1[i++, reloading].Value = ip;
                    dataGridView1[i++, reloading].Value = "0 / 0";
                    dataGridView1[i++, reloading].Value = "inf";
                    dataGridView1[i++, reloading].Value = "-";
                    dataGridView1[i++, reloading].Value = ip;
                }
                else
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
            }
            else
            {
                if (reloading == -1)
                {
                    if (output[0] == "0")
                    {
                        output[0] = "Online";
                    }
                    else
                    {
                        output[0] = "Protected";
                    }
                    dataGridView1.Rows.Add(output);
                }
                else
                {
                    int i = 0;
                    if (output[0] == "0")
                    {
                        dataGridView1[i++, reloading].Value = "Online";
                    }
                    else
                    {
                        dataGridView1[i++, reloading].Value = "Protected";
                    }

                    dataGridView1[i++, reloading].Value = hostname;
                    dataGridView1[i++, reloading].Value = min_playeri + " / " + max_playeri;
                    dataGridView1[i++, reloading].Value = ping;
                    dataGridView1[i++, reloading].Value = gamemode;
                    dataGridView1[i++, reloading].Value = ip;
                }
            }
            dataGridView1.Update();
        }
        private void UserControl2_Load(object sender, EventArgs e)
        {
            this.Show();
            this.Select();
           reloading();
        }

        private void metroButton4_Click_1(object sender, EventArgs e)
        {


        }

        public void reloading()
        {
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
                                    method[j++].epsilon = gamma1;
                                    break;
                                }
                            }
                            catch
                            {
                                method[j++].epsilon = ex[0];
                            }
                            loading(gamma1);
                            counter(j);
                        }
                    }
                }
            }



        }

        private void metroButton3_Click_1(object sender, EventArgs e)
        {
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
                            counter(j);
                        }
                    }
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int columnIndex = dataGridView1.CurrentCell.RowIndex;
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    dataGridView1[i, columnIndex].Selected = true;
                }
                for (int i = 0; i < 5; i++)
                    dataGridView1.Refresh();
                loading(dataGridView1[5, columnIndex].Value.ToString(), columnIndex);
            }
            catch
            {


            }
        }

       
        private void dataGridView1_CellDoubleClick(Object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int columnIndex = dataGridView1.CurrentCell.RowIndex;
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    dataGridView1[i, columnIndex].Selected = true;
                }
                for (int i = 0; i < 5; i++)
                    dataGridView1.Refresh();
                loading(dataGridView1[5, columnIndex].Value.ToString(), columnIndex);
            }
            catch
            {


            }
        }



        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text.Length > 0)
            {
                string save = "@%appdata%\\NeoSAMP\\dataname.db";
                File.WriteAllText(save, metroTextBox1.Text);
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            var x = new Form2(this);
            x.ShowDialog();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
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
                int ok = 0;
                for (int i = 0; i < all; i++)
                {
                    string combine = method[i].epsilon;
                    if (combine != find)
                    {
                        if (ok == 0)
                        {
                            File.WriteAllText(save, combine);
                            ok = 1;
                        }
                        else
                        {
                            File.AppendAllText(save, combine + Environment.NewLine);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                dataGridView1.Rows.RemoveAt(rowindex);
            }
            catch
            {
                MessageBox.Show("You don't have nothing to delete or you didn't selected!");
            }
 
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
