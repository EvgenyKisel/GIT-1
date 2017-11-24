using System;
using System.Collections;

namespace Shop
{
    class GetAveragePriceOfTheTypeCommand : Commands
    {
        const string AVERAGEPRICE = "average price ";
        const string PRODUCTEXCEPTION = "There is no such product!";

        public override void DoCommand(string command, ArrayList list)
        {
            if (command.Contains(AVERAGEPRICE))
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
                }
                if (typeCount == 0)
                {
                    throw new ProductException(PRODUCTEXCEPTION);
                }
                double averagePriceForOneType = totalPriceForOneType / typeCount;
                Console.WriteLine(averagePriceForOneType);
            }
        }
    }
}