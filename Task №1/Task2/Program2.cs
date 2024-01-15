public class Rectangle
{
    private double side1;
    private double side2;

    public Rectangle(double sideA, double sideB)
    {
        side1 = sideA;
        side2 = sideB;
    }

    public double CalculateArea()
    {
        return side1 * side2;
    }

    public double CalculatePerimeter()
    {
        return 2 * (side1 + side2);
    }

    public double Area
    {
        get { return CalculateArea(); }
    }

    public double Perimeter
    {
        get { return CalculatePerimeter(); }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Введите длину первой стороны: ");
        double sideA = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите длину второй стороны: ");
        double sideB = Convert.ToDouble(Console.ReadLine());

        Rectangle rectangle = new Rectangle(sideA, sideB);

        Console.WriteLine("Площадь прямоугольника: " + rectangle.Area);
        Console.WriteLine("Периметр прямоугольника: " + rectangle.Perimeter);
    }
}