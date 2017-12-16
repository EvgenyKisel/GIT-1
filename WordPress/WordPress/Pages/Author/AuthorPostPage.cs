using OpenQA.Selenium;

namespace WordPress.Pages
{
  public class AuthorPostPage
  {
    private By titleBy = By.CssSelector("#title");
    private By contentBy = By.XPath("//body[@id='tinymce']/p");
    private By publishButtonBy = By.XPath("//input[@type='publish']");
    private By deleteButtonBy = By.XPath("//a[@class='submitdelete deletion']");

    public IWebDriver Browser { get; set; }

    public AuthorPostPage(IWebDriver browser)
    {
      Browser = browser;
    }

    /// <summary>
    /// This method sets post title.
    /// </summary>
    public void SetPostTitle()
    {
      Browser.FindElement(titleBy).SendKeys("new post");
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

    /// <summary>
    /// This method deletes post.
    /// </summary>
    public void DeletePost()
    {
      Browser.FindElement(deleteButtonBy).Click();
    }
  }
}