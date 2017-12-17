﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WordPress.Pages
{
  public class AuthorHomePage : HomePage
  {
    private By postsBy = By.XPath("//li[@class='post-count']/a");
    
    /// <summary>
    /// This is constructor for AuthorHomePage page.
    /// </summary>
    /// <param name="browser"> Driver, with wich works </param>
    public AuthorHomePage(IWebDriver browser)
    {
      PageFactory.InitElements(browser, this);
      Browser = browser;
    }

    /// <summary>
    /// This method clicks on posts button.
    /// </summary>
    public EditPostPage PushPostsButton()
    {
      Browser.FindElement(postsBy).Click();
      return new EditPostPage(Browser);
    }
  }
}