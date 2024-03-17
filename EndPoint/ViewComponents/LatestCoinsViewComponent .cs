using _01_LampshadeQuery.Contracts.Article;
using _01_LampshadeQuery.Contracts.Coin;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.ViewComponents;

public class LatestCoinsViewComponent : ViewComponent
{
    private readonly ICoinQuery _articleQuery;

    public LatestCoinsViewComponent(ICoinQuery articleQuery)
    {
        _articleQuery = articleQuery;
    }

    public IViewComponentResult Invoke()
    {
        var articles = _articleQuery.GetCoin(3);
        return View(articles);
    }
}