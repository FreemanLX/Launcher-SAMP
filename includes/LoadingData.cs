using System;
using System.Threading;
using System.IO;


namespace LauncherSAMPInt
{
    public partial class LoadingData : MetroFramework.Forms.MetroForm
    {
        public LoadingData() => InitializeComponent();

        private void Loading()
        {
            string settings_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\LAMP";
            if (!File.Exists(settings_path + "\\settings.set"))
            {
                if (!Directory.Exists(settings_path)) Directory.CreateDirectory(settings_path);
                
                File.Create(settings_path + "\\settings.set").Close();
                bool location = false, dark = false, close = false;
                string[] output = new string[] { "Location 0", "Dark 0", "Close 0" };

                Data.reading["Location"] = location;
                Data.reading["Close"] = close;
                Data.reading["Dark"] = dark;
                foreach (string temp in output)
                {
                    File.AppendAllText(settings_path + "\\settings.set", temp + Environment.NewLine);
                }
            }
            else
            {
                string[] read = File.ReadAllLines(settings_path + "\\settings.set");
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
            loadingBox.BackColor = System.Drawing.Color.Transparent;
            loadingBox.Show();
            loadingBox.Refresh();
            Thread loading = new Thread(() => {
                Thread.Sleep(1000);
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
