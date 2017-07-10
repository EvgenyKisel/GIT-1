using System;

namespace TriangleType
{
    class Checker
    {
        public bool NegativityCheck(Sides sides)
        {
            if (sides.sideA > 0 && sides.sideB > 0 && sides.sideC > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool CheckTriangleNotExistence(Sides sides)
        {
            bool checker = false;
            double maxSide = Math.Max(Math.Max(sides.sideA, sides.sideB), sides.sideC);
            double minSide = Math.Min(Math.Min(sides.sideA, sides.sideB), sides.sideC);
            double meanSide = sides.sideA + sides.sideB + sides.sideC - maxSide - minSide;
            if (minSide + meanSide <= maxSide)
            {
                checker = true;
            }
            return checker;
        }
    }
}