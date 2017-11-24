using System;

namespace SeaBattle
{
  public class InvalidNumberException : Exception
  {
    const string INVALIDNUMBERERROR = "Wrong number. Only 1-10.";

    public InvalidNumberException(string message = INVALIDNUMBERERROR) : base(message) { }
  }
}