using System;
using System.Windows.Forms;

namespace LauncherSAMPInt
{
    public partial class About : UserControl
    {
        public About() => InitializeComponent();
        private void BackButton_Click(object sender, EventArgs e)
        {
            Data.defaultform_generally.ContentPanel.Controls.Remove(Data.defaultform_generally.ContentPanel.GetControlFromPosition(1, 0));
            Data.defaultform_generally.ContentPanel.Controls.Add(new Settings { Dock = DockStyle.Fill }, 1, 0);
            Dispose();
        }


        private void About_Load(object sender, EventArgs e)
        {

        }

    }
}
