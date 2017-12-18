using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordPress.Tests.PositiveTests
{
  [TestClass]
  public class AdminHomePagePositiveTests : HomePageTests
  {
    [TestInitialize]
    public void TestInitialize()
    {
      User user = new User("admin", "password", "evgeny@gmail.com", Role.ADMINISTRATOR);
      HomePage = LogInAs(user) as Pages.AdminHomePage;
    }

    [TestMethod]
    public void TestHomePageUrlForAdmin()
    {
      Assert.AreEqual(URL_HOME_PAGE, HomePage.GetUrl());
      Logger.PrintLogInformation(new TestResult().LogOutput);
    }
  }
}