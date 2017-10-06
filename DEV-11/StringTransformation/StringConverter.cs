using System.Collections.Generic;
using System.Text;

namespace StringTransformation
{
  class StringConverter
  {
    /// <summary>
    /// This method translates a string from one language to another using a dictionary.
    /// </summary>
    /// <param name="line"> transferred to translate string </param>
    /// <param name="dictionary"> transfared collection for translation. Contains symbols translit </param>
    /// <returns></returns>
    public StringBuilder TransformString(StringBuilder line, Dictionary<string, string> dictionary)
    {
      foreach (KeyValuePair<string, string> pair in dictionary)
      {
        line.Replace(pair.Key, pair.Value);
        line.Replace(pair.Key.ToUpper(), pair.Value.ToUpper());
      }
      return line;
    }
  }
}