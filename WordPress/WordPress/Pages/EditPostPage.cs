using OpenQA.Selenium;

namespace WordPress.Pages
{
  /// <summary>
  /// This is class for edit post page.
  /// </summary>
  public class EditPostPage : BasePage
  {
    private By addNewButtonBy = By.XPath("//a[preceding-sibling::h1[@class='wp-heading-inline']]");
    private By postButtonBy = By.XPath("//tbody[@id='the-list']/tr[1]//a[@class='row-title']");
    private By messageBy = By.XPath("//div[@id='message']/p");

    /// <summary>
    /// This is constructor for EditPostPage.
    /// </summary>
    /// <param name="browser"></param>
    public EditPostPage(IWebDriver browser) : base(browser) { }

    /// <summary>
    /// This method clicks on posts button.
    /// </summary>
    public PostPage GoToPost()
    {
      Browser.FindElement(postButtonBy).Click();
      return new PostPage(Browser);
    }

    /// <summary>
    /// This method clicks on submit post button.
    /// </summary>
    public PostPage PushAddNewButton()
    {
      Browser.FindElement(addNewButtonBy).Click();
      return new PostPage(Browser);
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