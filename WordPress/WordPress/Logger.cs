using System;
using System.IO;
using System.Text;

namespace WordPress
{
  /// <summary>
  /// This is logger class with singleton pattern.
  /// </summary>
  public class Logger
  {
    public static Logger logger;
    private static object syncRoot = new Object();
    private static readonly string FILE_PATH = "D:\\TAT\\GIT-1\\WordPress\\WordPress\\LOG.txt";

    /// <summary>
    /// This is closed constructor.
    /// </summary>
    private Logger() { }

    /// <summary>
    /// This is method, that initialize logger object, or get this object,
    /// if it had been initialized in the past.
    /// </summary>
    /// <returns> Logger instance </returns>
    public static Logger GetLoggerInstance()
    {
      lock (syncRoot)
      {
        if (logger == null)
        {
          logger = new Logger();
        }
      }
      return logger;
    }

    /// <summary>
    /// This method writes log information to log file.
    /// </summary>
    /// <param name="logText"> Log text </param>
    public static void PrintLogInformation(string logText)
    {
      using (StreamWriter writer = new StreamWriter(FILE_PATH, true, Encoding.Default))
      {
        writer.WriteLine(logText);
      }
    }
  }
}