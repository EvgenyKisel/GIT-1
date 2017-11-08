using System;

namespace ITCompany
{
  class EntryPoint
  {
    const string INPUTMONEYMESSAGE = "Please, enter amount of money.";
    const string INPUTPRODUCTIVITYMESSAGE = "Please, enter needed productivity.";

    static void Main(string[] args)
    {
      try
      {
        Console.WriteLine(INPUTMONEYMESSAGE);
        double money = double.Parse(Console.ReadLine());
        Console.WriteLine(INPUTPRODUCTIVITYMESSAGE);
        double productivity = double.Parse(Console.ReadLine());
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