using System;

namespace FigureArea
{
    public class FigureException : Exception
    {
        public FigureException(string message)
            : base(message)
        { }
    }

    public class FigureConstructorException : FigureException
    {
        public FigureConstructorException(string message)
            : base(message)
        { }
    }

    abstract public class Figure
    {
        public abstract double CalculateArea();
    }
}
