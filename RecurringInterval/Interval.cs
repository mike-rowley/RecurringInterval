using System;

namespace RecurringInterval
{
    public abstract class Interval
    {
        protected Interval(Period period)
        {
            Period = period;
        }

        public int TotalDays => (int)EndDate.Subtract(StartDate).TotalDays + 1;

        public DateTime StartDate { get; protected set; }
        public DateTime EndDate { get; protected set; }
        public Period Period { get; }
        public int SkipInterval { get; }

        static readonly IntervalFactory factory = new IntervalFactory();

        public static Interval Create(Period period, DateTime startDate, int skipInterval = 1)
        {
            return factory.CreateFromStartDate(period, startDate, skipInterval);
        }

        public abstract Interval Next(int skipInterval = 1);

    }
}