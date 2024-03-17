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
        private readonly ShopContext _context;
        public CoinPriceRepository(ShopContext context) : base(context)
        {
            _context = context;
        }

        public void DeleteAllPricesForThisCoin(string coinSymbol)
        {
            var deleteRecords = from price in _context.CoinPrices
                                join coin in _context.Coins
                                on price.CoinID equals coin.Id
                                where coin.Symbol == coinSymbol
                                select price;
            foreach (var item in deleteRecords)
            {
                _context.CoinPrices.Remove(item);
            }
        }
    }
}
