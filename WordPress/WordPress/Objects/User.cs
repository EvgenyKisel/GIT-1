namespace WordPress
{
  /// <summary>
  /// This is class, that contains user information.
  /// </summary>
  class User
  {
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }

    /// <summary>
    /// This is constructor for User class.
    /// </summary>
    /// <param name="userName"> User name </param>
    /// <param name="password"> User password </param>
    /// <param name="email"> User email </param>
    public User(string userName, string password, string email)
    {
      UserName = userName;
      Password = password;
      Email = email;
    }
  }
}