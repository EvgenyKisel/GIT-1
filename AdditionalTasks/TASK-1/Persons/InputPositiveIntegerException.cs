using System;

namespace Persons
{
    class InputPositiveIntegerException : Exception
    {
        const string INPUTPOSITIVEINTEGEREXCEPTION = "\n ! It's not a positive integer number. Try again\n";

        public InputPositiveIntegerException() : base()
        {
            Console.WriteLine(INPUTPOSITIVEINTEGEREXCEPTION);
        }
    }
}