using System.Collections.Generic;
using System.Text;

namespace StringTransformation
{
  class StringConverter
  {
    public StringBuilder TransformString(string inputString, Dictionary<string, string> dictionary)
    {
      StringBuilder convertedString = new StringBuilder();
      convertedString.Append(inputString);
      for (int i = 0; i < inputString.Length; i++)
      {
        foreach (KeyValuePair<string, string> pair in dictionary)
        {
          /* if (inputString[i].ToString().Equals(pair.Key))
           {
             convertedString.Append(pair.Value);
           }
           else
           {
             if (inputString[i].ToString().ToUpper().Equals(pair.Key.ToUpper()))
             {
               convertedString.Append(pair.Value);
               convertedString.Replace(pair.Value[0].ToString(), pair.Value[0].ToString().ToUpper());
             }
           }*/
          convertedString.Replace(pair.Key, pair.Value);
          if (inputString[i].ToString().ToUpper().Equals(pair.Key.ToUpper()) && !inputString[i].ToString().Equals(pair.Key))
          {
            convertedString.Replace(pair.Value[0].ToString(), pair.Value[0].ToString().ToUpper());
          }
        }
      }
      return convertedString;
    }
  }
}