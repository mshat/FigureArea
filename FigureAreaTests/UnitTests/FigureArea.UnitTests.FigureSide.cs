using System;
using System.Reflection;
using Xunit;
using FigureArea.Base;

namespace FigureArea.UnitTests
{
    public class FigureSideTests
    {
        protected void InvokeCheckLength(double length)
        {
            FigureSide obj = new FigureSide(1);
            Type t = typeof(FigureSide);

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
            Assert.Equal("Side length cannot be less than or equal to zero!", exception.InnerException.Message);
        }

        [Fact]
        public void FigureSide_CheckLengthRight_ReturnNull()
        {
            var ex = Record.Exception(() => InvokeCheckLength(1));
            Assert.Null(ex);
        }
    }
}
