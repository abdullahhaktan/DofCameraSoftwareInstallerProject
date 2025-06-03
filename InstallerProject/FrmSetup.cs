using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstallerProject
{
    public partial class FrmSetup: Form
    {
        public FrmSetup(int value)
        {
            InitializeComponent();
            progressBarSituaiton.Value = value;
        }

        public static string CreateShortcut()
        {
            string currentDirectory = @"C:\Camera\SaveImageToFile.exe";



            // Dosya adını dizinle birleştir
            string filePath = Path.Combine(currentDirectory, "");


            string userName = Environment.UserName;
            string exePath = currentDirectory;
            string tempFolder = Path.GetTempPath(); // Geçici klasöre oluştur
            string shortcutName = "SaveImageToFile.lnk";
            string shortcutFullPath = Path.Combine(tempFolder, shortcutName);



            try
            {
                if (!System.IO.File.Exists(exePath))
                    throw new FileNotFoundException("EXE file is not found", exePath);

                WshShell shell = new WshShell();
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutFullPath);
                shortcut.TargetPath = exePath;
                shortcut.WorkingDirectory = Path.GetDirectoryName(exePath);
                shortcut.WindowStyle = 1;
                shortcut.Description = "automotically start SaveImageToFile";
                shortcut.Save();

                return shortcutFullPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show("shortcut couldnt be created:\n" + ex.Message);
                return null;
            }
        }



        //public static void RunExeFiles()
        //{
        //    try
        //    {

        //        string basePath = AppDomain.CurrentDomain.BaseDirectory;
        //        string iCentralexePath = Path.Combine(basePath, @"Setup\iCentral.exe");
        //        string SentechexePath = Path.Combine(basePath, @"Setup\SentechSDK.exe");



        //        // Start the processes
        //        Process iCentraltProcess = Process.Start(new ProcessStartInfo
        //        {
        //            FileName = iCentralexePath,
        //            UseShellExecute = true
        //        });
        //        iCentraltProcess?.WaitForExit();

        //        // Start second process
        //        Process SentechProcess = Process.Start(new ProcessStartInfo
        //        {
        //            FileName = SentechexePath,
        //            UseShellExecute = true
        //        });

        //        SentechProcess?.WaitForExit();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message);
        //    }
        //}


        public static void CopyItems()
        {
            string userName = Environment.UserName;
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string folderPath = Path.Combine(basePath, "Setup");
            MessageBox.Show($"Path: {folderPath}");

            string sourceDirectory = folderPath;
            string targetDirectory = @"C:\Camera";

            // Create target directory if it doesn't exist
            if (!Directory.Exists(targetDirectory))
            {
                Directory.CreateDirectory(targetDirectory);
                Console.WriteLine("Directory has been created: " + targetDirectory);
            }
            else
            {
                Console.WriteLine("Directory is available: " + targetDirectory);
            }

            // Copy all files in the main Setup folder
            string[] files = Directory.GetFiles(sourceDirectory);
            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                string destFile = Path.Combine(targetDirectory, fileName);
                System.IO.File.Copy(file, destFile, overwrite: true);
            }

            // Copy the "config" folder and its contents
            string configSourcePath = Path.Combine(sourceDirectory, "config");
            string configTargetPath = Path.Combine(targetDirectory, "config");

            if (Directory.Exists(configSourcePath))
            {
                CopyDirectory(configSourcePath, configTargetPath);
                MessageBox.Show("Config folder copied.");
            }
            else
            {
                MessageBox.Show("Config folder does not exist.");
            }

            MessageBox.Show("All files and folders copied successfully");
        }

        // Recursive directory copy
        public static void CopyDirectory(string sourceDir, string targetDir)
        {
            Directory.CreateDirectory(targetDir);

            foreach (string file in Directory.GetFiles(sourceDir))
            {
                string fileName = Path.GetFileName(file);
                string destFile = Path.Combine(targetDir, fileName);
                System.IO.File.Copy(file, destFile, true);
            }

            foreach (string subDir in Directory.GetDirectories(sourceDir))
            {
                string dirName = Path.GetFileName(subDir);
                string targetSubDir = Path.Combine(targetDir, dirName);
                CopyDirectory(subDir, targetSubDir);
            }
        }




        public static void MoveExeToStartup()
        {
            string shortcutPath = CreateShortcut(); // .lnk dosyası yolu

            if (string.IsNullOrEmpty(shortcutPath))
                return;

            string startupFolder = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            string destinationPath = Path.Combine(startupFolder, Path.GetFileName(shortcutPath));

            try
            {
                if (System.IO.File.Exists(destinationPath))
                {
                    MessageBox.Show("the exe is available in Startup directory.");
                    return;
                }

                System.IO.File.Move(shortcutPath, destinationPath); // Geçici klasörden taşı
                MessageBox.Show("Shortcut moved successfully:\n" + destinationPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("an error occured while moving:\n" + ex.Message);
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            CopyItems();
            MoveExeToStartup();
            progressBarSituaiton.Value = 100;
            string message = "Installing are completed successfully";
            string title = "Successfully";
            FrmCustomMessageBox frm = new FrmCustomMessageBox(message,title);
            frm.Show();

            this.Close();
        }

        private void FrmSetup_Load(object sender, EventArgs e)
        {

        }
    }
}
