using System;

namespace ITCompany
{
  class NoSuitableOptionsException : Exception
  {
    const string NOSUITABLEOPTIONSERROR = "No matching options.";

    public NoSuitableOptionsException(string message = NOSUITABLEOPTIONSERROR) : base(message) { }
  }
}