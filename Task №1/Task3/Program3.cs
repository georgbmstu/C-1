public class Point
{
    private int x;
    private int y;

    public int X
    {
        get { return x; }
    }

    public int Y
    {
        get { return y; }
    }

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

public class Figure
{
    private Point[] points;
    public string Name { get; }

    public Figure(Point p1, Point p2, Point p3, string name)
    {
        this.points = new Point[] { p1, p2, p3 };
        this.Name = name;
    }

    public Figure(Point p1, Point p2, Point p3, Point p4, string name)
    {
        this.points = new Point[] { p1, p2, p3, p4 };
        this.Name = name;
    }

    public Figure(Point p1, Point p2, Point p3, Point p4, Point p5, string name)
    {
        this.points = new Point[] { p1, p2, p3, p4, p5 };
        this.Name = name;
    }

    public double LengthSide(Point A, Point B)
    {
        int dx = A.X - B.X;
        int dy = A.Y - B.Y;

        return Math.Sqrt(dx * dx + dy * dy);
    }

    public double PerimeterCalculator()
    {
        double perimeter = 0;

        for (int i = 0; i < points.Length - 1; i++)
        {
            perimeter += LengthSide(points[i], points[i + 1]);
        }

        perimeter += LengthSide(points[points.Length - 1], points[0]);

        return perimeter;
    }

    public void PrintInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Perimeter: " + PerimeterCalculator());
    }
}

public class Program
{
    public static void Main()
    {
        Point p1 = new Point(0, 0);
        Point p2 = new Point(0, 5);
        Point p3 = new Point(5, 0);

        Figure triangle = new Figure(p1, p2, p3, "Triangle");
        triangle.PrintInfo();

        Point p4 = new Point(0, 0);
        Point p5 = new Point(0, 10);
        Point p6 = new Point(5, 10);
        Point p7 = new Point(5, 0);

        Figure square = new Figure(p4, p5, p6, p7, "Square");
        square.PrintInfo();
    }
}