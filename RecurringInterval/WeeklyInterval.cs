using System;

namespace RecurringInterval
{
    internal class WeeklyInterval : Interval
    {
        public WeeklyInterval(DateTime startDate, int skipInterval = 1) : base(Period.Weekly)
        {
            StartDate = startDate;
            SkipInterval = skipInterval;
        }

        public override Interval Next()
        {
            return new WeeklyInterval(NextStartDate(), SkipInterval);
        }

        private DateTime NextStartDate()
        {
            return StartDate.AddDays(7 * SkipInterval);
        }

    }

}