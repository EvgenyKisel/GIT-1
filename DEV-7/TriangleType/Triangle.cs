using System;

namespace TriangleType
{
    class Triangle
    {
        const string DONOTEXIST = "Triangle doesn't exist.";

        public double SideA
        { get; set; }

        public double SideB
        { get; set; }

        public double SideC
        { get; set; }

        public void TriangleExistence()
        {
            double maxSide = Math.Max(Math.Max(SideA, SideB), SideC);
            double minSide = Math.Min(Math.Min(SideA, SideB), SideC);
            double meanSide = SideA + SideB + SideC - maxSide - minSide;
            if (minSide + meanSide <= maxSide)
            {
                Console.WriteLine(DONOTEXIST);
            }
        }
    }
}
