using System;
using System.Collections;

namespace Shop
{
    class Menu
    {
        const string PRODUCTEXCEPTION = "There is no such product!";

        public void DisplayMenu()
        {
            Console.WriteLine("Available commands: ");
            Console.WriteLine("  count types - display the number of product types");
            Console.WriteLine("  count all - display count of products;");
            Console.WriteLine("  average price - display average price of all products;");
            Console.WriteLine("  average price type - display average product type price;");
            Console.WriteLine("  exit - quit the program\n");
        }

        public void DoTheCommand(ArrayList list)
        {
            const string COUNTTYPES = "count types";
            const string COUNTALL = "count all";
            const string AVERAGEPRICE = "average price";
            const string AVERAGEPRICEFORTYPE = "average price ";
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
                        Console.WriteLine(menu.CountTypes(list));
                        break;
                    case COUNTALL:
                        Console.WriteLine(menu.CountAll(list));
                        break;
                    case AVERAGEPRICE:
                        Console.WriteLine(menu.GetAveragePrice(list));
                        break;
                    case EXIT:
                        continueInput = false;
                        break;
                    default:
                        if (command.Contains(AVERAGEPRICEFORTYPE))
                        {
                            Console.WriteLine(menu.GetAveragePriceForType(list, command));
                        }
                        else
                        {
                            Console.WriteLine("Shit happens");
                        }
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

        public double GetAveragePriceForType(ArrayList list, string command)
        {
            string type = command.Substring(14);
            double totalPriceForOneType = 0;
            int typeCount = 0;
            foreach (Goods goods in list)
            {
                if (type.Equals(goods.Type))
                {
                    totalPriceForOneType += goods.Price;
                    typeCount++;
                }
                else
                {
                    throw new ProductException(PRODUCTEXCEPTION);
                }
            }
            double averagePriceForOneType = totalPriceForOneType / typeCount;
            return averagePriceForOneType;
        }
    }
}