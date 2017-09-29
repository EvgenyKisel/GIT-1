using System.Text.RegularExpressions;

namespace SymbolReplacementInStrings
{
    class RandomExchangeInStrings
    {
        /// <summary>
        /// This method swaps symbols in two strings. 
        /// It calls string constructor, allocates substrings for replacement
        /// and use regex for replacement.
        /// </summary>
        /// <param name="firstString">one of the lines to swap symbols</param>
        /// <param name="secondString">another of the lines to swap symbols</param>
        /// <returns>modified line by regex method, that takes line and two substrings for replacement</returns>
        public string SwapSymbolsInStrings(string firstString, string secondString)
        {
            LineInitializer firstLine = new LineInitializer(firstString);
            string replacementSymbolsInFirstString = firstString.Substring(firstLine.StartIndex, firstLine.ReplacementLength);
            LineInitializer secondLine = new LineInitializer(secondString);
            string replacementSymbolsInSecondString = secondString.Substring(secondLine.StartIndex, secondLine.ReplacementLength);
            return Regex.Replace(firstString, replacementSymbolsInFirstString, replacementSymbolsInSecondString);
        }
    }
}