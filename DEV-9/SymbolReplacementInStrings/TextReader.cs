using System.Collections.Generic;
using System.IO;

namespace SymbolReplacementInStrings
{
    class TextReader
    {
        const string EMPTYFILE = "The file is empty.";

        // This method takes path of the file, gets information dron this file
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
            if (lines == null)
            {
                throw new EmptyFileException(EMPTYFILE);
            }
            return lines;
        }
    }
}
