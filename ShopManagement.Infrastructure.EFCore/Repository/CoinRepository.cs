using _0_Framework.Infrastructure;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Application.Contracts.ProductCategory;
using ShopManagement.Domain.Coin;
using ShopManagement.Domain.ProductCategoryAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Infrastructure.EFCore.Repository
{
    public class CoinRepository : RepositoryBase<long, Coin>, ICoinRepository
    {
        private readonly ShopContext _context;

        public CoinRepository(ShopContext context) : base(context)
        {
            _context = context;
        }

        public Coin GetBySymbol(string symbol)
        {
            return _context.Coins.FirstOrDefault(e => e.Symbol == symbol);
        }
    }
}
