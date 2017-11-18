using System;

namespace RecurringInterval
{
    internal class AnnualInterval : Interval
    {
        public AnnualInterval(DateTime startDate, int skipInterval = 1) : base(Period.Annual)
        {
            StartDate = startDate;
            SkipInterval = skipInterval;
        }

        public override Interval Next()
        {
            return new AnnualInterval(NextStartDate(), SkipInterval);
        }

        private DateTime NextStartDate()
        {
            return StartDate.AddYears(SkipInterval);
        }
    }
}