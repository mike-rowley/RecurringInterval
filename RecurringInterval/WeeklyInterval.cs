using System;

namespace RecurringInterval
{
    internal class WeeklyInterval : Interval
    {
        public WeeklyInterval(DateTime startDate, int skipInterval = 1) : base(Period.Weekly)
        {
            StartDate = startDate;
            EndDate = StartDate.AddDays(6);
        }

        public override Interval Next(int skipInterval = 1)
        {
            return new WeeklyInterval(NextStartDate(skipInterval));
        }

        private DateTime NextStartDate(int skipInterval = 1)
        {
            if (skipInterval < 1) skipInterval = 1;
            return EndDate.AddDays(skipInterval);
        }

    }

}