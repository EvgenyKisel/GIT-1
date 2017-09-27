using System;
using System.Text.RegularExpressions;

namespace SymbolReplacementInStrings
{
    class RandomExchangeInStrings
    {
        public string SwapSymbolsInStrings(string firstString, string secondString)
        {
            int startIndexInFirstString = new Random().Next(firstString.Length - 1);
            int startIndexInSecondString = new Random().Next(secondString.Length - 1);
            int replacementLengthOfFirstString = new Random().Next(firstString.Length - startIndexInFirstString);
            int replacementLengthOfSecondString = new Random().Next(secondString.Length - startIndexInSecondString);
            string replacementSymbolsInFirstString = firstString.Substring(startIndexInFirstString, replacementLengthOfFirstString);
            string replacementSymbolsInSecondString = secondString.Substring(startIndexInSecondString, replacementLengthOfSecondString);
            return Regex.Replace(firstString, replacementSymbolsInFirstString, replacementSymbolsInSecondString);
        }
    }
}