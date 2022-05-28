using DataAccessLayer.Repositories;
using UserInterface.Forms.Facory;

namespace UserInterface.Forms
{
    public partial class RegistrationForm : Form
    {
        private readonly FormsFactory formsFactory;
        private readonly IUserRepository userRepository;
        public RegistrationForm(FormsFactory formsFactory, IUserRepository userRepository)
        {
            InitializeComponent();

            this.formsFactory = formsFactory;
            this.userRepository = new UserRepository();
        }

        private void backBatton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.formsFactory.CreateForm(FormType.Home).ShowDialog();
            this.Close();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            string email = Guid.NewGuid().ToString();
            string password = Guid.NewGuid().ToString();
            string firstName = Guid.NewGuid().ToString();
            string lastName = Guid.NewGuid().ToString();
            this.userRepository.Add(email, password, firstName, lastName);

            // TODO: Obsługa walidacji danych (w formularzu i w DataAccessLayer)
            // TODO: Dodanie rejestracji uzytkownika
            throw new NotImplementedException();
        }
    }
}
