using System;
using System.Threading;
using System.IO;


namespace LauncherSAMPInt
{
    public partial class Loading_Files : MetroFramework.Forms.MetroForm
    {
        public Loading_Files() => InitializeComponent();

        private void Loading()
        {
            string settings_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\NeoSAMP\\settings.set";
            if (!File.Exists(settings_path))
            {
                File.Create(settings_path).Close();
                bool location = false, dark = false, close = false;
                string[] output = new string[3];
                output[0] = "Location 0";
                output[1] = "Dark 0";
                output[2] = "Close 0";

                Data.reading["Location"] = location;
                Data.reading["Close"] = close;
                Data.reading["Dark"] = dark;
                foreach (string temp in output)
                {
                    File.AppendAllText(settings_path, temp + Environment.NewLine);
                }
            }
            else
            {
                string[] read = File.ReadAllLines(settings_path);
                foreach (string temp in read)
                {
                    string[] temp1 = temp.Split(' ');
                    Data.reading[temp1[0]] = Convert.ToBoolean(int.Parse(temp1[1]));
                }
            }
        }
        private void Loading_Files_Load(object sender, EventArgs e)
        {
            Activate();
            Shown += new EventHandler(FormShown);
        }

        static WaitHandle[] waitHandles = new WaitHandle[]
        {
            new AutoResetEvent(false)
        };

        public void FormShown(object sender, EventArgs e)
        {
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Show();
            pictureBox1.Refresh();
            Thread loading = new Thread(() => {
                Thread.Sleep(500);
                Loading();
                Invoke(new Action(() => Hide()));
                DefaultForm Program = new DefaultForm();
                Program.ShowDialog();
                Program.BringToFront();
            })
            {IsBackground = true};
            loading.Start();
            
        }

    }
}
