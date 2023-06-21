using Figures.Library;

namespace Figures.Tests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(3, 4, 5, true)]
        [InlineData(3, 5, 5, false)]
        public void CheckingARightAngleTriangle(double AB, double BC, double CA, bool IsRectangular)
        {
            //Arrange
            Triangle triangle = new Triangle(AB, BC, CA);
            //Act
            var result = triangle.IsRectangular;
            //Assert
            Assert.Equal(result, IsRectangular);
        }
        [Theory]
        [InlineData(3, 4, 5, 6d)]
        [InlineData(3, 5, 5, 7.15d)]
        public void CheckingTheAreaOfATriangle(double AB, double BC, double CA, double area)
        {
            //Arrange
            Triangle triangle = new Triangle(AB, BC, CA);
            //Act
            var Area = Math.Round(triangle.Area, 2);
            //Assert
            Assert.Equal(Area, area);
        }
        [Fact]
        public void ExceptionCheck()
        {
            //Arrange
            Lazy<Triangle> triangle = new Lazy<Triangle>(()=>new Triangle(0, 1, 1));
            Lazy<Triangle> triangle1 = new Lazy<Triangle>(() => new Triangle(1, 0, 1));
            Lazy<Triangle> triangle2 = new Lazy<Triangle>(() => new Triangle(1, 1, 0));
            //Act
            Action act = () => {
                var t = triangle.Value;
            };
            Action act1 = () => {
                var t = triangle1.Value;
            };
            Action act2 = () => {
                var t = triangle2.Value;
            };
            //Assert
            InvalidDataException ex = Assert.Throws<InvalidDataException>(act);
            InvalidDataException ex1 = Assert.Throws<InvalidDataException>(act1);
            InvalidDataException ex2 = Assert.Throws<InvalidDataException>(act2);
            Assert.Equal("Сторона треугольника не может быть равна или меньше нуля", ex.Message);
            Assert.Equal("Сторона треугольника не может быть равна или меньше нуля", ex1.Message);
            Assert.Equal("Сторона треугольника не может быть равна или меньше нуля", ex2.Message);
        }
    }
}