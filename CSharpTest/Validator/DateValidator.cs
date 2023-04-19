using CSharpTest.Validator.Base;
using System;

namespace CSharpTest.Validator
{
    public class DateValidator : IDateValidator
    {
        public bool ValidateDate(DateTime start, DateTime end)
        {
            if(start > end)
                return false;
            return true;
        }
    }
}
