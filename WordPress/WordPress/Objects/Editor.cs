namespace WordPress.Objects
{
  public class Editor : User
  {
    /// <summary>
    /// This is constructor for Admin class.
    /// </summary>
    /// <param name="userName"> User name </param>
    /// <param name="password"> User password </param>
    /// <param name="email"> User email </param>
    public Editor(string userName, string password, string email)
    {
      base.UserName = userName;
      base.Password = password;
      base.Email = email;
    }
  }
}