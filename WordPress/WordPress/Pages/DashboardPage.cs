using OpenQA.Selenium;
using System;

namespace WordPress.Pages
{
  /// <summary>
  /// This is class for dashboard page.
  /// </summary>
  public class DashboardPage : BasePage
  {
    private string pathToPost = "//div[@id='published-posts']//li[1]/a[contains(text(), '{0}')]";

    /// <summary>
    /// This is constructor for DashboardPage.
    /// </summary>
    /// <param name="browser"> Driver, with wich works </param>
    public DashboardPage(IWebDriver browser) : base(browser) { }

    /// <summary>
    /// This method goes to post.
    /// </summary>
    public CommonViewPage GoToPost(string postName)
    {
      By postBy = By.XPath(String.Format(pathToPost, postName));
      Browser.FindElement(postBy).Click();
      return new CommonViewPage(Browser);
    }
  }
}