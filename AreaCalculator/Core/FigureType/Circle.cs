using FigureCalculator.Core.Abstraction;

namespace FigureCalculator.Core.FigureType;
/// <summary>
/// Класс для рассчета площади круга по радиусу
/// </summary>
public class Circle(double radius) : Figure
{
    private double Radius { get; } = radius;

    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}