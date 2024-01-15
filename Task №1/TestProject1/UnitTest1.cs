public class RectangleTests
{
    [Test]
    public void CalculateArea_ReturnsCorrectArea()
    {
        double side1 = 5;
        double side2 = 10;
        Rectangle rectangle = new Rectangle(side1, side2);
        double area = rectangle.CalculateArea();
        Assert.AreEqual(50, area);
    }
    [Test]
    public void CalculatePerimeter_ReturnsCorrectPerimeter()
    {
        double side1 = 5;
        double side2 = 10;
        Rectangle rectangle = new Rectangle(side1, side2);
        double perimeter = rectangle.CalculatePerimeter();
        Assert.AreEqual(30, perimeter);
    }
}