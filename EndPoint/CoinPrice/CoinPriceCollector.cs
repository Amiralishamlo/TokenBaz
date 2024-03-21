using EndPoint.Crawler;
using ShopManagement.Application.Contracts.Coin;
using ShopManagement.Application.Contracts.CoinPrice;

namespace EndPoint.CoinPrice
{
    public class CoinPriceCollector
    {

        private readonly ICoinApplication _coinApp;
        private readonly ICoinPriceApplication _coinPriceApp;

        public CoinPriceCollector(ICoinApplication coinApp, ICoinPriceApplication coinPriceApp)
        {
            _coinApp = coinApp;
            _coinPriceApp = coinPriceApp;
        }
        public async Task Run()
        {
            var baseURL = "https://tokenbaz.com/";
            var coins = _coinApp.GetCoins();
            foreach (var coin in coins)
            {
                try
                {

                    var html = await WebCrawler.ReadSiteHtml(baseURL + coin.Link);
                    var dtos = await CoinPriceDeserializer.Deserialize(html);
                    dtos = dtos.Select(e => { e.CoinSymbol = coin.Symbol; return e; }).ToList();
                    _coinPriceApp.AddCoinPrices(dtos);
                }
                catch (Exception)
                {
                    continue;
                }
            }
        }
    }
}
