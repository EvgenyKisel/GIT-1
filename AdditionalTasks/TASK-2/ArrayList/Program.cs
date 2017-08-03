using System;

namespace ArrayList
{
    class Program
    {
        const string RESTART = "\nDo you want to try again? (Esc - exit / other key - restart)";

        static void Main(string[] args)
        {
            do
            {
                try
                {
                    int[] arr = { 1, 2, 3, -8, 0, -5, 6 };
                    ArrayList arrayList = new ArrayList(arr);
                    arrayList.Delete(0);
                    arrayList.Delete(0);
                    arrayList.Delete(0);
                    Console.WriteLine(arrayList.ToString());
                    arrayList.Add(7, 0);
                    arrayList.Add(25, 1);
                    arrayList.Add(-3, 2);
                    Console.WriteLine(arrayList.ToString());
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