using System;

namespace TriangleType
{
  public class Checker
  {
    public bool PositivityCheck(Sides sides)
    {
      bool checker = false;
      if (sides.sideA > 0 && sides.sideB > 0 && sides.sideC > 0)
      {
        checker = true;
      }
      return checker;
    }

    public bool CheckTriangleExistence(Sides sides)
    {
      bool checker = true;
      double maxSide = Math.Max(Math.Max(sides.sideA, sides.sideB), sides.sideC);
      double minSide = Math.Min(Math.Min(sides.sideA, sides.sideB), sides.sideC);
      double meanSide = sides.sideA + sides.sideB + sides.sideC - maxSide - minSide;
      if (minSide + meanSide <= maxSide)
      {
        checker = false;
      }
      return checker;
    }
  }
}