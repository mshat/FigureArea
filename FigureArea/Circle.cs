using System;

namespace FigureArea
{
    public class Circle : IFigure
    {
        private Radius _radius;
        public double Radius
        {
            get { return _radius.Length; }

            set
            {
                _radius.Length = value;
            }
        }

        public Circle(double length)
        {
            try
            {
                _radius = new Radius(length);
            }
            catch (RadiusException)
            {
                throw new FigureConstructorException("Circle with these radius does not exist");
            }   
        }

        public double CalculateArea()
        {
            double area = Math.PI * Math.Pow(Radius, 2);
            return area;
        }     
    }
}
