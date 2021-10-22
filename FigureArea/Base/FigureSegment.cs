using System;


namespace FigureArea.Base
{
    public class FigureSegmentException : Exception
    {
        public FigureSegmentException(string message)
            : base(message)
        { }
    }

    public class RadiusException : FigureSegmentException
    {
        public RadiusException(string message)
            : base(message)
        { }
    }

    class Radius: FigureSegment
    {
        public Radius(double length) : base(length) { }

        protected override void CheckLength(double length)
        {
            if (length < 0)
            {
                throw new RadiusException("Side length cannot be less than or equal to zero!");
            }
        }
    }

    public class FigureSideException : FigureSegmentException
    {
        public FigureSideException(string message)
            : base(message)
        { }
    }

    class FigureSide : FigureSegment
    {
        public FigureSide(double length) : base(length) { }

        protected override void CheckLength(double length)
        {
            if (length <= 0)
            {
                throw new FigureSideException("Side length cannot be less than or equal to zero!");
            }
        }
    }

    abstract class FigureSegment
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
                throw new FigureSideException("Side length cannot be less than or equal to zero!");
            }
        }

        public FigureSegment(double length)
        {
            Length = length;
        }
    }
}
