using System;
using System.Collections;

namespace Shop
{
    class EntryPoint
    {
        const string RESTART = "\nDo you want to try again? (Esc - exit / other key - restart)";
        const string CONTINUEINPUTORNOT = "\nDo you want to add one more product? (Esc - no / other key - yes)";
       
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    ArrayList goods = new ArrayList();
                    int goodsNumber = 1;
                    do
                    {
                        try
                        {
                            GoodsBuilder goodsBuilder = new GoodsBuilder();
                            goods.Add(goodsBuilder.CreateGoods(goodsNumber));
                            goodsNumber++;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            continue;
                        }
                        Console.WriteLine(CONTINUEINPUTORNOT);
                    }
                    while (Console.ReadKey(true).Key != ConsoleKey.Escape);
                    Outputer outputer = new Outputer();
                    outputer.PrintListOfGoods(goods);
                }
                catch (Exception)
                {
                    continue;
                }
                Console.WriteLine(RESTART);
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}