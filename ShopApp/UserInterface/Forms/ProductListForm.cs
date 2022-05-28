using DataAccessLayer.Repositories;
using DataAccessLayer.ViewModel;

namespace UserInterface.Forms
{
    public partial class ProductListForm : Form
    {
        private readonly IProductRepository productRepository;
        public ProductListForm()
        {
            InitializeComponent();

            this. productRepository = new ProductRepository();
        }

        private async void ProductListForm_Load(object sender, EventArgs e)
        {
            IEnumerable<ProductViewModel> products = await productRepository.GetAllAsync();
            throw new NotImplementedException();
        }
    }
}
