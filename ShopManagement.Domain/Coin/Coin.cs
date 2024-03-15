using _0_Framework.Domain;
using ShopManagement.Domain.ProductAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Domain.Coin
{
    public class Coin : EntityBase
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Link { get; set; }
        public string ImageAddress { get; set; }
        public decimal PriceInToman { get; set; }
        public decimal PriceInDollar { get; set; }
        public decimal LastDaysPriceChangePercent { get; set; }
        public long TotalMarketValue { get; set; }
        public long LastDaysTradingVolume { get; set; }
        public DateTime LastUpdate { get; set; }

        public List<CoinPrice.CoinPrice> CoinPrices { get; }
    }
}
