using System;
using System.Threading;
using System.Windows.Forms;

namespace LauncherSAMPInt
{
    public partial class Advanced_settings : UserControl
    {
        public Advanced_settings() => InitializeComponent();
        
        private void BackClick(object sender, EventArgs e)
        {
            if(metroToggle2.Checked == true && string.IsNullOrWhiteSpace(TextLocation.Text))
            {
                Thread MessageSTAThread = 
                    new Thread(() =>
                    MessageBox.Show("Select a location for GTA San Andreas, or disable different directory to use the local folder", "Select GTA San Andreas Folder"))
                    #pragma warning disable CS0618 // Type or member is obsolete
                    { ApartmentState = ApartmentState.STA };
                    #pragma warning restore CS0618 // Type or member is obsolete
                MessageSTAThread.Start();
                return;
            }
            Data.defaultform_generally.ContentPanel.Controls.Remove(Data.defaultform_generally.ContentPanel.GetControlFromPosition(1, 0));
            Data.defaultform_generally.ContentPanel.Controls.Add(new Settings { Dock = DockStyle.Fill }, 1, 0);
            Dispose();
        }

        private void Advanced_settings_Load(object sender, EventArgs e)
        {
            metroToggle1.Checked = Data.reading["Close"];
            BrowseLocation.Visible = TextLocation.Visible = LabelLocation.Visible = metroToggle2.Checked = Data.reading["Location"];
            if(TextLocation.Visible == true)
            {
                TextLocation.Text = Data.GTALocation;
            }
        }

        private void ClosingToggle_CheckedChanged(object sender, EventArgs e) => Data.reading["Close"] = metroToggle1.Checked;

        private void LocationToggle_CheckedChanged(object sender, EventArgs e)
        {
            Data.reading["Location"] = metroToggle2.Checked;
            BrowseLocation.Visible = TextLocation.Visible = LabelLocation.Visible = metroToggle2.Checked;
        }

        private void BrowseLocation_Click(object sender, EventArgs e)
        {
            Thread STAFileThread = new Thread(() =>
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    if (fbd.ShowDialog() == DialogResult.OK && 
                            !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                            Invoke(new Action(()=>
                            TextLocation.Text = fbd.SelectedPath));
                            Data.GTALocation = TextLocation.Text;
                    }
                }
            });
            STAFileThread.SetApartmentState(ApartmentState.STA);
            STAFileThread.Start();
            
        }
    }
}
