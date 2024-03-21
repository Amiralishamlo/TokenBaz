using EndPoint.Crawler;
using ShopManagement.Application.Contracts.Coin;

namespace EndPoint.Coin
{
    public class CoinCollector
    {

        private readonly ICoinApplication _coinApp;

        public CoinCollector(ICoinApplication coinApp)
        {
            _coinApp = coinApp;
        }

        public async Task Run()
        {
            var url = "https://tokenbaz.com/coins";
            var html = await WebCrawler.ReadSiteHtml(url);
            var dtos = await CoinDeserializer.Deserialize(html);
            _coinApp.AddCoins(dtos);
        }
    }
}
