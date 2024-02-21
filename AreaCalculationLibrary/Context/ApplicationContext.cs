using AreaCalculationLibrary.Services;
using AreaCalculationLibrary.Services.Impl;
using Microsoft.Extensions.DependencyInjection;

namespace AreaCalculationLibrary.Context
{
    public class ApplicationContext
    {
        public static IServiceProvider RegisterServices()
        {
            var services = new ServiceCollection();

            services.AddSingleton<IAreaCalculator, AreaCalculator>();
            services.AddSingleton<TriangleAreaCalculator>();
            services.AddSingleton<CircleAreaCalculator>();

            return services.BuildServiceProvider();

        }

    }
}
