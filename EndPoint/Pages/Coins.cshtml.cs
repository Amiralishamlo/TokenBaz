using _01_LampshadeQuery.Contracts.Coins;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EndPoint.Pages
{
    public class CoinsModel : PageModel
    {
        private readonly ICoinsQuery _coinsQuery;

        public CoinsModel(ICoinsQuery coinsQuery)
        {
            _coinsQuery = coinsQuery;
        }

        public List<CoinsQueryModels> coins;
        public void OnGet()
        {
            coins=_coinsQuery.GetAll();
        }
    }
}
