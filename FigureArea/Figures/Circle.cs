using System;
using FigureArea.Base;

namespace FigureArea.Figures
{
    /// <summary>
    /// Class that represents a circle geometric figure. 
    /// </summary>
    public class Circle : IFigure
    {
        private Radius _radius;

        /// <value>Property <c>Radius</c> represents circle radius.</value>
        public double Radius
        {
            get { return _radius.Length; }

            set
            {
                _radius.Length = value;
            }
        }

        /// <param name="radius">Circle radius</param>
        public Circle(double radius)
        {
            try
            {
                _radius = new Radius(radius);
            }
            catch (RadiusException)
            {
                throw new FigureConstructorException("Circle with these radius does not exist");
            }   
        }

        /// <summary>
        /// Calculates the area of the circle
        /// </summary>
        /// <returns>Circle area</returns>
        public double CalculateArea()
        {
            double area = Math.PI * Math.Pow(Radius, 2);
            return area;
        }     
    }
}
