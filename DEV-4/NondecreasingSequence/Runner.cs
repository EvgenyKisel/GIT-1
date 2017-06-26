using System;

namespace NondecreasingSequence
{
    //This class was made to start a program
    class Runner
    {
        const string LENGTHERROR = "This willn't be a sequence. Try again";
        const string NUMBERERROR = "It is not a number. Try again";
        const string EXIT = "Press any key to exit.";
        const string YES = "y";
        const string RESTART = "Do you want to try again? (y - try again / other key - no)";

        //Entrypoint to program
        static void Main(string[] args)
        {
            bool reenter = true;
            while (reenter)
            {
                try
                {
                    Input input = new Input();
                    int[] sequence = input.InputSequence();
                    if (sequence.Length <= 1)
                    {
                        Console.WriteLine(LENGTHERROR);
                        continue;
                    }
                    else
                    {
                        SequenceType sequenceType = new SequenceType();
                        Console.WriteLine(sequenceType.DetermineSequenceTipe(sequence));
                        Console.WriteLine(RESTART);
                        if (Console.ReadLine().Equals(YES))
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine(EXIT);
                            Console.ReadKey();
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine(NUMBERERROR);
                    continue;
                }
                reenter = false;
            }
        }
    }
}