﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WordPress.Tests.PositiveTests
{
  [TestClass]
  public class EditorHomePageTests
  {
    private static readonly string URL_HOME_PAGE = "http://localhost:8080/wp-admin/";
    private IWebDriver Browser { get; set; }
    private Pages.EditorHomePage HomePage { get; set; }

    [TestInitialize]
    public void TestInitialize()
    {
      Logger.GetLoggerInstance();
      Browser = new ChromeDriver();
      Browser.Manage().Window.Maximize();
      Browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
      User user = new Objects.Author("Editor", "editor", "editor@gmail.com");
      EditorLoginPage loginPage = new EditorLoginPage(Browser, user);
      loginPage.OpenLoginPage();
      loginPage.InputUserName();
      loginPage.InputPassword();
      HomePage = loginPage.PushLogInButton();
    }

    [TestCleanup]
    public void TestCleanup()
    {
      Browser.Close();
    }

    [TestMethod]
    public void TestCorrectURLofEditorHomePage()
    {
      Assert.AreEqual(URL_HOME_PAGE, HomePage.GetUrl());
      Logger.PrintLogInformation("Correct url of editor+ home page.");
    }
  }
}