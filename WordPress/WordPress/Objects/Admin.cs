namespace WordPress.Objects
{
  public class Admin : User
  {
    /// <summary>
    /// This is constructor for Admin class.
    /// </summary>
    /// <param name="userName"> User name </param>
    /// <param name="password"> User password </param>
    /// <param name="email"> User email </param>
    public Admin()
    {
      base.UserName = "admin";
      base.Password = "password";
      base.Email = "evgeny@gmail.com";
    }
  }
}