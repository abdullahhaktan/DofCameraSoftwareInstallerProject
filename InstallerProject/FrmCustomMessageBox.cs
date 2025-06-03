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
    public partial class FrmCustomMessageBox : Form
    {
        public FrmCustomMessageBox(string message, string title)
        {
            InitializeComponent();
            this.Text = title;
            lblMessage.Text = message;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //public static void Sho(string message, string title = "Info")
        //{
        //    FrmCustomMessageBox box = new FrmCustomMessageBox(message, title);
        //    box.ShowDialog();
        //}

        private void FrmCustomMessageBox_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
