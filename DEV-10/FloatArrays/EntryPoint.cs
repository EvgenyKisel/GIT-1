using System;

namespace FloatArrays
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Initializer initializer = new Initializer();
            initializer.InitializeFloatArrays(out float[][] floatArrays);
            Outputer outputer = new Outputer();
            outputer.OutputFloatArrays(floatArrays);
            Console.ReadKey();
        }
    }
}