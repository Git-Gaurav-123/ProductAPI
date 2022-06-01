using Microsoft.EntityFrameworkCore;

using ProductAPI.Data.Entities;

namespace ProductApi.Data
{
    public class ProductContext : DbContext
    {
        private readonly IConfiguration _config;
        public ProductContext(IConfiguration config)
        {
            _config = config;
        }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("ProductContextDb"));
        }
    }
}

