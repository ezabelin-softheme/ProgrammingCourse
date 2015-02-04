using System;

namespace Exceptions_Exercise1
{
    class IncorrectDataFormatException : Exception
    {
        public IncorrectDataFormatException() : base()
        {
        }

        public IncorrectDataFormatException(String message) : base(message)
        {
        }
    }
}
