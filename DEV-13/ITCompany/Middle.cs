﻿namespace ITCompany
{
  class Middle : Employees
  {
    private double salary;
    private double productivity;

    public double Salary
    {
      get
      {
        return salary;
      }
      set
      {
        if (value < 0)
        {
          throw new InvalidSalaryException();
        }
        salary = value;
      }
    }

    public double Productivity
    {
      get
      {
        return productivity;
      }
      set
      {
        if (value < 0 || value > 5)
        {
          throw new InvalidSalaryException();
        }
        productivity = value;
      }
    }

    public Middle()
    {
      Salary = 500;
      Productivity = 1.0;
    }
  }
}