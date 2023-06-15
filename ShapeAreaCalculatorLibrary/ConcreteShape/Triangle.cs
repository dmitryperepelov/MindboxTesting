using ShapeAreaCalculatorLibrary.Base;

namespace ShapeAreaCalculatorLibrary.ConcreteShape
{
    public class Triangle : Shape
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public override double CalculateArea()
        {
            if (!IsTriangleExists())
                throw new ArgumentException("Треугольник с заданными сторонами не существует");

            if (IsRightTriangle())
            {
                var arr = new double[3] { sideA, sideB, sideC };
                Array.Sort(arr);
                return 0.5 * arr[0] * arr[1];
            }

            var semiperimeter = (sideA + sideB + sideC) / 2;
            var area = Math.Sqrt(semiperimeter * (semiperimeter - sideA) * (semiperimeter - sideB) * (semiperimeter - sideC));
            return area;
        }

        private bool IsTriangleExists()
        {
            if (sideA + sideB > sideC)
                if (sideA + sideC > sideB)
                    if (sideB + sideC > sideB)
                        return true;

            return false;
        }

        private bool IsRightTriangle()
        {
            if (sideA * sideA + sideB * sideB == sideC * sideC ||
                sideA * sideA + sideC * sideC == sideB * sideB ||
                sideC * sideC + sideB * sideB == sideA * sideA)
                return true;

            return false;
        }
    }
}
