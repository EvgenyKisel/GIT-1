using System;

namespace TriangleType
{
    class EntryPoint
    {
        const string FORMATEXCEPTION = " !!! It's not a number. Try again";
        const string ENTERSIDE = "Enter triangle sides : ";
        const string RESTART = "\nDo you want to try again? (Esc - exit / other key - restart)";
        const string NEGATIVITYERROR = " !!! Use only positive numbers. Try again";
        const string DONOTEXIST = "Triangle doesn't exist. Try again";

        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Inputer inputer = new Inputer();
                    Sides sides = new Sides();
                    Console.WriteLine(ENTERSIDE);
                    sides.sideA = inputer.InputSide();
                    sides.sideB = inputer.InputSide();
                    sides.sideC = inputer.InputSide();
                    Checker checker = new Checker();
                    if (checker.NegativityCheck(sides))
                    {
                        Console.WriteLine(NEGATIVITYERROR);
                        continue;
                    }
                    if (checker.CheckTriangleNotExistence(sides))
                    {
                        Console.WriteLine(DONOTEXIST);
                        continue;
                    }
                    Builder builder = new Builder();
                    Triangle triangle = builder.Build(sides);
                    Console.WriteLine(triangle.GetTriangleType());
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