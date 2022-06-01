using ProductAPI.Data.Entities;

namespace ProductAPI.Services
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProductsAsync();

        Task<Product?> GetProductsAsync(int productId);

    }
}
