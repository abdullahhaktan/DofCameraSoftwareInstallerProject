using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static InstallerProject.FrmExe1;

namespace InstallerProject
{
    public partial class FrmExe2: Form
    {
        public int _initialProgress;
        public FrmExe2(int initialProgress = 30)
        {
            InitializeComponent();

            progressBarExe2.Value = initialProgress;
        }




        private void FrmExe2_Load(object sender, EventArgs e)
        {
        }


        private async Task btnNext_ClickAsync(object sender, EventArgs e)
        {
            await RunExeFiles.runSentechSdk();  // EXE kapanana kadar bekle

            progressBarExe2.Value = 60;





            // EXE bittiğinde formu kapat ve diğer forma geç
            //this.Hide();

            //FrmExe2 frmExe2 = new FrmExe2();

            //frmExe2.SetValue(progressBarExe2.Value);

            //frmExe2.Show();


            //string newPath = @"C:\Program Files\iCentral\iCentral\Application\x64";
            //PathEditor.AddPathToSystem(newPath);
            //CopyItems();
            //MoveExeToStartup();
            //this.Close();
        }




        private async void btnNext1_Click(object sender, EventArgs e)
        {
            await  btnNext_ClickAsync(sender,e);

            FrmPath frmPath = new FrmPath(60);

            frmPath.Show();

            this.Hide();
        }
    }
}
