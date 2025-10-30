using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

namespace GroceryApp.Core.Data.Repositories
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        private readonly List<ProductCategory> _productCategories = new();

        public Task<IEnumerable<ProductCategory>> GetByCategoryIdAsync(int categoryId)
        {
            var result = _productCategories.Where(pc => pc.CategoryId == categoryId);
            return Task.FromResult(result.AsEnumerable());
        }

        public Task AddAsync(ProductCategory productCategory)
        {
            _productCategories.Add(productCategory);
            return Task.CompletedTask;
        }

        public Task RemoveAsync(ProductCategory productCategory)
        {
            _productCategories.Remove(productCategory);
            return Task.CompletedTask;
        }
    }
}
