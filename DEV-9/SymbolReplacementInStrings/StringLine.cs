using System;

namespace SymbolReplacementInStrings
{
    class StringLine
    {
        public string Line { get; }
        public int StartIndex { get; }
        public int ReplacementLength { get; }
        Random random = new Random();

        // This constructor gives replacement index and length for input string.
        public StringLine(string inputLine)
        {
            Line = inputLine;
            StartIndex = random.Next(Line.Length - 1);
            ReplacementLength = random.Next(1, Line.Length - StartIndex);
        }
    }
}