using Microsoft.EntityFrameworkCore;

namespace ProductMicroserviceProject.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [Precision(18, 2)]
        public decimal Price { get; set; }
    }
}
