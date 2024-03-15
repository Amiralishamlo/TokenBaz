using _01_LampshadeQuery.Contracts.Coin;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EndPoint.Pages
{
    public class CoinModel : PageModel
    {
        private readonly ICoinQuery coinQuery;

		public CoinModel(ICoinQuery coinQuery)
		{
			this.coinQuery = coinQuery;
		}

		public List<CoinQueryModels> CoinQueryModels;
        public void OnGet(long id)
        {
            CoinQueryModels = coinQuery.GetCoin(id);
        }
    }
}
