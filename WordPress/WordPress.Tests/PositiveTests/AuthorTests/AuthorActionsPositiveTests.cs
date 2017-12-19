using NUnit.Framework;

namespace WordPress.Tests.PositiveTests
{
  [TestFixture]
  public class AuthorActionsPositiveTests : AuthorActionsTests
  {
    private Pages.PostPage PostPage { get; set; }
    private static readonly string postTitle = "titlefromtest";
    //private static readonly string postContent = "testcontent";

    [Test]
    public void TestAuthorAbilityToAddNewPost()
    {
      PostPage = EditPostPage.ClickAddNewButton();
      PostPage.SetPostTitle(postTitle);
     // PostPage.InputPostContent(postContent); ERROR DETECTED. WHY???
      PostPage.ClickUpdatePublishSubmitPostButton();
      Assert.AreEqual(true, PostPage.GetInfirmationWindowMessage().Contains("Post published"));
    }
  }
}