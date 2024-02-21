using AreaCalculationLibrary.Services.Impl;

namespace AreaCalculationTest
{
    public class CircleAreaCalculatorTests
    {
        [Fact]
        public void CalculateArea_Radius13()
        {
            var calculator = new CircleAreaCalculator(13);
            var result = calculator.CalculateArea();

            Assert.Equal(530.9291584415, result, 4);
        }

        [Fact]
        public void CalculateArea_Radius0()
        {
            var calculator = new CircleAreaCalculator(0);
            var result = calculator.CalculateArea();

            Assert.Equal(0, result);
        }
    }
}