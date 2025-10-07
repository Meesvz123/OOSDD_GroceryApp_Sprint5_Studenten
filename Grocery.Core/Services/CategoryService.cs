using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;

namespace Grocery.Core.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryService _categoryRepository;

        public CategoryService(IProductRepository categoryRepository)
        {
            _categoryRepository = (ICategoryService?)categoryRepository;
        }

        public List<Product> GetAll()
        {
            return (List<Category>)_categoryRepository.GetAll();
        }
    }
}

