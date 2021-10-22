using System;

namespace FigureArea.Base
{
    public class FigureConstructorException : Exception
    {
        public FigureConstructorException(string message)
            : base(message)
        { }
    }

    public interface IFigure
    {
        public abstract double CalculateArea();
    }
}
