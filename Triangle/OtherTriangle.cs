using System;

public class OtherTriangle
{	
    public double SquareCatets(double sideA, double SideB)
    {
      double  Square = (sideA * SideB) / 2;
        return Square;
    }

    public double SquareBySides(double sideA, double sideB, double sideC)
    {
        double p = (a + b + c) / 2;
       double Square = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        return Square;
    }
}
