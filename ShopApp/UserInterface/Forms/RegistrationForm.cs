namespace UserInterface.Forms
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void backBatton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomeForm().ShowDialog();
            this.Close();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {

        }
    }
}
