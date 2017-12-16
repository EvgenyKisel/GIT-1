using OpenQA.Selenium;

namespace WordPress.Pages
{
  public class CommonViewPage
  {
    public IWebDriver Browser { get; set; }
    
    private By commentBy = By.XPath("//textarea[@id='comment']");
    private By submitCommentButtonBy = By.XPath("//input[@id='submit']");

    public CommonViewPage(IWebDriver browser)
    {
      Browser = browser;
    }

    /// <summary>
    /// This method adds comment.
    /// </summary>
    public void AddComment()
    {
      Browser.FindElement(commentBy).SendKeys("comment");
    }

    /// <summary>
    /// This method potsts comment.
    /// </summary>
    public void PostComment()
    {
      Browser.FindElement(submitCommentButtonBy).Click();
    }

    /// <summary>
    /// This method gets infrormation about inputted comment.
    /// </summary>
    /// <returns> conformation information </returns>
    public string GetMessageAboutPostedComment()
    {
      return Browser.FindElement(By.ClassName("comment-awaiting-moderation")).Text;
    }
  }
}