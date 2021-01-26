using System;
using NUnit.Framework;
using GeometryDash.Figures;

namespace GeometryDashTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CircleSquareZero()
        {
            Circle circle = new Circle(0);
            var square = circle.CalculateSquare();
            Assert.AreEqual(0, square);
        }

        [Test]
        public void CircleSquarePositive()
        {
            Circle circle = new Circle(10);
            var square = circle.CalculateSquare();
            Assert.IsTrue(314 < square && square < 315);
        }

        [Test]
        public void CircleSquareNegativeRadius()
        {
            Assert.Throws<ArgumentException>(() => { Circle circle = new Circle(-1); });
        }

        [Test]
        public void TriangleSquareZero()
        {
            Assert.Throws<ArgumentException>(() => { Triangle triangle = new Triangle(0, 0, 0); });
        }

        [Test]
        public void TriangleSquareRight()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            var square = triangle.CalculateSquare();
            Assert.AreEqual(6, square);
        }

        [Test]
        public void TriangleSquarePositive()
        {
            Triangle triangle = new Triangle(7, 8, 10);
            var square = triangle.CalculateSquare();
            Assert.IsTrue(27 < square && square < 28);
        }

        [Test]
        public void TriangleSquareNegative()
        {
            Assert.Throws<ArgumentException>(() => { Triangle triangle = new Triangle(-1, -1, -1); });
        }
    }
}