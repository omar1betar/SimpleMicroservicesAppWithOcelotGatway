﻿using Microsoft.EntityFrameworkCore;
using ProductMicroserviceProject.Models;

namespace ProductMicroserviceProject.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDBContext _dbContext;
        public ProductRepository(ProductDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void DeleteProduct(int productId)
        {
            var product = _dbContext.Products.Find(productId);
            _dbContext.Products.Remove(product);
            Save();
        }

        public Product GetProductById(int productId)
        {
            if(productId == 0 || productId ==null)
            {
                throw new ArgumentException("null");
            }
            return _dbContext.Products.Find(productId);
        }

        public IEnumerable<Product> GetProducts()
        {
           return _dbContext.Products.ToList();
        }

        public void InsertProduct(Product product)
        {
            _dbContext.Add(product);
            Save();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            _dbContext.Entry(product).State= EntityState.Modified;
            Save();
        }
    }
}
