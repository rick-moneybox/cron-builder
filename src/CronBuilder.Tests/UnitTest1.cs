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

            var hourlyExpression1 = CronExpression.Hourly()
                .Every(3)
                .ForAllHours()
                .At(Minute.Thirty);

            var hourlyExpression2 = CronExpression.Hourly()
                .Every(1)
                .Between(Hour.EightAM, Hour.Midday)
                .At(Minute.Zero);

            var dailyExpression = CronExpression.Daily()
                .At(Minute.Zero)
                .At(Hour.Midnight, Hour.Midday);

            var weeklyExpression1 = CronExpression.Weekly()
                .EveryDay()
                .At(Minute.Zero)
                .At(Hour.Midday);

            var weeklyExpression2 = CronExpression.Weekly()
                .OnDays(Weekday.Monday, Weekday.Wednesday, Weekday.Friday)
                .At(Minute.Zero)
                .At(Hour.Midday);

            var monthlyExpression = CronExpression.Monthly()
                .On(MonthDay.ThirtyFirst)
                .At(Minute.Zero)
                .At(Hour.Midday);

            var yearlyExpression1 = CronExpression.Yearly()
                .EveryMonth()
                .On(MonthDay.First)
                .At(Minute.Zero)
                .At(Hour.Midday);

            var yearlyExpression2 = CronExpression.Yearly()
                .On(YearMonth.January, YearMonth.July)
                .On(MonthDay.First, MonthDay.Second)
                .At(Minute.Zero)
                .At(Hour.Midday);
        }
    }
}
