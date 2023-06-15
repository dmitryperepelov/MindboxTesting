using ShapeAreaCalculatorLibrary.Base;

namespace ShapeAreaCalculatorLibrary.ConcreteShape
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            if (!IsRadiusValid())
                throw new ArgumentException("Радиус должен быть больше нуля");

            return Math.PI * radius * radius;
        }

        private bool IsRadiusValid()
        {
            if (radius > 0)
                return true;

            return false;
        }
    }
}
