using System;


namespace RecurringInterval
{
    internal class IntervalFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="period"></param>
        /// <param name="startDate">The first date</param>
        /// <param name="skipInterval">The number of periods to skip between Intervals</param>
        /// <returns></returns>
        public Interval CreateFromStartDate(Period period, DateTime startDate, int skipInterval = 1)
        {
            switch (period)
            {
                case Period.Monthly:
                    return new MonthlyInterval(startDate, skipInterval);

                case Period.Weekly:
                    return new WeeklyInterval(startDate, skipInterval);

                case Period.Daily:
                    return new DailyInterval(startDate, skipInterval);

                case Period.Annual:
                    return new AnnualInterval(startDate, skipInterval);

                default:
                    return new DailyInterval(startDate, skipInterval);
            }
        }
    }
}
