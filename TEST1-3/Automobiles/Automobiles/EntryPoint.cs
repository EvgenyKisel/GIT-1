using System;
using System.Collections.Generic;

namespace Automobiles
{
  /// <summary>
  /// Entry point to program.
  /// </summary>
  class EntryPoint
  {
    /// <summary>
    /// This method creates list of cars, that creates list of cars, sort cars, and prints sorted cars on console.
    /// </summary>
    static void Main()
    {
      try
      {
        AutomobilesList automobilesList = new AutomobilesList();
        List<Automobile> automobiles = automobilesList.AddAutomobiles();
        automobiles = automobilesList.SortAutomobiles();
        automobilesList.Print();
      }
      catch (Exception exception)
      {
        Console.WriteLine(exception.Message);
      }
    }
  }
}