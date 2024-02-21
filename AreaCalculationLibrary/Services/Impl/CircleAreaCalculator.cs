using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculationLibrary.Services.Impl
{
    public class CircleAreaCalculator : IFigureAreaCalculator
    {
        private readonly double radius;

        public CircleAreaCalculator(double radius)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
