using System;

namespace RecurringInterval
{
    internal class DailyInterval : Interval
    {
        public DailyInterval(DateTime startDate, int skipInterval = 1) : base(Period.Daily)
        {
            StartDate = startDate;
            EndDate = StartDate;
        }

        public override Interval Next(int skipInterval = 1)
        {
            return new DailyInterval(NextStartDate(skipInterval));
        }

        private DateTime NextStartDate(int skipInterval = 1)
        {
            if (skipInterval < 1) skipInterval = 1;
            return EndDate.AddDays(skipInterval);
        }
    }
   
}