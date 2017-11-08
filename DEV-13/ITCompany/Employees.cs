namespace ITCompany
{
  public abstract class Employees
  {
    private double salary;
    private double productivity;
    private int count;

    public Employees()
    {
      salary = 0;
      productivity = 0;
    }

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
        if (value < 0 || value > 10)
        {
          throw new InvalidSalaryException();
        }
        productivity = value;
      }
    }

    public int Count { get; set; }
  }
}