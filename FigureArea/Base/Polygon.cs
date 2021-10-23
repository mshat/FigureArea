using System.Collections.Generic;

namespace FigureArea.Base
{
    abstract class Polygon
    {
        protected double _epsilon = 1E-15;

        protected List<FigureSide> _sides;

        public List<FigureSide> Sides
        {
            get { return _sides; }

            set { _sides = value; }
        }

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
