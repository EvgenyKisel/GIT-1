using System;

namespace NondecreasingSequence
{
    class Runner
    {
        //Entrypoint to program
        static void Main(string[] args)
        {
            bool duration = true;
            while (duration)
            {
                try
                {
                    Input input = new Input();
                    int[] sequence = input.InputSequence();
                    if (sequence.Length <= 1)
                    {
                        Console.WriteLine("This willn't be a sequence. Try again");
                        continue;
                    }
                    else
                    {
                        PrintOnConsole printOnConsole = new PrintOnConsole();
                        printOnConsole.PrintSequenceType(sequence);
                        Console.WriteLine("\nDo you want to try again? (y - yes / other key - no)");
                        if (Console.ReadLine().Equals("y"))
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("\nPress any key to exit.");
                            Console.ReadKey();
                        }
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
}