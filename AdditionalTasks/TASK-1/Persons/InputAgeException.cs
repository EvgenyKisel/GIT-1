using System;

namespace Persons
{
    class InputAgeException : Exception
    {
        const string INPUTAGEEXCEPTION = "\n ! Uncorrect age. Age must be between 0 and 100. Try again";

        public InputAgeException() : base()
        {
            Console.WriteLine(INPUTAGEEXCEPTION);
        }
    }
}