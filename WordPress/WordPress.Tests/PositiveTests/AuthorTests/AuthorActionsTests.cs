using NUnit.Framework;

namespace WordPress.Tests.PositiveTests
{
  [TestFixture]
  public abstract class AuthorActionsTests : BasePageTests
  {
    protected Pages.AuthorHomePage HomePage { get; set; }
    protected Pages.EditPostPage EditPostPage { get; set; }
    protected static readonly string URL_USERS_PAGE = "http://localhost:8080/wp-admin/users.php";

    [SetUp]
    public void TestInitialize()
    {
      User user = new User("Author", "author", "author@gmail.com", Role.AUTHOR);
      HomePage = LogInAs(user) as Pages.AuthorHomePage;
      EditPostPage = HomePage.GoToPosts();
    }   
  }
}