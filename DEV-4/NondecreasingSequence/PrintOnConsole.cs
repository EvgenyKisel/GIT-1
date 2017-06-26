using System;

namespace NondecreasingSequence
{
    //This class was created to print results on console
    class PrintOnConsole
    {
        public void PrintSequenceType(int[] sequence)
        {
            SequenceType sequenceType = new SequenceType();
            if (sequenceType.NondecreasingSequence(sequence))
            {
                Console.WriteLine("It is nondecreasing sequence");
            }
            else
            {
                Console.WriteLine("It is not nondecreasing sequence");
            }
        }
    }
}