using System;
using FigureArea.Base;
using System.Collections.Generic;

namespace FigureArea.Figures
{
    class Triangle : Polygon, IFigure
    {
        public double SideA
        {
            get { return _sides[0].Length; }

            set { _sides[0].Length = value; }
        }

        public double SideB
        {
            get { return _sides[1].Length; }

            set { _sides[1].Length = value; }
        }

        public double SideC
        {
            get { return _sides[2].Length; }

            set { _sides[2].Length = value; }
        }

        public Triangle(double sideA, double sideB, double sideC)
        {
            try
            {
                _sides = new List<FigureSide> 
                { new FigureSide(sideA), new FigureSide(sideB), new FigureSide(sideC) };
            }
            catch (FigureSideException)
            {
                throw new FigureConstructorException("One or more sides of the triangle <= 0!");
            }

            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            {
                throw new FigureConstructorException("Triangle with these sides cannot exist!");
            }
        }

        public bool CheckRightTriangle()
        {
            double sideASqr = Math.Pow(SideA, 2);
            double sideBSqr = Math.Pow(SideB, 2);
            double sideCSqr = Math.Pow(SideC, 2);

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
            double area = Math.Sqrt(semiperimeter * (semiperimeter - SideA) * (semiperimeter - SideB) * (semiperimeter - SideC));
            return area;
        }
    }
}
