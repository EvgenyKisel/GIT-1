using OpenQA.Selenium;
using System;

namespace WordPress.Pages
{
  /// <summary>
  /// This is class for common view page.
  /// </summary>
  public class CommonViewPage : BasePage
  {
    private By commentBy = By.XPath("//textarea[@id='comment']");
    private By postCommentButtonBy = By.XPath("//input[@id='submit']");
    private By messageBy = By.ClassName("comment-awaiting-moderation");
    private static readonly string pathToSubscriberComment = "//section[@class='comment-content comment']/p[contains(text(), '{0}')]";

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
    /// This method posts comment.
    /// </summary>
    public void ClickPostCommentButton()
    {
      Browser.FindElement(postCommentButtonBy).Click();
    }

    /// <summary>
    /// This method searches subscriber comment.
    /// </summary>
    /// <param name="comment"> Comment content </param>
    /// <returns> True, if comment exists, and false, if doesn't </returns>
    public bool FindSubscriberComment(string comment)
    {
      bool result = false;
      if(Browser.FindElement(By.XPath(String.Format(pathToSubscriberComment, comment))).Displayed)
      {
        result = true;
      }
      return result;
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