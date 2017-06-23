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
                        int fibNumb1 = 1, fibNumb2 = 1, fibNumbN = 1;
                        bool checkFibonacci = false;
                        for (int i = 0; i < number; i++)
                        {
                            fibNumb1 = fibNumb2;
                            fibNumb2 = fibNumbN;
                            fibNumbN = fibNumb1 + fibNumb2;
                            if (number == fibNumbN || number == 1)
                            {
                                checkFibonacci = true;
                            }
                        }
                        if (checkFibonacci)
                        {
                            Console.WriteLine("This is the number of Fibonacci.");
                        }
                        else
                        {
                            Console.WriteLine("This is not the number of Fibonacci.");
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
                break;
            }
        }
    }
}
