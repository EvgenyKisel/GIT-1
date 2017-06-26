using System;

namespace NondecreasingSequence
{
    class Runner
    {
        //Entrypoint to program
        static void Main(string[] args)
        {
            const string LENGTHERROR = "This willn't be a sequence. Try again";
            const string NUMBERERROR = "It is not a number. Try again";
            const string EXIT = "Press any key to exit.";
            const string YES = "y";
            const string RESTART = "Do you want to try again? (y - try again / other key - no)";
            bool duration = true;
            while (duration)
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
                        PrintOnConsole printOnConsole = new PrintOnConsole();
                        printOnConsole.PrintSequenceType(sequence);
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
                duration = false;
            }
        }
    }
}