using System;

namespace ITCompany
{
  class InputValuesException : Exception
  {
    const string INPUTVALUESERROR = "Wrong value. Try positive values";

    public InputValuesException(string message = INPUTVALUESERROR) : base(message) { }
  }
}