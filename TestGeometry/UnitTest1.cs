using NUnit.Framework;
using GeometryLibrary;

namespace GeometryLibrary.Tests
{
    [TestFixture]
    public class GeometryFigureTests
    {
        [Test]
        public void CalculateCircleArea_ValidRadius_ReturnsCorrectArea()
        {
            double radius = 5;
            double expectedArea = Math.PI * Math.Pow(radius, 2);
            double actualArea = GeometryFigure.CalculateCircleArea(radius);
            Assert.AreEqual(expectedArea, actualArea, 0.001);
        }

        [Test]
        public void CalculateTriangleArea_ValidSides_ReturnsCorrectArea()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            double expectedArea = 6;
            double actualArea = GeometryFigure.CalculateTriangleArea(side1, side2, side3);
            Assert.AreEqual(expectedArea, actualArea, 0.001);
        }

        [Test]
        public void IsRightTriangle_ValidSides_ReturnsTrue()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            bool isRight = GeometryFigure.IsRightTriangle(side1, side2, side3);
            Assert.IsTrue(isRight);
        }

        [Test]
        public void IsRightTriangle_InvalidSides_ReturnsFalse()
        {
            double side1 = 2;
            double side2 = 3;
            double side3 = 4;
            bool isRight = GeometryFigure.IsRightTriangle(side1, side2, side3);
            Assert.IsFalse(isRight);
        }
    }
}
