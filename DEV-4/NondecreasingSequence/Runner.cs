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
        const string RESTART = "Do you want to try again? (Esc - try again / other key - restart)";

        //Entrypoint to program
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Inputer inputer = new Inputer();
                    int[] sequence = inputer.InputSequence(args);
                    if (sequence.Length <= 1)
                    {
                        Console.WriteLine(LENGTHERROR);
                        continue;
                    }
                    else
                    {
                        SequenceType sequenceType = new SequenceType();
                        Console.WriteLine(sequenceType.DetermineSequenceType(sequence));
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine(NUMBERERROR);
                    continue;
                }
                Console.WriteLine(RESTART);
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}