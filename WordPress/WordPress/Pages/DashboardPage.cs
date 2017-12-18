using OpenQA.Selenium;

namespace WordPress.Pages
{
  /// <summary>
  /// This is class for dashboard page.
  /// </summary>
  public class DashboardPage : BasePage
  {
    private By postButtonBy = By.XPath("//div[@id='published-posts']//li[1]/a");

    /// <summary>
    /// This is constructor for DashboardPage.
    /// </summary>
    /// <param name="browser"> Driver, with wich works </param>
    public DashboardPage(IWebDriver browser) : base(browser) { }

    /// <summary>
    /// This method goes to post.
    /// </summary>
    public CommonViewPage GoToPost()
    {
      Browser.FindElement(postButtonBy).Click();
      return new CommonViewPage(Browser);
    }
  }
}