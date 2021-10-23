using System.Collections.Generic;

namespace FigureArea.Base
{
    /// <summary>
    /// Abstract class that represents geometric polygone. 
    /// </summary>
    public abstract class Polygon
    {
        /// <summary>
        /// Accuracy for mathematical comparisons.
        /// </summary>
        protected double _epsilon = 1E-15;

        /// <summary>
        /// List of polygon sides
        /// </summary>
        protected List<FigureSide> _sides;

        /// <value>Property <c>Sides</c> polygon sides.</value>
        public List<FigureSide> Sides
        {
            get { return _sides; }

            set { _sides = value; }
        }

        /// <summary>
        /// Calculates the perimeter of the polygon
        /// </summary>
        /// <returns>Polygon perimeter</returns>
        protected double Perimeter()
        {
            double perimeter = 0;
            foreach (FigureSide side in _sides)
            {
                perimeter += side.Length;
            }
            return perimeter;
        }
    }
}
