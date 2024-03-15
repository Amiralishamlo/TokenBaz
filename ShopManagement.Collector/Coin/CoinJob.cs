using ShopManagement.Application.Contracts.Coin;
using ShopManagement.Collector.Scheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Collector.Coin
{
    public class CoinJob : CronJobService
    {

        private readonly CoinCollector _collector;
        public CoinJob(IScheduleConfig<CoinJob> cronExpression, CoinCollector collector) : base(cronExpression.CronExpression)
        {
            _collector = collector;
        }

        public override Task DoWork(CancellationToken cancellationToken)
        {
            return _collector.Run();
        }
    }
}
