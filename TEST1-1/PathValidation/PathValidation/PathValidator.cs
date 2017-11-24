using System.Linq;

namespace PathValidation
{
  public class PathValidator
  {
    public static readonly string[] invalidCharacters = { "\\", "/", "*", "?", "/", "<", ">", "|", ":" };
    public static readonly string[] invalidNames = {"CON", "PRN", "AUX", "NUL", "COM1", "COM2", "COM3", "COM4",
      "COM5", "COM6", "COM7", "COM8", "COM9","LPT1", "LPT2", "LPT3", "LPT4", "LPT5", "LPT6", "LPT7", "LPT8", "LPT9" };
    public static readonly char SLASH = '\\';
    public static readonly char SPACE = ' ';
    public static readonly char DOT = '.';
    public static readonly char COLON = ':';
    public static readonly char LetterA = 'A';
    public static readonly char LetterZ = 'Z';

    public string FilePath { get; set; }
    public string[] PathParts { get; set; }

    public PathValidator(string filePath)
    {
      FilePath = filePath.ToUpper();
      PathParts = FilePath.Split(SLASH);
    }

    /// <summary>
    /// This method checks the end of the path for dot and space.
    /// </summary>
    /// <returns> false value if file path ends with space or dot and true value if it is </returns>
    public bool CheckEndOfThePath()
    {
      bool checker = true;
      if (FilePath.EndsWith(DOT.ToString()) || FilePath.EndsWith(SPACE.ToString()))
      {
        checker = false;
      }
      return checker;
    }

    /// <summary>
    /// This method checks the path for invalid characters.
    /// </summary>
    /// <returns> false value if file path contains invalid characters and true value if it's not </returns>
    public bool CheckInvalidCharacters()
    {
      bool checker = true;
      for (int i = 1; i < PathParts.Length; i++)
      {
        foreach (string invalidCharacter in invalidCharacters)
        {
          if (PathParts[i].Contains(invalidCharacter))
          {
            checker = false;
            return checker;
          }
        }
      }
      return checker;
    }

    /// <summary>
    /// This method checks the file path for invalid names.
    /// </summary>
    /// <returns> false value if folder or file name is one of the invalid names and true value if it's not </returns>
    public bool CheckInvalidNames()
    {
      bool checker = true;
      string[] lastParts = PathParts[PathParts.Length - 1].Split(DOT);
      string fileName = lastParts[0];
      if (lastParts.Length > 2)
      {
        fileName = lastParts[lastParts.Length - 2];
      }
      foreach (string pathPart in PathParts)
      {
        foreach (string invalidName in invalidNames)
        {
          if (pathPart.Equals(invalidName) || fileName.Equals(invalidName))
          {
            checker = false;
          }
        }
      }
      return checker;
    }

    /// <summary>
    /// This method checks the start of the path.
    /// </summary>
    /// <returns> true value if start of the file path is correct and false value if it's not </returns>
    public bool CheckStartOfThePath()
    {
      bool checker = false;
      if ((FilePath[0].Equals(DOT) && FilePath[1].Equals(SLASH)) ||
        (FilePath[0].Equals(DOT) && FilePath[1].Equals(DOT) && FilePath[2].Equals(SLASH) || (FilePath[0].Equals(SLASH))))
      {
        checker = true;
      }
      else
      {
        if ((FilePath.Length == 2) && ((FilePath[0] >= LetterA && FilePath[0] <= LetterZ) && (FilePath[1].Equals(COLON))))
        {
          checker = true;
        }
        else
        {
          if ((FilePath.Length > 2) && (FilePath[0] >= LetterA && FilePath[0] <= LetterZ) &&
            (FilePath[1].Equals(COLON) && (FilePath[2].Equals(SLASH))))
          {
            checker = true;
          }
          else
          {
            checker = false;
            foreach (string pathPart in PathParts)
            {
              foreach (string invalidCharacter in invalidCharacters)
              {
                if (PathParts.Contains(invalidCharacter))
                {
                  return checker;
                }
              }
            }
          }
        }
      }
      return checker;
    }

    /// <summary>
    /// This method checks count of dots.
    /// </summary>
    /// <returns> false value if count is more than 2 and true value if it's not </returns>
    public bool CheckDotsInThePath()
    {
      int count = 0;
      foreach (string pathPart in PathParts)
      {
        for (int i = 0; i < pathPart.Length - 1; i++)
          if (pathPart[i].Equals(DOT) && pathPart[i + 1].Equals(DOT))
          {
            count++;
          }
      }
      return (count <= 2);
    }

    /// <summary>
    /// This method validates file path.
    /// </summary>
    /// <returns> true value if path is correct and false value if it's not </returns>
    public bool ValidatePath()
    {
      return (CheckEndOfThePath() && CheckStartOfThePath() && CheckInvalidNames()
        && CheckInvalidCharacters() && CheckDotsInThePath());
    }
  }
}