namespace CronBuilder
{
    public interface ICronWeeklyBuilder
    {
        ICronDailyTimeBuilder OnAllDays();

        ICronDailyTimeBuilder OnDays(params Weekday[] days);
    }
}
