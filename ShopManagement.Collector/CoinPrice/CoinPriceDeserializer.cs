using AngleSharp.Html.Parser;
using AngleSharp;
using ShopManagement.Application.Contracts.Coin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopManagement.Application.Contracts.CoinPrice;
using AngleSharp.Dom;
using Microsoft.IdentityModel.Tokens;

namespace ShopManagement.Collector.CoinPrice
{
    public class CoinPriceDeserializer
    {
        public static async Task<List<CoinPriceDto>> Deserialize(string html)
        {
            var result = new List<CoinPriceDto>();

            var context = BrowsingContext.New();
            var document = await context.OpenAsync(req => req.Content(html));
            var parser = new HtmlParser();
            var parsedDoc = await parser.ParseDocumentAsync(document);
            var elements = parsedDoc.QuerySelectorAll("tr.price-table-row").ToList();

            foreach (var elem in elements)
            {
                var coinPriceDto = new CoinPriceDto();

                var cells = elem.QuerySelectorAll("td");
                coinPriceDto.ExchangeName = cells[0].Children[0].Children[1].TextContent.Trim();
                coinPriceDto.ExchangeUrl = cells[0].Children[0].Children[1].GetAttribute("href");
                var exchangeType = cells[0].Children[1].TextContent.Trim();
                if (exchangeType == "فروشگاه") coinPriceDto.ExchangeType = ExchangeType.Store;
                if (exchangeType == "بازار") coinPriceDto.ExchangeType = ExchangeType.Market;
                coinPriceDto.PurchasePrice = (long)Convert.ToDecimal(cells[1].GetAttribute("data-price"));
                coinPriceDto.PurchaseVolume = cells[2].GetAttribute("data-amount").IsNullOrEmpty() ? null : Convert.ToDecimal(cells[2].GetAttribute("data-amount"));
                coinPriceDto.SalesPrice = (long)Convert.ToDecimal(cells[3].GetAttribute("data-price"));
                coinPriceDto.SalesVolume = cells[4].GetAttribute("data-amount").IsNullOrEmpty() ? null : Convert.ToDecimal(cells[4].GetAttribute("data-amount"));
                coinPriceDto.TransactionFee = cells[5].TextContent.Trim();
                coinPriceDto.Date = DateTime.Now;
                result.Add(coinPriceDto);
            }

            return result;
        }
    }
}
