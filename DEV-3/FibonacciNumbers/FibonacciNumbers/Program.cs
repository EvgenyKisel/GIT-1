using System;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter a number: ");
                    int number = int.Parse(Console.ReadLine());
                    if (number < 0)
                    {
                        Console.WriteLine("It is a negative number. Try again");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("\nPress any key to exit.");
                        Console.ReadKey();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("It is not a number. Try again");
                    continue;
                }
                break;
            }
        }
    }
}
