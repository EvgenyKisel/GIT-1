using OpenQA.Selenium;

namespace WordPress.Pages
{
  public class NewPostPage
  {
    private By titleBy = By.CssSelector("#title");
    private By contentBy = By.XPath("//body[@data-id='content']");
    private By publishButtonBy = By.XPath("//input[@type='publish']");

    public IWebDriver Browser { get; set; }

    public NewPostPage(IWebDriver browser)
    {
      Browser = browser;
    }

    /// <summary>
    /// This method sets post title.
    /// </summary>
    public void SetPostTitle()
    {
      Browser.FindElement(titleBy).SendKeys("title");
    }

    /// <summary>
    /// This method inputs post content.
    /// </summary>
    public void InputPostContent()
    {
      Browser.FindElement(contentBy).SendKeys("content");
    }

    /// <summary>
    /// This method clicks on publish button.
    /// </summary>
    public void PushPublishButton()
    {
      Browser.FindElement(publishButtonBy).Click();
    }
  }
}