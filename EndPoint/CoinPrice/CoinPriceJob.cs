using EndPoint.Scheduler;

namespace EndPoint.CoinPrice
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
