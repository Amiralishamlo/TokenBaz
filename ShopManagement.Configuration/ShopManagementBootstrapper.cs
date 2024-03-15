using _01_LampshadeQuery.Contracts.Coin;
using _01_LampshadeQuery.Contracts.Coins;
using _01_LampshadeQuery.Contracts.Product;
using _01_LampshadeQuery.Contracts.ProductCategory;
using _01_LampshadeQuery.Query;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShopManagement.Application;
using ShopManagement.Application.Contracts.Product;
using ShopManagement.Application.Contracts.ProductCategory;
using ShopManagement.Domain.ProductAgg;
using ShopManagement.Domain.ProductCategoryAgg;
using ShopManagement.Infrastructure.EFCore;
using ShopManagement.Infrastructure.EFCore.Repository;

namespace ShopManagement.Configuration;

public class ShopManagementBootstrapper
{
    public static void Configure(IServiceCollection services, string connectionString)
    {
        services.AddTransient<IProductCategoryApplication, ProductCategoryApplication>();
        services.AddTransient<IProductCategoryRepository, ProductCategoryRepository>();

        services.AddTransient<IProductApplication, ProductApplication>();
        services.AddTransient<IProductRepository, ProductRepository>();

        services.AddTransient<IProductCategoryQuery, ProductCategoryQuery>();
        services.AddTransient<IProductQuery, ProductQuery>();
		services.AddTransient<ICoinsQuery, CoinsQuery>();
        services.AddTransient<ICoinQuery, CoinQuery>();



        services.AddDbContext<ShopContext>(x => x.UseSqlServer(connectionString));
    }
}