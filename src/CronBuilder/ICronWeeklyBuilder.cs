namespace CronBuilder
{
    public interface ICronWeeklyBuilder
    {
        ICronDailyMinuteTimeBuilder EveryDay();

        ICronDailyMinuteTimeBuilder OnDays(params Weekday[] days);
    }
}
