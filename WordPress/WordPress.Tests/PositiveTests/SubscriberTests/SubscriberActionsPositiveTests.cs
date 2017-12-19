using NUnit.Framework;

namespace WordPress.Tests.PositiveTests
{
  [TestFixture]
  public class SubscriberActionsPositiveTests : SubscriberActionsTests
  {
    private Pages.CommonViewPage CommonViewPage { get; set; }
    private static readonly string postTitle = "Hello world!";
    private static readonly string commentPost = "testcontent1";

    [Test]
    public void TestSubscriberAbilityToAddComments()
    {
      CommonViewPage = DashboardPage.GoToPost(postTitle);
      CommonViewPage.InputCommentContent(commentPost);
      CommonViewPage.ClickPostCommentButton();
      Assert.AreEqual(true, CommonViewPage.FindSubscriberComment(commentPost));
    }
  }
}