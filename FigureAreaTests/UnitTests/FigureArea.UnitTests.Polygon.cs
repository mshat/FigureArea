using System;
using System.Reflection;
using Xunit;
using FigureArea.Base;
using System.Collections.Generic;

namespace FigureArea.Tests.UnitTests
{
    class PolygonSubclass: Polygon 
    {
        public PolygonSubclass(List<FigureSide> sides)
        {
            _sides = sides;
        }
    }
    public class FigureAreaTests
    {
        [Fact]
        protected void Polygon_InvokePerimeter_ReturnRightNumber()
        {
            var temp_sides = new List<FigureSide> { new FigureSide(10.0), new FigureSide(10.0), new FigureSide(10.0) };
            PolygonSubclass obj = new PolygonSubclass(temp_sides);
            Type t = typeof(PolygonSubclass);

            var res = t.InvokeMember(
                "Perimeter",
                BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.NonPublic,
                null,
                obj,
                null);
            Assert.Equal(30.0, res);
        }

    }
}
