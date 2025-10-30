using Grocery.Core.Models;

using Grocery.App.ViewModels;
using GroceryApp.App.ViewModels;

namespace Grocery.App.Views;

public partial class CategoriesView : ContentPage
{
    public CategoriesView(CategoriesViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Category selected)
        {
            await Shell.Current.GoToAsync($"{nameof(ProductCategoriesView)}?CategoryId={selected.Id}");
        }
    }
}
