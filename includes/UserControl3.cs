using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Net;
using System.Text;

namespace Neo_San_Andras_Multiplayer
{
#pragma warning disable IDE1006 // Naming Styles
    public partial class UserControl3 : UserControl
    {
        string[] temp;
        int j;
        void read_pictures(string[] s)
        {
            string temp = s[j];
            Bitmap x = new Bitmap(temp);
            int y = 0, z = 0;
            Color pixelColor = x.GetPixel(y, z);
            x.SetPixel(340, 290, pixelColor);
            pictureBox1.Image = x;
        }

        void upload(string[] s)
        {
            string temp = s[j];
            
        }

   

        public UserControl3()
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
            s = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\GTA San Andreas User Files\\SAMP\\screens\\";
            if (Directory.Exists(s))
            {
                temp = Directory.GetFiles(s, "*.png");
                if (temp != null)
                {
                    j = 0;
                    read_pictures(temp);
                }
            }
        }

#pragma warning disable IDE1006 // Naming Styles
        private void richTextBox1_TextChanged(object sender, EventArgs e){ }
        private void button1_Click(object sender, EventArgs e)
        {
            if (j == temp.Length - 1) MessageBox.Show("You can't move before because this is the last picture", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else { ++j; read_pictures(temp); }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (j == 0) MessageBox.Show("You can't move before because this is the first picture", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else { j--; read_pictures(temp); }
        }

        private void UserControl3_Load(object sender, EventArgs e){
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.Items.Count - 1; i > -1; i--) listBox1.Items.RemoveAt(i);
            listBox1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
#pragma warning restore IDE1006 // Naming Styles