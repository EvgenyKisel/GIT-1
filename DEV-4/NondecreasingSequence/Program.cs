using System;

namespace NondecreasingSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            bool duration = true;
            while (duration)
            {
                try
                {
                    Console.Write("Enter size of sequence: ");
                    int sequenceSize = int.Parse(Console.ReadLine());
                    if (sequenceSize <= 1)
                    {
                        Console.WriteLine("This willn't be a sequence. Try again");
                        continue;
                    }
                    else
                    {
                        int[] sequence = new int[sequenceSize];
                        Console.WriteLine("Enter a sequence: ");
                        for (int i = 0; i < sequenceSize; i++)
                        {
                            string inputLine = Console.ReadLine();
                            sequence[i] = int.Parse(inputLine);
                        }
                        SequenceType sequenceType = new SequenceType();
                        if (sequenceType.NondecreasingSequence(sequence))
                        {
                            Console.WriteLine("It is nondecreasing sequence");
                        }
                        else
                        {
                            Console.WriteLine("It is not nondecreasing sequence");
                        }
                        Console.WriteLine("\nPress any key to exit.");
                        Console.ReadKey();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("It is not a number. Try again");
                    continue;
                }
                duration = false;
            }
        }
    }

    class SequenceType
    {
        public bool NondecreasingSequence(int[] sequence)
        {
            for (int i = 1; i < sequence.Length; i++)
            {
                if (sequence[i] >= sequence[i - 1])
                {
                    return true;
                }
            }
            return false;
        }
    }
}