using Microsoft.EntityFrameworkCore;
using ProductApi.Data;
using ProductAPI.Data.Entities;

namespace ProductAPI.Services
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _context;

        public ProductRepository(ProductContext context)
        {
            _context = context; 
        }

        public async Task<Product?> GetProductsAsync(int productId)
        {
           return await _context.Products.Where(p=>p.ProductId == productId).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _context.Products.OrderBy(p=>p.ProductName).ToListAsync();
        }

     
    }
}
