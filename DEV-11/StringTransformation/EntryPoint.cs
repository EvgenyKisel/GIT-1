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
        Dictionary<string, string> latinSymbols = dictionaryMaker.CreateDictionary(pathToLatinSymbols);
        Dictionary<string, string> cyrillicSymbols = dictionaryMaker.CreateDictionary(pathToCyrillicSymbols);
        StringConverter stringConverter = new StringConverter();
        Console.WriteLine(stringConverter.TransformString(line, latinSymbols));
        Console.WriteLine(stringConverter.TransformString(line, cyrillicSymbols));
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
      Console.ReadKey();
    }
  }
}