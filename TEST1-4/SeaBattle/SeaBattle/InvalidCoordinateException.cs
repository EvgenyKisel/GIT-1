using System;

namespace SeaBattle
{
  public class InvalidCoordinateException : Exception
  {
    const string INVALIDCOORDINATEERROR = "Invalid coordinate. Try again!";

    public InvalidCoordinateException(string message = INVALIDCOORDINATEERROR) : base(message) { }
  }
}