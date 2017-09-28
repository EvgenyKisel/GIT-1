﻿using System.Collections;

namespace FloatArrays
{
    class NewArrayCreator
    {
        // This method finds elements, that belong to at least two arrays,
        // and then writes them in new array.
        public ArrayList CreateNewArray(float[][] floatArrays)
        {
            ArrayList newArray = new ArrayList();
            for (int i = 0; i < floatArrays.Length - 1; i++)
            {
                for (int j = 0; j < floatArrays[i].Length; j++)
                {
                    int count = 1;
                    for (int l = i + 1; l < floatArrays.Length; l++)
                    {
                        for (int k = 0; k < floatArrays[l].Length; k++)
                        {
                            if (floatArrays[i][j] == floatArrays[l][k])
                            {
                                count++;
                                break;
                            }
                        }
                        if (count >= 2)
                        {
                            if (!newArray.Contains(floatArrays[i][j]))
                            {
                                newArray.Add(floatArrays[i][j]);
                            }
                            break;
                        }
                    }
                }
            }
            return newArray;
        }
    }
}