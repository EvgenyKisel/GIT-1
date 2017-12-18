using NUnit.Framework;

namespace WordPress.Tests.PositiveTests
{
  [TestFixture]
  public class ContributorHomePagePositiveTests : HomePageTests
  {
    [SetUp]
    public void TestInitialize()
    {
      User user = new User("Contributor", "contributor", "contributor@gmail.com", Role.CONTRIBUTOR);
      HomePage = LogInAs(user) as Pages.ContributorHomePage;
    }

    [Test]
    public void TestHomePageUrlForContributor()
    {
      Assert.AreEqual(URL_HOME_PAGE, HomePage.GetUrl());
    }

    [Test]
    public void TestContributorLogOut()
    {
      TestCorrectLogOut();
    }
  }
}