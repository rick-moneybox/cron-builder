namespace CronBuilder
{
    public interface ICronMonthlyBuilder
    {
        ICronDailyMinuteTimeBuilder On(params MonthDay[] day);
    }
}
