using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordPress.Tests.PositiveTests
{
  [TestClass]
  public class ContributorHomePageTests : HomePageTests
  {
    [TestInitialize]
    public void TestInitialize()
    {
      User user = new User("Contributor", "contributor", "contributor@gmail.com", Role.CONTRIBUTOR);
      HomePage = LogInAs(user) as Pages.ContributorHomePage;
    }

    [TestMethod]
    public void TestHomePageUrlForContributor()
    {
      Assert.AreEqual(URL_HOME_PAGE, HomePage.GetUrl());
      Logger.PrintLogInformation(new TestResult().LogOutput);
    }
  }
}