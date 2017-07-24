using System;

namespace Persons
{
    class InputException : Exception
    {
        public InputException(string message) : base(message) { }
    }
}