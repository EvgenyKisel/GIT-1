using OpenQA.Selenium;

namespace WordPress.Pages
{
  /// <summary>
  /// This is class for contributor home page.
  /// </summary>
  public class ContributorHomePage : HomePage
  {
    private By postsBy = By.XPath("//div[contains(text(), 'Posts')]");

    /// <summary>
    /// This is constructor for ContributorHomePage.
    /// </summary>
    /// <param name="browser"> Driver, with wich works </param>
    public ContributorHomePage(IWebDriver browser) : base(browser) { }

    /// <summary>
    /// This method clicks on posts button.
    /// </summary>
    public EditPostPage GoToPosts()
    {
      Browser.FindElement(postsBy).Click();
      return new EditPostPage(Browser);
    }
  }
}