using Microsoft.EntityFrameworkCore;

namespace ProductMicroserviceProject.Models
{
    public class ProductDBContext :DbContext
    {
        public DbSet<Product> Products { get; set; }
        public ProductDBContext(DbContextOptions<ProductDBContext> options) : base(options) { }
    }
}
