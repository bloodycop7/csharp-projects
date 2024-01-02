using System.Drawing.Design;

namespace Contest_Project
{
    public partial class parent_panel : Form
    {
        public void setUserPanel(UserControl userPanel)
        {
            userPanel.Dock = DockStyle.Fill;
            container_main.Controls.Clear();
            container_main.Controls.Add(userPanel);
            userPanel.BringToFront();
        }
        public parent_panel()
        {
            InitializeComponent();

            page_home homePage = new page_home();
            setUserPanel(homePage);
        }

        private void container_left_Paint(object sender, PaintEventArgs e)
        {
        }

        private void container_left_button_home_Click(object sender, EventArgs e)
        {
            page_home homePage = new page_home();
            setUserPanel(homePage);
        }

        private void container_main_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
