using CommunityToolkit.Maui;
using Grocery.App.ViewModels;
using Grocery.App.Views;
using Grocery.Core.Data.Repositories;
using Grocery.Core.Interfaces;
using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Services;
using Grocery.App.ViewModels;
using GroceryApp.Core.Data.Repositories;
using Microsoft.Extensions.Logging;
using GroceryApp.App.ViewModels;

namespace Grocery.App
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<IGroceryListService, GroceryListService>(builder.Services);
            Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<IGroceryListItemsService, GroceryListItemsService>(builder.Services);
            Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<IProductService, ProductService>(builder.Services);
            Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<IAuthService, AuthService>(builder.Services);
            Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<IClientService, ClientService>(builder.Services);
            Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<IFileSaverService, FileSaverService>(builder.Services);
            Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<IBoughtProductsService, BoughtProductsService>(builder.Services);

            Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<IProductCategoryService, ProductCategoryService>(builder.Services);
            Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<ICategoryService, CategoryService>(builder.Services);
            Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<IGroceryListRepository, GroceryListRepository>(builder.Services);
            Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<IGroceryListItemsRepository, GroceryListItemsRepository>(builder.Services);
            Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<IProductRepository, ProductRepository>(builder.Services);
            Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<IClientRepository, ClientRepository>(builder.Services);
            Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<IProductCategoryRepository, ProductCategoryRepository>(builder.Services);
            Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<ICategoryRepository, CategoryRepository>(builder.Services);

            Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<GlobalViewModel>(builder.Services);
            Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddTransient<GroceryListsView>(builder.Services);
            Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddTransient<GroceryListViewModel>(builder.Services);
            Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddTransient<GroceryListItemsView>(builder.Services);
            Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddTransient<GroceryListItemsViewModel>(builder.Services);
            Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddTransient<ProductView>(builder.Services);
            Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddTransient<ProductViewModel>(builder.Services);
            Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddTransient<ChangeColorView>(builder.Services);
            Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddTransient<ChangeColorViewModel>(builder.Services);
            Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddTransient<LoginView>(builder.Services);
            Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddTransient<LoginViewModel>(builder.Services);
            Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddTransient<BestSellingProductsView>(builder.Services);
            Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddTransient<BestSellingProductsViewModel>(builder.Services);
            Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddTransient<BoughtProductsView>(builder.Services);
            Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddTransient<BoughtProductsViewModel>(builder.Services);
            Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddTransient<CategoriesView>(builder.Services);
            Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddTransient<CategoriesViewModel>(builder.Services);

            Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddTransient<ProductCategoriesView>(builder.Services);
            Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddTransient<ProductCategoriesViewModel>(builder.Services);

            return builder.Build();
        }
    }
}
