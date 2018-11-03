﻿using System;

namespace CronBuilder
{
    public interface ICronEveryMinuteBuilder
    {
        string Every(int minutes);
    }

    public class CronEveryMinuteBuilder : ICronEveryMinuteBuilder
    {
        internal CronEveryMinuteBuilder()
        {
        }

        public string Every(int minutes)
        {
            if (minutes < 1 || minutes > 59)
            {
                throw new ArgumentException("Minutes must be between 1 and 59 inclusive");
            }

            return $"0 0/{minutes} * 1/1 * ? *";
        }
    }
}