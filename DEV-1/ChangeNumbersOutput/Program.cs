using System;

namespace ChangeNumbersOutput
{
    class Program
    {
        // Entrypoint to program
        static void Main(string[] args)
        {
            Console.Write("Output : ");
            for (int i = 0; i <= 100; i++)
            {
                String output = i.ToString();
                if (i % 3 == 0 && i % 5 == 0)
                {
                    output = "Tutti-Frutti";
                } else if (i % 3 == 0)
                {
                    output = "Tutti";
                } else if (i % 5 == 0)
                {
                    output = "Frutti";
                }
                Console.Write(output + " ");
            }
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
