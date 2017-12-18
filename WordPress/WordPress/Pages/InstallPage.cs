using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.ObjectModel;

namespace WordPress.Pages
{
  /// <summary>
  /// This is class for install page.
  /// </summary>
  class InstallPage
  {
    private static readonly string URL_INSTALL_PAGE = "http://localhost:8080/wp-admin/install.php";

    private By siteTitleBy = By.XPath("//input[@name='weblog_title']");
    private By userNameBy = By.XPath("//input[@name ='user_name']");
    private By passwordBy = By.CssSelector("[type=password]");
    private By emailBy = By.XPath("//input[contains(@name,'email')]");
    private By privacyCheckBoxBy = By.XPath("//input[@type='checkbox']");
    private By installButtonBy = By.XPath("//input[@type='submit']");

    public IWebDriver Browser { get; private set; }
    public IWebElement WebElement { get; private set; }
    public User CurrentUser { get; private set; }

    /// <summary>
    /// This is constructor for install page.
    /// </summary>
    /// <param name="browser"> Driver, with wich works </param>
    public InstallPage(IWebDriver browser, User user)
    {
      PageFactory.InitElements(browser, this);
      Browser = browser;
      CurrentUser = user;
    }

    /// <summary>
    /// This method opens install page.
    /// </summary>
    public void OpenInstallPage()
    {
      Browser.Navigate().GoToUrl(URL_INSTALL_PAGE);
    }

    /// <summary>
    /// This method finds position for site title and inputs it.
    /// </summary>
    public void InputSiteTitle(string title)
    {
      Browser.FindElement(siteTitleBy).SendKeys(title);
    }

    /// <summary>
    /// This method finds position for user name and inputs it.
    /// </summary>
    public void InputUserName()
    {
      WebElement = Browser.FindElement(userNameBy);
      WebElement.Clear();
      WebElement.SendKeys(CurrentUser.UserName);
    }

    /// <summary>
    /// This method finds two positions for passwords and inputs them.
    /// </summary>
    public void InputPasswords()
    {
      ReadOnlyCollection<IWebElement> passwordsPathes = Browser.FindElements(passwordBy);
      foreach (IWebElement passwordPath in passwordsPathes)
      {
        passwordPath.SendKeys(CurrentUser.Password);
      }
    }

    /// <summary>
    /// This method finds position for email and inputs it.
    /// </summary>
    public void InputEmail()
    {
      Browser.FindElement(emailBy).SendKeys(CurrentUser.Email);
    }

    /// <summary>
    /// This method clicks on privacy check box.
    /// </summary>
    public void ClickOnAcceptPrivacyCheckBox()
    {
      Browser.FindElement(privacyCheckBoxBy).Click();
    }

    /// <summary>
    /// This method push submit button.
    /// </summary>
    public void PushSubmitButton()
    {
      Browser.FindElement(installButtonBy).Click();
    }

    /// <summary>
    /// This method gets url of the page.
    /// </summary>
    /// <returns> Url of the page </returns>
    public string GetUrl()
    {
      return Browser.Url;
    }
  }
}