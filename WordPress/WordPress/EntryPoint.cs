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
      User user = new Objects.Admin();
      AdminLoginPage loginPage = new AdminLoginPage(browser, user);
      loginPage.OpenLoginPage();
      loginPage.InputUserName();
      loginPage.InputPassword();
      Pages.AdminHomePage homePage = loginPage.PushLogInButton();
      Pages.Admin.NewUserPage newUserPage = homePage.GoToUsers().AddNewUser();
      newUserPage.SetNewUserLogin("newuser");
      newUserPage.SetNewUserEmail("newuser@gmail.com");
      newUserPage.ClickOnPasswordButton();
      newUserPage.SetNewUserPasssword("password");
      newUserPage.AcceptIfPasswordIsWeak();
      newUserPage.GoToUserRoleSelector();
      newUserPage.SetNewUserRole("contributor");
      newUserPage.SubmitNewUserAdding();
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