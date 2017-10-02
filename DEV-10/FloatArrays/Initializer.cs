using System;

namespace FloatArrays
{
    class Initializer
    {
        const int RANDOMMINSIZEVALUE = 1;
        const int RANDOMMAXSIZEVALUE = 10;
        const int RANDOMMINELEMENTVALUE = -20;
        const int RANDOMMAXELEMENTVALUE = 50;
        
        /// <summary>
        /// This method declares and initializes array of arrays with random length and elements.
        /// </summary>
        /// <param name="floatArrays"> array of arrays </param>
        public void InitializeFloatArrays(out double[][] floatArrays)
        {
            Random random = new Random();
            floatArrays = new double[random.Next(RANDOMMINSIZEVALUE, RANDOMMAXSIZEVALUE)][];
            for (int i = 0; i < floatArrays.Length; i++)
            {
                floatArrays[i] = new double[random.Next(RANDOMMINSIZEVALUE, RANDOMMAXSIZEVALUE)];
                for (int j = 0; j < floatArrays[i].Length; j++)
                {
                    floatArrays[i][j] = random.NextDouble()*random.Next(RANDOMMINELEMENTVALUE, RANDOMMAXELEMENTVALUE);
                }
            }
        }
    }
}