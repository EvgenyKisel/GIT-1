using System.Text.RegularExpressions;
using System;

namespace WordPress
{
  /// <summary>
  /// This is class, that contains user information.
  /// </summary>
  public class User
  {
    private string userName;
    private string email;

    /// <summary>
    /// Username can has only alphanumeric characters, spaces, underscores, hyphens, periods and the @ symbol.
    /// </summary>
    public string UserName
    {
      get
      {
        return userName;
      }
      set
      {
        if (Regex.IsMatch(value, "[0-9a-zA-Z.-_@ ]+"))
        {
          userName = value;
        }
        else
        {
          throw new FormatException();
        }
      }
    }
    /// <summary>
    /// Username must be like "username@gmail.com". Username can has only alphanumeric characters, underscores, and hyphens. 
    /// </summary>
    public string Email
    {
      get
      {
        return email;
      }
      set
      {
        if (Regex.IsMatch(value, "[0-9a-zA-Z.-_]+@[a-zA-Z.]+"))
        {
          email = value;
        }
        else
        {
          throw new FormatException();
        }
      }
    }
    public string Password { get; set; }

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