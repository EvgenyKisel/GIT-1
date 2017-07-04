using System;

namespace TriangleType
{
    class Inputer
    {
        const string POSITIVITYERROR = "Use only positive numbers. Try again";
        const string ENTERSIDE = "Enter triangle side : ";

        public double InputSide()
        {
            double side = 0;
            bool reenter = true;
            while (reenter)
            {
                Console.Write(ENTERSIDE);
                side = Double.Parse(Console.ReadLine());
                if (0 >= side)
                {
                    Console.WriteLine(POSITIVITYERROR);
                    continue;
                }
                reenter = false;
            }
            return side;
        }
    }
}
