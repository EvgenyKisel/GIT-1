using NUnit.Framework;

namespace WordPress.Tests.PositiveTests
{
  [TestFixture]
  public class AdminActionsPositiveTests : AdminActionsTests
  {
    private Pages.AdditionNewUserPage AdditionNewUserPage { get; set; }
    private static readonly string newUserLogin = "userfromtest";
    private static readonly string newUserEmail = "test@gmail.com";
    private static readonly string newUserPassword = "testpassword";
    private Role newUserRole = Role.SUBSCRIBER;
    private static readonly string userForDeletion = "userfromtest";

    [Test]
    public void TestAdminAbilityToAddNewUser()
    {
      AdditionNewUserPage = UsersPage.AddNewUser();
      AdditionNewUserPage.SetNewUserLogin(newUserLogin);
      AdditionNewUserPage.SetNewUserEmail(newUserEmail);
      AdditionNewUserPage.ClickOnPasswordButton();
      AdditionNewUserPage.SetNewUserPasssword(newUserPassword);
      AdditionNewUserPage.AcceptIfPasswordIsWeak();
      AdditionNewUserPage.GoToUserRoleSelector();
      AdditionNewUserPage.SetNewUserRole(newUserRole);
      AdditionNewUserPage.SubmitNewUserAdding();
      Assert.AreEqual(true, UsersPage.GetInfirmationWindowMessage().Contains("New user created"));
    }

    [Test]
    public void TestAdminAbilityToDeleteUser()
    {
      UsersPage.DeleteUser(userForDeletion);
      Assert.AreEqual(true, UsersPage.GetInfirmationWindowMessage().Contains("User deleted"));
    }
  }
}