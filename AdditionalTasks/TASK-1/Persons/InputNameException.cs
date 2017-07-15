using System;

namespace Persons
{
    class InputNameException : Exception
    {
        const string INPUTNAMEEXCEPTION = "\n ! Uncorrect name. Use only letters. Try again\n";

        public InputNameException() : base()
        {
            Console.WriteLine(INPUTNAMEEXCEPTION);
        }
    }
}