using System;
using System.Linq.Expressions;

namespace CronBuilder
{
    public static class CronExpression
    {
        public static ICronEveryMinuteBuilder Minutes()
        {
            throw new NotImplementedException();
        }

        public static ICronEveryHourBuilder Hourly()
        {
            throw new NotImplementedException();
        }

        public static ICronDailyTimeBuilder Daily()
        {
            throw new NotImplementedException();
        }

        public static ICronWeeklyBuilder Weekly()
        {
            throw new NotImplementedException();
        }

        public static ICronMonthlyBuilder Monthly()
        {
            throw new NotImplementedException();
        }

        public static ICronYearlyBuilder Yearly()
        {
            throw new NotImplementedException();
        }
    }
}
