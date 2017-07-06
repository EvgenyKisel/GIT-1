using System;

namespace TriangleType
{
    class Starter
    {
        const string FORMATEXCEPTION = " !!! It's not a number. Try again";
        const string RESTART = "\nDo you want to try again? (Esc - exit / other key - restart)";

        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Triangle triangle = new Triangle();
                    Inputer inputer = new Inputer();
                    triangle.SideA = inputer.InputSide();
                    triangle.SideB = inputer.InputSide();
                    triangle.SideC = inputer.InputSide();
                    if (triangle.CheckTriangleExistence())
                    {
                        continue;
                    }
                    Console.WriteLine(triangle.DetectTriangleType());
                }
                catch (FormatException)
                {
                    Console.WriteLine(FORMATEXCEPTION);
                    continue;
                }
                Console.WriteLine(RESTART);
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}