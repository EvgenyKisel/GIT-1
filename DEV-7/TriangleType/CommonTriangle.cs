namespace TriangleType
{
    class CommonTriangle : Triangle
    {
        const string COMMON = "Triangle is common.";

        public CommonTriangle(Sides sides) : base(sides) { }

        public override string GetTriangleType()
        {
            return COMMON;
        }
    }
}