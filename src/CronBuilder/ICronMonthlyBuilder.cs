namespace CronBuilder
{
    public interface ICronMonthlyBuilder
    {
        ICronDailyTimeBuilder On(MonthDay month);
    }
}
