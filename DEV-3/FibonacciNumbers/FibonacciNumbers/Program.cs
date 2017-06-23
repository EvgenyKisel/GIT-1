using System;

namespace FibonacciNumbers
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
                    Console.Write("Enter a number: ");
                    int number = int.Parse(Console.ReadLine());
                    if (number < 0)
                    {
                        Console.WriteLine("It is a negative number. Try again");
                        continue;
                    }
                    else
                    {
                        FibonacciNumber fibonacciNumber = new FibonacciNumber();
                        fibonacciNumber.DetectFibonacciNumber(number);
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

    class FibonacciNumber
    {
        public void DetectFibonacciNumber(int number)
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
                    break;
                }
            }
            if (checkFibonacci)
            {
                Console.WriteLine("This is the Fibonacci number.");
            }
            else
            {
                Console.WriteLine("This is not the Fibonacci number.");
            }
        }
    }
}
