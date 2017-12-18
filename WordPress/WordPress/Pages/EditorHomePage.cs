using OpenQA.Selenium;

namespace WordPress.Pages
{
  /// <summary>
  /// This is class for editor home page.
  /// </summary>
  public class EditorHomePage : HomePage
  {
    private By postsBy = By.XPath("//div[contains(text(), 'Posts')]");
    private By commentsBy = By.XPath("//div[contains(text(), 'Comments')]");

    /// <summary>
    /// This is constructor for editor home page.
    /// </summary>
    /// <param name="browser"> Driver, with wich works </param>
    public EditorHomePage(IWebDriver browser) : base(browser) { }

    /// <summary>
    /// This method clicks on posts button.
    /// </summary>
    public EditPostPage PushPostsButton()
    {
      Browser.FindElement(postsBy).Click();
      return new EditPostPage(Browser);
    }

    /// <summary>
    /// This method clicks on comments button.
    /// </summary>
    public CommentsPage PushCommentsButton()
    {
      Browser.FindElement(commentsBy).Click();
      return new CommentsPage(Browser);
    }
  }
}