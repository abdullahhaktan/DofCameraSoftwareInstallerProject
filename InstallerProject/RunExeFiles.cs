using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstallerProject
{
    public class RunExeFiles
    {
        public static async Task runCentralExeAsync()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string iCentralexePath = Path.Combine(basePath, @"Setup\iCentral.exe");

            try
            {
                using (Process iCentralProcess = new Process())
                {
                    iCentralProcess.StartInfo.FileName = iCentralexePath;
                    iCentralProcess.StartInfo.UseShellExecute = true; // eğer dosya klasör gibi şeyleri çalıştırmak istiyorsak true yapılır
                    iCentralProcess.EnableRaisingEvents = true; // bu satır olay dinleyicisini titkler.

                    var tcs = new TaskCompletionSource<bool>();
                    iCentralProcess.Exited += (s, e) => tcs.TrySetResult(true);
                    iCentralProcess.Start();

                    await tcs.Task; // bu da işlem bitene kadar processin beklemesini sağlar
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        public static async Task runSentechSdk()
        {
            try
            {
                string basePath = AppDomain.CurrentDomain.BaseDirectory;
                string SentechexePath = Path.Combine(basePath, @"Setup\SentechSDK.exe");


                // Start second process
                Process SentechProcess = Process.Start(new ProcessStartInfo
                {
                    FileName = SentechexePath,
                    UseShellExecute = true
                });

                SentechProcess?.WaitForExit();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
