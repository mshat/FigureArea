using System;
using System.Reflection;
using Xunit;
using FigureArea.Base;


namespace FigureArea.Tests.UnitTests
{
    public class RadiusTests
    {
        protected void InvokeCheckLength(double length)
        {
            Radius obj = new Radius(1);
            Type t = typeof(Radius);

            t.InvokeMember(
                "CheckLength",
                BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.NonPublic,
                null,
                obj,
                new object[] { length });
        }

        [Fact]
        public void FigureSide_CheckLengthRight_ReturnException()
        {
            Action act = () => InvokeCheckLength(-1);

            Exception exception = Assert.Throws<System.Reflection.TargetInvocationException>(act);
            Assert.Equal("Radius length cannot be less than or equal to zero!", exception.InnerException.Message);
        }

        [Fact]
        public void FigureSide_CheckLengthRight_ReturnNull()
        {
            var ex = Record.Exception(() => InvokeCheckLength(1));
            Assert.Null(ex);
        }
    }
}
