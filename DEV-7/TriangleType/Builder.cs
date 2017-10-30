using System;

namespace TriangleType
{
  class Builder
  {
    const double EPSILON = Double.Epsilon;

    public Triangle Build(Sides sides)
    {
      Type type = DetermineTriangleType(sides);
      switch (type)
      {
        case Type.EQUILATERALOR:
          return new EquilateralorTriangle(sides);
        case Type.ISOSCELES:
          return new IsoscelesTriangle(sides);
        case Type.COMMON:
          return new CommonTriangle(sides);
        default:
          throw new InvalidOperationException();
      }
    }

    Type DetermineTriangleType(Sides sides)
    {
      Type type = Type.COMMON;
      if (Math.Abs(sides.sideA - sides.sideB) < EPSILON &&
              Math.Abs(sides.sideB - sides.sideC) < EPSILON)
      {
        type = Type.EQUILATERALOR;
      }
      else
      {
        if (Math.Abs(sides.sideA - sides.sideB) < EPSILON ||
                Math.Abs(sides.sideA - sides.sideC) < EPSILON ||
                Math.Abs(sides.sideB - sides.sideC) < EPSILON)
        {
          type = Type.ISOSCELES;
        }
      }
      return type;
    }
  }
}