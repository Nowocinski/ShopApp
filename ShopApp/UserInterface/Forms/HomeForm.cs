using UserInterface.Forms.Facory;

namespace UserInterface.Forms
{
    public partial class HomeForm : Form
    {
        private readonly FormsFactory formsFactory;
        public HomeForm(FormsFactory formsFactory)
        {
            InitializeComponent();
            this.formsFactory = formsFactory;
        }

        private void loggingButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.formsFactory.CreateForm(FormType.Login).ShowDialog();
            this.Close();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.formsFactory.CreateForm(FormType.Registration).ShowDialog();
            this.Close();
        }
    }
}
