using System;
using System.Collections;

namespace FloatArrays
{
    /// <summary>
    /// Entrypoint to program.
    /// </summary>
    class EntryPoint
    {
        const string NEWARRAYISEMPTY = "There is no such elements.";

        /// <summary>
        /// This method calls one method, that initializes array of arrays, another method,
        /// that prints this array on console, and method, that create new array of special values, and then displayed on console.
        /// </summary>
        static void Main()
        {
            try
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}