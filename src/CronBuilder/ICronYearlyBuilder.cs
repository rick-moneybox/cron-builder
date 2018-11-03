namespace CronBuilder
{
    public interface ICronYearlyBuilder
    {
        ICronDailyTimeBuilder On(YearMonth yearMonth, MonthDay monthDay);
    }
}
