using System;

namespace FigureArea.Base
{
    public class FigureSegmentException : Exception
    {
        public FigureSegmentException(string message)
            : base(message)
        { }
    }

    public abstract class FigureSegment
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

        virtual protected void CheckLength(double length)
        {
            if (length <= 0)
            {
                throw new FigureSegmentException("Length cannot be less than or equal to zero!");
            }
        }

        public FigureSegment(double length)
        {
            Length = length;
        }
    }
}
