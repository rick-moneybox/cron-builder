namespace CronBuilder
{
    public interface ICronDailyTimeBuilder
    {
        string At(Hour startHour, Minute startMinute = Minute.Zero);
    }
}
