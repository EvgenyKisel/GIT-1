namespace TriangleType
{
    class IsoscelesTriangle : Triangle
    {
        const string ISOSCELES = "Triangle is isosceles.";

        public IsoscelesTriangle(Sides sides) : base(sides) { }

        public override string GetTriangleType()
        {
            return ISOSCELES;
        }
    }
}