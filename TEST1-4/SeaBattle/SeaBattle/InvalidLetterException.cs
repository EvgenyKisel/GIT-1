using System;

namespace SeaBattle
{
  public class InvalidLetterException : Exception
  {
    const string INVALIDLETTERERROR = "Wrong letter. Only A-J.";

    public InvalidLetterException(string message = INVALIDLETTERERROR) : base(message) { }
  }
}