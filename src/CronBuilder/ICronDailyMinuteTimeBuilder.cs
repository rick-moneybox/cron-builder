namespace CronBuilder
{
    public interface ICronDailyMinuteTimeBuilder
    {
        ICronDailyHourTimeBuilder At(params Minute[] minutes);
    }
}
