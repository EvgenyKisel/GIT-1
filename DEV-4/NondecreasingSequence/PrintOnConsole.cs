using System;

namespace NondecreasingSequence
{
    //This class was created to print results on console
    class PrintOnConsole
    {
        public void PrintSequenceType(int[] sequence)
        {
            const string NONDECREASING = "It is nondecreasing sequence of integers";
            const string NOTNONDECREASING = "It is not nondecreasing sequence of integers";
            SequenceType sequenceType = new SequenceType();
            if (sequenceType.NondecreasingSequence(sequence))
            {
                Console.WriteLine(NONDECREASING);
            }
            else
            {
                Console.WriteLine(NOTNONDECREASING);
            }
        }
    }
}