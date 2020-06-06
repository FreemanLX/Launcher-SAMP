using System;
using System.Drawing;
using System.Windows.Forms;

namespace Neo_San_Andras_Multiplayer
{
#pragma warning disable IDE0017 // Naming Styles
#pragma warning disable IDE1006 // Naming Styles
    public partial class About : UserControl
    {
        public About()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
#pragma warning disable IDE0017 // Naming Styles
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var x = new UserControl1();
            x.Location = new Point(145, 72);
            this.Parent.Controls.Add(x);
            this.Dispose();
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {
                
        }

        private void About_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {
            var x = new Form4();
            x.ShowDialog();
        }
    }
}
#pragma warning restore IDE1006 // Naming Styles
