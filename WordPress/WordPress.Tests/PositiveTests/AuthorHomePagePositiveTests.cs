using NUnit.Framework;

namespace WordPress.Tests.PositiveTests
{
  [TestFixture]
  public class AuthorHomePagePositiveTests : HomePageTests
  {
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
  }
}