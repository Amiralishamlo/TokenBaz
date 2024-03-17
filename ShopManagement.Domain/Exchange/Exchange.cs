using _0_Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Domain.Exchange
{
    public class Exchange : EntityBase
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string ImageAddress { get; set; }
        public ExchangeType ExchangeType { get; set; }
    }
    public enum ExchangeType
    {
        Market = 1,
        Store = 2,
    }

}
