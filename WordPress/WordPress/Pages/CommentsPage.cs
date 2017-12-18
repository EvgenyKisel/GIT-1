using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace WordPress.Pages
{
  public class CommentsPage : BasePage
  {
    private string pathToUserComment = "//td[@class='author column-author']/strong[contains(text(), '{0}')]";
    private string pathToUnapprovedUserComment = "//tr[contains(@class, 'unapproved')]//td[@class='author column-author']/strong[contains(text(), '{0}')]";
    private string pathToApproveButton = "//tr[contains(@class, 'unapproved')]//td[@class='author column-author']/strong[contains(text(), '{0}')]/parent::td/following-sibling::td//span[@class='approve']";
    private string pathToUnapproveButton = "//tr[contains(@class, ' approved')]//td[@class='author column-author']/strong[contains(text(), '{0}')]/parent::td/following-sibling::td//span[@class='unapprove']";
    private string pathToDeleteButton = "//td[@class='author column-author']/strong[contains(text(), '{0}')]/parent::td/following-sibling::td//span[@class='trash']";
    private By deletedMessageBy = By.XPath("//tbody[@id='the-comment-list']//div[@class='trash-undo-inside']");

    /// <summary>
    /// This is constructor for EditPostPage.
    /// </summary>
    /// <param name="browser"></param>
    public CommentsPage(IWebDriver browser) : base(browser) { }

    /// <summary>
    /// This method approves comment.
    /// </summary>
    public void ApproveUserPostComment(string userName)
    {
      new Actions(Browser).MoveToElement(Browser.FindElement(By.XPath(String.Format(pathToUnapprovedUserComment, userName)))).Perform();
      By approveButtonBy = By.XPath(String.Format(pathToApproveButton, userName));
      new WebDriverWait(Browser, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(approveButtonBy));
      Browser.FindElement(approveButtonBy).Click();
    }

    /// <summary>
    /// This method unapproves comment.
    /// </summary>
    public void UnapproveUserPostComment(string userName)
    {
      new Actions(Browser).MoveToElement(Browser.FindElement(By.XPath(String.Format(pathToUserComment, userName)))).Perform();
      By unapproveButtonBy = By.XPath(String.Format(pathToUnapproveButton, userName));
      new WebDriverWait(Browser, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(unapproveButtonBy));
      Browser.FindElement(unapproveButtonBy).Click();
    }

    /// <summary>
    /// This method unapproves comment.
    /// </summary>
    public void DeleteUserPostComment(string userName)
    {
      new Actions(Browser).MoveToElement(Browser.FindElement(By.XPath(String.Format(pathToUserComment, userName)))).Perform();
      By deleteButtonBy = By.XPath(String.Format(pathToDeleteButton, userName));
      new WebDriverWait(Browser, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(deleteButtonBy));
      Browser.FindElement(deleteButtonBy).Click();
    }

    /// <summary>
    /// This method gets approved post deletion information.
    /// </summary>
    public string GetDeletionApprovedInformation()
    {
      return Browser.FindElement(deletedMessageBy).Text;
    }
  }
}