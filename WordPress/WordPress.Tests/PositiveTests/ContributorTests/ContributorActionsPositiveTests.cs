using NUnit.Framework;

namespace WordPress.Tests.PositiveTests
{
  [TestFixture]
  public class ContributorActionsPositiveTests : ContributorActionsTests
  {
    private Pages.CommonViewPage CommonViewPage { get; set; }
    private Pages.PostPage PostPage { get; set; }
    private static readonly string postTitle = "Hello world!";
    private static readonly string commentPost = "testcontentbycontributor1";
    private static readonly string newPostTitle = "contributortesttitle1";
    //private static readonly string newPostContent = "testcontent";

    [Test]
    public void TestContributorAbilityToAddComments()
    {
      EditPostPage.ClickAllPostsButton();
      CommonViewPage = EditPostPage.ViewPost(postTitle);
      CommonViewPage.InputCommentContent(commentPost);
      CommonViewPage.ClickPostCommentButton();
      Assert.AreEqual(true, CommonViewPage.FindContributorUnapprovedComment(commentPost));
    }

    [Test]
    public void TestContributorAbilityToAddPosts()
    {
      PostPage = EditPostPage.ClickAddNewButton();
      PostPage.SetPostTitle(newPostTitle);
      // PostPage.InputPostContent(newPostContent); ERROR DETECTED. WHY???
      PostPage.ClickUpdatePublishSubmitPostButton();
      Assert.AreEqual(true, PostPage.GetInfirmationWindowMessage().Contains("Post submitted"));
    }
  }
}