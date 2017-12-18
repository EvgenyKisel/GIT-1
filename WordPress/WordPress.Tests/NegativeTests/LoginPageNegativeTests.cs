using NUnit.Framework;

namespace WordPress.Tests
{
  public class LoginPageNegativeTests : BasePageTests
  {
    private static readonly string URL_LOG_PAGE = "http://localhost:8080/wp-login.php";

    private static readonly User[] sourceListWithInvalidUsers =
    {
       new User("admin", "passwo", "evgeny@gmail.com", Role.ADMINISTRATOR),
       new User("login", "password", "evgeny@gmail.com", Role.ADMINISTRATOR),
       new User("Author", "rfe", "author@gmail.com", Role.AUTHOR),
       new User("Editor", "epam", "editor@gmail.com", Role.EDITOR),
       new User("Contributor", "password", "contributor@gmail.com", Role.CONTRIBUTOR),
       new User("Subscriber", "password", "subscriber@gmail.com", Role.SUBSCRIBER)
    };

    [Test, TestCaseSource("sourceListWithInvalidUsers")]
    public void TestLogIn_uncorrectUserLogin_errorExpected(User sourceListWithInvalidUsers)
    {
      User user = sourceListWithInvalidUsers;
      LogInAs(user);
      Assert.AreEqual(true, LoginPage.CatchLoginErrorIfPresence().Contains("ERROR"));
      Assert.AreEqual(URL_LOG_PAGE, Browser.Url);
    }
  }
}