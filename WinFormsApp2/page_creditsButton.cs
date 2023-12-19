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
    public partial class page_creditsButton : UserControl
    {
        public page_creditsButton()
        {
            InitializeComponent();
        }

        private void credit_eon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("explorer", "https://github.com/bloodycop7");
            Process.Start(sInfo);
        }
    }
}
