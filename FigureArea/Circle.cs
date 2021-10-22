﻿using System;

namespace FigureArea
{
    public class Circle : IFigure
    {
        public double radius { get; }
        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new FigureConstructorException("Circle with these radius does not exist");
            }

            this.radius = radius;      
        }

        public double CalculateArea()
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }     
    }
}
