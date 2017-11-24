using System;

namespace PathValidation
{
  /// <summary>
  /// Entry point to program.
  /// </summary>
  class EntryPoint
  {
    const string VALIDPATH = "Path is valid";
    const string INVALIDPATH = "Path is invalid";

    /// <summary>
    /// This method takes file path from command line and validate this path.
    /// </summary>
    /// <param name="args"> file path </param>
    static void Main(string[] args)
    {
      try
      {
        if (args.Length == 0)
        {
          Console.WriteLine(INVALIDPATH);
        }
        string filePath = args[0];
        PathValidator pathValidator = new PathValidator(filePath);
        if (pathValidator.ValidatePath())
        {
          Console.WriteLine(VALIDPATH);
        }
        else
        {
          Console.WriteLine(INVALIDPATH);
        }
      }
      catch (Exception exception)
      {
        Console.WriteLine(exception.Message);
      }
    }
  }
}