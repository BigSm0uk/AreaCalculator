using FigureCalculator.Core.Abstraction;
using FigureCalculator.Core.FigureType;
using FigureCalculator.Exceptions.TriangleExceptions;

namespace FigureCalculator;

public static class AreaCalculator
{
    /// <summary>
    /// Вычисление площади фигуры.
    /// </summary>
    /// <param name="figure">Фигура для вычисления площади.</param>
    /// <param name="result">Площадь фигуры.</param>
    public static void CalculateArea(Figure figure, out double result)
    {
        ArgumentNullException.ThrowIfNull(figure);
        result = figure.CalculateArea();
    }
}