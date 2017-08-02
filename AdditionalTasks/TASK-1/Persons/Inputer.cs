using System;

namespace Persons
{
    class Inputer
    {
        public string InputString()
        {
            return Console.ReadLine();
        }

        public double InputNumber()
        {
            return double.Parse(Console.ReadLine());
        }

        public int InputIntegerNumber()
        {
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                throw new InputPositiveIntegerException();
            }
            return number;
        }
    }
}