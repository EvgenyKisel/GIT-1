using System;

namespace StringTransformation
{
  class TranslationFilePath
  {
    /// <summary>
    /// This method chooses the path for the file based on the language of the inputted file.
    /// </summary>
    /// <param name="language"> the language from which the translation will be made </param>
    /// <returns> path to the translation file </returns>
    public string ChoseFilePath(Language language)
    {
      string pathToTheSymbols = string.Empty;
      string[] filePathes = Environment.GetCommandLineArgs();
      string pathToLatinSymbols = filePathes[1];
      string pathToCyrillicSymbols = filePathes[2];
      switch (language)
      {
        case Language.latin:
          {
            pathToTheSymbols = pathToCyrillicSymbols;
            break;
          }
        case Language.cyrillic:
          {
            pathToTheSymbols = pathToLatinSymbols;
            break;
          }
        default:
          {
            throw new InvalidOperationException();
          }
      }
      return pathToTheSymbols;
    }
  }
}