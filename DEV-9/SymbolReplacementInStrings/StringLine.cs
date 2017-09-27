using System;

namespace SymbolReplacementInStrings
{
    class StringLine
    {
        public string Line { get; }
        public int StartIndex { get; }
        public int ReplacementLength { get; }

        public StringLine(string inputLine)
        {
            Line = inputLine;
            StartIndex = new Random().Next(Line.Length - 1);
            ReplacementLength = new Random().Next(Line.Length - StartIndex);
        }
    }
}