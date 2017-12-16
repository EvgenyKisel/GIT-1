namespace WordPress.Objects
{
  public class Subscriber : User
  {
    /// <summary>
    /// This is constructor for Subscriber class.
    /// </summary>
    /// <param name="userName"> User name </param>
    /// <param name="password"> User password </param>
    /// <param name="email"> User email </param>
    public Subscriber(string userName, string password, string email)
    {
      base.UserName = userName;
      base.Password = password;
      base.Email = email;
    }
  }
}