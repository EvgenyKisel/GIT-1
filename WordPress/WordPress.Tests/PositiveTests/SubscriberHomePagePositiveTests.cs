using NUnit.Framework;

namespace WordPress.Tests.PositiveTests
{
  [TestFixture]
  public class SubscriberHomePagePositiveTests : HomePageTests
  {
    private new readonly string URL_HOME_PAGE = "http://localhost:8080/wp-admin/profile.php";
    protected static readonly string URL_DASHBOARD_PAGE = "http://localhost:8080/wp-admin/index.php";

    [SetUp]
    public void TestInitialize()
    {
      User user = new User("Subscriber", "subscriber", "subscriber@gmail.com", Role.SUBSCRIBER);
      HomePage = LogInAs(user) as Pages.SubscriberHomePage;
    }

    [Test]
    public void TestHomePageUrlForSubscriber()
    {
      Assert.AreEqual(URL_HOME_PAGE, HomePage.GetUrl());
    }

    [Test]
    public void TestSubscriberAbilityToGoToDashboard()
    {
      Pages.SubscriberHomePage SubscriberHomePage = HomePage as Pages.SubscriberHomePage;
      SubscriberHomePage.GoToDashboard();
      Assert.AreEqual(URL_DASHBOARD_PAGE, Browser.Url);
    }

    [Test]
    public void TestSubscriberLogOut()
    {
      TestCorrectLogOut();
    }
  }
}