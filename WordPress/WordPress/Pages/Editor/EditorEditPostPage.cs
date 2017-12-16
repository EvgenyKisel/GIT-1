using OpenQA.Selenium;

namespace WordPress
{
  public class EditorEditPostPage
  {
    public IWebDriver Browser { get; set; }

    private By addNewButtonBy = By.XPath("//a[preceding-sibling::h1[@class='wp-heading-inline']]");
    private By postButtonBy = By.XPath("//tbody[@id='the-list']/tr[1]//a[@class='row-title']");
    private By deletionMessageBy = By.XPath("//div[@id='message']/p");

    public EditorEditPostPage(IWebDriver browser)
    {
      Browser = browser;
    }

    /// <summary>
    /// This method clicks on posts button.
    /// </summary>
    public Pages.EditorPostPage GoToPost()
    {
      Browser.FindElement(postButtonBy).Click();
      return new Pages.EditorPostPage(Browser);
    }

    /// <summary>
    /// This method clicks on submit post button.
    /// </summary>
    public Pages.EditorPostPage PushAddNewButton()
    {
      Browser.FindElement(addNewButtonBy).Click();
      return new Pages.EditorPostPage(Browser);
    }

    /// <summary>
    /// This method gets deletion information.
    /// </summary>
    /// <returns> Deletion message</returns>
    public string GetDeletionInfirmation()
    {
      return Browser.FindElement(deletionMessageBy).Text;
    }
  }
}