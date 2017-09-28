using System;

namespace SymbolReplacementInStrings
{
    class EmptyFileException : Exception
    {
        public EmptyFileException(string message) : base(message) { }
    }
}