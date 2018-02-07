using NUnit.Framework;

namespace WordPress.Tests.PositiveTests
{
  [TestFixture]
  public class EditorHomePagePositiveTests : HomePageTests
  {
    private static readonly string URL_COMMENTS_PAGE = "http://localhost:8080/wp-admin/edit-comments.php";
    private static readonly string URL_POSTS_PAGE = "http://localhost:8080/wp-admin/edit.php";

    [SetUp]
    public void TestInitialize()
    {
      User user = new User("Editor", "editor", "editor@gmail.com", Role.EDITOR);
      HomePage = LogInAs(user) as Pages.EditorHomePage;
    }

    [Test]
    public void TestHomePageUrlForEditor()
    {
      Assert.AreEqual(URL_HOME_PAGE, HomePage.GetUrl());
    }

    [Test]
    public void TestEditorAbilityToGoToComments()
    {
      Pages.EditorHomePage EditorHomePage = HomePage as Pages.EditorHomePage;
      EditorHomePage.GoToComments();
      Assert.AreEqual(URL_COMMENTS_PAGE, Browser.Url);
    }

    [Test]
    public void TestEditorAbilityToGoToPosts()
    {
      Pages.EditorHomePage EditorHomePage = HomePage as Pages.EditorHomePage;
      EditorHomePage.GoToPosts();
      Assert.AreEqual(URL_POSTS_PAGE, Browser.Url);
    }

    [Test]
    public void TestEditorLogOut()
    {
      TestCorrectLogOut();
    }
  }
}