namespace CronBuilder
{
    public interface ICronEveryHourRangeBuilder
    {
        ICronDailyMinuteTimeBuilder Between(Hour first, Hour last);

        ICronDailyMinuteTimeBuilder ForAllHours();
    }
}
