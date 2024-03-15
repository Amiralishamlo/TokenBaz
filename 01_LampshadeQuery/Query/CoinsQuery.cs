using _01_LampshadeQuery.Contracts.Coins;
using ShopManagement.Infrastructure.EFCore;
namespace _01_LampshadeQuery.Query
{
    public class CoinsQuery: ICoinsQuery
    {
        private readonly ShopContext _context;

        public CoinsQuery(ShopContext context)
        {
            _context = context;
        }

        public List<CoinsQueryModels> GetAll()
        {
            var coins = _context.Coins
            .Select(product => new CoinsQueryModels
            {
                ImageAddress = product.ImageAddress,
                LastDaysPriceChangePercent = product.LastDaysPriceChangePercent,
                LastDaysTradingVolume= product.LastDaysTradingVolume,
                Link= product.Link,
                Name= product.Name, 
                PriceInDollar= product.PriceInDollar,
                PriceInToman= product.PriceInToman,
                Symbol= product.Symbol,
                TotalMarketValue = product.TotalMarketValue,
                Id= product.Id,
            }).ToList();
            return coins;
        }
    }
}
