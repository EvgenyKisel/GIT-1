using System;

namespace ITCompany
{
  class CriterionSelection
  {
    public void DisplayMenu()
    {
      Console.WriteLine("Please, select the right criterion: ");
      Console.WriteLine("  1 - Maximum productivity within the entered amount of money.");
      Console.WriteLine("  2 - The minimum cost for a fixed productivity.");
      Console.WriteLine("  3 - The minimum number of employees higher than Junior for fixed productivity.");
      Console.WriteLine("  exit - quit the program\n");
    }
  }
}