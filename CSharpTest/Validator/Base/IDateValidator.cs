using System;

namespace CSharpTest.Validator.Base
{
    public interface IDateValidator
    {
        bool ValidateDate(DateTime start, DateTime end);
    }
}
