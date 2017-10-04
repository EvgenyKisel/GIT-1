using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StringTransformation
{
  class DictionaryMaker
  {
    /// <summary>
    /// This method makes a dictionary for translation. Keys - one language, values - another.
    /// </summary>
    /// <param name="filePath"> path to the file with symbols </param>
    /// <returns> ready for translation dictionary </returns>
    public Dictionary<string, string> CreateDictionary(string filePath)
    {
      string line = string.Empty;
      Dictionary<string, string> dictionary = new Dictionary<string, string>();
      using (StreamReader symbolsReader = new StreamReader(filePath, Encoding.Default))
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