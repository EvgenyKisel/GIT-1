using System;

namespace FloatArrays
{
    class Initializer
    {
        const int RANDOMMINSIZEVALUE = 1;
        const int RANDOMMAXSIZEVALUE = 10;
        const int RANDOMMINELEMENTVALUE = -20;
        const int RANDOMMAXELEMENTVALUE = 50;

        // This method declares and initializes array of arrays with random length and elements.
        public void InitializeFloatArrays(out float[][] floatArrays)
        {
            Random random = new Random();
            floatArrays = new float[random.Next(RANDOMMINSIZEVALUE, RANDOMMAXSIZEVALUE)][];
            for (int i = 0; i < floatArrays.Length; i++)
            {
                floatArrays[i] = new float[random.Next(RANDOMMINSIZEVALUE, RANDOMMAXSIZEVALUE)];
                for (int j = 0; j < floatArrays[i].Length; j++)
                {
                    floatArrays[i][j] = random.Next(RANDOMMINELEMENTVALUE, RANDOMMAXELEMENTVALUE);
                }
            }
        }
    }
}