using System;

namespace CronBuilder
{
    public interface ICronEveryHourBuilder
    {
        ICronEveryHourRangeBuilder Every(int hours);
    }

    public class CronEveryHourBuilder : ICronEveryHourBuilder
    {
        private readonly Cron _cron;

        internal CronEveryHourBuilder()
        {
            _cron = new Cron();
        }

        public ICronEveryHourRangeBuilder Every(int hours)
        {
            if (hours < 1 || hours > 23)
            {
                throw new ArgumentException("'hours' must be between 1 and 23 inclusive");
            }

            _cron.Hour = hours.ToString();

            return new CronEveryHourRangeBuilder(_cron);
        }
    }
}
