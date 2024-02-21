using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculationLibrary.Services.Impl
{
    public class TriangleAreaCalculator : IFigureAreaCalculator
    {
        private readonly double sideA;
        private readonly double sideB;
        private readonly double sideC;

        public TriangleAreaCalculator(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public double CalculateArea()
        {
            if (!IsRightTriangle()) throw new Exception("the sides are entered incorrectly");
            double s = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));

        }

        private bool IsRightTriangle()
        {
            var side1 = Math.Min(sideA, Math.Min(sideB, sideC));
            var side2 = Math.Min(Math.Max(sideA, sideB), sideC);
            var side3 = Math.Max(sideA, Math.Max(sideB, sideC));

            return side1 + side2 > side3;
        }
    }
}
