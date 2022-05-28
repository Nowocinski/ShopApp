using DataAccessLayer.Repositories;

namespace UserInterface.Forms.Facory
{
    public class FormsFactory
    {
        private readonly IProductRepository productRepository;
        private readonly IUserRepository userRepository;
        public FormsFactory(IProductRepository productRepository, IUserRepository userRepository)
        {
            this.productRepository = productRepository;
            this.userRepository = userRepository;
        }
        public Form CreateForm(FormType type)
        {
            switch (type)
            {
                case FormType.Home: 
                    return new HomeForm(this);
                case FormType.Login:
                    return new LoginForm(this, this.userRepository);
                case FormType.Registration:
                    return new RegistrationForm(this, this.userRepository);
                case FormType.ProductList:
                    return new ProductListForm(this.productRepository);
                default:
                    throw new Exception($"Form type {type} is not handled.");
            }
        }
    }
}
