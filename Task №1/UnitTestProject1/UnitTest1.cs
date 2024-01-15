using Microsoft.VisualStudio.TestTools.UnitTesting;
using classRectangle;

namespace UnitTestProject1
{
    [TestClass]
    public class RectangelTests
    {
        [TestMethod]
        public void CalculateArea_ReturnsCorrectArea()
        {
            // Arrange
            double side1 = 5;
            double side2 = 10;
            Rectangle rectangle = new Rectangle(side1, side2);

            // Act
            double area = rectangle.CalculateArea();

            // Assert
            Assert.AreEqual(50, area);
        }

    }
}
