using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;


namespace TriangleTest
{
    [TestClass]
    public class SquareTest
    {
        [TestMethod]
        public void TestSquareCatet()
        {
            double sideA =10;
            double sideB = 10;
            var sq = new TriangleSquare(sideA, sideB);
            double actual = sq.CulculateSquare();
            Assert.AreEqual(50, actual);
        }

        [TestMethod]
        public void TestSquareBySides()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            var sq = new TriangleSquare(sideA, sideB, sideC);
            double actual = sq.CulculateSquare();
            Assert.AreEqual(6, actual);
        }

        [TestMethod]
        public void TestOtherSquareCatets()
        {
            double sideA = 10;
            double sideB = 10;
            var sq = new OtherTriangle();
            double actual = sq.SquareCatets(sideA, sideB);
            Assert.AreEqual(50, actual);
        }

        [TestMethod]
        public void TestOtherSquareBySides()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            var sq = new OtherTriangle();
            double actual = sq.SquareBySides(sideA, sideB, sideC);
            Assert.AreEqual(6, actual);
        }
    }
}
