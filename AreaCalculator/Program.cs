using AreaCalculator;
using System.Security.Cryptography.X509Certificates;

public class Program 
{
    public static void Main() 
    {
        IShape shape = new Circle(25);
        Console.WriteLine(shape.CalculateArea());
         // получаем из фабрики фигуру и выводим ее площадь 
        IShape shape1= ShapeFactory.CreateCircle(25);
        Console.WriteLine(shape1.CalculateArea());

        // 
        IShape shape2 = ShapeFactory.CreateTriangle(3,3,5);


        Console.WriteLine(shape2.CalculateArea());

        //shape2.IsRightAngled(); ошибка потому что shape2 это IShape а не Triangle
    }
}   