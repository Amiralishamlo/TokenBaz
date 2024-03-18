// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ShopManagement.Application;
using ShopManagement.Application.Contracts.Coin;
using ShopManagement.Application.Contracts.CoinPrice;
using ShopManagement.Collector.Coin;
using ShopManagement.Collector.CoinPrice;
using ShopManagement.Collector.Crawler;
using ShopManagement.Collector.Scheduler;
using ShopManagement.Configuration;
using ShopManagement.Domain.Coin;
using ShopManagement.Domain.CoinPrice;
using ShopManagement.Domain.Exchange;
using ShopManagement.Infrastructure.EFCore;
using ShopManagement.Infrastructure.EFCore.IdentityContext;
using ShopManagement.Infrastructure.EFCore.Repository;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = Host.CreateApplicationBuilder(args);
        AddServices(builder);

        var connectionString = builder.Configuration.GetConnectionString("Token");
        ShopManagementBootstrapper.Configure(builder.Services, connectionString);

        var app = builder.Build();


        RunForDevelop(app);
        //app.Run();






    }

    private static void AddServices(HostApplicationBuilder builder)
    {
        builder.Services.AddDbContext<IdentityDbContexts>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Token")));
        builder.Services.AddSingleton<CoinDeserializer>();
        builder.Services.AddSingleton<CoinPriceDeserializer>();
        builder.Services.AddSingleton<CoinCollector>();
        builder.Services.AddSingleton<CoinPriceCollector>();
        builder.Services.AddTransient<ICoinApplication, CoinApplication>();
        builder.Services.AddTransient<ICoinPriceApplication, CoinPriceApplication>();
        builder.Services.AddTransient<ICoinRepository, CoinRepository>();
        builder.Services.AddTransient<ICoinPriceRepository, CoinPriceRepository>();
        builder.Services.AddTransient<IExchangeRepository, ExchangeRepository>();
        builder.Services.AddCronJob<CoinJob>(c =>
        {
            c.CronExpression = @"0 0 0/6 1/1 * ? *";
        });
        builder.Services.AddCronJob<CoinPriceJob>(c =>
        {
            c.CronExpression = @"0 0 0/6 1/1 * ? *";
        });
    }

    static void RunForDevelop(IHost app)
    {
        var collector = app.Services.GetService<CoinPriceCollector>();
        var task = collector.Run();
        task.Wait();
    }

}