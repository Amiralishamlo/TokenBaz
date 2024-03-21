using AngleSharp;
using AngleSharp.Html.Parser;
using ShopManagement.Application.Contracts.Coin;

namespace EndPoint.Coin
{
    public class CoinDeserializer
    {
        public static async Task<List<CoinDto>> Deserialize(string html)
        {
            var result = new List<CoinDto>();

            var context = BrowsingContext.New();
            var document = await context.OpenAsync(req => req.Content(html));
            var parser = new HtmlParser();
            var parsedDoc = await parser.ParseDocumentAsync(document);
            var elements = parsedDoc.QuerySelectorAll("tr.coins-table-row").ToList();

            foreach (var elem in elements)
            {
                var coinDto = new CoinDto();
                var aTags = elem.QuerySelectorAll(".coins-table-name-cell a");
                var price = elem.QuerySelectorAll(".coins-table-price-cell");
                var change = elem.QuerySelectorAll(".coins-table-cell");

                coinDto.ImageAddress = "https://tokenbaz.com" + aTags[0].Children[0].GetAttribute("src");
                coinDto.Link = aTags[0].GetAttribute("href");
                coinDto.Name = aTags[1].Children[0].TextContent;
                coinDto.Symbol = aTags[1].Children[2].TextContent;
                coinDto.PriceInToman = price[0].Children[0].TextContent.Trim();
                coinDto.PriceInDollar = price[0].Children[2].TextContent.Trim();
                coinDto.TotalMarketValue = change[1].TextContent.Trim();
                coinDto.LastDaysTradingVolume = change[0].TextContent.Trim();
                coinDto.LastDaysPriceChangePercent = change[2].TextContent.Trim();
                result.Add(coinDto);
            }

            return result;
        }
    }

}
