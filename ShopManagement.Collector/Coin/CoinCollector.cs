using ShopManagement.Application.Contracts.Coin;
using ShopManagement.Collector.Crawler;
using ShopManagement.Domain.Coin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Collector.Coin
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
