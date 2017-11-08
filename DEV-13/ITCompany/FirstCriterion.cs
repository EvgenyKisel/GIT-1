using System;
using System.Collections.Generic;

namespace ITCompany
{
  class FirstCriterion : Criteria
  {
    public List<List<int>> EmployeeCountList { get; set; }
    public List<double> ProductivityList { get; set; }
    public int IndexOfMaxProductivity { get; set; }
    public List<List<int>> PossibleCases { get; set; }

    public override void CountNeededEmployees(Employees[] employees, double money)
    {
      PossibleCases = new List<List<int>>();
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
              PossibleCases.Add(new List<int> { i, j, k, (q - i - j - k) });
              PossibleCases.Add(new List<int> { (q - i - j - k), k, j, i });
            }
          }
        }
      }
      EmployeeCountList = new List<List<int>>();
      ProductivityList = new List<double>();
      foreach (List<int> list in PossibleCases)
      {
        double commonSalary = 0;
        double commonProductivity = 0;
        commonSalary += list[0] * employees[0].Salary + list[1] * employees[1].Salary +
          list[2] * employees[2].Salary + list[3] * employees[3].Salary;
        commonProductivity += list[0] * employees[0].Productivity + list[1] * employees[1].Productivity +
          list[2] * employees[2].Productivity + list[3] * employees[3].Productivity;
        if (commonSalary == money)
        {
          ProductivityList.Add(commonProductivity);
          EmployeeCountList.Add(list);
        }
      }
      double maxProductivity = 0;
      for (int i = 0; i < ProductivityList.Count; i++)
      {
        if (ProductivityList[i] > maxProductivity)
        {
          maxProductivity = ProductivityList[i];
          IndexOfMaxProductivity = i;
        }
      }
    }

    public override void PrintResults()
    {
      if (EmployeeCountList.Capacity == 0)
      {
        throw new NoSuitableOptionsException();
      }
      Console.WriteLine("{0} Juniors, {1} Middles, {2} Seniors, {3} Leads", EmployeeCountList[IndexOfMaxProductivity][0],
        EmployeeCountList[IndexOfMaxProductivity][1], EmployeeCountList[IndexOfMaxProductivity][2], EmployeeCountList[IndexOfMaxProductivity][3]);
    }
  }
}