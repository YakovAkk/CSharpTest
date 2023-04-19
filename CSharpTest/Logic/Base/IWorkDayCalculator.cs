using System;

namespace CSharpTest
{
    public interface IWorkDayCalculator
    {
       DateTime Calculate(DateTime startDate, int dayCount, WeekEnd[] weekEnds);
    }
}
