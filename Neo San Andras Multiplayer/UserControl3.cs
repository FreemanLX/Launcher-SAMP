using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace Neo_San_Andras_Multiplayer
{
    public partial class UserControl3 : UserControl
    {
        string last;
        void set(string temp)
        {
            last = temp;
        }
        public UserControl3()
        {
            InitializeComponent();
            string s = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            s += "\\GTA San Andreas User Files\\SAMP\\chatlog.txt";
            try
            {
                richTextBox1.LoadFile(s, RichTextBoxStreamType.PlainText);
            }
            catch { }
            s = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\GTA San Andreas User Files\\SAMP\\screens\\";
            string temp = "sa-mp-";
            string picture = "000";
            set(picture);
            Bitmap x = new Bitmap(s + temp + picture + ".png");
            int y = 0, z = 0;
            Color pixelColor = x.GetPixel(y, z);
            x.SetPixel(340, 290, pixelColor);
            pictureBox1.Image = x;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        string gobefore(string s)
        {
            char[] s1 = new char[3];
            s1[0] = s[0];
            s1[1] = s[1];
            s1[2] = s[2];
            return s1.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string s = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\GTA San Andreas User Files\\SAMP\\screens\\";
            string temp = "sa-mp-";
            string picture = last;
            set(picture);
            Bitmap x =  new Bitmap(s + temp + picture + ".png");
            Color pixelColor = x.GetPixel(340, 290);
            x.SetPixel(340, 290, pixelColor);
            pictureBox1.Image = x;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\GTA San Andreas User Files\\SAMP\\screens\\";
            string temp = "sa-mp-";
            string picture = last;
            set(picture);
            pictureBox1.Image = new Bitmap(s + temp + picture + ".png");
        }
    }
}
