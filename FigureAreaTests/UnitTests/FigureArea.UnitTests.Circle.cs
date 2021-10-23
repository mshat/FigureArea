using System;
using Xunit;
using FigureArea.Base;
using FigureArea.Figures;

namespace FigureArea.Tests.UnitTests
{
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
