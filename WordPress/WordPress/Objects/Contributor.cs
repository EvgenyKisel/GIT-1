namespace WordPress.Objects
{
  public class Contributor : User
  {
    /// <summary>
    /// This is constructor for Contributor class.
    /// </summary>
    /// <param name="userName"> User name </param>
    /// <param name="password"> User password </param>
    /// <param name="email"> User email </param>
    public Contributor(string userName, string password, string email)
    {
      base.UserName = userName;
      base.Password = password;
      base.Email = email;
    }
  }
}