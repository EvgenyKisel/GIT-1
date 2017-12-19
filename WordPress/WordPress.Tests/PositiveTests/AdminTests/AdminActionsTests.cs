using NUnit.Framework;

namespace WordPress.Tests.PositiveTests
{
  [TestFixture]
  public abstract class AdminActionsTests : BasePageTests
  {
    protected Pages.AdminHomePage HomePage { get; set; }
    protected Pages.UsersPage UsersPage { get; set; }
    protected static readonly string URL_USERS_PAGE = "http://localhost:8080/wp-admin/users.php";

    [SetUp]
    public void TestInitialize()
    {
      User user = new User("admin", "password", "evgeny@gmail.com", Role.ADMINISTRATOR);
      HomePage = LogInAs(user) as Pages.AdminHomePage;
      UsersPage = HomePage.GoToUsers();
    }   
  }
}