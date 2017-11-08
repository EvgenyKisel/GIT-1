using System.Collections.Generic;

namespace ITCompany
{
  public abstract class Criteria
  {
    public abstract void CountNeeded(Employees[] employees, double money);
  }
}