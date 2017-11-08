using System;

namespace ITCompany
{
  enum Criterion
  {
    MAXIMUMPRODUCTITVITY = 1,
    MINIMUMCOSTFORFIXEDPRODUCTIVITY,
    MINIMUMEMPLOYEESHIGHERJUNIORFORFIXEDPRODUCTIVITY
  }

  class CriterionSelection
  {
    public void DisplayMenu()
    {
      Console.WriteLine("Please, select the right criterion: ");
      Console.WriteLine("  1 - Maximum productivity within the entered amount of money.");
      Console.WriteLine("  2 - The minimum cost for a fixed productivity.");
      Console.WriteLine("  3 - The minimum number of employees higher than Junior for fixed productivity.");
    }

    public void ChooseRightAction(Employees[] employees, double money, double productivity)
    {
      bool rightActionChecker = true;
      while (rightActionChecker)
      {
        try
        {
          int criterion = int.Parse(Console.ReadLine());
          Criteria criteria; 
          switch (criterion)
          {
            case 1:
              criteria = new FirstCriterion();
              criteria.CountNeededEmployees(employees, money);
              criteria.PrintResults();
              break;
            case 2:
              criteria = new SecondCriterion();
              criteria.CountNeededEmployees(employees, productivity);
              criteria.PrintResults();
              break;
            case 3:
              break;
            default:
              throw new InvalidCriterionException();
          }
        }
        catch (Exception ex)
        {
          Console.WriteLine(ex.Message);
          continue;
        }
        rightActionChecker = false;
      }
    }
  }
}