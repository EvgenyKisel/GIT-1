using System;

namespace ITCompany
{
  class InvalidSalaryException : Exception
  {
    public const string INVALIDSALARYMESSAGE = "Salary must be above 0.";

    public InvalidSalaryException(string message = INVALIDSALARYMESSAGE) : base(message){}
  }
}