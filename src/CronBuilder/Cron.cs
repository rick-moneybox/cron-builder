namespace CronBuilder
{
    internal class Cron
    {
        public string Minute { get; set; }

        public string MinuteRange { get; set; }

        public string Hour { get; set; }

        public string HourRange { get; set; }

        public string MonthDay { get; set; }

        public string MonthDayRange { get; set; }

        public string Month { get; set; }

        public string MonthRange { get; set; }

        public string WeekDay { get; set; }

        public string WeekDayRange { get; set; }

        internal Cron()
        {
            Minute = "*";
            Hour = "*";
            MonthDay = "*";
            Month = "*";
            WeekDay = "*";
        }

        public override string ToString()
        {
            var minute = GenerateCronComponent(Minute, MinuteRange);
            var hour = GenerateCronComponent(Hour, HourRange);
            var monthDay = GenerateCronComponent(MonthDay, MonthDayRange);
            var month = GenerateCronComponent(Month, MonthRange);
            var weekDay = GenerateCronComponent(WeekDay, WeekDayRange);

            return $"{minute} {hour} {monthDay} {month} {weekDay}";
        }

        static string GenerateCronComponent(string val, string valRange)
        {
            if (!string.IsNullOrWhiteSpace(val) && val != "*")
            {
                if (!string.IsNullOrWhiteSpace(valRange))
                {
                    return $"{valRange}/{val}";
                }

                return $"*/{val}";
            }

            if (!string.IsNullOrWhiteSpace(valRange))
            {
                return $"{valRange}";
            }

            return val;
        }
    }
}
