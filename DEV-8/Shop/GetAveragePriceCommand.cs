using System;
using System.Collections;

namespace Shop
{
    class GetAveragePriceCommand : Commands
    {
        const string AVERAGEPRICE = "average price";

        public override void DoCommand(string command, ArrayList list)
        {
            if (command.Equals(AVERAGEPRICE))
            {
                double totalPrice = 0;
                foreach (Goods goods in list)
                {
                    totalPrice += goods.Price;
                }
                double averagePrice = totalPrice / list.Count;
                Console.WriteLine(averagePrice);
            }
        }
    }
}