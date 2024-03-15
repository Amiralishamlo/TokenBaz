using _0_Framework.Infrastructure;
using ShopManagement.Domain.Coin;
using ShopManagement.Domain.Exchange;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Infrastructure.EFCore.Repository
{
    public class ExchangeRepository : RepositoryBase<long, Exchange>, IExchangeRepository
    {
        private readonly ShopContext _context;

        public ExchangeRepository(ShopContext context) : base(context)
        {
            _context = context;
        }

        public Exchange GetByName(string name)
        {
            return _context.Exchanges.SingleOrDefault(e => e.Name == name);
        }

    }
}
