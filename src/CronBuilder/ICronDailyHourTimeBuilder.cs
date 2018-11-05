using System;
using System.Linq;

namespace CronBuilder
{
    public interface ICronDailyHourTimeBuilder
    {
        string At(params Hour[] hours);
    }

    internal class CronDailyHourTimeBuilder : ICronDailyHourTimeBuilder
    {
        private readonly Cron _cron;

        internal CronDailyHourTimeBuilder(Cron cron)
        {
            _cron = cron;
        }

        public string At(params Hour[] hours)
        {
            if (hours == null || !hours.Any())
            {
                throw new ArgumentNullException(nameof(hours));
            }

            _cron.HourRange = hours
                .Distinct()
                .Select(h => ((int)h).ToString())
                .Aggregate((prev, curr) => $"{prev},{curr}");

            return _cron.ToString();
        }
    }
}
