using System;

namespace ITCompany
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      try
      {
        Console.WriteLine();
        double money = double.Parse(Console.ReadLine());
        Console.WriteLine();
        double productivity = double.Parse(Console.ReadLine());
        CriterionSelection criterionSelection = new CriterionSelection();
        criterionSelection.DisplayMenu();
        criterionSelection.ChooseRightAction();
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
        FirstCriterion f = new FirstCriterion();
        f.CountNeeded(team, money);
        f.PrintResults();
      }
      catch (Exception exception)
      {
        Console.WriteLine(exception.Message);
      }
      Console.ReadKey();
    }
  }
}