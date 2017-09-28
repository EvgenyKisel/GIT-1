using System;
using System.Collections;

namespace FloatArrays
{
    class EntryPoint
    {
        const string NEWARRAYISEMPTY = "There is no such elements.";

        // This method calls one method, that initializes array of arrays, another method,
        // that prints this array on console, and method, that create new array of special values, and then displayed on console.
        static void Main(string[] args)
        {
            Initializer initializer = new Initializer();
            initializer.InitializeFloatArrays(out float[][] floatArrays);
            Outputer outputer = new Outputer();
            outputer.OutputFloatArrays(floatArrays);
            ArrayList newFloatArray = new NewArrayCreator().CreateNewArray(floatArrays);
            if (new Checker().CheckForNonEmpty(newFloatArray) == true)
            {
                outputer.OutputNewFloatArray(newFloatArray);
            }
            else
            {
                Console.WriteLine(NEWARRAYISEMPTY);
            }
            Console.ReadKey();
        }
    }
}