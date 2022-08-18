using ProductStore.Domain;

namespace ProductStore.Application.Contracts
{
    public interface IProductRepository : IAsyncRepository<Product>
    {
        Task<IReadOnlyList<Product>> GetAllProductsAsync(bool includeCategory);
        Task<Product> GetProductByIdAsync(Guid id, bool includeCategory);
    }
}
