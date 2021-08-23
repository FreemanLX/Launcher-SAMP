using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LauncherSAMPInt
{
#pragma warning disable IDE1006 // Naming Styles
    public partial class Settings_Personalization : UserControl
    {
        public Settings_Personalization()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e){

            Data.defaultform_generally.ContentPanel.Controls.Remove(Data.defaultform_generally.ContentPanel.GetControlFromPosition(1, 0));
            Data.defaultform_generally.ContentPanel.Controls.Add(new Settings { Dock = DockStyle.Fill }, 1, 0);
            Dispose();
        }
        private void Settings_Personalization_Load(object sender, EventArgs e)
        {

        }
    }
}
