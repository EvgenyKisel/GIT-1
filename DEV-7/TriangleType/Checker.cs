using System;

namespace TriangleType
{
  public class Checker
  {
    public bool NegativityCheck(Sides sides)
    {
      bool checker = true;
      if (sides.sideA > 0 && sides.sideB > 0 && sides.sideC > 0)
      {
        checker = false;
      }
      return checker;
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