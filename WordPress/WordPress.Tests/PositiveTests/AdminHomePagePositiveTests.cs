using NUnit.Framework;

namespace WordPress.Tests.PositiveTests
{
  [TestFixture]
  public class AdminHomePagePositiveTests : HomePageTests
  {
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
    public void TestAdminLogOut()
    {
      TestCorrectLogOut();
    }
  }
}