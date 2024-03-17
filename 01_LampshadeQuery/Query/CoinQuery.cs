using _01_LampshadeQuery.Contracts.Coin;
using _01_LampshadeQuery.Contracts.Product;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Infrastructure.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
				Image=product.Image,
			}).ToList();



			return products;
		}
	}
}
