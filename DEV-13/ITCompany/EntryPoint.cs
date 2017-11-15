using System;

namespace ITCompany
{
  /// <summary>
  /// Entry point to program.
  /// </summary>
  class EntryPoint
  {
    const string INPUTMONEYMESSAGE = "Please, enter amount of money.";
    const string INPUTPRODUCTIVITYMESSAGE = "Please, enter needed productivity.";

    /// <summary>
    /// This method takes two values from console, chooses right criterion, counts employees according to all entered data.
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
      try
      {
        Console.WriteLine(INPUTMONEYMESSAGE);
        double money = double.Parse(Console.ReadLine());
        Console.WriteLine(INPUTPRODUCTIVITYMESSAGE);
        double productivity = double.Parse(Console.ReadLine());
        if (money < 0 || productivity < 0)
        {
          throw new InputValuesException();
        }
        Employees junior = new Junior();
        Employees middle = new Middle();
        Employees senior = new Senior();
        Employees lead = new Lead();
        Employees[] team =
        {
          junior,
          middle,
          senior,
          lead
        };
        CriterionSelection criterionSelection = new CriterionSelection();
        criterionSelection.DisplayMenu();
        criterionSelection.ChooseRightAction(team, money, productivity);
      }
      catch (Exception exception)
      {
        Console.WriteLine(exception.Message);
      }
      Console.ReadKey();
    }
  }
}