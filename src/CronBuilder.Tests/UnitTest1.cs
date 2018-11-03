using System;
using Xunit;

namespace CronBuilder.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var minuteExpression = CronExpression.Minutes()
                .Every(5);

            var hourlyExpression = CronExpression.Hourly()
                .Every(1);

            var dailyExpression = CronExpression.Daily()
                .At(Hour.Midday, Minute.Zero);

            var weeklyExpression = CronExpression.Weekly()
                .OnDays(Weekday.Monday, Weekday.Wednesday, Weekday.Friday)
                .At(Hour.Midday);

            var monthlyExpression = CronExpression.Monthly()
                .On(MonthDay.ThirtyFirst)
                .At(Hour.TwoPM);

            var yearlyExpression = CronExpression.Yearly()
                .On(YearMonth.January, MonthDay.First)
                .At(Hour.Midnight);
        }
    }
}
