namespace WordPress
{
  /// <summary>
  /// This is class with post description.
  /// </summary>
  public class Post
  {
    public string TitleName { get; set; }
    public string Content { get; set; }

    /// <summary>
    /// This is constructor for Post class.
    /// </summary>
    /// <param name="titleName"> Title name </param>
    /// <param name="content"> Content </param>
    public Post(string titleName, string content)
    {
      TitleName = titleName;
      Content = content;
    }
  }
}