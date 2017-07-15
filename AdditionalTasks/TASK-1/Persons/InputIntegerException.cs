using System;

namespace Persons
{
    class InputIntegerException : Exception
    {
        const string INPUTINTEGEREXCEPTION = "\n ! It's not an integer number. Try again";

        public InputIntegerException() : base()
        {
            Console.WriteLine(INPUTINTEGEREXCEPTION);
        }
    }
}