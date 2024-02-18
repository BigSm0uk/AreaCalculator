using FigureCalculator.Core.Abstraction;

namespace FigureCalculator.Core.FigureType;
/// <summary>
/// Класс для рассчета площади круга по радиусу
/// </summary>
public class Circle : Figure
{
    private double Radius { get; }

    public Circle(double radius)
    {
        if (radius < 0.0001)
        {
            throw new ArgumentException("Радиус не может быть отрицательным или равным нулю.", nameof(radius));
        }

        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}