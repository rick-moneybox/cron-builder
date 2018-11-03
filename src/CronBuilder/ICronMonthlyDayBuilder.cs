using System;
using System.Collections.Generic;
using System.Text;

namespace CronBuilder
{
    public interface ICronMonthlyDayBuilder
    {
        void OnDay(MonthDay monthDay);
    }
}
