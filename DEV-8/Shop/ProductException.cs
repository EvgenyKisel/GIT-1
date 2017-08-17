using System;

namespace Shop
{
    class ProductException : Exception
    {
        public ProductException(string message) : base(message) { }
    }
}