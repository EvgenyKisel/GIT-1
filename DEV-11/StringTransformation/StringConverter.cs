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
      for (int i = 0; i < line.Length; i++)
      {
        foreach (KeyValuePair<string, string> pair in dictionary)
        {
          line.Replace(pair.Key, pair.Value);
          if (line[i].ToString().ToUpper().Equals(pair.Key.ToUpper()) && !line[i].ToString().Equals(pair.Key))
          {
            line.Remove(i, pair.Key.Length);
            line.Insert(i, pair.Value[0].ToString().ToUpper());
          }
        }
      }
      return line;
    }
  }
}