namespace FigureArea.Base
{
    /// <summary>
    /// Сlass for FigureSide exceptions
    /// </summary>
    public class FigureSideException : LineSegmentException
    {

        /// <param name="message">The message that describes the error.</param>
        public FigureSideException(string message)
            : base(message)
        { }
    }

    /// <summary>
    /// Сlass that represents the side of a geometric figure. For example, the side of a triangle.
    /// </summary>
    public class FigureSide : LineSegment
    {

        /// <param name="length">Length of figure side.</param>
        public FigureSide(double length) : base(length) { }

        /// <summary>
        /// Checks if the length is a natural number
        /// </summary>
        /// <param name="length">Length of line segment</param>
        protected override void CheckLength(double length)
        {
            if (length <= 0)
            {
                throw new FigureSideException("Side length cannot be less than or equal to zero!");
            }
        }
    }
}
