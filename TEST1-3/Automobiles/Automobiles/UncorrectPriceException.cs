using System;

namespace Automobiles
{
  public class UncorrectPriceException : Exception
  {
    const string UNCORRECTPRICEERROR = "Price must be above 0.";

    public UncorrectPriceException(string message = UNCORRECTPRICEERROR) : base(UNCORRECTPRICEERROR) { }
  }
}