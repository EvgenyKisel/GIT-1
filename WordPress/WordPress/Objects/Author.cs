namespace WordPress.Objects
{
  public class Author : User
  {
    /// <summary>
    /// This is constructor for Author class.
    /// </summary>
    /// <param name="userName"> User name </param>
    /// <param name="password"> User password </param>
    /// <param name="email"> User email </param>
    public Author(string userName, string password, string email)
    {
      base.UserName = userName;
      base.Password = password;
      base.Email = email;
    }
  }
}