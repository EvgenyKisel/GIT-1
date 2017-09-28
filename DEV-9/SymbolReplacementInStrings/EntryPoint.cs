using System;
using System.Collections.Generic;
using System.IO;

namespace SymbolReplacementInStrings
{
    // Entrypoint to program.
    class EntryPoint
    {
        // This method calls one method, that reads two strings from the file
        // and another method, that randomly replaces symbols in strings.
        // Argument contains the path to the file with strings.
        static void Main(string[] args)
        {
            try
            {
                List<string> lines = new List<string>();
                lines = new TextReader().ReadFile(args[0]);
                string firstString = lines[0];
                string secondString = lines[1];
                string stringAfterReplacement = new RandomExchangeInStrings().SwapSymbolsInStrings(firstString, secondString);
                Console.WriteLine(firstString);
                Console.WriteLine(secondString);
                Console.WriteLine(stringAfterReplacement);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}