using System;

namespace FloatArrays
{
    class Initializer
    {
        const int RANDOMMAXVALUE = 10;

        public void InitializeFloatArrays(out float[][] floatArrays)
        {
            Random random = new Random();
            floatArrays = new float[random.Next(1, RANDOMMAXVALUE)][];
            for (int i = 0; i < floatArrays.Length; i++)
            {
                floatArrays[i] = new float[random.Next(1, RANDOMMAXVALUE)];
                for (int j = 0; j < floatArrays[i].Length; j++)
                {
                    floatArrays[i][j] = random.Next(RANDOMMAXVALUE);
                }
            }
        }
    }
}