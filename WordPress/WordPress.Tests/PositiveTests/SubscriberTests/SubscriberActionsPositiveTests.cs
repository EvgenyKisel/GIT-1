﻿using NUnit.Framework;

namespace WordPress.Tests.PositiveTests
{
  [TestFixture]
  public class SubscriberActionsPositiveTests : SubscriberActionsTests
  {
    private Pages.CommonViewPage CommonViewPage { get; set; }
    private static readonly string postTitle = "Hello world!";
    private static readonly string commentPost = "testcontent";

    [Test]
    public void TestSubscriberAbilityToAddComments()
    {
      CommonViewPage = DashboardPage.GoToPost(postTitle);
      CommonViewPage.AddComment(commentPost);
      CommonViewPage.ClickPostCommentButton();
      Assert.AreEqual(true, CommonViewPage.FindSubscriberComment(commentPost));
    }
  }
}