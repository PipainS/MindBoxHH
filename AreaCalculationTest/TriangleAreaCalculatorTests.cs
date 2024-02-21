using Xunit;
using AreaCalculationLibrary.Services.Impl;

namespace AreaCalculationLibrary.Tests
{
    public class TriangleAreaCalculatorTests
    {
        [Fact]
        public void CalculateArea_WithSides3_4_5_Returns6()
        {
            var calculator = new TriangleAreaCalculator(3, 4, 5);
            var result = calculator.CalculateArea();

            Assert.Equal(6, result, 4); 
        }

        [Fact]
        public void CalculateArea_ThrowsException_WhenNotRightTriangle()
        {
            var triangle = new TriangleAreaCalculator(100, 4, 5);

            var exception = Assert.Throws<Exception>(() =>
            {
                triangle.CalculateArea();
            });

            Assert.Contains("the sides are entered incorrectly", exception.Message);
        }
    }
}