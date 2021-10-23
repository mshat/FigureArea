namespace FigureArea.Base
{
    public class FigureSideException : FigureSegmentException
    {
        public FigureSideException(string message)
            : base(message)
        { }
    }

    public class FigureSide : FigureSegment
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
}
