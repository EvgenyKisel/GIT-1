﻿using System;

namespace TriangleType
{
    class Triangle
    {
        const string DONOTEXIST = "Triangle doesn't exist.";
        const string COMMON = "Triangle is common.";
        const string EQUILATERALOR = "Triangle is equilateralor.";
        const string ISOSCELES = "Triangle is isosceles.";
        const double EPSILON = Double.Epsilon;

        public double SideA
        { get; set; }

        public double SideB
        { get; set; }

        public double SideC
        { get; set; }

        public string TriangleType
        { get; set; }

        public void CheckTriangleExistence()
        {
            double maxSide = Math.Max(Math.Max(SideA, SideB), SideC);
            double minSide = Math.Min(Math.Min(SideA, SideB), SideC);
            double meanSide = SideA + SideB + SideC - maxSide - minSide;
            if (minSide + meanSide <= maxSide)
            {
                Console.WriteLine(DONOTEXIST);
            }
        }

        public string DetectTriangleType()
        {
            TriangleType = COMMON;
            if (Math.Abs(SideA - SideB) < EPSILON &&
                    Math.Abs(SideB - SideC) < EPSILON)
            {

                TriangleType = EQUILATERALOR;
            }
            if (Math.Abs(SideA - SideB) < EPSILON ||
                    Math.Abs(SideA - SideC) < EPSILON ||
                    Math.Abs(SideB - SideC) < EPSILON)
            {
                TriangleType = ISOSCELES;
            }
            return TriangleType;
        }
    }
}