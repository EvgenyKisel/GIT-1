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
                    Console.Clear();
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
                    bool reenterCommands = true;
                    while (reenterCommands == true)
                    {
                        try
                        {
                            Menu menu = new Menu();
                            menu.DisplayMenu();
                            Inputer inputer = new Inputer();
                            bool continueInputCommands = true;
                            while (continueInputCommands == true)
                            {
                                string command = inputer.InputString();
                                if (command.Equals("exit"))
                                {
                                    break;
                                }
                                else
                                {
                                    ArrayListCommands commands = new ArrayListCommands();
                                    commands.CallCommand(command, commands.AddToHashOfCommands(), goods);
                                }
                            }
                        }
                        catch (FormatException exception)
                        {
                            Console.WriteLine(exception.Message);
                            continue;
                        }
                        reenterCommands = false;
                    }
                }
                catch (FormatException exception)
                {
                    Console.WriteLine(exception.Message);
                    continue;
                }
                Console.Clear();
                Console.WriteLine(RESTART);
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}