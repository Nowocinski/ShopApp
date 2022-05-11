namespace UserInterface.Forms
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void loggingButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().ShowDialog();
            this.Close();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RegistrationForm().ShowDialog();
            this.Close();
        }
    }
}
