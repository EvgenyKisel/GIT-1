using System;
using System.IO;

namespace SymbolReplacementInStrings
{
    class EntryPoint
    {
        // This method reads two strings from the file,
        // calls method to randomly replace symbols in strings.
        // Argument contains the path to the file with strings.
        static void Main(string[] args)
        {
            try
            {
                string firstString = string.Empty;
                string secondString = string.Empty;
                using (StreamReader file = new StreamReader(args[0]))
                {
                    firstString = file.ReadLine();
                    secondString = file.ReadLine();
                }
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