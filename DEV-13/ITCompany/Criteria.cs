namespace ITCompany
{
  abstract class Criteria
  {
    /// <summary>
    /// This method counts employees according to the requirements.
    /// </summary>
    /// <param name="employees"> junior, middle, senior and lead </param>
    /// <param name="money"> inputted money </param>
    public abstract void CountNeededEmployees(Employees[] employees, double money);

    /// <summary>
    /// This method prints result on console.
    /// </summary>
    public abstract void PrintResults();
  }
}