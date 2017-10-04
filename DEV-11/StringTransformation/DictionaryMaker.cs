using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StringTransformation
{
  class DictionaryMaker
  {
    public Dictionary<string, string> CreateDictionary(string path)
    {
      string line = string.Empty;
      Dictionary<string, string> dictionary = new Dictionary<string, string>();
      using (StreamReader symbolsReader = new StreamReader(path, Encoding.GetEncoding(1251)))
      {
        while (line != null)
        {
          line = symbolsReader.ReadLine();
          if (line == null)
          {
            break;
          }
          string[] symbols = line.Split('-');
          dictionary.Add(symbols[0], symbols[1]);
        }
      }
      return dictionary;
    }
  }
}