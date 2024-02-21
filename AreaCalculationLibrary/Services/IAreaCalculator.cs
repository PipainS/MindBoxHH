using AreaCalculationLibrary.enums;

namespace AreaCalculationLibrary.Services
{
    public interface IAreaCalculator
    {
        IFigureAreaCalculator CreateCalculator(ShapeNames shape, params double[] sides);
    }
}
