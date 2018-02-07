using NUnit.Framework;

namespace WordPress.Tests.PositiveTests
{
  [TestFixture]
  public class ContributorHomePagePositiveTests : HomePageTests
  {
    protected static readonly string URL_POSTS_PAGE = "http://localhost:8080/wp-admin/edit.php";

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
    public void TestContributorAbilityToGoToPosts()
    {
      Pages.ContributorHomePage ContributorHomePage = HomePage as Pages.ContributorHomePage;
      ContributorHomePage.GoToPosts();
      Assert.AreEqual(URL_POSTS_PAGE, Browser.Url);
    }

    [Test]
    public void TestContributorLogOut()
    {
      TestCorrectLogOut();
    }
  }
}