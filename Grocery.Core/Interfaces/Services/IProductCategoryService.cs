using Grocery.Core.Models;


namespace Grocery.Core.Interfaces
{
    public interface IProductCategoryService
    {
        Task<IEnumerable<ProductCategory>> GetProductsByCategoryAsync(int categoryId);
        Task AddProductToCategoryAsync(int categoryId, ProductCategory productCategory);
        Task RemoveProductFromCategoryAsync(ProductCategory productCategory);
    }
}
