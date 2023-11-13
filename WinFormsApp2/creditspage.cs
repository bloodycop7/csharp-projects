using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class creditspage : UserControl
    {
        public creditspage()
        {
            InitializeComponent();
        }

        private void credit_eon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process openURLProccess = new Process();
            openURLProccess.StartInfo.UseShellExecute = true;
            openURLProccess.StartInfo.FileName = "opera";
            openURLProccess.StartInfo.Arguments = "https://github.com/bloodycop7";
            openURLProccess.Start();
        }
    }
}
