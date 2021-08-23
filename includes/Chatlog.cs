using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Net;
using System.Text;

namespace LauncherSAMPInt
{
#pragma warning disable IDE1006 // Naming Styles
    public partial class Chatlog : UserControl
    {


        public Chatlog()
        {
            InitializeComponent();
            string s = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\GTA San Andreas User Files\\SAMP\\chatlog.txt";
            if (File.Exists(s))
            {
                try
                {
                    string[] alpha = File.ReadAllLines(s);
                    foreach (string al in alpha) listBox1.Items.Add(al);
                }
                catch { }
              
            }
        }

#pragma warning disable IDE1006 // Naming Styles
        private void richTextBox1_TextChanged(object sender, EventArgs e){ }

        private void UserControl3_Load(object sender, EventArgs e){
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.Items.Count - 1; i > -1; i--) listBox1.Items.RemoveAt(i);
            listBox1.Refresh();
        }
    }
}
#pragma warning restore IDE1006 // Naming Styles