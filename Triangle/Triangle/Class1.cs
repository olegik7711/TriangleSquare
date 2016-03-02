using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Triangle;

namespace Triangle
{
    public class TriangleSquare
    {
        private double square;
        public double Square
        { get{ return square; }
          set { square = value; }
        }
        //площадь по двум катетам
        public TriangleSquare(double a, double b)
        {
            Square = (a * b) / 2;
        }

        //площадь по трем сторонам
        public TriangleSquare(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            Square = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public double CulculateSquare()
        {
            return square;
        }
       


    }

    public class OtherTriangle
    {
        public double SquareCatets(double sideA, double sideB)
        {
            double Square = (sideA * sideB) / 2;
            return Square;
        }

        public double SquareBySides(double sideA, double sideB, double sideC)
        {
            double p = (sideA + sideB + sideC) / 2;
            double Square = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            return Square;
        }
    }

}
