using _0_Framework.Domain;
using ShopManagement.Domain.Coin;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Domain.CoinPrice
{
    public class CoinPrice : EntityBase
    {
        public long CoinID { get; set; }
        [ForeignKey("CoinID")]
        public virtual Coin.Coin Coin { get; set; }
        public long ExchangeID { get; set; }

        [ForeignKey("ExchangeID")]
        public virtual Exchange.Exchange Exchange { get; set; }



        public long PurchasePrice { get; set; }
        public decimal? PurchaseVolume{ get; set; }
        public long SalesPrice { get; set; }
        public decimal? SalesVolume { get; set; } 
        public string TransactionFee { get; set; }
        public DateTime Date { get; set; }
    }
}
