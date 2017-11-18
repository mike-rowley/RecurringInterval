using System;

namespace RecurringInterval
{
    internal class DailyInterval : Interval
    {
        public DailyInterval(DateTime startDate, int skipInterval = 1) : base(Period.Daily)
        {
            StartDate = startDate;
            SkipInterval = skipInterval;
        }

        public override Interval Next()
        {
            return new DailyInterval(NextStartDate(), SkipInterval);
        }

        private DateTime NextStartDate()
        {
            return StartDate.AddDays(SkipInterval);
        }
    }
   
}