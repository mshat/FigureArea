using System;

namespace FigureArea
{
    public class Triangle : IFigure
    {
        private FigureSide _sideA;
        public double SideA
        {
            get { return _sideA.Length; }

            set
            {
                _sideA.Length = value;
            }
        }

        private FigureSide _sideB;
        public double SideB
        {
            get { return _sideB.Length; }

            set
            {
                _sideB.Length = value;
            }
        }

        private FigureSide _sideC;
        public double SideC
        {
            get { return _sideC.Length; }

            set
            {
                _sideC.Length = value;
            }
        }

        public Triangle(double sideA, double sideB, double sideC)
        {
            try
            {
                _sideA = new FigureSide(sideA);
                _sideB = new FigureSide(sideB);
                _sideC = new FigureSide(sideC);
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

            double epsilon = 0.000000000000001;

            if (Math.Abs(sigCosA) < epsilon || Math.Abs(sigCosB) < epsilon || Math.Abs(sigCosC) < epsilon)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        protected double Perimeter()
        {
            return SideA + SideB + SideC;
        }
        public double CalculateArea()
        {
            double semiperimeter = Perimeter() / 2;
            double area = Math.Sqrt(semiperimeter * (semiperimeter - SideA) * (semiperimeter - SideB) * (semiperimeter - SideC));
            return area;
        }
    }
}
