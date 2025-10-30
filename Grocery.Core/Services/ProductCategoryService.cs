using Grocery.Core.Interfaces;
using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;
namespace Grocery.Core.Services
{
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly IProductCategoryRepository _repository;

        public ProductCategoryService(IProductCategoryRepository repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<ProductCategory>> GetProductsByCategoryAsync(int categoryId)
            => _repository.GetByCategoryIdAsync(categoryId);

        public Task AddProductToCategoryAsync(ProductCategory productCategory)
            => _repository.AddAsync(productCategory);

        public Task RemoveProductFromCategoryAsync(ProductCategory productCategory)
            => _repository.RemoveAsync(productCategory);

        public Task AddProductToCategoryAsync(int categoryId, ProductCategory productCategory)
        {
            throw new NotImplementedException();
        }
    }
}
