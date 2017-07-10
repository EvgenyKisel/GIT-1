namespace TriangleType
{
    enum Type
    {
        EQUILATERALOR,
        ISOSCELES,
        COMMON
    }

    abstract class Triangle
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