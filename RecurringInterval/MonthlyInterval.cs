using System;

namespace RecurringInterval
{
    internal class MonthlyInterval : Interval
    {
        public MonthlyInterval(DateTime startDate, int skipInterval = 1) : base(Period.Monthly)
        {
            StartDate = startDate;

            if (startDate.Day == 1)
            {
                EndDate = new DateTime(startDate.Year, startDate.Month, DateTime.DaysInMonth(startDate.Year, startDate.Month));
            }
            else
                EndDate = startDate.AddMonths(1).AddDays(-1);
        }
        
        public override Interval Next(int skipInterval = 1)
        {
            return new MonthlyInterval(NextStartDate(skipInterval));
        }

        private DateTime NextStartDate(int skipInterval = 1)
        {
            if (skipInterval < 1) skipInterval = 1;
            return EndDate.AddDays(skipInterval);
        }
        
    }

}