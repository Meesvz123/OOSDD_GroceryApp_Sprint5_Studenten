using Grocery.App.ViewModels;
using Grocery.Core.Interfaces;
using Grocery.Core.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace GroceryApp_Sprint5.ViewModels
{
    [QueryProperty(nameof(CategoryId), "CategoryId")]
    public class ProductCategoriesViewModel : BaseViewModel
    {
        private readonly IProductCategoryService _productCategoryService;
        private int _categoryId;

        public int CategoryId
        {
            get => _categoryId;
            set
            {
                _categoryId = value;
                LoadProducts();
            }
        }

        public ObservableCollection<ProductCategory> Products { get; } = new();

        public ICommand RemoveProductCommand { get; }

        public ProductCategoriesViewModel(IProductCategoryService service)
        {
            _productCategoryService = service;
            RemoveProductCommand = new Command<ProductCategory>(async (p) => await RemoveProduct(p));
        }

        private async void LoadProducts()
        {
            var items = await _productCategoryService.GetProductsByCategoryAsync(CategoryId);
            Products.Clear();
            foreach (var item in items)
                Products.Add(item);
        }

        private async Task RemoveProduct(ProductCategory product)
        {
            await _productCategoryService.RemoveProductFromCategoryAsync(product);
            LoadProducts();
        }
    }
}
