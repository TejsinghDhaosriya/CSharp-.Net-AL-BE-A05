using System;

namespace CalculatorConsoleApp.exceptions
{
    public class InvalidInputException : ApplicationException
    {
        public InvalidInputException(string name)
            : base(name)
        {
        }
    }
}