using _01_LampshadeQuery.Contracts.Coin;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Infrastructure.EFCore;

namespace _01_LampshadeQuery.Query
{
    public class CoinQuery:ICoinQuery
	{
		private readonly ShopContext _context;

		public CoinQuery(ShopContext context)
		{
			_context = context;
		}

		public List<CoinQueryModels> GetCoin(long id)
		{
			var products = _context.CoinPrices.Where(x=>x.CoinID==id).Include(x => x.Exchange)
			.Select(product => new CoinQueryModels
			{
				Name=product.Exchange.Name,
				Url=product.Exchange.Url,
				PurchasePrice=product.PurchasePrice,
				PurchaseVolume=product.PurchaseVolume,
				SalesPrice=product.SalesPrice,
				SalesVolume=product.SalesVolume,
				TransactionFee = product.TransactionFee,
				Image=product.Exchange.ImageAddress,
				MarketType=((int)product.Exchange.ExchangeType)
			}).ToList();



			return products;
		}

        public CoinParentQueryModels GetCoinParents(long id)
        {
            var products = _context.Coins.Where(x => x.Id == id)
            .Select(product => new CoinParentQueryModels
            {
				Image=product.ImageAddress,
				Name=product.Name,
				Symbole=product.Symbol
            }).FirstOrDefault();

            return products;
        }
    }
}
