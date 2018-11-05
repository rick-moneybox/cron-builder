namespace CronBuilder
{
    public interface ICronDailyHourTimeBuilder
    {
        string At(params Hour[] hours);
    }
}
