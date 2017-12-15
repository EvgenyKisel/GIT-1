using OpenQA.Selenium;
using System;

namespace WordPress.Pages
{
  class NewPostPage
  {
    private static readonly string URL_NEWPOST_PAGE = "http://localhost:8080/wp-admin/post-new.php";

    private By titleBy = By.CssSelector("#title");
    private By contentBy = By.XPath("//body[@data-id='content']");
    private By submitButtonBy = By.XPath("//input[@type='submit']");
  }
}