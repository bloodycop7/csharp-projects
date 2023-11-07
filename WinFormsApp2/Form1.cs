namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            homepage homePage = new homepage();
            addUserControl(homePage);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            topContainer.Controls.Clear();
            topContainer.Controls.Add(userControl);
            userControl.BringToFront();

            button1.Text = "Was PRessed";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            homepage homePage = new homepage();
            addUserControl(homePage);

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            creditspage creditsPage = new creditspage();
            addUserControl(creditsPage);
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}