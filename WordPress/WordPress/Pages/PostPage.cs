using OpenQA.Selenium;

namespace WordPress.Pages
{
  /// <summary>
  /// This is class for post page.
  /// </summary>
  public class PostPage
  {
    private By titleBy = By.CssSelector("#title");
    private By contentBy = By.XPath("//body[@id='tinymce']/p");
    private By publishButtonBy = By.XPath("//input[@type='publish']");
    private By deleteButtonBy = By.XPath("//a[@class='submitdelete deletion']");

    public IWebDriver Browser { get; set; }

    /// <summary>
    /// This is constructor for post page.
    /// </summary>
    /// <param name="browser"> Driver, with wich works </param>
    public PostPage(IWebDriver browser)
    {
      Browser = browser;
    }

    /// <summary>
    /// This method sets post title.
    /// </summary>
    /// <param name="postTitle"> Post title </param>
    public void SetPostTitle(string postTitle)
    {
      Browser.FindElement(titleBy).SendKeys(postTitle);
    }

    /// <summary>
    /// This method inputs post content.
    /// </summary>
    /// <param name="postContent"> Post content </param>
    public void InputPostContent(string postContent)
    {
      Browser.FindElement(contentBy).SendKeys(postContent);
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