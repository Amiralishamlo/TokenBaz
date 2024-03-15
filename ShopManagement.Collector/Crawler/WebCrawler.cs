using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Collector.Crawler
{
    public class WebCrawler
    {
        public static async Task<string> ReadSiteHtml(string url)
        {
            try
            {
                using var client = new HttpClient();
                client.Timeout = TimeSpan.FromSeconds(10);

                var result = new HttpResponseMessage();

                result = await client.GetAsync(url);
                result.EnsureSuccessStatusCode();

                return await result.Content.ReadAsStringAsync();
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
    }
}
