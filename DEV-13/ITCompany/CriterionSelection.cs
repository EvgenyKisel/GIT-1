using System;

namespace ITCompany
{
  enum Criterion
  {
    MAXIMUMPRODUCTITVITY = 1,
    MINIMUMCOSTFORFIXEDPRODUCTIVITY,
    MINIMUMEMPLOYEESHIGHERJUNIORFORFIXEDPRODUCTIVITY
  }

  public class CriterionSelection
  {
    /// <summary>
    /// This method displays menu on console.
    /// </summary>
    public void DisplayMenu()
    {
      Console.WriteLine("Please, select the right criterion: ");
      Console.WriteLine("  1 - Maximum productivity within the entered amount of money.");
      Console.WriteLine("  2 - The minimum cost for a fixed productivity.");
      Console.WriteLine("  3 - The minimum number of employees higher than Junior for fixed productivity.");
    }

    /// <summary>
    /// This method chooses right criterion accordint to the entered value.
    /// </summary>
    /// <param name="employees"> junior, middle, senior, lead </param>
    /// <param name="money"> inputted money </param>
    /// <param name="productivity"> inputted productivity </param>
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
              criteria = new ThirdCriterion();
              criteria.CountNeededEmployees(employees, productivity);
              criteria.PrintResults();
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