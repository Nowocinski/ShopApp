using DataAccessLayer.Repositories;
using DataAccessLayer.ViewModel;

namespace UserInterface.Forms
{
    public partial class LoginForm : Form
    {
        private readonly IUserRepository userRepository;
        public LoginForm()
        {
            InitializeComponent();

            // TODO: Do zastanowienia. Działa, ale tworzenie obiektu powinno wykonywać się przez DI.
            this.userRepository = new UserRepository();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomeForm().ShowDialog();
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            UserViewModel user = this.userRepository.LogIn(this.emailTextBox.Text, this.passwordTextBox.Text);
        }
    }
}
