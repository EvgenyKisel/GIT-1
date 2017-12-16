using OpenQA.Selenium;

namespace WordPress
{
  public class EditPostPage
  {
    public IWebDriver Browser { get; set; }

    private By addNewButtonBy = By.XPath("//a[preceding-sibling::h1[@class='wp-heading-inline']]");
    private By postButtonBy = By.XPath("//tbody[@id='the-list']/tr[1]//a[@class='row-title']");
    private By messageBy = By.XPath("//div[@id='message']/p");

    public EditPostPage(IWebDriver browser)
    {
      Browser = browser;
    }

    /// <summary>
    /// This method clicks on posts button.
    /// </summary>
    public Pages.PostPage GoToPost()
    {
      Browser.FindElement(postButtonBy).Click();
      return new Pages.PostPage(Browser);
    }

    /// <summary>
    /// This method clicks on submit post button.
    /// </summary>
    public Pages.PostPage PushAddNewButton()
    {
      Browser.FindElement(addNewButtonBy).Click();
      return new Pages.PostPage(Browser);
    }

    /// <summary>
    /// This method gets action information.
    /// </summary>
    /// <returns> Message </returns>
    public string GetInfirmation()
    {
      return Browser.FindElement(messageBy).Text;
    }
  }
}