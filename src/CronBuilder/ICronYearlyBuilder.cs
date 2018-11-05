namespace CronBuilder
{
    public interface ICronYearlyBuilder
    {
        ICronMonthlyBuilder On(params YearMonth[] month);

        ICronMonthlyBuilder EveryMonth();
    }
}
