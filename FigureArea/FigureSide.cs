using System;

namespace FigureArea
{
    public class FigureSideException : Exception
    {
        public FigureSideException(string message)
            : base(message)
        { }
    }

    internal class FigureSide
    {
        protected double _length;
        public double Length
        {
            get { return _length; }

            set
            {
                CheckLength(value);
                _length = value;
            }
        }

        protected void CheckLength(double length)
        {
            if (length <= 0)
            {
                throw new FigureSideException("Side length cannot be less than or equal to zero!");
            }
        }

        public FigureSide(double length)
        {
            Length = length;
        }
    }
}
