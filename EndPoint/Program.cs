using _0_Framework.Application;
using BlogManagement.Infrastructure.Configuration;
using EndPoint;
using EndPoint.Scheduler;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Application.Contracts.Coin;
using ShopManagement.Application.Contracts.CoinPrice;
using ShopManagement.Application;
using ShopManagement.Configuration;
using ShopManagement.Domain.Coin;
using ShopManagement.Domain.CoinPrice;
using ShopManagement.Domain.Exchange;
using ShopManagement.Infrastructure.EFCore.IdentityContext;
using ShopManagement.Infrastructure.EFCore.Repository;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using EndPoint.Coin;
using EndPoint.CoinPrice;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

#region Identity
builder.Services.AddDbContext<IdentityDbContexts>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Token")));
builder.Services.AddIdentityService(builder.Configuration);
builder.Services.AddAuthorization();
builder.Services.ConfigureApplicationCookie(option =>
{
    option.ExpireTimeSpan = TimeSpan.FromMinutes(10);
    option.LoginPath = "/loginAdmin";
    option.AccessDeniedPath = "/AccessDenied";
    option.SlidingExpiration = true;
});
#endregion

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddHttpContextAccessor();
builder.Services.AddSingleton(HtmlEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Arabic));
builder.Services.AddSingleton<IPasswordHasher, PasswordHasher>();
builder.Services.AddTransient<IFileUploader, FileUploader>();

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

var connectionString = builder.Configuration.GetConnectionString("Token");
ShopManagementBootstrapper.Configure(builder.Services, connectionString);
BlogManagementBootstrapper.Configure(builder.Services, connectionString);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
