using System;
using System.Collections;

namespace Shop
{
    class Menu
    {
        public void DisplayMenu()
        {
            Console.WriteLine("Available commands: ");
            Console.WriteLine("  count types - display the number of product types");
            Console.WriteLine("  count all - display count of products;");
            Console.WriteLine("  average price - display average price of all products;");
            Console.WriteLine("  average price type - display average product type price;");
            Console.WriteLine("  exit - quit the program\n");
        }

        public void DoTheCommand(ArrayList goods)
        {
            const string COUNTTYPES = "count types";
            const string COUNTALL = "count all";
            const string AVERAGEPRICE = "average price";
            const string EXIT = "exit";
            Console.WriteLine("Press any key to enter menu");
            Console.ReadKey();
            Console.Clear();
            Menu menu = new Menu();
            menu.DisplayMenu();
            Inputer inputer = new Inputer();
            bool continueInput = true;
            while (continueInput)
            {
                string command = inputer.InputString();
                switch (command)
                {
                    case COUNTTYPES:
                        Console.WriteLine(menu.CountTypes(goods));
                        break;
                    case COUNTALL:
                        Console.WriteLine(menu.CountAll(goods));
                        break;
                    case AVERAGEPRICE:
                        Console.WriteLine(menu.GetAveragePrice(goods));
                        break;
                    case EXIT:
                        continueInput = false;
                        break;
                    default:
                        Console.WriteLine("");
                        break;
                }
            }
        }

        public int CountTypes(ArrayList list)
        {
            return list.Count;
        }

        public int CountAll(ArrayList list)
        {
            int totalCount = 0;
            foreach (Goods goods in list)
            {
                totalCount += goods.Count;
            }
            return totalCount;
        }

        public double GetAveragePrice(ArrayList list)
        {
            double averagePrice = 0;
            double totalPrice = 0;
            foreach (Goods goods in list)
            {
                totalPrice += goods.Price;
            }
            averagePrice = totalPrice / list.Count;
            return averagePrice;
        }

        public double GetAveragePriceForType(ArrayList list)
        {
            return 0;
        }
    }
}