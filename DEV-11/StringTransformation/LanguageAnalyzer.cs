using System.Collections.Generic;
using System.Text;

namespace StringTransformation
{
  enum Language
  {
    latin,
    cyrillic
  }

  class LanguageAnalyzer
  {
    /// <summary>
    /// This method detect the language of inputted line.
    /// </summary>
    /// <param name="line"> inputted line </param>
    /// <param name="latinDictionary"> one dictionary </param>
    /// <param name="cyrillicDictionary"> another dictionary </param>
    /// <returns> inputted line language </returns>
    public Language DetectLanguage(StringBuilder line, Dictionary<string, string> latinDictionary, Dictionary<string, string> cyrillicDictionary)
    {
      Language language = Language.latin;
      int latinSymbolsCount = 0;
      foreach (KeyValuePair<string, string> pair in latinDictionary)
      {
        if (line.ToString().Contains(pair.Value.ToString()))
        {
          latinSymbolsCount++;
        }
      }
      int cyrillicSymbolsCount = 0;
      foreach (KeyValuePair<string, string> pair in cyrillicDictionary)
      {
        if (line.ToString().Contains(pair.Value.ToString()))
        {
          cyrillicSymbolsCount++;
        }
      }
      if (cyrillicSymbolsCount > 0)
      {
        language = Language.cyrillic;
      }
      else
      {
        if (latinSymbolsCount > 0)
        {
          language = Language.latin;
        }
        else
        {
          throw new KeyNotFoundException();
        }
      }
      return language;
    }
  }
}