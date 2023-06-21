using Figures.Library;

namespace Figures.Tests
{
    public class CircleTests
    {
        [Theory]
        [InlineData(6,113.1d)]
        [InlineData(9, 254.47d)]
        public void CheckingTheSreaOfTheCircle(double radius,double area)
        {
            //Arrange
            Circle circle = new Circle(radius);
            //Act
            double Area = Math.Round(circle.Area,2);
            //Assert
            Assert.Equal(Area, area);
        }
        [Fact]
        public void ExceptionCheck()
        {
            //Arrange
            Lazy<Circle> circle = new Lazy<Circle>(()=>new Circle(0));
            Lazy<Circle> circle1 = new Lazy<Circle>(()=>new Circle(-1));
            //Act
            Action act = () => {
                var c = circle.Value;
            };
            Action act1 = () => {
                var c = circle.Value;
            };
            //Assert
            InvalidDataException exception = Assert.Throws<InvalidDataException>(act);
            InvalidDataException exception1 = Assert.Throws<InvalidDataException>(act1);
            Assert.Equal("Радиус не может быть равен или меньше нуля", exception.Message);
            Assert.Equal("Радиус не может быть равен или меньше нуля", exception.Message);
        }
    }
}
