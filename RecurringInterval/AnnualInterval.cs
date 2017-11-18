using System;

namespace RecurringInterval
{
    internal class AnnualInterval : Interval
    {
        public AnnualInterval(DateTime startDate, int skipInterval = 1) : base(Period.Annual)
        {
            StartDate = startDate;
            EndDate = NextStartDate().AddDays(-1);
        }

        public override Interval Next(int skipInterval = 1)
        {
            return new AnnualInterval(NextStartDate(skipInterval));
        }

        private DateTime NextStartDate(int skipInterval = 1)
        {
            if (skipInterval < 1) skipInterval = 1;
            return EndDate.AddYears(skipInterval);
        }
    }
}