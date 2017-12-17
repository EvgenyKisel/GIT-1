using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace WordPress.Pages
{
  public class AuthorHomePage
  {
    private By postsBy = By.XPath("//li[@class='post-count']/a");
    private By profileBarBy = By.XPath("//*[@id='wp-admin-bar-my-account']/a");
    public By logOutBy = By.XPath("//*[@id='wp-admin-bar-logout']/a[contains(text(),'Log Out')]");

    public IWebDriver Browser { get; set; }

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
    /// This method gets url of the page.
    /// </summary>
    /// <returns> Url of the page </returns>
    public string GetUrl()
    {
      return Browser.Url;
    }

    /// <summary>
    /// This method clicks on posts button.
    /// </summary>
    public EditPostPage PushPostsButton()
    {
      Browser.FindElement(postsBy).Click();
      return new EditPostPage(Browser);
    }

    /// <summary>
    /// This method clicks on profile bar.
    /// </summary>
    public void GoToProfileBar()
    {
      Browser.FindElement(profileBarBy).Click();
    }

    /// <summary>
    /// This method log out drom the profile.
    /// </summary>
    public void LogOut()
    {
      new WebDriverWait(Browser, TimeSpan.FromSeconds(5)).Until(ExpectedConditions.ElementExists(logOutBy));
      Browser.FindElement(logOutBy).Click();
    }
  }
}