using System;

namespace FigureArea.Base
{
    /// <summary>
    /// Сlass for exceptions that occur when creating a figure object.
    /// </summary>
    public class FigureConstructorException : Exception
    {
        /// <param name="message">The message that describes the error.</param>
        public FigureConstructorException(string message)
            : base(message)
        { }
    }

    /// <summary>
    /// Interface for geometric shapes with an area
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// Calculates the area of the figure
        /// </summary>
        /// <returns>Figure area</returns>
        public abstract double CalculateArea();
    }
}
