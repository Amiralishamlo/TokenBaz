using EndPoint.Scheduler;

namespace EndPoint.Coin
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
