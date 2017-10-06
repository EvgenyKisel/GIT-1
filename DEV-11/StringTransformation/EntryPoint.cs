using System;
using System.Collections.Generic;
using System.Text;

namespace StringTransformation
{
  class EntryPoint
  {
    /// <summary>
    /// Entrypoint to program. This method takes pathes to files with translation,
    /// takes string from console, puts translations to dictionaries, calls methods, that translate string
    /// and out this translations on console.
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
        string pathToLatinSymbols = args[0];
        string pathToCyrillicSymbols = args[1];        
        StringBuilder line = new StringBuilder();
        line.Append(Console.ReadLine());
        DictionaryMaker dictionaryMaker = new DictionaryMaker();
        Dictionary<string, string> latinDictionary = dictionaryMaker.CreateDictionary(pathToLatinSymbols);
        Dictionary<string, string> cyrillicDictionary = dictionaryMaker.CreateDictionary(pathToCyrillicSymbols);
        Language language = new LanguageAnalyzer().DetectLanguage(line, latinDictionary, cyrillicDictionary);
        StringConverter stringConverter = new StringConverter();
        switch (language)
        {
          case Language.latin:
            {
              Console.WriteLine(stringConverter.TransformString(line, cyrillicDictionary));
              break;
            }
           
          case Language.cyrillic:
            {
              Console.WriteLine(stringConverter.TransformString(line, latinDictionary));
              break;
            }
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
      Console.ReadKey();
    }
  }
}