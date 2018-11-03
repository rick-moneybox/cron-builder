namespace CronBuilder
{
    public interface ICronWeeklyDaysBuilder
    {
        void OnDays(params Weekday[] days);
    }
}
