using System;
using FigureArea.Base;

namespace FigureArea.Base
{
    public class RadiusException : FigureSegmentException
    {
        public RadiusException(string message)
            : base(message)
        { }
    }

    class Radius : FigureSegment
    {
        public Radius(double length) : base(length) { }

        protected override void CheckLength(double length)
        {
            if (length < 0)
            {
                throw new RadiusException("Radius length cannot be less than or equal to zero!");
            }
        }
    }
}
