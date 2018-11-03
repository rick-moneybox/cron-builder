using System;

namespace CronBuilder
{
    public interface ICronEveryHourBuilder
    {
        string Every(int hours);
    }

    public class CronEverHourBuilder : ICronEveryHourBuilder
    {
        internal CronEverHourBuilder()
        {
        }

        public string Every(int hours)
        {
            if (hours < 1 || hours > 23)
            {
                throw new ArgumentException("'hours' must be between 1 and 23 inclusive");
            }

            return $"0 0 0/{hours} 1/1 * ? *";
        }
    }
}
