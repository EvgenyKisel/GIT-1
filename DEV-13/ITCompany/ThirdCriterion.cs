using System;
using System.Collections.Generic;

namespace ITCompany
{
  class ThirdCriterion : Criteria
  {
    public List<List<int>> EmployeeCountList { get; set; }
    public int IndexOfMaxJuniors { get; set; }
    public List<List<int>> PossibleCases { get; set; }

    public override void CountNeededEmployees(Employees[] employees, double productivity)
    {
      /*int countJuniors = 0;
      double commonProductivity = 0;
      while (productivity - commonProductivity > employees[0].Productivity)
      {
        commonProductivity += employees[0].Productivity;
        countJuniors++;
      }
      double productivityAfterJuniors = productivity - commonProductivity;
      int countMiddles = 0;
      while(productivity - productivityAfterJuniors > employees[1].Productivity)
      {
        productivityAfterJuniors += employees[1].Productivity;
        countMiddles++;
      }
      double productivityAfterMiddles = productivity - productivityAfterJuniors;
      int countSeniors = 0;
      while (productivity - productivityAfterMiddles > employees[2].Productivity)
      {
        productivityAfterMiddles += employees[2].Productivity;
        countSeniors++;
      }
      double productivityAfterSeniors = productivity - productivityAfterMiddles;
      int countLeads = 0;
      while (productivity - productivityAfterJuniors > employees[3].Productivity)
      {
        productivityAfterJuniors += employees[3].Productivity;
        countLeads++;
      }
      List<int> employeesCount = new List<int>();*/
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
      foreach (List<int> list in PossibleCases)
      {
        double commonProductivity = 0;
        commonProductivity += list[0] * employees[0].Productivity + list[1] * employees[1].Productivity +
          list[2] * employees[2].Productivity + list[3] * employees[3].Productivity;
        if (commonProductivity == productivity)
        {
          EmployeeCountList.Add(list);
        }
      }
      int maxCountJuniors = EmployeeCountList[0][0];
      for (int i = 0; i < EmployeeCountList.Count; i++)
      {
        if (EmployeeCountList[i][0] > EmployeeCountList[0][0])
        {
          IndexOfMaxJuniors = i;
        }
      }
    }

    public override void PrintResults()
    {
      if (EmployeeCountList.Capacity == 0)
      {
        throw new NoSuitableOptionsException();
      }
      Console.WriteLine("{0} Juniors, {1} Middles, {2} Seniors, {3} Leads", EmployeeCountList[IndexOfMaxJuniors][0],
        EmployeeCountList[IndexOfMaxJuniors][1], EmployeeCountList[IndexOfMaxJuniors][2], EmployeeCountList[IndexOfMaxJuniors][3]);
    }
  }
}