using System;
using System.Linq;

namespace CronBuilder
{
    public interface ICronWeeklyBuilder
    {
        ICronDailyMinuteTimeBuilder EveryDay();

        ICronDailyMinuteTimeBuilder OnDays(params Weekday[] days);
    }

    internal class CronWeeklyBuilder : ICronWeeklyBuilder
    {
        private readonly Cron _cron;

        internal CronWeeklyBuilder()
        {
            _cron = new Cron();
        }

        public ICronDailyMinuteTimeBuilder EveryDay()
        {
            return new CronDailyMinuteTimeBuilder(_cron);
        }

        public ICronDailyMinuteTimeBuilder OnDays(params Weekday[] days)
        {
            if (days == null || !days.Any())
            {
                throw new ArgumentNullException(nameof(days));
            }

            _cron.WeekDayRange = days
                .Distinct()
                .Select(d => ((int)d).ToString())
                .Aggregate((prev, curr) => $"{prev},{curr}");

            return new CronDailyMinuteTimeBuilder(_cron);
        }
    }
}
