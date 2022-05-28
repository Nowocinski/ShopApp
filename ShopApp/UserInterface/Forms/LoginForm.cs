using DataAccessLayer.Repositories;
using DataAccessLayer.ViewModel;
using UserInterface.Forms.Facory;

namespace UserInterface.Forms
{
    public partial class LoginForm : Form
    {
        private readonly FormsFactory formsFactory;
        private readonly IUserRepository userRepository;
        public LoginForm(FormsFactory formsFactory, IUserRepository userRepository)
        {
            InitializeComponent();

            this.formsFactory = formsFactory;
            this.userRepository = userRepository;
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.formsFactory.CreateForm(FormType.Home).ShowDialog();
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            UserViewModel user = this.userRepository.LogIn(this.emailTextBox.Text, this.passwordTextBox.Text);

            if (user is null)
            {
                // TODO: Obsługa przypadku kiedy użytkownik nie istnieje w bazie danych.
                throw new NotImplementedException();
            }

            this.Hide();
            this.formsFactory.CreateForm(FormType.ProductList).ShowDialog();
            this.Close();
        }
    }
}
