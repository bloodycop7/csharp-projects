using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp2
{
    

    public partial class page_homeButton : UserControl
    {
        public page_homeButton()
        {
            InitializeComponent();

            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("lang", "eng");
            dic.Add("darkTheme", "1");

            string json = JsonSerializer.Serialize(dic);

            StreamWriter file = new StreamWriter("C:\\Users\\User\\AppData\\Roaming\\eontest.json");
            file.Write(json);
            file.Close();
        }
    }
}
