namespace TriangleType
{
  class EquilateralorTriangle : Triangle
  {
    const string EQUILATERALOR = "Triangle is equilateralor.";

    public EquilateralorTriangle(Sides sides) : base(sides) { }

    public override string GetTriangleType()
    {
      return EQUILATERALOR;
    }
  }
}