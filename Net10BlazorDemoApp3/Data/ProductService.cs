using Net10BlazorDemoApp3.Models;

namespace Net10BlazorDemoApp3.Data
{
    public class ProductService
    {
        private readonly List<Product> _products = new()
        {
            new Product { Id = 1, Name = "Laptop", Description = "High-performance laptop", Price = 1299.99m, Category = "Electronics" },
            new Product { Id = 2, Name = "Headphones", Description = "Noise-cancelling over-ear headphones", Price = 199.99m, Category = "Audio" },
            new Product { Id = 3, Name = "Coffee Maker", Description = "Programmable drip coffee machine", Price = 89.99m, Category = "Kitchen" }
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return _products;
        }

        public Product? GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }
    }
}