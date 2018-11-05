using System;

namespace CronBuilder
{
    public static class CronExpression
    {
        public static ICronEveryMinuteBuilder Minutes()
        {
            return new CronEveryMinuteBuilder();
        }

        public static ICronEveryHourBuilder Hourly()
        {
            return new CronEveryHourBuilder();
        }

        public static ICronDailyMinuteTimeBuilder Daily()
        {
            return new CronDailyMinuteTimeBuilder();
        }

        public static ICronWeeklyBuilder Weekly()
        {
            return new CronWeeklyBuilder();
        }

        public static ICronMonthlyBuilder Monthly()
        {
            return new CronMonthlyBuilder();
        }

        public static ICronYearlyBuilder Yearly()
        {
            return new CronYearlyBuilder();
        }
    }
}
