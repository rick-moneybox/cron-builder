using System;
using Xunit;

namespace CronBuilder.Tests
{
    public class CronExpressionTests
    {
        [Fact]
        public void Expression_EveryMinutes_IsCorrect()
        {
            var expression = CronExpression.Minutes().Every(5);

            Assert.Equal("*/5 * * * *", expression);
        }

        [Fact]
        public void Expression_EveryHoursForAllHoursAtMinutes_IsCorrect()
        {
            var expression = CronExpression.Hourly()
                .Every(3)
                .ForAllHours()
                .At(Minute.Zero, Minute.Thirty);

            Assert.Equal("0,30 */3 * * *", expression);
        }

        [Fact]
        public void Expression_EveryHoursForHourRangeAtMinutes_IsCorrect()
        {
            var expression = CronExpression.Hourly()
                .Every(1)
                .Between(Hour.Midnight, Hour.Midday)
                .At(Minute.Zero);

            Assert.Equal("0 0-12/1 * * *", expression);
        }

        [Fact]
        public void Expression_Daily_IsCorrect()
        {
            var expression = CronExpression.Daily()
                .At(Minute.Fifteen, Minute.Thirty)
                .At(Hour.Midnight, Hour.EightAM, Hour.Midday);

            Assert.Equal("15,30 0,8,12 * * *", expression);
        }

        [Fact]
        public void Expression_WeeklyEveryDay_IsCorrect()
        {
            var expression = CronExpression.Weekly()
                .EveryDay()
                .At(Minute.Zero)
                .At(Hour.Midday);

            Assert.Equal("0 12 * * *", expression);
        }

        [Fact]
        public void Expression_WeeklyOnDays_IsCorrect()
        {
            var expression = CronExpression.Weekly()
                .OnDays(Weekday.Monday, Weekday.Wednesday, Weekday.Friday)
                .At(Minute.Zero)
                .At(Hour.Midday);

            Assert.Equal("0 12 * * 1,3,5", expression);
        }

        [Fact]
        public void Expression_MonthlyOnDays_IsCorrect()
        {
            var expression = CronExpression.Monthly()
                .On(MonthDay.ThirtyFirst)
                .At(Minute.Zero)
                .At(Hour.Midday);

            Assert.Equal("0 12 31 * *", expression);
        }


        [Fact]
        public void Expression_YearlyOnEveryMonth_IsCorrect()
        {
            var expression = CronExpression.Yearly()
                .EveryMonth()
                .On(MonthDay.First)
                .At(Minute.Zero)
                .At(Hour.Midday);

            Assert.Equal("0 12 1 * *", expression);
        }

        [Fact]
        public void Expression_YearlyOnMonths_IsCorrect()
        {
            var expression = CronExpression.Yearly()
                .On(YearMonth.January, YearMonth.June)
                .On(MonthDay.First, MonthDay.Second)
                .At(Minute.Zero)
                .At(Hour.Midday);

            Assert.Equal("0 12 1,2 1,6 *", expression);
        }
    }
}
