﻿using System;

namespace Shop
{
    class EntryPoint
    {
        const string RESTART = "\nDo you want to try again? (Esc - exit / other key - restart)";

        static void Main(string[] args)
        {
            do
            {
                try
                {

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                Console.WriteLine(RESTART);
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}