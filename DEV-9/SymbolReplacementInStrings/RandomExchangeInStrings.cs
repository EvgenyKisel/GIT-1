using System.Text.RegularExpressions;

namespace SymbolReplacementInStrings
{
    class RandomExchangeInStrings
    {
        // This method calls string constructor, allocates substrings for replacement,
        // returns modified line by regex method, that takes line and two substrings for replacement.
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