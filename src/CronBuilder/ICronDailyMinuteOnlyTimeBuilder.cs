using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CronBuilder
{
    public interface ICronDailyMinuteOnlyTimeBuilder
    {
        string At(params Minute[] minutes);
    }

    internal class CronDailyMinuteOnlyTimeBuilder : ICronDailyMinuteOnlyTimeBuilder
    {
        private readonly Cron _cron;

        internal CronDailyMinuteOnlyTimeBuilder(Cron cron)
        {
            _cron = cron;
        }

        public string At(params Minute[] minutes)
        {
            if (minutes == null || !minutes.Any())
            {
                throw new ArgumentNullException(nameof(minutes));
            }

            _cron.MinuteRange = minutes
                .Distinct()
                .Select(m => ((int)m).ToString())
                .Aggregate((prev, curr) => $"{prev},{curr}");

            return _cron.ToString();
        }
    }
}
