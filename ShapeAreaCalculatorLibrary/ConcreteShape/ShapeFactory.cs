using ShapeAreaCalculatorLibrary.Base;

namespace ShapeAreaCalculatorLibrary.ConcreteShape
{
    public class ShapeFactory
    {
        public static Shape CreateShape(ShapeType shapeType, params double[] parameters)
        {
            switch (shapeType)
            {
                case ShapeType.Circle:
                    if (parameters?.Length != 1)
                        throw new ArgumentException("Необходимо указать 1 параметр");
                    return new Circle(parameters[0]);

                case ShapeType.Triangle:
                    if (parameters?.Length != 3)
                        throw new ArgumentException("Необходимо указать 3 параметра");
                    return new Triangle(parameters[0], parameters[1], parameters[2]);

                default:
                    throw new NotImplementedException();
            }
        }
    }
}
