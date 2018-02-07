using NUnit.Framework;

namespace WordPress.Tests.PositiveTests
{
  [TestFixture]
  public abstract class SubscriberActionsTests : BasePageTests
  {
    protected Pages.SubscriberHomePage HomePage { get; set; }
    protected Pages.DashboardPage DashboardPage { get; set; }
    protected static readonly string URL_USERS_PAGE = "http://localhost:8080/wp-admin/users.php";

    [SetUp]
    public void TestInitialize()
    {
      User user = new User("Subscriber", "subscriber", "subscriber@gmail.com", Role.SUBSCRIBER);
      HomePage = LogInAs(user) as Pages.SubscriberHomePage;
      DashboardPage = HomePage.GoToDashboard();
    }   
  }
}