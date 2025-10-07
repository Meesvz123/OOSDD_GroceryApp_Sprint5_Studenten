using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

namespace Grocery.Core.Data.Repositories
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        private readonly List<ProductCategory> productCategories;
        public ProductCategoryRepository()
        {
            productCategories = new List<ProductCategory>
            {
                new ProductCategory(1, "Zuivel", 1, 1),
                new ProductCategory(2, "Brood", 3, 2),
                new ProductCategory(3, "Ontbijtgranen", 4, 3)
            };
        }
    }
}
