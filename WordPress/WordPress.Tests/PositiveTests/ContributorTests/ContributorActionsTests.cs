using NUnit.Framework;

namespace WordPress.Tests.PositiveTests
{
  [TestFixture]
  public abstract class ContributorActionsTests : BasePageTests
  {
    protected Pages.ContributorHomePage HomePage { get; set; }
    protected Pages.EditPostPage EditPostPage { get; set; }

    [SetUp]
    public void TestInitialize()
    {
      User user = new User("Contributor", "contributor", "contributor@gmail.com", Role.CONTRIBUTOR);
      HomePage = LogInAs(user) as Pages.ContributorHomePage;
      EditPostPage = HomePage.GoToPosts();
    }   
  }
}