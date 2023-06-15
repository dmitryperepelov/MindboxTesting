using ShapeAreaCalculatorLibrary.Base;
using ShapeAreaCalculatorLibrary.ConcreteShape;

namespace ShapeAreaCalculatorLibraryTests
{
    [TestFixture]
    public class ShapeTests
    {
        [Test]
        public void Circle_CalculateArea_ValidRadius()
        {
            double radius = 5;
            Shape circle = ShapeFactory.CreateShape(ShapeType.Circle, radius);
            double area = circle.CalculateArea();
            Assert.That(area, Is.EqualTo(78.53981633974483));
        }

        [Test]
        public void Circle_CalculateArea_InvalidRadius()
        {
            double radius = -5;
            Shape circle = ShapeFactory.CreateShape(ShapeType.Circle, radius);
            Assert.Throws<ArgumentException>(() => circle.CalculateArea());
        }

        [Test]
        public void Triangle_CalculateArea_ValidSides()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            Shape triangle = ShapeFactory.CreateShape(ShapeType.Triangle, side1, side2, side3);
            double area = triangle.CalculateArea();
            Assert.That(area, Is.EqualTo(6));
        }

        [Test]
        public void Triangle_CalculateArea_InvalidSides()
        {
            double side1 = -3;
            double side2 = 4;
            double side3 = 5;
            Shape triangle = ShapeFactory.CreateShape(ShapeType.Triangle, side1, side2, side3);
            Assert.Throws<ArgumentException>(() => triangle.CalculateArea());
        }
    }
}