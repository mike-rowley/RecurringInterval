using System;

namespace RecurringInterval
{
    internal class MonthlyInterval : Interval
    {
        public MonthlyInterval(DateTime startDate, int skipInterval = 1) : base(Period.Monthly)
        {
            StartDate = startDate;
            SkipInterval = skipInterval;
        }
        
        public override Interval Next()
        {
            return new MonthlyInterval(NextStartDate(), SkipInterval);
        }

        private DateTime NextStartDate()
        {
            return StartDate.AddMonths(SkipInterval);
        }
        
    }

}