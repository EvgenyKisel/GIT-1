using System;

namespace ITCompany
{
  class InvalidCriterionException : Exception
  {
    const string INVALIDCRITERIONMESSAGE = "Please, input 1,2,3 to choose the right criterion. Try again";

    public InvalidCriterionException(string message = INVALIDCRITERIONMESSAGE) : base(message) { }
  }
}