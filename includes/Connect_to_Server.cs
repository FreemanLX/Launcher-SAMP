using MetroFramework.Forms;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace LauncherSAMPInt
{
          public partial class Connect_to_Server : MetroForm
          {
                    public static string ExeDir(bool location) => (location == false) ? Directory.GetCurrentDirectory() : Data.GTALocation;

                    public static string SAMPDLLPath(bool location) => ExeDir(location) + "\\samp.dll";

                    public static string GTASAExePath(bool location) => ExeDir(location) + "\\gta_sa.exe";

                    public static bool IsSAMPAvailable(bool location) => File.Exists(GTASAExePath(location)) && File.Exists(SAMPDLLPath(location));

                    public Connect_to_Server(
                          string ip,
                          string dns,
                          string ping,
                          string username,
                          string port = "7777",
                          string password = "No")
                    {
                          InitializeComponent();
                          metroLabel4.Text = ip;
                          metroLabel8.Text = ping;
                          metroLabel9.Text = port;
                          metroLabel11.Text = password;
                          textBox1.Text = dns;
                          if (password == "Password")
                             metroLabel6.Text = "Yes";
                          else
                             metroLabel6.Text = "No";
                          if (password == "Offline")
                              metroButton1.Enabled = false;
                          else
                              metroButton1.Enabled = true;
                              this.username = username;
                    }

                    private void Connect_Click(object sender, EventArgs e)
                    {
                          if (IsSAMPAvailable(Data.reading["Location"]))
                          {
                                StringBuilder stringBuilder = new StringBuilder();
                                bool flag2 = true;
                                string[] strArray1 = new string[7]
                                {
                                      "-c", "-h", metroLabel4.Text, "-p", metroLabel9.Text, "-n", username
                                };
                                foreach (string str in strArray1)
                                {
                                      if (flag2) flag2 = false;
                                      else stringBuilder.Append(" ");
                                      stringBuilder.Append(str);
                                }

                                    IntPtr procAddress = Kernel32.GetProcAddress(Kernel32.GetModuleHandle("kernel32.dll"), "LoadLibraryW");

                                    Kernel32.STARTUPINFO lpStartupInfo = new Kernel32.STARTUPINFO();
                                    if (Kernel32.CreateProcess(GTASAExePath(Data.reading["Location"]), stringBuilder.ToString(), 
                                        IntPtr.Zero, IntPtr.Zero, false, 12U, IntPtr.Zero, ExeDir(Data.reading["Location"]), ref lpStartupInfo, 
                                        out Kernel32.PROCESS_INFORMATION lpProcessInformation))
                                    {
                                        IntPtr VirtualAllocPtr = Kernel32.VirtualAllocEx(lpProcessInformation.hProcess, IntPtr.Zero, (uint)((SAMPDLLPath(Data.reading["Location"]).Length + 1) * 2), 
                                            Kernel32.AllocationType.Commit | Kernel32.AllocationType.Reserve, Kernel32.MemoryProtection.ReadWrite);

                                        if (VirtualAllocPtr != IntPtr.Zero)
                                        {
                                            byte[] LocationPathBytes = Encoding.Unicode.GetBytes(SAMPDLLPath(Data.reading["Location"]));
                                            byte[] nullBytes = Encoding.Unicode.GetBytes("\0");
                                            if (Kernel32.WriteProcessMemory(lpProcessInformation.hProcess, VirtualAllocPtr, LocationPathBytes, (uint)LocationPathBytes.Length, out int lpNumberOfBytesWritten) && Kernel32.WriteProcessMemory(lpProcessInformation.hProcess, new IntPtr(VirtualAllocPtr.ToInt64() + (long)LocationPathBytes.Length), nullBytes, (uint)nullBytes.Length, out lpNumberOfBytesWritten))
                                            {
                                                IntPtr remoteThread = Kernel32.CreateRemoteThread(lpProcessInformation.hProcess, IntPtr.Zero, 0U, procAddress, VirtualAllocPtr, 4U, out uint lpThreadId);
                                                if (remoteThread != IntPtr.Zero)
                                                {
                                                    Kernel32.ResumeThread(remoteThread);
                                                    Kernel32.WaitForSingleObject(remoteThread, uint.MaxValue);
                                                    if (Data.reading["Close"]) Data.Save();
                                                    else Close();
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Failed to create remote thread with \"CreateRemoteThread\".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Failed to write into process memory with \"WriteProcessMemory\".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                            }
                                            Kernel32.VirtualFreeEx(lpProcessInformation.hProcess, VirtualAllocPtr, 0, Kernel32.AllocationType.Release);
                                        }
                                        else
                                        {
                                            MessageBox.Show("Failed to allocate memory with \"VirtualAllocEx\".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                        }
                                        Kernel32.ResumeThread(lpProcessInformation.hThread);
                                        Kernel32.CloseHandle(lpProcessInformation.hProcess);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Failed to create process \"" + GTASAExePath(Data.reading["Location"]) + "\"", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    }
                                

                          }
                          else
                          {
                             MessageBox.Show("GTA San Andreas is not installed on \"" + ExeDir(Data.reading["Location"]) + "\".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                          }
                          if (!Data.reading["Close"]) return;
                          Environment.Exit(0);
                        }

                private void CloseClick(object sender, EventArgs e) => Close();

        private void Connect_to_Server_Load(object sender, EventArgs e)
        {

        }
    }
}
