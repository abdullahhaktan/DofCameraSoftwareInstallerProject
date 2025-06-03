using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstallerProject
{
    public partial class FrmPath: Form
    {
        public FrmPath(int initialProgress=60)
        {
            InitializeComponent();

            progressBarPath.Value = initialProgress;

        }

        public class PathEditor
        {
            public static void AddPathToSystem(string newPath)
            {
                const string regKey = @"SYSTEM\CurrentControlSet\Control\Session Manager\Environment";

                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(regKey, true))
                {
                    if (key == null)
                        throw new Exception("Registery book couldnt be opened...");

                    string pathValue = key.GetValue("Path").ToString();

                    if (!pathValue.ToLower().Contains(newPath.ToLower()))
                    {
                        string updated = pathValue + ";" + newPath;
                        key.SetValue("Path", updated, RegistryValueKind.ExpandString);
                        SendEnvironmentChangeMessage();
                        MessageBox.Show("the releated path added into environment variables...");
                    }
                    else
                    {
                        MessageBox.Show("Path is Added to environment variables already");
                    }
                }
            }

            [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
            private static extern int SendMessage(int hWnd, int Msg, IntPtr wParam, string lParam);

            private static void SendEnvironmentChangeMessage()
            {
                const int HWND_BROADCAST = 0xFFFF;
                const int WM_SETTINGCHANGE = 0x001A;
                SendMessage(HWND_BROADCAST, WM_SETTINGCHANGE, IntPtr.Zero, "Environment");
            }
        }

        private void btnNext2_Click(object sender, EventArgs e)
        {
            string newPath = @"C:\Program Files\iCentral\iCentral\Application\x64";
            PathEditor.AddPathToSystem(newPath);
            progressBarPath.Value = 80;

            FrmSetup frmSetup = new FrmSetup(80);

            frmSetup.Show();

            this.Hide();

        }

        private void FrmPath_Load(object sender, EventArgs e)
        {

        }
    }
}
