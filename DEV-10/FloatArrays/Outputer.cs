using System;
using System.Collections;

namespace FloatArrays
{
    class Outputer
    {
        /// <summary>
        /// This method prints on console array of arrays.
        /// </summary>
        /// <param name="floatArrays"> array of arrays </param>
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

        /// <summary>
        /// This method prints on console new array.
        /// </summary>
        /// <param name="newFloatArray"> new array with special elements </param>
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