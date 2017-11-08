using System;
using System.Collections.Generic;

namespace ITCompany
{
  class FirstCriterion : Criteria
  {
    public List<List<int>> EmployeeCountList { get; set; }

    public override void CountNeeded(Employees[] employees, double money)
    {
      List<List<int>> possibleCases = new List<List<int>>();
      int minEmployeesCount = (int)(money / employees[3].Salary);
      int maxEmployeesCount = (int)(money / employees[0].Salary);
      for (int q = minEmployeesCount; q < maxEmployeesCount; q++)
      {
        for (int i = 0; i < (q / 4) + 1; i++)
        {
          for (int j = i; j < ((q - i) / 3) + 1; j++)
          {
            for (int k = j; k < ((q - j) / 2) + 1; k++)
            {
              possibleCases.Add(new List<int> { i, j, k, (q - i - j - k) });
              possibleCases.Add(new List<int> { (q - i - j - k), k, j, i });
            }
          }
        }
      }
      EmployeeCountList = new List<List<int>>();
      foreach (List<int> list in possibleCases)
      {
        double commonSalary = 0;
        commonSalary += list[0] * employees[0].Salary + list[1] * employees[1].Salary +
          list[2] * employees[2].Salary + list[3] * employees[3].Salary;
        if (commonSalary == money)
        {
          EmployeeCountList.Add(list);
        }
      }
    }

    public void PrintResults()
    {
      foreach (List<int> employeeCount in EmployeeCountList)
      {
        Console.WriteLine("{0} Juniors, {1} Middles, {2} Seniors, {3} Leads", employeeCount[0],
          employeeCount[1], employeeCount[2], employeeCount[3]);
      }
    }
  }
}