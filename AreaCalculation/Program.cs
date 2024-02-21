using AreaCalculationLibrary.Context;
using AreaCalculationLibrary.enums;
using AreaCalculationLibrary.Services;
using Microsoft.Extensions.DependencyInjection;

namespace AreaCalculation
{
    public class Program
    {
        public static void Main()
        {
            var serviceProvider = ApplicationContext.RegisterServices();

            var factory = serviceProvider.GetRequiredService<IAreaCalculator>();
            var triangleCalculator = factory.CreateCalculator(ShapeNames.Triangle, 5, 5, 5);
            double circleArea = triangleCalculator.CalculateArea();

            Console.WriteLine($"The area of the triangle is {circleArea:F2}");
        }
    }
}