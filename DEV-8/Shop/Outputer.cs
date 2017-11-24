using System;
using System.Collections;

namespace Shop
{
    class Outputer
    {
        public void PrintListOfGoods(ArrayList goods)
        {
            Console.Clear();
            int i = 1;
            foreach (Goods good in goods)
            {
                Console.WriteLine(String.Format("\nGoods №{0} : ", i) + good.ToString());
                i++;
            }
        }
    }
}