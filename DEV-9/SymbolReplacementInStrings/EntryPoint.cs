using System;
using System.Collections.Generic;

namespace SymbolReplacementInStrings
{
    /// <summary>
    /// Entrypoint to program.
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// This method calls one method, that reads two strings from the file
        /// and another method, that randomly replaces symbols in strings.
        /// </summary>
        /// <param name="args">Argument contains the path to the file with strings.</param>
        static void Main(string[] args)
        {
            const int linesCount = 2;
            const string NOTENOUGHLINESINTHEFILE = "There is't not enough lines. Please, add two lines in the file.";

            try
            {
                List<string> lines = new List<string>();
                lines = new TextReader().ReadFile(args[0]);
                if (lines.Count < linesCount)
                {
                    throw new ArgumentNullException();
                }
                string firstString = lines[0];
                string secondString = lines[1];
                string stringAfterReplacement = new RandomExchangeInStrings().SwapSymbolsInStrings(firstString, secondString);
                Console.WriteLine(firstString);
                Console.WriteLine(secondString);
                Console.WriteLine(stringAfterReplacement);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine(NOTENOUGHLINESINTHEFILE);
            }
            Console.ReadKey();
        }
    }
}