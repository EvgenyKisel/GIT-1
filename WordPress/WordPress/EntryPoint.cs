using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace WordPress
{
  /// <summary>
  /// This is entry point to program.
  /// </summary>
  class EntryPoint
  {
    static void Main(string[] args)
    {
      IWebDriver browser = new ChromeDriver();
      browser.Manage().Window.Maximize();
      browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
      User user = new Objects.Author("Author", "author", "author@gmail.com");
      AuthorLoginPage loginPage = new AuthorLoginPage(browser, user);
      loginPage.OpenLoginPage();
      loginPage.InputUserName();
      loginPage.InputPassword();
      Pages.AuthorHomePage homePage = loginPage.PushLogInButton();
      AuthorEditPostPage editPostPage = homePage.PushPostsButton();
     // Pages.AuthorPostPage postPage = editPostPage.GoToPost();
     // postPage.DeletePost();
    //  Console.WriteLine(editPostPage.GetDeletionInfirmation());
     // newPostPage.SetPostTitle();
     // newPostPage.InputPostContent();
     // newPostPage.PushPublishButton();
      homePage.GoToProfileBar();
      homePage.LogOut();
    }
  }
}