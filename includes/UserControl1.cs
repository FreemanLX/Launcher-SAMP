using System;
using System.Windows.Forms;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Neo_San_Andras_Multiplayer
{
    public partial class UserControl1 : UserControl
    {
#pragma warning disable IDE1006 // Naming Styles
        public UserControl1()
        {
            InitializeComponent();
            try
            {
                Parent.Controls.Clear();
            }
            catch
            {

            }
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
        }

        Settings_Personalization x = new Settings_Personalization();
        About y = new About();
        Advanced_settings z = new Advanced_settings();
        private void UserControl1_Load(object sender, EventArgs e) {
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent
            button3.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent
            try
            {
                this.Parent.Controls.Remove(x);
            }
            catch {
                try
                {
                    this.Parent.Controls.Remove(y);
                }
                catch {
                    try
                    {
                        this.Parent.Controls.Remove(z);
                    }
                    catch { }
                }

            }
            
          
            /// Parent.Controls.Clear();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            x.Location = new Point(145, 72);
            Hide();
            Parent.Controls.Add(x);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            z.Location = new Point(145, 72);
            Hide();
            Parent.Controls.Add(z);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            y.Location = new Point(145, 72);
            Hide();
            Parent.Controls.Add(y);
        }
    }
}
#pragma warning restore IDE1006 // Naming Styles
