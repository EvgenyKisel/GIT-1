﻿using System;

namespace SymbolReplacementInStrings
{
    class LineCreator
    {
        public string Line { get; }
        public int StartIndex { get; }
        public int ReplacementLength { get; }
        Random random = new Random();
        
        /// <summary>
        /// This constructor gives replacement index and length for input string.
        /// </summary>
        /// <param name="inputLine">input string</param>
        public LineCreator(string inputLine)
        {
            Line = inputLine;
            StartIndex = random.Next(Line.Length - 1);
            ReplacementLength = random.Next(1, Line.Length - StartIndex);
        }
    }
}