using System;

namespace FloatArrays
{
  /// <summary>
  /// Entrypoint to program.
  /// </summary>
  class EntryPoint
  {
    /// <summary>
    /// This method calls one method, that initializes array of arrays, another method,
    /// that prints this array on console, and method, that create new array of special values, and then displayed on console.
    /// </summary>
    static void Main()
    {
      try
      {
        FloatArray floatArray = new FloatArray();
        floatArray.InitializeFloatArrays();
        floatArray.OutputFloatArrays();
        floatArray.CreateNewArray();
        floatArray.OutputNewFloatArray();
        Console.ReadKey();
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}