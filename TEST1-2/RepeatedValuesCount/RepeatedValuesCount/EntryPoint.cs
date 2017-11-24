using System;

namespace RepeatedValuesCount
{
  /// <summary>
  /// Entry point to program.
  /// </summary>
  class EntryPoint
  {
    /// <summary>
    /// This method calls method that initializes collection, counts repeated elements in collection and prints this count on console.
    /// </summary>
    /// <param name="args"> file path with values for collection </param>
    static void Main(string[] args)
    {
      try
      {
        if (args.Length == 0)
        {
          throw new ArgumentException();
        }
        string filePath = args[0];
        ListOfValues valuesList = new ListOfValues();
        Console.WriteLine(valuesList.CountRepeatedElements(valuesList.InitializeList(filePath)));
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}