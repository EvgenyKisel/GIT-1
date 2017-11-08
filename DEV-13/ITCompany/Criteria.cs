namespace ITCompany
{
  abstract class Criteria
  {
    public abstract void CountNeededEmployees(Employees[] employees, double money);

    public abstract void PrintResults();
  }
}