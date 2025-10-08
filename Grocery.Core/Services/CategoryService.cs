using Grocery.Core.Interfaces;
using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;
namespace Grocery.Core.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;

        public CategoryService(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<Category>> GetAllCategoriesAsync() => _repository.GetAllAsync();

        public Task<Category?> GetCategoryByIdAsync(int id) => _repository.GetByIdAsync(id);
    }
}
