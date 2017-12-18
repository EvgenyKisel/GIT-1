using OpenQA.Selenium;

namespace WordPress.Pages
{
  /// <summary>
  /// This is class for common view page.
  /// </summary>
  public class CommonViewPage : BasePage
  {
    private By commentBy = By.XPath("//textarea[@id='comment']");
    private By submitCommentButtonBy = By.XPath("//input[@id='submit']");
    private By messageBy = By.ClassName("comment-awaiting-moderation");

    /// <summary>
    /// This is constructor for CommonViewPage.
    /// </summary>
    /// <param name="browser"> Driver, with wich works </param>
    public CommonViewPage(IWebDriver browser) : base(browser) { }

    /// <summary>
    /// This method adds comment.
    /// </summary>
    public void AddComment(string comment)
    {
      Browser.FindElement(commentBy).SendKeys(comment);
    }

    /// <summary>
    /// This method potsts comment.
    /// </summary>
    public void PostComment()
    {
      Browser.FindElement(submitCommentButtonBy).Click();
    }

    /// <summary>
    /// This method gets infrormation about some actions on the page.
    /// </summary>
    /// <returns> Message </returns>
    public string GetInfirmationWindowMessage()
    {
      return Browser.FindElement(messageBy).Text;
    }
  }
}