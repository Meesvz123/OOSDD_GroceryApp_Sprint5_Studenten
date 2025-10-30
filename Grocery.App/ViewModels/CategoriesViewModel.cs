using Grocery.App.ViewModels;
using Grocery.Core.Interfaces;
using Grocery.Core.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace GroceryApp.App.ViewModels
{
    public class CategoriesViewModel : BaseViewModel
    {
        private readonly ICategoryService _categoryService;

        public ObservableCollection<Category> Categories { get; } = new();

        public ICommand CategoryTappedCommand { get; }

        public CategoriesViewModel(ICategoryService categoryService)
        {
            _categoryService = categoryService;
            CategoryTappedCommand = new Command<Category>(OnCategorySelected);
            LoadCategories();
        }

        private async void LoadCategories()
        {
            var categories = await _categoryService.GetAllCategoriesAsync();
            Categories.Clear();
            foreach (var c in categories)
                Categories.Add(c);
        }

        private async void OnCategorySelected(Category category)
        {
            if (category == null) return;
            await Shell.Current.GoToAsync($"ProductCategoriesView?CategoryId={category.Id}");
        }
    }
}
