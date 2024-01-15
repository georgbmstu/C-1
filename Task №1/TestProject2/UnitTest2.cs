public class FigureTests
{
    [Test]
    public void TestLengthSide()
    {
        Point p1 = new Point(0, 0);
        Point p2 = new Point(0, 5);
        Figure figure = new Figure(p1, p2, null, null, null, null);
        double length = figure.LengthSide(p1, p2);
        Assert.AreEqual(5, length);
    }

    [Test]
    public void TestPerimeterCalculator()
    {
        Point p1 = new Point(0, 0);
        Point p2 = new Point(0, 5);
        Point p3 = new Point(5, 0);
        string name = "Triangle";
        Figure triangle = new Figure(p1, p2, p3, name);
        double perimeter = triangle.PerimeterCalculator();
        Assert.AreEqual(17.071067811865476, perimeter);
    }

    [Test]
    public void TestPrintInfo()
    {
        Point p1 = new Point(0, 0);
        Point p2 = new Point(0, 5);
        Point p3 = new Point(5, 0);
        string name = "Triangle";
        Figure triangle = new Figure(p1, p2, p3, name);
        triangle.PrintInfo();
    }
}