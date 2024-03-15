using AngleSharp.Html.Parser;
using AngleSharp;
using ShopManagement.Application.Contracts.Coin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Collector.Coin
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

            foreach ( var elem in elements )
            {
                var coinDto = new CoinDto();
                var aTags = elem.QuerySelectorAll(".coins-table-name-cell a");

                coinDto.ImageAddress = "https://tokenbaz.com" + aTags[0].Children[0].GetAttribute("src");
                coinDto.Link = aTags[0].GetAttribute("href");
                coinDto.Name = aTags[1].Children[0].TextContent;
                coinDto.Symbol = aTags[1].Children[2].TextContent;
                result.Add( coinDto);
            }

            return result;
        }
    }
}
