using System;

namespace Shop
{
    class Outputer
    {
        public void PrintListOfGoods(Goods[] goods)
        {
            Console.Clear();
            for (int i = 0; i < goods.Length; i++)
            {
                Console.WriteLine(String.Format("\nGoods №{0} : ", i + 1) + goods[i].ToString());
            }
        }
    }
}