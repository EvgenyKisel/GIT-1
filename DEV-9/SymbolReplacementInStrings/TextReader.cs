using System.Collections.Generic;
using System.IO;

namespace SymbolReplacementInStrings
{
    class TextReader
    {
        // This method takes path of the file, gets information from this file
        // and return collection of strings.
        public List<string> ReadFile(string path)
        {
            if (path == null)
            {
                throw new FileNotFoundException();
            }
            List<string> lines = new List<string>();
            using (StreamReader file = new StreamReader(path))
            {
                lines.Add(file.ReadLine());
                lines.Add(file.ReadLine());
            }
            return lines;
        }
    }
}