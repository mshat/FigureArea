using System;
using System.Reflection;
using Xunit;
using FigureArea.Base;

namespace FigureArea.Tests.UnitTests
{
    class FigureSegmentSubclass : FigureSegment
    {
        public FigureSegmentSubclass(double length) : base(length) { }
    }

    public class FigureSegmentTests
    {
        [Fact]
        public void FigureSegment_Creating_ReturnObject()
        {
            var side = new FigureSegmentSubclass(1.5);

            Assert.NotNull(side);
            Assert.Equal(1.5, side.Length);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-0.1)]
        public void FigureSegment_FigureSideWithUnacceptableLenght_ReturnException(double length)
        {
            Action act = () => new FigureSegmentSubclass(length);

            Exception exception = Assert.Throws<FigureSegmentException>(act);
            Assert.Equal("Length cannot be less than or equal to zero!", exception.Message);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void FigureSegment_SetUnacceptableLenght_ReturnFalse(double length)
        {
            var figureSegment = new FigureSegmentSubclass(1);

            Action act = () => figureSegment.Length = length;

            Exception exception = Assert.Throws<FigureSegmentException>(act);
            Assert.Equal("Length cannot be less than or equal to zero!", exception.Message);
        }
    }
}
