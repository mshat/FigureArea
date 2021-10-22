using System;
using Xunit;
using Moq;


namespace FigureArea.Tests
{
    public class FigureSideTests
    {
        [Fact]
        public void FigureSide_CreatingFigureSide_ReturnObject()
        {
            var side = new FigureSide(1.5);

            Assert.NotNull(side);
            Assert.Equal(1.5, side.Length);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-0.1)]
        public void FigureSide_FigureSideWithUnacceptableLenght_ReturnException(double length)
        {
            Action act = () => new FigureSide(length);

            Exception exception = Assert.Throws<FigureSideException>(act);
            Assert.Equal("Side length cannot be less than or equal to zero!", exception.Message);
        }
    }

    public class TriangleTests
    {
        [Fact]
        public void Triangle_Creating_ReturnObject()
        {
            var triangle = new Triangle(0.1, 0.1, 0.1);
            Assert.NotNull(triangle);
            Assert.Equal(0.1, triangle.SideA);
            Assert.Equal(0.1, triangle.SideB);
            Assert.Equal(0.1, triangle.SideC);
        }

        [Theory]
        [InlineData(0, 1, 1)]
        [InlineData(1, 0, 1)]
        [InlineData(1, 1, 0)]
        [InlineData(-1, 1, 1)]
        [InlineData(1, -1, 1)]
        [InlineData(1, 1, -1)]
        public void Triangle_CreatingTriangleWithNonExistSides_ReturnException(double sideA, double sideB, double sideC)
        {
            Action act = () => new Triangle(sideA, sideB, sideC);

            Exception exception = Assert.Throws<FigureConstructorException>(act);
            Assert.Equal("One or more sides of the triangle <= 0!", exception.Message);
        }

        [Theory]
        [InlineData(1, 2, 3.5)]
        [InlineData(1, 3.1, 2)]
        [InlineData(4.1, 2, 2)]
        public void Triangle_CreatingNonExistTiangle_ReturnException(double sideA, double sideB, double sideC)
        {
            Action act = () => new Triangle(sideA, sideB, sideC);

            Exception exception = Assert.Throws<FigureConstructorException>(act);
            Assert.Equal("Triangle with these sides cannot exist!", exception.Message);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void Triangle_SetUnacceptableSideALenght_ReturnFalse(double sideA)
        {
            var triangle = new Triangle(1, 1, 1);

            Action act = () => triangle.SideA = sideA;

            Exception exception = Assert.Throws<FigureSideException>(act);
            Assert.Equal("Side length cannot be less than or equal to zero!", exception.Message);
        }

        [Theory]
        [InlineData(-10)]
        [InlineData(0)]
        public void Triangle_SetUnacceptableSideBLenght_ReturnFalse(double sideB)
        {
            var triangle = new Triangle(1, 1, 1);

            Action act = () => triangle.SideB = sideB;

            Exception exception = Assert.Throws<FigureSideException>(act);
            Assert.Equal("Side length cannot be less than or equal to zero!", exception.Message);
        }

        [Theory]
        [InlineData(-1.4)]
        [InlineData(0)]
        public void Triangle_SetUnacceptableSideCLenght_ReturnFalse(double sideC)
        {
            var triangle = new Triangle(1, 1, 1);

            Action act = () => triangle.SideC = sideC;

            Exception exception = Assert.Throws<FigureSideException>(act);
            Assert.Equal("Side length cannot be less than or equal to zero!", exception.Message);
        }

        [Theory]
        [InlineData(3, 4, 5)]
        [InlineData(1, 2, 2.23606797749979)]
        public void Triangle_CheckRightTriangle_ReturnTrue(double sideA, double sideB, double sideC)
        {
            var triangle = new Triangle(sideA, sideB, sideC);

            var isTriangleRight = triangle.CheckRightTriangle();
            Assert.True(isTriangleRight);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(1, 2, 2.5)]
        [InlineData(2.23606797749978, 1, 2)]
        [InlineData(1, 2.23606797749980, 2)]
        [InlineData(1, 2, 2.236067977499791)]
        public void Triangle_CheckNotRightTriangle_ReturnFalse(double sideA, double sideB, double sideC)
        {
            var triangle = new Triangle(sideA, sideB, sideC);

            var isTriangleRight = triangle.CheckRightTriangle();
            Assert.False(isTriangleRight);
        }

        [Fact]
        public void Triangle_CalculateArea_ReturnNumber()
        {
            var triangle = new Triangle(1, 1, 1);

            var area = triangle.CalculateArea();

            Assert.Equal(0.4330127018922193, area);
        }
    }

    public class CircleTests
    {
        [Fact]
        public void Circle_Creating_Success()
        {
            var circle = new Circle(1);

            Assert.NotNull(circle);
            Assert.Equal(1, circle.Radius);
        }

        [Fact]
        public void Circle_CreatingPointCirlce_ReturnException()
        {
            var exception = Record.Exception(() => new Circle(0));

            Assert.Null(exception);
        }

        [Theory]
        [InlineData(-0.1)]
        public void Circle_CreatingCircleWithNonExistRadius_ReturnException(double radius)
        {
            Action act = () => new Circle(radius);

            Exception exception = Assert.Throws<FigureConstructorException>(act);
            Assert.Equal("Circle with these radius does not exist", exception.Message);
        }

        [Fact]
        public void Circle_CalculateArea_ReturnNumber()
        {
            var circle = new Circle(10);

            var area = circle.CalculateArea();

            Assert.Equal(314.1592653589793, area);
        }

        [Fact]
        public void Circle_CalculatePointCircleArea_ReturnNumber()
        {
            var circle = new Circle(0);

            var area = circle.CalculateArea();

            Assert.Equal(0, area);
        }
    }
}
