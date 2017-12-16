using OpenQA.Selenium;

namespace WordPress
{
  public class EditPostPage
  {
    public IWebDriver Browser { get; set; }

    private By addNewButtonBy = By.XPath("//a[preceding-sibling::h1[@class='wp-heading-inline']]");
    private By deleteButtonBy = By.XPath("//a[@class='submitdelete deletion']");

    public EditPostPage(IWebDriver browser)
    {
      Browser = browser;
    }

    /// <summary>
    /// This method deletes post.
    /// </summary>
    public void DeletePost()
    {
      Browser.FindElement(deleteButtonBy).Click();
    }

    /// <summary>
    /// This method clicks on posts button.
    /// </summary>
    public Pages.NewPostPage PushAddNewButton()
    {
      Browser.FindElement(addNewButtonBy).Click();
      return new Pages.NewPostPage(Browser);
    }
  }
}