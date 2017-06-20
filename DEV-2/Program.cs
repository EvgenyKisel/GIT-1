using System;

namespace OutputWithChanges
{
    class Program
    {
        // Entrypoint to program
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter a number: ");
                    String str = Console.ReadLine();
                    int count = int.Parse(str);
                    if (count > 0)
                    {
                        Console.Write("Output : ");
                        for (int i = 0; i <= count; i++)
                        {
                            String output = i.ToString();
                            if (i % 3 == 0) output = "Tutti";
                            if (i % 5 == 0) output = "Frutti";
                            if (i % 3 == 0 && i % 5 == 0) output = "Tutti-Frutti";
                            Console.Write(output + " ");
                        }
                        Console.WriteLine("\nPress any key to exit.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Not a positive number.");
                        continue;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Not a number.");
                    continue;
                }
                break;
            }
        }
    }
}
