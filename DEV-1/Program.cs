using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeNumbersOutput
{
    class Program
    {
       // Entrypoint to program
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
               String output = (i % 3 == 0 ? "3*" + i / 3 : i.ToString());
               Console.Write(output + " ");
            }
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
