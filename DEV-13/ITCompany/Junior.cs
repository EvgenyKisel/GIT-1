namespace ITCompany
{
  class Junior
  {
    private double salary;
    private int productivity;

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

    public int Productivity
    {
      get
      {
        return productivity;
      }
      set
      {
        if (value < 0 || value > 10)
        {
          throw new InvalidSalaryException();
        }
        productivity = value;
      }
    }
  }
}