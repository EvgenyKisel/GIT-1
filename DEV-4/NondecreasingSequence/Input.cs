using System;

namespace NondecreasingSequence
{
    //This class was created to input smth 
    class Input
    {
        public int[] InputSequence()
        {
            Console.Write("Enter a sequence: ");
            string[] inputNumbers = Console.ReadLine().Split();
            int[] sequence = new int[inputNumbers.Length];
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                sequence[i] = int.Parse(inputNumbers[i]);
            }
            return sequence;
        }
    }
}