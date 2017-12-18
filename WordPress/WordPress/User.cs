using System.Text.RegularExpressions;
using System;

namespace WordPress
{
  /// <summary>
  /// This is all waordpresses roles.
  /// </summary>
  public enum Role
  {
    CONTRIBUTOR,
    SUBSCRIBER,
    AUTHOR,
    EDITOR,
    ADMINISTRATOR
  }

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
        if (!Regex.IsMatch(value, "[0-9a-zA-Z.-_@ ]+"))
        {
          throw new FormatException();
        }
        userName = value;
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
        if (!Regex.IsMatch(value, "[0-9a-zA-Z.-_]+@[a-zA-Z]+.[a-zA-Z]"))
        {
          throw new FormatException();
        }
        email = value;
      }
    }

    public Role UserRole { get; set; }
    public string Password { get; set; }

    /// <summary>
    /// This is constructor for User class.
    /// </summary>
    /// <param name="name"> User name </param>
    /// <param name="password"> User password </param>
    /// <param name="email"> User email </param>
    /// <param name="role"> User role </param>
    public User(string name, string password, string email, Role role)
    {
      UserName = name;
      Password = password;
      Email = email;
      UserRole = role;
    }
  }
}