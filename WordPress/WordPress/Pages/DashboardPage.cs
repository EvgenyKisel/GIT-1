using OpenQA.Selenium;

namespace WordPress.Pages.Subscriber
{
  public class DashboardPage
  {
    public IWebDriver Browser { get; set; }

    private By postButtonBy = By.XPath("//div[@id='published-posts']//li[1]/a");

    public DashboardPage(IWebDriver browser)
    {
      Browser = browser;
    }
    
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