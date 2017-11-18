using System;

namespace RecurringInterval
{
    public abstract class Interval
    {
        protected Interval(Period period)
        {
            Period = period;
        }

        public DateTime StartDate { get; protected set; }
        public Period Period { get; }
        private int skipInterval = 1;

        public int SkipInterval
        {
            get => skipInterval;
            set => skipInterval = value < 1 ? 1 : value;
        }

        static readonly IntervalFactory factory = new IntervalFactory();

        public static Interval Create(Period period, DateTime startDate, int skipInterval = 1)
        {
            return factory.CreateFromStartDate(period, startDate, skipInterval);
        }

        public abstract Interval Next();

    }
}