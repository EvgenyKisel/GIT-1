﻿using OpenQA.Selenium;
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
      User user = new User("admin", "passwor", "evgeny@gmail.com", Role.ADMINISTRATOR);
      Pages.LoginPage loginPage = new Pages.LoginPage(browser, user);
      loginPage.OpenLoginPage();
      loginPage.InputUserName();
      loginPage.InputPassword();
      Pages.AdminHomePage homePage = (Pages.AdminHomePage)loginPage.PushLogInButton();
      Console.WriteLine(loginPage.CatchLoginErrorIfPresence());
   /*   Pages.UsersPage usersPage = homePage.GoToUsers();
      usersPage.DeleteUser("newuser");*/
     /* Pages.AdditionNewUserPage newUserPage = homePage.GoToUsers().AddNewUser();
      newUserPage.SetNewUserLogin("newuser4");
      newUserPage.SetNewUserEmail("newuser4@gmail.com");
      newUserPage.ClickOnPasswordButton();
      newUserPage.SetNewUserPasssword("password");
      newUserPage.AcceptIfPasswordIsWeak();
      newUserPage.GoToUserRoleSelector();
      newUserPage.SetNewUserRole(Role.EDITOR);
      newUserPage.SubmitNewUserAdding();*/
     // homePage.GoToProfileBar();
     // homePage.LogOut();
    }
  }
}