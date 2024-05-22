using System;
using System.Threading;
using System.Windows.Forms;

namespace LauncherSAMPInt
{
    public partial class Settings : UserControl
    {
        public Settings() => InitializeComponent();
        
        private void BackClick(object sender, EventArgs e)
        {
            if(metroToggle2.Checked == true && string.IsNullOrWhiteSpace(differentLocationTextBox.Text))
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
            differentLocationButton.Visible = differentLocationTextBox.Visible = differentLocationTextLabel.Visible = metroToggle2.Checked = Data.reading["Location"];
            if(differentLocationTextBox.Visible == true)
            {
                differentLocationTextBox.Text = Data.GTALocation;
            }
        }

        private void ClosingToggle_CheckedChanged(object sender, EventArgs e) => Data.reading["Close"] = metroToggle1.Checked;

        private void LocationToggle_CheckedChanged(object sender, EventArgs e)
        {
            Data.reading["Location"] = metroToggle2.Checked;
            differentLocationButton.Visible = differentLocationTextBox.Visible = differentLocationTextLabel.Visible = metroToggle2.Checked;
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
                            differentLocationTextBox.Text = fbd.SelectedPath));
                            Data.GTALocation = differentLocationTextBox.Text;
                    }
                }
            });
            STAFileThread.SetApartmentState(ApartmentState.STA);
            STAFileThread.Start();
            
        }
    }
}
