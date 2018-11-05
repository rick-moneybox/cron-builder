using System;
using System.Linq;

namespace CronBuilder
{
    public interface ICronYearlyBuilder
    {
        ICronMonthlyBuilder On(params YearMonth[] month);

        ICronMonthlyBuilder EveryMonth();
    }

    internal class CronYearlyBuilder : ICronYearlyBuilder
    {
        private readonly Cron _cron;

        internal CronYearlyBuilder()
        {
            _cron = new Cron();
        }

        public ICronMonthlyBuilder EveryMonth()
        {
            return new CronMonthlyBuilder(_cron);
        }

        public ICronMonthlyBuilder On(params YearMonth[] month)
        {
            if (month == null || !month.Any())
            {
                throw new ArgumentNullException(nameof(month));
            }

            _cron.MonthRange = month
                .Distinct()
                .Select(m => ((int)m).ToString())
                .Aggregate((prev, curr) => $"{prev},{curr}");

            return new CronMonthlyBuilder(_cron);
        }
    }
}
