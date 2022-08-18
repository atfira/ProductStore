using Microsoft.EntityFrameworkCore;
using ProductStore.Application.Contracts;
using ProductStore.Domain;

namespace ProductStore.Persistence.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(ProductDbContext productDbContext) : base(productDbContext)
        {

        }
        public async Task<IReadOnlyList<Product>> GetAllProductsAsync(bool includeCategory)
        {
            List<Product> allProducts = new List<Product>();
            allProducts = includeCategory ? await _dbContext.Products.Include(x => x.Category).ToListAsync() 
                                          : await _dbContext.Products.ToListAsync();
            return allProducts;
        }

        public async Task<Product> GetProductByIdAsync(Guid id, bool includeCategory)
        {
            var product = new Product();
            product = includeCategory ? await _dbContext.Products.Include(x => x.Category).FirstOrDefaultAsync(x => x.Id == id) 
                                      : await GetByIdAsync(id);
            return product;
        }
    }

}