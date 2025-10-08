using Grocery.Core.Interfaces;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;
using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Grocery.App.ViewModels
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
                if (_categoryId == value) return;
                _categoryId = value;
                _ = LoadProductsAsync();
            }
        }

        public ObservableCollection<ProductCategory> Products { get; } = new();

        public ICommand RemoveProductCommand { get; }

        public ProductCategoriesViewModel(IProductCategoryService service)
        {
            _productCategoryService = service ?? throw new ArgumentNullException(nameof(service));
            RemoveProductCommand = new Command<ProductCategory>(async (p) => await RemoveProductAsync(p));
        }

        private async Task LoadProductsAsync()
        {
            if (CategoryId <= 0) return;
            var items = await _productCategoryService.GetProductsByCategoryAsync(CategoryId);
            Products.Clear();
            foreach (var item in items)
                Products.Add(item);
        }

        private async Task RemoveProductAsync(ProductCategory product)
        {
            if (product == null) return;
            await _productCategoryService.RemoveProductFromCategoryAsync(product);
            await LoadProductsAsync();
        }
        public void LoadProductsByCategory(int categoryId)
        {
            CategoryId = categoryId;
            _ = LoadProductsAsync();
        }
    }
}
