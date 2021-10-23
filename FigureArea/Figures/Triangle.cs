using System;
using FigureArea.Base;
using System.Collections.Generic;

namespace FigureArea.Figures
{
    public class Triangle : Polygon, IFigure
    {
        public double SideALength
        {
            get { return _sides[0].Length; }

            set { _sides[0].Length = value; }
        }

        public double SideBLength
        {
            get { return _sides[1].Length; }

            set { _sides[1].Length = value; }
        }

        public double SideCLength
        {
            get { return _sides[2].Length; }

            set { _sides[2].Length = value; }
        }

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

        public double CalculateArea()
        {
            double semiperimeter = Perimeter() / 2;
            double area = Math.Sqrt(semiperimeter * (semiperimeter - SideALength) * (semiperimeter - SideBLength) * (semiperimeter - SideCLength));
            return area;
        }
    }
}
