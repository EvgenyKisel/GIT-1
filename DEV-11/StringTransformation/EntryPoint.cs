using System;
using System.Collections.Generic;
using System.Text;

namespace StringTransformation
{
  class EntryPointe
  {
    /// <summary>
    /// Entrypoint to program. This method takes pathes to files with translation,
    /// takes string from console, detect language of the line, choose the path to the file with needed translation,
    /// puts appropriately translation to dictionary, calls method, that translate string,
    /// and out this translation on console.
    /// </summary>
    /// <param name="args"> contains pathes to the files </param>
    static void Main(string[] args)
    {
      try
      {
        if (args.Equals(null))
        {
          throw new ArgumentNullException();
        }
        StringBuilder line = new StringBuilder();
        line.Append(Console.ReadLine());
        Language language = new LanguageAnalyzer().DetectLanguage(line);
        string pathToTheTranslationFile = new TranslationFilePath().ChoseFilePath(language);
        DictionaryMaker dictionaryMaker = new DictionaryMaker();
        Dictionary<string, string> dictionary = dictionaryMaker.CreateDictionary(pathToTheTranslationFile);
        StringConverter stringConverter = new StringConverter();
        Console.WriteLine(stringConverter.TransformString(line, dictionary));
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
      Console.ReadKey();
    }
  }
}