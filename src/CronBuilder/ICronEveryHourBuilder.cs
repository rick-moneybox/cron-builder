using System;

namespace CronBuilder
{
    public interface ICronEveryHourBuilder
    {
        ICronEveryHourRangeBuilder Every(int hours);
    }

    public class CronEveryHourBuilder : ICronEveryHourBuilder
    {
        internal CronEveryHourBuilder()
        {
        }

        public ICronEveryHourRangeBuilder Every(int hours)
        {
            if (hours < 1 || hours > 23)
            {
                throw new ArgumentException("'hours' must be between 1 and 23 inclusive");
            }

            throw new NotImplementedException();
        }
    }
}
