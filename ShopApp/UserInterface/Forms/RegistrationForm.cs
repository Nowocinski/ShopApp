using DataAccessLayer.Repositories;

namespace UserInterface.Forms
{
    public partial class RegistrationForm : Form
    {
        private readonly IUserRepository userRepository;
        public RegistrationForm()
        {
            InitializeComponent();

            // TODO: Do zastanowienia. Działa, ale tworzenie obiektu powinno wykonywać się przez DI.
            this.userRepository = new UserRepository();
        }

        private void backBatton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomeForm().ShowDialog();
            this.Close();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            string email = Guid.NewGuid().ToString();
            string password = Guid.NewGuid().ToString();
            string firstName = Guid.NewGuid().ToString();
            string lastName = Guid.NewGuid().ToString();
            this.userRepository.Add(email, password, firstName, lastName);

            throw new NotImplementedException();
        }
    }
}
