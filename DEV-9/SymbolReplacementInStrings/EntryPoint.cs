using System;

namespace SymbolReplacementInStrings
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            const string FIRSTSTRING = "qwertyuiop";
            const string SECONDSTRING = "asdfghjkl";

            string firstString = FIRSTSTRING;
            string secondString = SECONDSTRING;
            string stringAfterReplacement = new RandomExchangeInStrings().SwapSymbolsInStrings(firstString, secondString);
            Console.WriteLine(firstString);
            Console.WriteLine(secondString);
            Console.WriteLine(stringAfterReplacement);
            Console.ReadKey();
        }
    }
}