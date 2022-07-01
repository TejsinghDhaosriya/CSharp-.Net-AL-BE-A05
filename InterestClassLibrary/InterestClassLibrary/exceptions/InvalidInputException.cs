using System;

namespace InterestClassLibrary.exceptions
{
    public class InvalidInputException : ApplicationException
    {
        public InvalidInputException(string name)
            : base(name)
        {
        }
    }
}