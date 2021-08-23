using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LauncherSAMPInt
{
    public partial class Screenshots : UserControl
    {
        public Screenshots()
        {
            InitializeComponent();
        }

        string[] GetScreenshotsPaths;
        int j;
        void ReadPicture(string[] s)
        {
            string temp = s[j];
            Bitmap x = new Bitmap(temp);
            int y = 0, z = 0;
            Color pixelColor = x.GetPixel(y, z);
            x.SetPixel(340, 290, pixelColor);
            pictureBox1.Image = x;
        }

        private void Screenshots_Load(object sender, EventArgs e)
        {
            string screenshots = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\GTA San Andreas User Files\\SAMP\\screens\\";
            if (Directory.Exists(screenshots))
            {
                GetScreenshotsPaths = Directory.GetFiles(screenshots, "*.png");
                if (GetScreenshotsPaths != null)
                {
                    j = 0;
                    ReadPicture(GetScreenshotsPaths);
                }
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (j == GetScreenshotsPaths.Length - 1) MessageBox.Show("You can't move before because this is the last picture", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else { ++j; ReadPicture(GetScreenshotsPaths); }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (j == 0) MessageBox.Show("You can't move before because this is the first picture", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else { j--; ReadPicture(GetScreenshotsPaths); }
        }
    }
}
