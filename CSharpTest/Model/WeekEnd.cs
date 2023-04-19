using System;
using System.Collections.Generic;

namespace CSharpTest
{
    public class WeekEnd
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public WeekEnd(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }

        public List<DateTime> GetAllDatesFromStartToEnd()
        {
            var dates = new List<DateTime>();

            for (DateTime i = StartDate; i <= EndDate; i = i.AddDays(1))
            {
                dates.Add(i);
            }

            return dates;
        }
    }
}
