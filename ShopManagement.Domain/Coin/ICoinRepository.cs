using _0_Framework.Domain;
using ShopManagement.Domain.ProductAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Domain.Coin
{
    public interface ICoinRepository : IRepository<long, Coin>
    {

        Coin GetBySymbol(string symbol);
    }
}
