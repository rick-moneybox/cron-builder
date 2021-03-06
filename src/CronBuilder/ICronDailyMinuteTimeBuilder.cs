﻿using System;
using System.Linq;

namespace CronBuilder
{
    public interface ICronDailyMinuteTimeBuilder
    {
        ICronDailyHourTimeBuilder At(params Minute[] minutes);
    }

    internal class CronDailyMinuteTimeBuilder : ICronDailyMinuteTimeBuilder
    {
        private readonly Cron _cron;

        internal CronDailyMinuteTimeBuilder() : this(new Cron())
        {
        }

        internal CronDailyMinuteTimeBuilder(Cron cron)
        {
            _cron = cron;
        }

        public ICronDailyHourTimeBuilder At(params Minute[] minutes)
        {
            if (minutes == null || !minutes.Any())
            {
                throw new ArgumentNullException(nameof(minutes));
            }

            _cron.MinuteRange = minutes
                .Distinct()
                .Select(m => ((int)m).ToString())
                .Aggregate((prev, curr) => $"{prev},{curr}");

            return new CronDailyHourTimeBuilder(_cron);
        }
    }
}
