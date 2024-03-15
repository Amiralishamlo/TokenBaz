using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Collector.Scheduler
{
    public interface IScheduleConfig<T>
    {
        string CronExpression { get; set; }
    }
}
