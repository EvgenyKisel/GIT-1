using System.Collections.Generic;
using System.IO;

namespace SymbolReplacementInStrings
{
    class TextReader
    {
        /// <summary>
        /// This method gets information from the file.
        /// </summary>
        /// <param name="path">path of the file</param>
        /// <returns>collection of strings</returns>
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