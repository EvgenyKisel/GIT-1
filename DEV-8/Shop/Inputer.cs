using System;

namespace Shop
{
    public class Inputer
    {
        public string InputString()
        {
            return Console.ReadLine();
        }

        public double InputDouble()
        {
            return double.Parse(Console.ReadLine());
        }

        public int InputInteger()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}