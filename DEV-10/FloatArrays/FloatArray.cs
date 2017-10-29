using System;
using System.Collections;
using System.Text;

namespace FloatArrays
{
  class FloatArray
  {
    const float EPSILON = float.Epsilon;
    const int RANDOMMINSIZEVALUE = 1;
    const int RANDOMMAXSIZEVALUE = 10;
    const int RANDOMMINELEMENTVALUE = -20;
    const int RANDOMMAXELEMENTVALUE = 50;

    public double[][] FloatArrays { get; set; }
    public ArrayList NewFloatArray { get; set; }

    /// <summary>
    /// This method declares and initializes array of arrays with random length and elements.
    /// </summary>
    /// <param name="floatArrays"> array of arrays </param>
    public void InitializeFloatArrays()
    {
      Random random = new Random();
      FloatArrays = new double[random.Next(RANDOMMINSIZEVALUE, RANDOMMAXSIZEVALUE)][];
      for (int i = 0; i < FloatArrays.Length; i++)
      {
        FloatArrays[i] = new double[random.Next(RANDOMMINSIZEVALUE, RANDOMMAXSIZEVALUE)];
        for (int j = 0; j < FloatArrays[i].Length; j++)
        {
          FloatArrays[i][j] = random.NextDouble() * random.Next(RANDOMMINELEMENTVALUE, RANDOMMAXELEMENTVALUE);
        }
      }
    }

    /// <summary>
    /// This method finds elements, that belong to at least two arrays,
    /// and then writes them in new array.
    /// </summary>
    /// <param name="floatArrays"> array of arrays </param>
    /// <returns> new array with special elements </returns>
    public void CreateNewArray()
    {
      NewFloatArray = new ArrayList();
      for (int i = 0; i < FloatArrays.Length - 1; i++)
      {
        for (int j = 0; j < FloatArrays[i].Length; j++)
        {
          int count = 1;
          for (int l = i + 1; l < FloatArrays.Length; l++)
          {
            for (int k = 0; k < FloatArrays[l].Length; k++)
            {
              if (Math.Abs(FloatArrays[i][j] - FloatArrays[l][k]) < EPSILON)
              {
                count++;
                break;
              }
            }
            if (count >= 2)
            {
              if (!NewFloatArray.Contains(FloatArrays[i][j]))
              {
                NewFloatArray.Add(FloatArrays[i][j]);
              }
              break;
            }
          }
        }
      }
    }

    /// <summary>
    /// This method prints on console array of arrays.
    /// </summary>
    /// <param name="floatArrays"> array of arrays </param>
    public void OutputFloatArrays()
    {
      foreach (double[] row in FloatArrays)
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
    public void OutputNewFloatArray()
    {
      StringBuilder line = new StringBuilder();
      Console.WriteLine();
      foreach (double element in NewFloatArray)
      {
        line.Append($"{element} \t");
      }
      Console.WriteLine(line);
    }
  }
}