using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ITCompany.Tests
{
  [TestClass]
  public class CollectionTests
  {
    static List<Employees> employees;

    [ClassInitialize]
    public static void InitializeCurrentTest(TestContext testContext)
    {
      employees = new List<Employees>
      {
        new Junior(),
        new Middle(),
        new Senior(),
        new Lead()
      };
    }

    [TestMethod]
    public void AllItemsAreNotNull()
    {
      CollectionAssert.AllItemsAreNotNull(employees, "Not null failed");
    }
  }
}