using System;
using FigureArea.Base;
using System.Collections.Generic;

namespace FigureArea.Figures
{
    /// <summary>
    /// Class that represents a triangle geometric figure. 
    /// </summary>
    public class Triangle : Polygon, IFigure
    {
        /// <value>Property <c>SideALength</c> represents length of 1st triangle side.</value>
        public double SideALength
        {
            get { return _sides[0].Length; }

            set { _sides[0].Length = value; }
        }

        /// <value>Property <c>SideBLength</c> represents length of 2nd triangle side.</value>
        public double SideBLength
        {
            get { return _sides[1].Length; }

            set { _sides[1].Length = value; }
        }

        /// <value>Property <c>SideCLength</c> represents length of 3rd triangle side.</value>
        public double SideCLength
        {
            get { return _sides[2].Length; }

            set { _sides[2].Length = value; }
        }

        /// <param name="sideALength">Length of 1st triangle side</param>
        /// <param name="sideBLength">Length of 2nd triangle side</param>
        /// <param name="sideCLength">Length of 3rd triangle side</param>
        public Triangle(double sideALength, double sideBLength, double sideCLength)
        {
            try
            {
                _sides = new List<FigureSide> 
                { new FigureSide(sideALength), new FigureSide(sideBLength), new FigureSide(sideCLength) };
            }
            catch (FigureSideException)
            {
                throw new FigureConstructorException("One or more sides of the triangle <= 0!");
            }

            if (SideALength + SideBLength <= SideCLength || SideALength + SideCLength <= SideBLength || SideBLength + SideCLength <= SideALength)
            {
                throw new FigureConstructorException("Triangle with these sides cannot exist!");
            }
        }

        /// <summary>
        /// Check the rightness of a triangle
        /// </summary>
        /// <returns>True if triangle is right and false else</returns>
        public bool CheckRightTriangle()
        {
            double sideASqr = Math.Pow(SideALength, 2);
            double sideBSqr = Math.Pow(SideBLength, 2);
            double sideCSqr = Math.Pow(SideCLength, 2);

            double sigCosA = sideBSqr + sideCSqr - sideASqr;
            double sigCosB = sideCSqr + sideASqr - sideBSqr;
            double sigCosC = sideASqr + sideBSqr - sideCSqr;

            if (Math.Abs(sigCosA) < _epsilon || Math.Abs(sigCosB) < _epsilon || Math.Abs(sigCosC) < _epsilon)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Calculates the area of the triangle
        /// </summary>
        /// <returns>Triangle area</returns>
        public double CalculateArea()
        {
            double semiperimeter = Perimeter() / 2;
            double area = Math.Sqrt(semiperimeter * (semiperimeter - SideALength) * (semiperimeter - SideBLength) * (semiperimeter - SideCLength));
            return area;
        }
    }
}
