using System;
using System.Collections;

namespace FloatArrays
{
    class Outputer
    {
        public void OutputFloatArrays(float[][] floatArrays)
        {
            foreach (float[] row in floatArrays)
            {
                foreach (float element in row)
                {
                    Console.Write($"{element} \t");
                }
                Console.WriteLine();
            }
        }

        public void OutputNewFloatArray(ArrayList newFloatArray)
        {
            Console.WriteLine();
            foreach (float element in newFloatArray)
            {
                Console.Write($"{element} \t");
            }
        }
    }
}