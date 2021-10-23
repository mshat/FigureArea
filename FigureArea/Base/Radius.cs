namespace FigureArea.Base
{
    /// <summary>
    /// Сlass for Radius exceptions
    /// </summary>
    public class RadiusException : LineSegmentException
    {
        /// <param name="message">The message that describes the error.</param>
        public RadiusException(string message)
            : base(message)
        { }
    }

    class Radius : LineSegment
    {
        public Radius(double length) : base(length) { }

        /// <summary>
        /// Checks if the length is a natural number or zero
        /// </summary>
        /// <param name="length">Length of line segment</param>
        protected override void CheckLength(double length)
        {
            if (length < 0)
            {
                throw new RadiusException("Radius length cannot be less than or equal to zero!");
            }
        }
    }
}
