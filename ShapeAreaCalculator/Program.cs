using ShapeAreaCalculatorLibrary.Base;
using ShapeAreaCalculatorLibrary.ConcreteShape;


Shape circle = ShapeFactory.CreateShape(ShapeType.Circle, 5);
double circleArea = circle.CalculateArea();
Console.WriteLine("Площадь круга: " + circleArea);

Shape triangle = ShapeFactory.CreateShape(ShapeType.Triangle, 5, 4, 3);
double triangleArea = triangle.CalculateArea();
Console.WriteLine("Площадь треугольника: " + triangleArea);