using _0_Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Domain.CoinPrice
{
    public interface ICoinPriceRepository : IRepository<long, CoinPrice>
    {
        void DeleteAllPricesForThisCoin(string coinSymbol);
    }
}
