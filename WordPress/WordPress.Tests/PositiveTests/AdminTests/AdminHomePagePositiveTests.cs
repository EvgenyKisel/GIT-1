using NUnit.Framework;

namespace WordPress.Tests.PositiveTests
{
  [TestFixture]
  public class AdminHomePagePositiveTests : HomePageTests
  {
    private static readonly string URL_USERS_PAGE = "http://localhost:8080/wp-admin/users.php";

    [SetUp]
    public void TestInitialize()
    {
      User user = new User("admin", "password", "evgeny@gmail.com", Role.ADMINISTRATOR);
      HomePage = LogInAs(user) as Pages.AdminHomePage;
    }

    [Test]
    public void TestHomePageUrlForAdmin()
    {
      Assert.AreEqual(URL_HOME_PAGE, HomePage.GetUrl());
    }

    [Test]
    public void TestAdminAbilityToGoToUsers()
    {
      Pages.AdminHomePage AdminHomePage = HomePage as Pages.AdminHomePage;
      AdminHomePage.GoToUsers();
      Assert.AreEqual(URL_USERS_PAGE, Browser.Url);
    }

    [Test]
    public void TestAdminLogOut()
    {
      TestCorrectLogOut();
    }
  }
}