using System;

namespace Shop
{
    class Menu
    {
        const string MENU = "Press any key to start enter commands";

        public void DisplayMenu()
        {
            Console.WriteLine(MENU);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Available commands: ");
            Console.WriteLine("  count types - display the number of product types");
            Console.WriteLine("  count all - display count of products;");
            Console.WriteLine("  average price - display average price of all products;");
            Console.WriteLine("  average price type - display average product type price;");
            Console.WriteLine("  exit - quit the program\n");
        }

        public 
    }
}