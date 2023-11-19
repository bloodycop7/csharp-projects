using System.IO;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            Controller.ThemeChange();

            homepage homePageLol = new homepage();
            addUserControl(homePageLol);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            topContainer.Controls.Clear();
            topContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            homepage homePageLol = new homepage();
            addUserControl(homePageLol);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            settingspage settingsPageLol = new settingspage();
            addUserControl(settingsPageLol);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            creditspage creditsPageLol = new creditspage();
            addUserControl(creditsPageLol);
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}