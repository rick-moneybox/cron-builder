using System;
using System.Linq;

namespace CronBuilder
{
    public interface ICronMonthlyBuilder
    {
        ICronDailyMinuteTimeBuilder On(params MonthDay[] day);
    }

    internal class CronMonthlyBuilder : ICronMonthlyBuilder
    {
        private readonly Cron _cron;

        internal CronMonthlyBuilder() : this(new Cron())
        {
        }

        internal CronMonthlyBuilder(Cron cron)
        {
            _cron = cron;
        }

        public ICronDailyMinuteTimeBuilder On(params MonthDay[] day)
        {
            if (day == null || !day.Any())
            {
                throw new ArgumentNullException(nameof(day));
            }

            _cron.MonthDayRange = day
               .Distinct()
               .Select(d => ((int)d).ToString())
               .Aggregate((prev, curr) => $"{prev},{curr}");

            return new CronDailyMinuteTimeBuilder(_cron);
        }
    }
}
