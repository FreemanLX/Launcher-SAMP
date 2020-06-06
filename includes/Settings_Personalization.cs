using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neo_San_Andras_Multiplayer
{
#pragma warning disable IDE1006 // Naming Styles
    public partial class Settings_Personalization : UserControl
    {
        public Settings_Personalization()
        {
            InitializeComponent();
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

        private void Settings_Personalization_Load(object sender, EventArgs e)
        {

        }
    }
}
#pragma warning restore IDE1006 // Naming Styles