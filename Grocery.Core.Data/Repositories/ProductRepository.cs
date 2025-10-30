using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

namespace Grocery.Core.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> products;

        public List<Product> Products { get; } = new();
        public ProductRepository()
        {
            products = [
                new Product(1, "Melk", 300, 1.49, 1, new DateOnly(2025, 9, 25)),
                new Product(2, "Kaas", 100, 3.29, 1, new DateOnly(2025, 9, 30)),
                new Product(3, "Brood", 400, 1.19, 2, new DateOnly(2025, 9, 12)),
                new Product(4, "Cornflakes", 0, 2.39, 3, new DateOnly(2025, 12, 31))];
        }
        public List<Product> GetAll()
        {
            return products;
        }

        public Product? Get(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }

        public Product Add(Product item)
        {
            throw new NotImplementedException();
        }

        public Product? Delete(Product item)
        {
            throw new NotImplementedException();
        }

        public Product? Update(Product item)
        {
            Product? product = products.FirstOrDefault(p => p.Id == item.Id);
            if (product == null) return null;
            product.Id = item.Id;
            return product;
        }
    }
}
