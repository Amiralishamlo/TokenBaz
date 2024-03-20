using _01_LampshadeQuery.Contracts.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EndPoint.Pages
{
    public class ExchangesModel : PageModel
    {
        private readonly IProductQuery _articleQuery;
        public ProductQueryModel product;


        public ExchangesModel(IProductQuery articleQuery)
        {
            _articleQuery = articleQuery;
        }

        public void OnGet(string id)
        {
            product = _articleQuery.GetProductDetails(id);
        }
    }
}
