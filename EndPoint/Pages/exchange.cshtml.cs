using _01_LampshadeQuery.Contracts.Article;
using _01_LampshadeQuery.Contracts.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EndPoint.Pages
{
    public class exchangeModel : PageModel
    {
        private readonly IProductQuery _articleQuery;
        public ProductQueryModel product;


        public exchangeModel(IProductQuery articleQuery)
        {
            _articleQuery = articleQuery;
        }

        public void OnGet(string id)
        {
            product = _articleQuery.GetProductDetails(id);
        }
    }
}
