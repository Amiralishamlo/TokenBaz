namespace EndPoint.Scheduler
{
    public interface IScheduleConfig<T>
    {
        string CronExpression { get; set; }
    }
}
