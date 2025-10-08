using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

namespace Grocery.Core.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly List<Category> _categories =new();
        public CategoryRepository()
        {
            _categories = [
                new Category(1, "Fruit"),
                new Category(2, "Groente"),
                new Category(3, "Zuivel")];
        }
        public Task<IEnumerable<Category>> GetAllAsync() =>
            Task.FromResult(_categories.AsEnumerable());

        public Task<Category?> GetByIdAsync(int id) =>
            Task.FromResult(_categories.FirstOrDefault(c => c.Id == id));
    }
}
