using OpenQA.Selenium;

namespace WordPress.Pages
{
  /// <summary>
  /// This is class for author home page.
  /// </summary>
  public class AuthorHomePage : HomePage
  {
    private By postsBy = By.XPath("//li[@class='post-count']/a");

    /// <summary>
    /// This is constructor for AuthorHomePage page.
    /// </summary>
    /// <param name="browser"> Driver, with wich works </param>
    public AuthorHomePage(IWebDriver browser) : base(browser) { }

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