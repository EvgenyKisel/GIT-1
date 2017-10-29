using System;

namespace Shop
{
    class InputException : Exception
    {
        public InputException(string message) : base(message) { }
    }
}