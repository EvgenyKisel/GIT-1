using NUnit.Framework;

namespace WordPress.Tests.PositiveTests
{
  [TestFixture]
  public class AuthorHomePagePositiveTests : HomePageTests
  {
    protected static readonly string URL_POSTS_PAGE = "http://localhost:8080/wp-admin/edit.php?post_type=post";

    [SetUp]
    public void TestInitialize()
    {
      User user = new User("Author", "author", "author@gmail.com", Role.AUTHOR);
      HomePage = LogInAs(user) as Pages.AuthorHomePage;
    }

    [Test]
    public void TestHomePageUrlForAuthor()
    {
      Assert.AreEqual(URL_HOME_PAGE, HomePage.GetUrl());
    }

    [Test]
    public void TestAuthorLogOut()
    {
      TestCorrectLogOut();
    }

    [Test]
    public void TestAuthorAbilityGoToPosts()
    {
      Pages.AuthorHomePage AuthorHomePage = HomePage as Pages.AuthorHomePage;
      AuthorHomePage.GoToPosts();
      Assert.AreEqual(URL_POSTS_PAGE, Browser.Url);
    }
  }
}