using System;
using System.Text;
using System.Text.RegularExpressions;

namespace StringTransformation
{
  enum Language
  {
    latin,
    cyrillic,
    none
  }

  class LanguageAnalyzer
  {
    /// <summary>
    /// This method detect the language of inputted line by regex method.
    /// </summary>
    /// <param name="line"> inputted line </param>
    /// <returns> language of inputted line </returns>
    public Language DetectLanguage(StringBuilder line)
    {
      Language language = Language.none;
      if (Regex.IsMatch(line.ToString(), "[a-zA-Z]+"))
      {
        language = Language.latin;
      }
      else
      {
        if (Regex.IsMatch(line.ToString(), "[а-яА-Я]+"))
        {
          language = Language.cyrillic;
        }
        else
        {
          throw new FormatException();
        }
      }
      return language;
    }
  }
}