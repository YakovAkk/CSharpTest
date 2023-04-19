using CSharpTest;
using CSharpTest.Validator;
using CSharpTest.Validator.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpTest
{
    public class WorkDayCalculator : IWorkDayCalculator
    {
        private readonly IDateValidator _dateValidator;

        public WorkDayCalculator()
        {
            _dateValidator = new DateValidator();
        }

        public DateTime Calculate(DateTime startDate, int dayCount, WeekEnd[] weekEnds)
        {
            if (weekEnds == null)
                return startDate.AddDays(dayCount - 1);

            //Validation of weekEnds
            foreach (var item in weekEnds)
            {
                if (!_dateValidator.ValidateDate(item.StartDate, item.EndDate))
                    throw new ArgumentException("Start date must be more than end date in weekEnds array!");
            }

            // Get all weekend dates in one list
            List<DateTime> weekendsDates = new List<DateTime>();
            foreach (var item in weekEnds)
            {
                weekendsDates = weekendsDates.Union(item.GetAllDatesFromStartToEnd()).ToList();
            }

            var currentDate = startDate;

            while (dayCount != 0)
            {
                if (!weekendsDates.Contains(currentDate))
                {
                    currentDate = currentDate.AddDays(1);
                    dayCount--;
                }
                else
                {
                    currentDate = currentDate.AddDays(1);
                }
            }

            return currentDate.AddDays(-1);
        }
    }
}
