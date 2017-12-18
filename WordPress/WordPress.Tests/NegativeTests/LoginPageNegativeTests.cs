using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace WordPress.Tests
{
  [TestFixture]
  public class LoginPageNegativeTests
  {
    private static readonly string URL_LOG_PAGE = "http://localhost:8080/wp-login.php";
    private IWebDriver Browser { get; set; }
    private Pages.LoginPage LoginPage { get; set; }

    private static readonly User[] sourceListWithInvalidUsers =
    {
       new User("admin", "passwo", "evgeny@gmail.com", Role.ADMINISTRATOR),
       new User("login", "password", "evgeny@gmail.com", Role.ADMINISTRATOR),
       new User("Author", "rfe", "author@gmail.com", Role.AUTHOR),
       new User("Editor", "epam", "editor@gmail.com", Role.EDITOR),
       new User("Contributor", "password", "contributor@gmail.com", Role.CONTRIBUTOR),
       new User("Subscriber", "password", "subscriber@gmail.com", Role.SUBSCRIBER)
    };

    [SetUp]
    public void Initialize()
    {
      Browser = new ChromeDriver();
      Browser.Manage().Window.Maximize();
      Browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
    }

    [TearDown]
    public void CleanUp()
    {
      Browser.Close();
    }

    /// <summary>
    /// This method inputs user info on the site.
    /// </summary>
    /// <param name="user"> User </param>
    private void LogInAs(User user)
    {
      LoginPage = new Pages.LoginPage(Browser, user);
      LoginPage.OpenLoginPage();
      LoginPage.InputUserName();
      LoginPage.InputPassword();
      LoginPage.PushLogInButton();
    }

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