using System;

namespace SymbolReplacementInStrings
{
    class WorkLine
    {
        public string Line { get; }
        public int StartIndex { get; }
        public int ReplacementLength { get; }

        public WorkLine(string inputLine)
        {
            Line = inputLine;
            StartIndex = new Random().Next(Line.Length - 1);
            ReplacementLength = new Random().Next(Line.Length - StartIndex);
        }
    }
}