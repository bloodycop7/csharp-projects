using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class settingspage : UserControl
    {
        public settingspage()
        {
            InitializeComponent();
        }

        // TODO: Make the value save and be accessable everywhere OR store the value (somehow).
        private void checkBox_darkMode_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_darkMode.Checked) // Turn on dark mode.
            {
                settingsLabel.ForeColor = Color.White;
                BackColor = Color.Black;
            }
            else
            {
                settingsLabel.ForeColor = Color.Black;
                BackColor = Color.White;
            }
        }
    }
}
