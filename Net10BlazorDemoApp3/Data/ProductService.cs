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

        // GET ALL PRODUCTS
        public IEnumerable<Product> GetProducts()
        {
            return _products;
        }

        // GET PRODUCT BY ID
        public Product? GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        // ADD NEW PRODUCT
        public void AddProduct(Product product)
        {
            product.Id = _products.Max(p => p.Id) + 1;
            _products.Add(product);
        }

        // UPDATE EXISTING PRODUCT
        public void UpdateProduct(Product? updated)
        {
            if (updated is null)
                return;

            var existing = _products.FirstOrDefault(p => p.Id == updated.Id);
            if (existing is not null)
            {
                existing.Name = updated.Name;
                existing.Description = updated.Description;
                existing.Category = updated.Category;
                existing.Price = updated.Price;
            }
        }
    }
}