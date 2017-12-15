using System;

namespace WordPress
{
  /// <summary>
  /// This is logger class with singleton pattern.
  /// </summary>
  class Logger
  {
    public static Logger logger;
    public string LogText { get; set; }

    /// <summary>
    /// This is closed constructor.
    /// </summary>
    private Logger() { }

    /// <summary>
    /// This is method, that initialize logger object, or get this object,
    /// if it had been initialized in the past.
    /// </summary>
    /// <param name="logText"> Text for logger </param>
    /// <returns> Logger instance </returns>
    public Logger GetLoggerInstance(string logText)
    {
      if (logger == null)
      {
        logger = new Logger();
      }
      return logger;
    }

    /// <summary>
    /// This method outputs log information on console.
    /// </summary>
    public void PrintLogInformation()
    {
      Console.WriteLine(LogText);
    }
  }
}