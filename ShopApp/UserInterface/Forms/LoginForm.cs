namespace UserInterface.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomeForm().ShowDialog();
            this.Close();
        }
    }
}
