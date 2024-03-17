using _01_LampshadeQuery.Contracts.Article;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EndPoint.Pages
{
    public class ArticalesModel : PageModel
    {
        private readonly IArticleQuery _articleQuery;
        public List<ArticleQueryModel> articles;


        public ArticalesModel(IArticleQuery articleQuery)
        {
            _articleQuery = articleQuery;
        }

        public void OnGet()
        {
            articles = _articleQuery.Articles();
        }
    }
}
