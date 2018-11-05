using System;

namespace CronBuilder
{
    public interface ICronEveryHourRangeBuilder
    {
        ICronDailyMinuteOnlyTimeBuilder Between(Hour first, Hour last);

        ICronDailyMinuteOnlyTimeBuilder ForAllHours();
    }

    internal class CronEveryHourRangeBuilder : ICronEveryHourRangeBuilder
    {
        private readonly Cron _cron;

        internal CronEveryHourRangeBuilder(Cron cron)
        {
            _cron = cron;
        }

        public ICronDailyMinuteOnlyTimeBuilder Between(Hour first, Hour last)
        {
            if (first >= last)
            {
                throw new ArgumentException("First hour must be before the second hour");
            }

            _cron.HourRange = $"{((int)first).ToString()}-{((int)last).ToString()}";

            return new CronDailyMinuteOnlyTimeBuilder(_cron);
        }

        public ICronDailyMinuteOnlyTimeBuilder ForAllHours()
        {
            return new CronDailyMinuteOnlyTimeBuilder(_cron);
        }
    }
}
