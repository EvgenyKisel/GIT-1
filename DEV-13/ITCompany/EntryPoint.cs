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
      }
      catch (Exception exception)
      {
        Console.WriteLine(exception.Message);
      }
      Console.ReadKey();
    }
  }
}