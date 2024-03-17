using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Application.Contracts.Coin
{
    public class CoinDto
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Link { get; set; }
        public string ImageAddress { get; set; }
        public string PriceInToman { get; set; }
        public string PriceInDollar { get; set; }
        public string LastDaysPriceChangePercent { get; set; }
        public string TotalMarketValue { get; set; }
        public string LastDaysTradingVolume { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
