namespace TriangleType
{
  public enum Type
  {
    EQUILATERALOR,
    ISOSCELES,
    COMMON
  }

  public abstract class Triangle
  {
    public Sides Sides
    { get; }

    public Triangle(Sides sides)
    {
      Sides = sides;
    }

    public abstract string GetTriangleType();
  }
}