using System;

namespace LinkedList
{
    class EntryPoint
    {
        const string RESTART = "\nDo you want to try again? (Esc - exit / other key - restart)";

        static void Main(string[] args)
        {
            do
            {
                try
                {
                    LinkedList<int> list = new LinkedList<int>(1);
                    list.Add(784);
                    list.Add(25);
                    list.Add(-5);
                    list.Add(145);
                    list.Add(0);
                    list.Add(-4);
                    list.Output(list);
                    list.Remove(-5);
                    list.Output(list);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                Console.WriteLine(RESTART);
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}