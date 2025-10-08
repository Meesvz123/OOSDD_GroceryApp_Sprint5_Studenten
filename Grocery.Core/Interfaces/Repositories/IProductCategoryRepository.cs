using Grocery.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery.Core.Interfaces.Repositories
{
    public interface IProductCategoryRepository
    {
        Task<IEnumerable<ProductCategory>> GetByCategoryIdAsync(int categoryId);
        Task AddAsync(ProductCategory productCategory);
        Task RemoveAsync(ProductCategory productCategory);
    }
}
