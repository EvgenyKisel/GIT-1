using System;

namespace NondecreasingSequence
{
    //This class was created to input smth 
    class Inputer
    {
        const string ENTERSEQUENCE = "Enter a sequence: ";

        public int[] InputSequence(string[] inputLine)
        {
            if (inputLine.Length != 0)
            {
                foreach (var args in inputLine)
                {
                    Console.Write(args + " ");
                }
                int[] sequence = new int[inputLine.Length];
                for (int i = 0; i < inputLine.Length; i++)
                {
                    sequence[i] = int.Parse(inputLine[i]);
                }
                return sequence;
            }
            else
            {
                Console.Write(ENTERSEQUENCE);
                string[] inputNumbers = Console.ReadLine().Split(new char[] { ',', ';' });
                foreach (var args in inputNumbers)
                {
                    Console.Write(args + " ");
                }
                int[] sequence = new int[inputNumbers.Length];
                for (int i = 0; i < inputNumbers.Length; i++)
                {
                    sequence[i] = int.Parse(inputNumbers[i]);
                }
                return sequence;
            }
        }
    }
}