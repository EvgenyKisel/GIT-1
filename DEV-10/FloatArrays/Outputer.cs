using System;

namespace FloatArrays
{
    class Outputer
    {
        public void OutputFloatArrays(float[][] floatArrays)
        {
            foreach(float[] row in floatArrays)
            {
                foreach (float number in row)
                {
                    Console.Write($"{number} \t");
                }
                Console.WriteLine();
            }
        }
    }
}