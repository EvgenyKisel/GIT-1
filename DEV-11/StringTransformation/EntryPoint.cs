using System;
using System.Collections.Generic;

namespace StringTransformation
{
  class EntryPoint
  {
    /// <summary>
    /// Entrypoint to program.
    /// </summary>
    /// <param name="args"> contains pathes to the files </param>
    static void Main(string[] args)
    {
      try
      {
        string pathToLatinSymbols = args[0];
        string pathToCyrillicSymbols = args[1];
        string str = "ТатРф";
        DictionaryMaker dictionaryMaker = new DictionaryMaker();
        Dictionary<string, string> latinSymbols = dictionaryMaker.CreateDictionary(pathToLatinSymbols);
        //Dictionary<string, string> cyrillicLowerSymbols = dictionaryMaker.CreateDictionary(pathToCyrillicSymbols);

        foreach (KeyValuePair<string, string> pair in latinSymbols)
        {
          Console.WriteLine("Key: {0} - Value: {1}", pair.Key, pair.Value);
        }
        StringConverter stringConverter = new StringConverter();
        Console.WriteLine(stringConverter.TransformString(str,latinSymbols));
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
      Console.ReadKey();
    }
  }
}