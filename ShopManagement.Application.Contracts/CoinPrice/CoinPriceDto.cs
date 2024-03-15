using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Application.Contracts.CoinPrice
{
    public class CoinPriceDto
    {
        public string CoinSymbol { get; set; }
        public string ExchangeName { get; set; }
        public string ExchangeUrl { get; set; }
        public ExchangeType ExchangeType { get; set; }
        public long PurchasePrice { get; set; }
        public decimal? PurchaseVolume { get; set; }
        public long SalesPrice { get; set; }
        public decimal? SalesVolume { get; set; }
        public string TransactionFee { get; set; }
        public DateTime Date { get; set; }
    }
    public enum ExchangeType
    {
        Market = 1,
        Store = 2,
    }
}
