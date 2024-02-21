using AreaCalculationLibrary.enums;

namespace AreaCalculationLibrary.Services.Impl
{
    public class AreaCalculator : IAreaCalculator
    {
        private readonly IServiceProvider serviceProvider;
        public AreaCalculator(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public IFigureAreaCalculator CreateCalculator(ShapeNames shape, params double[] sides)
        {
            switch(shape)
            {
                case ShapeNames.Circle:
                    if (sides.Length != 1) throw new ArgumentException();
                    return new CircleAreaCalculator(sides[0]);
                case ShapeNames.Triangle:
                    if (sides.Length != 3) throw new ArgumentException();
                    return new TriangleAreaCalculator(sides[0], sides[1], sides[2]);
                default:
                    throw new ArgumentException("Invalid shape name");
            };
        }
    }
}
