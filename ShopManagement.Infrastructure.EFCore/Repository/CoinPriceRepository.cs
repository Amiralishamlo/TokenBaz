using _0_Framework.Infrastructure;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Domain.CoinPrice;
using ShopManagement.Domain.Exchange;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Infrastructure.EFCore.Repository
{
    public class CoinPriceRepository : RepositoryBase<long, CoinPrice>, ICoinPriceRepository
    {
        public CoinPriceRepository(ShopContext context) : base(context)
        {
        }
    }
}
