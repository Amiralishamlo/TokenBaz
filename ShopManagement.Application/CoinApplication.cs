using ShopManagement.Application.Contracts.Coin;
using ShopManagement.Domain.Coin;

namespace ShopManagement.Application
{
    public class CoinApplication : ICoinApplication
    {
        private readonly ICoinRepository _coinRepository;

        public CoinApplication(ICoinRepository coinRepository)
        {
            _coinRepository = coinRepository;
        }

        public List<CoinDto> GetCoins()
        {
            var coins = _coinRepository.Get();
            var result = new List<CoinDto>();
            foreach (var coin in coins)
            {
                result.Add(new CoinDto
                {
                    ImageAddress = coin.ImageAddress,
                    Link = coin.Link,
                    Name = coin.Name,
                    Symbol = coin.Symbol,
                    LastDaysPriceChangePercent = coin.LastDaysPriceChangePercent,
                    LastDaysTradingVolume = coin.LastDaysTradingVolume,
                    LastUpdate = coin.LastUpdate,
                    PriceInDollar = coin.PriceInDollar,
                    PriceInToman = coin.PriceInToman,
                    TotalMarketValue = coin.TotalMarketValue
                });
            }
            return result;
        }

        public void AddCoins(List<CoinDto> coins)
        {
            foreach (var coin in coins)
            {
                var entity = BuildEntity(coin);
                try
                {
                    var oldrecord = _coinRepository.GetBySymbol(entity.Symbol);
                    if (oldrecord == null)
                    {
                        _coinRepository.Create(entity);
                        _coinRepository.SaveChanges();
                    }
                    else
                    {
                        oldrecord.PriceInDollar = coin.PriceInDollar;
                        oldrecord.PriceInToman = coin.PriceInToman;
                        oldrecord.LastDaysPriceChangePercent = coin.LastDaysPriceChangePercent;
                        oldrecord.TotalMarketValue = coin.TotalMarketValue;
                        oldrecord.LastDaysTradingVolume = coin.LastDaysTradingVolume;
                        oldrecord.LastUpdate = coin.LastUpdate;
                        _coinRepository.SaveChanges();
                    }
                }
                catch (Exception)
                {
                }
            }
        }



        private Coin BuildEntity(CoinDto coin)
        {
            return new Coin
            {
                ImageAddress = coin.ImageAddress,
                Link = coin.Link,
                Name = coin.Name,
                Symbol = coin.Symbol,
                PriceInDollar = coin.PriceInDollar,
                PriceInToman = coin.PriceInToman,
                TotalMarketValue = coin.TotalMarketValue,
                LastDaysTradingVolume = coin.LastDaysTradingVolume,
                LastDaysPriceChangePercent = coin.LastDaysPriceChangePercent,
                LastUpdate = coin.LastUpdate,
                CreationDate = DateTime.Now,
            };
        }
    }
}
