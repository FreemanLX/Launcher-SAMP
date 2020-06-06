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
    public partial class Advanced_settings : UserControl
    {
#pragma warning disable IDE1006 // Naming Styles
        public Advanced_settings()
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

        private void Advanced_settings_Load(object sender, EventArgs e)
        {
            Reading q = new Reading();
            bool s = q.recieve("Close");
            metroToggle1.Checked = s;
            s = q.recieve("Location");
            metroToggle2.Checked = s;
        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            Reading q = new Reading("Close", metroToggle1.Checked);
        }

        private void metroToggle2_CheckedChanged(object sender, EventArgs e)
        {
            Reading q = new Reading("Location", metroToggle2.Checked);
        }

        private void metroToggle3_CheckedChanged(object sender, EventArgs e)
        {
            Reading q = new Reading("Beta", metroToggle2.Checked);
        }
    }
}
#pragma warning restore IDE1006 // Naming Styles