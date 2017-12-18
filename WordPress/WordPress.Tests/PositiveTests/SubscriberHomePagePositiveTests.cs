using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordPress.Tests.PositiveTests
{
  [TestClass]
  public class SubscriberHomePagePositiveTests : HomePageTests
  {
    private new readonly string URL_HOME_PAGE = "http://localhost:8080/wp-admin/profile.php";

    [TestInitialize]
    public void TestInitialize()
    {
      User user = new User("Subscriber", "subscriber", "subscriber@gmail.com", Role.SUBSCRIBER);
      HomePage = LogInAs(user) as Pages.SubscriberHomePage;
    }

    [TestMethod]
    public void TestHomePageUrlForSubscriber()
    {
      Assert.AreEqual(URL_HOME_PAGE, HomePage.GetUrl());
      Logger.PrintLogInformation(new TestResult().LogOutput);
    }

    [TestMethod]
    public void TestSubscriberLogOut()
    {
      TestCorrectLogOut();
    }
  }
}