using System;
using System.Collections.Generic;

namespace ITCompany
{
  class SecondCriterion : Criteria
  {
    public List<List<int>> EmployeeCountList { get; set; }
    public List<double> SalaryList { get; set; }
    public int IndexOfMinSalary { get; set; }
    public List<List<int>> PossibleCases { get; set; }

    public override void CountNeededEmployees(Employees[] employees, double productivity)
    {
      PossibleCases = new List<List<int>>();
      int minEmployeesCount = (int)(productivity / employees[3].Productivity);
      int maxEmployeesCount = (int)(productivity / employees[0].Productivity);
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
      SalaryList = new List<double>();
      foreach (List<int> list in PossibleCases)
      {
        double commonSalary = 0;
        double commonProductivity = 0;
        commonSalary += list[0] * employees[0].Salary + list[1] * employees[1].Salary +
          list[2] * employees[2].Salary + list[3] * employees[3].Salary;
        commonProductivity += list[0] * employees[0].Productivity + list[1] * employees[1].Productivity +
          list[2] * employees[2].Productivity + list[3] * employees[3].Productivity;
        if (commonProductivity == productivity)
        {
          SalaryList.Add(commonSalary);
          EmployeeCountList.Add(list);
        }
      }
      double minSalary = SalaryList[0];
      for (int i = 0; i < SalaryList.Count; i++)
      {
        if (SalaryList[i] < minSalary)
        {
          minSalary = SalaryList[i];
          IndexOfMinSalary = i;
        }
      }
    }

    public override void PrintResults()
    {
      if (EmployeeCountList.Capacity == 0)
      {
        throw new NoSuitableOptionsException();
      }
      Console.WriteLine("{0} Juniors, {1} Middles, {2} Seniors, {3} Leads", EmployeeCountList[IndexOfMinSalary][0],
        EmployeeCountList[IndexOfMinSalary][1], EmployeeCountList[IndexOfMinSalary][2], EmployeeCountList[IndexOfMinSalary][3]);
    }
  }
}