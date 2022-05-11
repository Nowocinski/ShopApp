using DataAccessLayer.Context;
using DataAccessLayer.Models;
using DataAccessLayer.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductViewModel>> GetAllAsync();
    }

    public class ProductRepository : IProductRepository
    {
        private readonly DataBaseContext context;
        public ProductRepository()
        {
            this.context = DataBaseContext.Instance;
        }
        public async Task<IEnumerable<ProductViewModel>> GetAllAsync()
        {
            IEnumerable<Product> products = await this.context.Product.ToListAsync();
            return products.Select(x => new ProductViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                Price = x.Price
            });
        }
    }
}
