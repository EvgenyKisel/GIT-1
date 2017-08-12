using System;

namespace Shop
{
    class EntryPoint
    {
        const string RESTART = "\nDo you want to try again? (Esc - exit / other key - restart)";
        const string INPUTCOUNT = "Input integer amount of goods : ";

        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.WriteLine(INPUTCOUNT);
                    Inputer inputer = new Inputer();
                    int goodsCount = inputer.InputInteger();
                    Goods[] goods = new Goods[goodsCount];
                    for (int i = 0; i < goods.Length; i++)
                    {
                        GoodsBuilder goodsBuilder = new GoodsBuilder();
                        bool reenter = true;
                        while (reenter)
                        {
                            try
                            {
                                goods[i] = goodsBuilder.CreateGoods(i);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                continue;
                            }
                            reenter = false;
                        }
                    }
                    Outputer outputer = new Outputer();
                    outputer.PrintListOfGoods(goods);
                }
                catch (InputPositiveIntegerException)
                {
                    continue;
                }
                Console.WriteLine(RESTART);
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}