using System;

namespace Automobiles
{
  /// <summary>
  /// This class initialize automobiles.
  /// </summary>
  public class AutomobileCreator
  {
    public static readonly string NOTANUMBER = "Price is not a number. Try again";

    /// <summary>
    /// This method build a car.
    /// </summary>
    /// <returns> automobile with mark, model, type and price </returns>
    public Automobile BuildAutomobile()
    {
      Console.WriteLine("Mark : ");
      string mark = Console.ReadLine();
      Console.WriteLine("Model : ");
      string model = Console.ReadLine();
      Console.WriteLine("Type : ");
      string type = Console.ReadLine();
      Console.WriteLine("Price : ");
      decimal price = 0;
      try
      {
        price = decimal.Parse(Console.ReadLine());
      }
      catch (FormatException)
      {
        Console.WriteLine(NOTANUMBER);
        return BuildAutomobile();
      }
      return new Automobile(mark, model, type, price);
    }

    /// <summary>
    /// This method controls adding cars.
    /// </summary>
    /// <returns> true if user wants to add one more car and false if he doesn't </returns>
    public bool DoYouWantToAddOneMoreAutomobile()
    {
      Console.WriteLine("Please, press ENTER, if you want to add one more car or press any key to continue program.");
      bool answer = true;
      switch (Console.ReadKey(true).Key)
      {
        case ConsoleKey.Enter:
          answer = true;
          break;
        default:
          answer = false;
          break;
      }
      return answer;
    }
  }
}