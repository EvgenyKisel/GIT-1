using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace WordPress.Pages
{
  /// <summary>
  /// This is class for edit post page.
  /// </summary>
  public class EditPostPage : BasePage
  {
    private By addNewButtonBy = By.XPath("//a[preceding-sibling::h1[@class='wp-heading-inline']]");
    private string pathToPost = "//td[@data-colname='Title']//a[contains(text(), '{0}')]";
    private By messageBy = By.XPath("//div[@id='message']/p");
    private string pathToDeletePostButton = "//a[contains(text(), '{0}')]/parent::strong/following-sibling::div[@class='row-actions']//span[@class='trash']/a";
    private string pathToEditPostButton = "//a[contains(text(), '{0}')]/parent::strong/following-sibling::div[@class='row-actions']//span[@class='edit']/a";
    private string pathToViewPostButton = "//a[contains(text(), '{0}')]/parent::strong/following-sibling::div[@class='row-actions']//span[@class='view']/a";

    /// <summary>
    /// This is constructor for EditPostPage.
    /// </summary>
    /// <param name="browser"></param>
    public EditPostPage(IWebDriver browser) : base(browser) { }

    /// <summary>
    /// This method clicks on submit post button.
    /// </summary>
    public PostPage PushAddNewButton()
    {
      Browser.FindElement(addNewButtonBy).Click();
      return new PostPage(Browser);
    }

    /// <summary>
    /// This method deletes post.
    /// </summary>
    /// <param name="postNameForDeletion"> Post name </param>
    public void DeletePost(string postNameForDeletion)
    {
      new Actions(Browser).MoveToElement(Browser.FindElement(By.XPath(String.Format(pathToPost, postNameForDeletion)))).Perform();
      By deleteButtonBy = By.XPath(String.Format(pathToDeletePostButton, postNameForDeletion));
      new WebDriverWait(Browser, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(deleteButtonBy));
      Browser.FindElement(deleteButtonBy).Click();
    }

    /// <summary>
    /// This method edits post.
    /// </summary>
    /// <param name="postNameForEdition"> Post name </param>
    /// <returns> Post page </returns>
    public PostPage EditPost(string postNameForEdition)
    {
      new Actions(Browser).MoveToElement(Browser.FindElement(By.XPath(String.Format(pathToPost, postNameForEdition)))).Perform();
      By editButtonBy = By.XPath(String.Format(pathToEditPostButton, postNameForEdition));
      new WebDriverWait(Browser, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(editButtonBy));
      Browser.FindElement(editButtonBy).Click();
      return new PostPage(Browser);
    }

    /// <summary>
    /// This method edits post.
    /// </summary>
    /// <param name="postNameForView"> Post name </param>
    /// <returns> Post page </returns>
    public CommonViewPage ViewPost(string postNameForView)
    {
      new Actions(Browser).MoveToElement(Browser.FindElement(By.XPath(String.Format(pathToPost, postNameForView)))).Perform();
      By viewButtonBy = By.XPath(String.Format(pathToEditPostButton, postNameForView));
      new WebDriverWait(Browser, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(viewButtonBy));
      Browser.FindElement(viewButtonBy).Click();
      return new CommonViewPage(Browser);
    }

    /// <summary>
    /// This method gets action information.
    /// </summary>
    /// <returns> Message </returns>
    public string GetInfirmationWindowMessage()
    {
      return Browser.FindElement(messageBy).Text;
    }
  }
}