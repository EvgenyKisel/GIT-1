using System;
using System.Text.RegularExpressions;

namespace SymbolReplacementInStrings
{
    class RandomExchangeInStrings
    {
        public string SwapSymbolsInStrings(string firstString, string secondString)
        {
            /* int startIndexInFirstString = new Random().Next(firstString.Length - 1);
             int startIndexInSecondString = new Random().Next(secondString.Length - 1);
             int replacementLengthOfFirstString = new Random().Next(firstString.Length - startIndexInFirstString);
             int replacementLengthOfSecondString = new Random().Next(secondString.Length - startIndexInSecondString);*/
            StringLine firstLine = new StringLine(firstString);
            string replacementSymbolsInFirstString = firstString.Substring(firstLine.StartIndex, firstLine.ReplacementLength);
            StringLine secondLine = new StringLine(secondString);
            string replacementSymbolsInSecondString = secondString.Substring(secondLine.StartIndex, secondLine.ReplacementLength);
            return firstString.Replace(replacementSymbolsInFirstString, replacementSymbolsInSecondString);
        }
    }
}