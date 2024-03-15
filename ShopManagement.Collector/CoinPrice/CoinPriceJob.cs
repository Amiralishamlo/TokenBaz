using ShopManagement.Collector.Coin;
using ShopManagement.Collector.Scheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Collector.CoinPrice
{
    public class CoinPriceJob : CronJobService
    {

        private readonly CoinPriceCollector _collector;

        public CoinPriceJob(IScheduleConfig<CoinPriceJob> cronExpression, CoinPriceCollector collector) : base(cronExpression.CronExpression)
        {
            _collector = collector;
        }

        public override Task DoWork(CancellationToken cancellationToken)
        {
            return _collector.Run();
        }
    }
}
