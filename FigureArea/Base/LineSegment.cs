using System;

namespace FigureArea.Base
{
    /// <summary>
    /// Сlass for LineSegment exceptions
    /// </summary>
    public class LineSegmentException : Exception
    {
        /// <param name="message">The message that describes the error.</param>
        public LineSegmentException(string message)
            : base(message)
        { }
    }

    /// <summary>
    /// Abstract class that represents geometric line segment. Can be used to construct geometric shapes.
    /// </summary>
    public abstract class LineSegment
    {
        /// <summary>
        /// length of line segment.
        /// </summary>
        protected double _length;

        /// <value>Property <c>length</c> represents length of line segment.</value>
        public double Length
        {
            get { return _length; }

            set
            {
                CheckLength(value);
                _length = value;
            }
        }

        /// <summary>
        /// Checks if the length is a natural number
        /// </summary>
        /// <param name="length">Length of line segment</param>
        virtual protected void CheckLength(double length)
        {
            if (length <= 0)
            {
                throw new LineSegmentException("Length cannot be less than or equal to zero!");
            }
        }

        /// <param name="length">length of line segment</param>
        public LineSegment(double length)
        {
            Length = length;
        }
    }
}
